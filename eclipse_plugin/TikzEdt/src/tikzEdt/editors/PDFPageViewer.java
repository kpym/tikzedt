/*******************************************************************************
 * Copyright (c) 2011 Boris von Loesch.
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://www.eclipse.org/legal/epl-v10.html
 * 
 * Contributors:
 *     Boris von Loesch - initial API and implementation
 ******************************************************************************/
package tikzEdt.editors;


import java.awt.Color;
import java.awt.Dimension;
import java.awt.Image;
import java.awt.geom.AffineTransform;
import java.awt.geom.NoninvertibleTransformException;
import java.awt.geom.Rectangle2D;
import java.awt.geom.Rectangle2D.Double;
import java.awt.image.BufferedImage;
import java.awt.image.DataBufferByte;
import java.awt.image.DirectColorModel;
import java.awt.image.ImageObserver;
import java.awt.image.IndexColorModel;
import java.awt.image.WritableRaster;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStream;
import java.lang.ref.WeakReference;
import java.net.MalformedURLException;
import java.net.URL;
import java.nio.ByteBuffer;
import java.util.List;

import org.eclipse.jface.dialogs.MessageDialog;
import org.eclipse.swt.SWT;
import org.eclipse.swt.events.MouseListener;
import org.eclipse.swt.events.PaintEvent;
import org.eclipse.swt.events.PaintListener;
import org.eclipse.swt.graphics.GC;
import org.eclipse.swt.graphics.ImageData;
import org.eclipse.swt.graphics.PaletteData;
import org.eclipse.swt.graphics.Point;
import org.eclipse.swt.graphics.RGB;
import org.eclipse.swt.graphics.Rectangle;
import org.eclipse.swt.widgets.Canvas;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Display;
import org.eclipse.ui.IWorkbench;
import org.eclipse.ui.IWorkbenchWindow;
import org.eclipse.ui.PartInitException;
import org.eclipse.ui.PlatformUI;


import com.sun.pdfview.ImageInfo;
import com.sun.pdfview.PDFFile;
import com.sun.pdfview.PDFPage;
import com.sun.pdfview.PDFRenderer;
import com.sun.pdfview.RefImage;
import com.sun.pdfview.Watchable;
import com.sun.pdfview.action.GoToAction;
//import com.sun.pdfview.action.UriAction;
//import com.sun.pdfview.annotation.LinkAnnotation;
//import com.sun.pdfview.annotation.PDFAnnotation;

//import de.vonloesch.pdf4eclipse.editors.PDFEditor;
//import de.vonloesch.pdf4eclipse.editors.handlers.ToggleLinkHighlightHandler;


/**
 * SWT Canvas which shows a whole pdf-page. It also handles click on links.
 * Since the pdf library returns an awt BufferedImage, we need to convert it
 * to an SWT image. This was avoided in {@link PDFPageViewerAWT}.
 * 
 * @author Boris von Loesch
 *
 */
public class PDFPageViewer extends Canvas implements PaintListener, ImageObserver {
    /** The image of the rendered PDF page being displayed */
    private Image currentImage;
    
    /** The current PDFPage that was rendered into currentImage */
    public PDFPage currentPage;
    /** the current transform from device space to page space */
    AffineTransform currentXform;
    /** The horizontal offset of the image from the left edge of the panel */
    int offx;
    /** The vertical offset of the image from the top of the panel */
    int offy;
    /** the size of the image */
    Dimension prevSize;

    private Display display;
    
    private float zoomFactor;
    private PDFFile Pdf;
    
    private org.eclipse.swt.graphics.Image swtImage;

    private String FileName;
    
    public void setFileName(String FileName)
    {
    	this.FileName = FileName;
    	reload();
    }
    
    public void showPage() {
    	if (Pdf != null)
    	{
    		PDFPage page = Pdf.getPage(1);
    		showPage(page);
    	}
//    	updateStatusLine();
    }
    
    /**
     * Create a new PagePanel.
     */
    public PDFPageViewer(Composite parent) {
        //super(parent, SWT.NO_BACKGROUND|SWT.NO_REDRAW_RESIZE);
    	//super(parent, SWT.EMBEDDED | SWT.NO_BACKGROUND | SWT.NO_REDRAW_RESIZE);
    	super(parent, SWT.NO_BACKGROUND );


    	display = parent.getDisplay();
        setSize(800, 600);
        zoomFactor = 1.f;
        this.addPaintListener(this);
    }

    
    /**
     * Converts a buffered image to SWT <code>ImageData</code>.
     *
     * @param bufferedImage  the buffered image (<code>null</code> not
     *         permitted).
     *
     * @return The image data.
     */
    public static ImageData convertToSWT(BufferedImage bufferedImage) {
        if (bufferedImage.getType() == BufferedImage.TYPE_4BYTE_ABGR) {
        	byte[] datas =
        			((DataBufferByte) bufferedImage.getRaster()
        				.getDataBuffer())
        				.getData();
        	ImageData data = new ImageData(bufferedImage.getWidth(),
                    bufferedImage.getHeight(), 32,
                    new PaletteData(0x000000FF, 0x0000FF00, 0x00FF0000));
        	data.data = datas;
        	return data;
        }

    	if (bufferedImage.getColorModel() instanceof DirectColorModel) {
            DirectColorModel colorModel
                    = (DirectColorModel) bufferedImage.getColorModel();
            PaletteData palette = new PaletteData(colorModel.getRedMask(),
                    colorModel.getGreenMask(), colorModel.getBlueMask());
            ImageData data = null;
            if (bufferedImage.getType() == BufferedImage.TYPE_INT_ARGB) {
            	data = new ImageData(bufferedImage.getWidth(),
                        bufferedImage.getHeight(), colorModel.getPixelSize(),
                        palette);
            	//We get this type from PDFPage
            	int[] rbgs = new int[data.width];
                for (int y = 0; y < data.height; y += 1) {
                	bufferedImage.getRGB(0, y, data.width, 1, rbgs, 0, data.width);
                	data.setPixels(0, y, data.width, rbgs, 0);
                }
            }
            else if (bufferedImage.getType() == BufferedImage.TYPE_INT_RGB){
            	data = new ImageData(bufferedImage.getWidth(),
                        bufferedImage.getHeight(), colorModel.getPixelSize(),
                        palette);
                WritableRaster raster = bufferedImage.getRaster();
            	int[] pixelArray = new int[3];
            	for (int y = 0; y < data.height; y++) {
            		for (int x = 0; x < data.width; x++) {
            			raster.getPixel(x, y, pixelArray);
            			int pixel = palette.getPixel(new RGB(pixelArray[0],
            					pixelArray[1], pixelArray[2]));
            			data.setPixel(x, y, pixel);
            		}
            	}
            }
            return data;
        }
        else if (bufferedImage.getColorModel() instanceof IndexColorModel) {
            IndexColorModel colorModel = (IndexColorModel)
                    bufferedImage.getColorModel();
            int size = colorModel.getMapSize();
            byte[] reds = new byte[size];
            byte[] greens = new byte[size];
            byte[] blues = new byte[size];
            colorModel.getReds(reds);
            colorModel.getGreens(greens);
            colorModel.getBlues(blues);
            RGB[] rgbs = new RGB[size];
            for (int i = 0; i < rgbs.length; i++) {
                rgbs[i] = new RGB(reds[i] & 0xFF, greens[i] & 0xFF,
                        blues[i] & 0xFF);
            }
            PaletteData palette = new PaletteData(rgbs);
            ImageData data = new ImageData(bufferedImage.getWidth(),
                    bufferedImage.getHeight(), colorModel.getPixelSize(),
                    palette);
            data.transparentPixel = colorModel.getTransparentPixel();
            WritableRaster raster = bufferedImage.getRaster();
            int[] pixelArray = new int[1];
            for (int y = 0; y < data.height; y++) {
                for (int x = 0; x < data.width; x++) {
                    raster.getPixel(x, y, pixelArray);
                    data.setPixel(x, y, pixelArray[0]);
                }
            }
            return data;
        }
        return null;
    }
    
    /**
     * Stop the generation of any previous page, and draw the new one.
     * @param page the PDFPage to draw.
     */
    public void showPage(PDFPage page) {
    	// stop drawing the previous page
    	if (currentPage != null && prevSize != null && currentPage.isFinished()) {
    		currentPage.stop(prevSize.width, prevSize.height, null);
    	}

    	// set up the new page
    	currentPage = page;

    	boolean resize = false;
    	int newW = Math.round(zoomFactor*page.getWidth());
    	int newH = Math.round(zoomFactor*page.getHeight());

    	Point sz = getSize();

    	if (sz.x != newW || sz.y != newH) {
    		sz.x = newW;
    		sz.y = newH;
    		resize = true;
    	}

    	if (sz.x == 0 || sz.y == 0) return;

    	Dimension pageSize = page.getUnstretchedSize(sz.x, sz.y, null);

    //	ImageInfo info = new ImageInfo(pageSize.width, pageSize.height, null, Color.WHITE);

    	currentImage = null;
    	
    	//First check if there is already an old renderer
    	//if (page.renderers.containsKey(info)) {
    	//	r = (PDFRenderer) page.renderers.get(info).get();
    		//Note, this is a weak reference, so r could be null
    	//}
    	
    	//if (r != null) {
    	//r = new PDFRenderer(page, info, (BufferedImage) currentImage);
    	//currentImage = r.getImage();
    	//}
    	if (page != null)
    		currentImage = page.getImage(sz.x, sz.y,
    				null,
    				this , true, true);
    	System.out.println("Got image: ");
    	if (currentImage == null) {
    		return;
    		//We have no cached image :(
    		
    		//currentImage = new RefImage(pageSize.width, pageSize.height,
    				//BufferedImage.TYPE_INT_ARGB);
    			//	BufferedImage.TYPE_4BYTE_ABGR);

    		//page.renderers.clear();
    		//r = new PDFRenderer(page, info, (BufferedImage) currentImage);
    		/*java.awt.Rectangle rect = new java.awt.Rectangle(0, 0, pageSize.width, pageSize.height);
    		PDFRenderer r = new PDFRenderer(page, ((BufferedImage)currentImage).createGraphics(), rect, 
    			null, Color.WHITE);*/
    		//page.renderers.put(info, new WeakReference<PDFRenderer>(r));
    		
    	}
    	// calculate the transform from screen to page space
    	currentXform = page.getInitialTransform(pageSize.width,
    			pageSize.height, null);
    	try {
    		currentXform = currentXform.createInverse();
    	} catch (NoninvertibleTransformException nte) {
    		System.out.println("Error 1");
    		nte.printStackTrace();
    	}

    	prevSize = pageSize;

    	if (swtImage != null) swtImage.dispose();
    	swtImage = new org.eclipse.swt.graphics.Image(display, convertToSWT((BufferedImage)currentImage));

    	//if (resize) {
    		//Resize triggers repaint
    		setSize(Math.round(zoomFactor*page.getWidth()), Math.round(zoomFactor*page.getHeight()));
    	//}
    	redraw();
    	
    }

    private Rectangle getRectangle(Rectangle2D r) {
    	return new Rectangle((int)Math.round(r.getX()), (int)Math.round(r.getY()), (int)Math.round(r.getWidth()), (int)Math.round(r.getHeight()));
    }
    
    public void convertImg()
    {    	
    	if (swtImage != null) swtImage.dispose();
    	swtImage = new org.eclipse.swt.graphics.Image(display, convertToSWT((BufferedImage)currentImage));
    }
    
    public Rectangle2D convertPDF2ImageCoord(Rectangle2D r) {
    	if (currentImage == null) return null;
    	int imwid = currentImage.getWidth(null);
        int imhgt = currentImage.getHeight(null);
    	AffineTransform t = currentPage.getInitialTransform(imwid,
                imhgt, null);
    	Rectangle2D tr = t.createTransformedShape(r).getBounds2D();
    	tr.setFrame(tr.getX() + offx, tr.getY() + offy, tr.getWidth(), tr.getHeight());
    	return tr;    	
    }
    
    public Rectangle2D convertImage2PDFCoord(Rectangle2D r) {
    	if (currentImage == null) return null;

    	r.setFrame(r.getX() - offx, r.getY() -offy, 1, 1);
    	Rectangle2D tr = currentXform.createTransformedShape(r).getBounds2D();
    	tr.setFrame(tr.getX(), tr.getY(), tr.getWidth(), tr.getHeight());
    	return tr;    	
    }
    
    /**
     * Sets the zoom factor and rerenders the current page.
     * @param factor 0 < factor < \infty
     */
    public void setZoomFactor(float factor) {
    	assert (factor > 0);
    	zoomFactor = factor;
    	showPage(currentPage);
    }
    
    public void refresh()
    {
    	showPage(currentPage);
    }
    
    public void reload()
    {
    	if (FileName == null)
    		return;
    	
    	File fff = new File(FileName);
    	if (!fff.exists())
    		return;
    	
    	try {
    		
    		ByteBuffer buf = getBytesFromFile(FileName);
    			//ByteBuffer.allocateDirect((int) contentLength);
    		
    		   IWorkbench wb = PlatformUI.getWorkbench();
    		   IWorkbenchWindow window = wb.getActiveWorkbenchWindow();

    		
    		//FileChannel c = ff.getChannel();
    		//c.read(buf);
    		//Mapped buffers lock the file, hence Latex could not rebuild it
    		//at least under Windows OS
    		//buf = c.map(MapMode.READ_ONLY, 0, len);
    		//c.close();
    		//ff.close();
    		//}
    		//MessageDialog.openInformation(window.getShell(),"Testmultipage","Hello, Eclipse world "+FileName);
    		try
    		{
    			Pdf = new PDFFile(buf);
    			//MessageDialog.openInformation(    					window.getShell(),"Testmultipage","n pages " + Pdf.getNumPages());
    		} catch (Exception e)
    		{
    			MessageDialog.openInformation(
    					window.getShell(),
    					"Testmultipage",
    					"Hello, Eclipse world " + e.getMessage());
    		}
    		//pageNumbers = f.getNumPages();
    		showPage();
    		
    	} catch (FileNotFoundException fnfe) {
    		//throw new PartInitException(Messages.PDFEditor_ErrorMsg3, fnfe);
    	} catch (IOException ioe) {
    		//throw new PartInitException(Messages.PDFEditor_ErrorMsg4, ioe);
    	} 
    }
    
    /**
     * Returns the current used zoom factor
     * @return
     */
    public float getZoomFactor() {
    	return zoomFactor;
    }
    
    /**
     * Draw the image.
     */
    public void paintControl(PaintEvent event) {
    	GC g = event.gc;
        Point sz = getSize();
        if (currentImage == null) {
            g.setForeground(getBackground());
            g.fillRectangle(0, 0, sz.x, sz.y);
            g.setForeground(display.getSystemColor(SWT.COLOR_BLACK));
            g.drawString("Error 2", sz.x / 2 - 30, sz.y / 2);
        } else {
            // draw the image
            int imwid = currentImage.getWidth(null);
            int imhgt = currentImage.getHeight(null);

            // draw it centered within the panel
            offx = (sz.x - imwid) / 2;
            offy = (sz.y - imhgt) / 2;

            if ((imwid == sz.x && imhgt <= sz.y) ||
                    (imhgt == sz.y && imwid <= sz.x)) {
            	
            	if (swtImage != null) g.drawImage(swtImage, offx, offy);


            } else {
                // the image is bogus.  try again, or give up.
                if (currentPage != null) {
                    showPage(currentPage);
                }
                g.setForeground(getBackground());
                g.fillRectangle(0, 0, sz.x, sz.y);                
                g.setForeground(display.getSystemColor(SWT.COLOR_RED));
                g.drawLine(0, 0, sz.x, sz.y);
                g.drawLine(0, sz.y, sz.x, 0);
            }
        }
    }

    
    /**
     * Gets the page currently being displayed
     */
    public PDFPage getPage() {
        return currentPage;
    }

    @Override
    public void dispose() {
    	super.dispose();

    	currentImage.flush();
    	if (swtImage != null) swtImage.dispose();
		currentImage = null;
    	
    }


	@Override
	public boolean imageUpdate(Image img, int infoflags, int x, int y,
			int width, int height) {
        System.out.println("Image update: " + (infoflags & ALLBITS));
        //Dimension sz = getSize();
        if ((infoflags & (SOMEBITS | ALLBITS)) != 0) {
            // [[MW: dink this rectangle by 1 to handle antialias issues]]
        	
            //repaint(x + offx, y + offy, width, height);
        }
        if ((infoflags & (ALLBITS | ERROR | ABORT)) != 0) {
           // flag.set();
            //	    System.out.println("   flag set");
            return false;
        } else {
            return true;
        }
	}
	
public static ByteBuffer getBytesFromFile(String filename) throws IOException {
		
		File file = new File(filename);
		
	    InputStream is = new FileInputStream(file);

	    // Get the size of the file
	    long length = file.length();

	    // Create the byte array to hold the data
	    byte[] bytes = new byte[(int)length];

	    // Read in the bytes
	    int offset = 0;
	    int numRead = 0;
	    while (offset < bytes.length
	           && (numRead=is.read(bytes, offset, bytes.length-offset)) >= 0) {
	        offset += numRead;
	    }

	    // Ensure all the bytes have been read in
	    if (offset < bytes.length) {
	        throw new IOException("Could not completely read file "+file.getName());
	    }

	    // Close the input stream and return bytes
	    is.close();
	    return ByteBuffer.wrap(bytes);
	}
}