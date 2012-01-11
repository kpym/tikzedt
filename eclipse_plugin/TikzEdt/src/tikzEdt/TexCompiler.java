package tikzEdt;

import java.beans.PropertyChangeEvent;
import java.beans.PropertyChangeListener;
import java.beans.PropertyChangeSupport;
import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import java.util.concurrent.Future;
import java.util.concurrent.LinkedBlockingQueue;
import java.util.concurrent.RejectedExecutionHandler;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;

import org.apache.commons.io.FileUtils;
import org.eclipse.osgi.service.environment.EnvironmentInfo;
import org.eclipse.swt.widgets.Display;

public class TexCompiler implements PropertyChangeListener {
	final private ThreadPoolExecutor pool = 
		new ThreadPoolExecutor(1, 1, 10, TimeUnit.SECONDS,
				new LinkedBlockingQueue<Runnable>(1));
	private String FileName;
	
	private PropertyChangeSupport propertyChangeSupport = new PropertyChangeSupport(
			this);

	
	
	public void addPropertyChangeListener(String propertyName,
			PropertyChangeListener listener) {
		propertyChangeSupport.addPropertyChangeListener(propertyName, listener);
	}

	public void removePropertyChangeListener(PropertyChangeListener listener) {
		propertyChangeSupport.removePropertyChangeListener(listener);
	}
	
	public TexCompiler()
	{
		pool.setRejectedExecutionHandler(new ThreadPoolExecutor.DiscardOldestPolicy() );		
	}
	
	public void setFileName(String FileName)
	{
		this.FileName = FileName;
	}
	
	public void abort()
	{
		pool.shutdownNow();
	}
	
	/* 
	 * 
	 */
	public void Compile(final String TexCode)
	{
		if (FileName == null || TexCode == null)
			return;
		
		pool.execute(new Runnable()
		{
			@Override
			public void run() {
				// save to temp file
				String Out="", Err="";
				int RetVal = 1;
				try {
					File TexFile = new File(FileName);
					FileUtils.writeStringToFile(TexFile, TexCode);
			
				// run pdflatex
				 
				      String line;
				      Process p = Runtime.getRuntime().exec("pdflatex -interaction=nonstopmode " + FileName, null, 
				    		  TexFile.getParentFile());
				      BufferedReader bri = new BufferedReader
				        (new InputStreamReader(p.getInputStream()));
				      BufferedReader bre = new BufferedReader
				        (new InputStreamReader(p.getErrorStream()));
				      
				      while ((line = bri.readLine()) != null) {
				        System.out.println(line);
				        Out += line + "\n";
				      }
				      bri.close();
				      while ((line = bre.readLine()) != null) {
				        System.out.println(line);
				        Err += line + "\n";
				      }
				      bre.close(); 
				      p.waitFor();
				      RetVal = p.exitValue();
				      System.out.println("Latex compilation done.");
				    }
				    catch (Exception err) {
				      err.printStackTrace();
				    }
				    
				    //Display.getDefault().asyncExec(new Runnable() {										
					//	@Override
					//	public void run() {
							// trigger completed event
							fireEvent(RetVal, Out, Err);
					//	}
					//});
			}
		});
		
	}


		

	public class CompilationEvent extends java.util.EventObject {
        //here's the constructor
		public int RetVal;
		public String Out;
		public String Err;
        public CompilationEvent(Object source, int RetVal, String Out, String Err) {
            super(source);
            this.Out = Out;
            this.Err = Err;
            this.RetVal = RetVal;
       }
	}
	public interface CompilationEventListener {
        public void handleCompilationEvent(CompilationEvent e);
	}

	  private List _compileEventListeners = new ArrayList();
	  public synchronized void addEventListener(CompilationEventListener listener)	{
		  _compileEventListeners.add(listener);
	  }
	  public synchronized void removeEventListener(CompilationEventListener listener)	{
		  _compileEventListeners.remove(listener);
	  }

	  // call this method whenever you want to notify
	  //the event listeners of the particular event
	  private synchronized void fireEvent( int RetVal, String Out, String Err)	{
		  CompilationEvent event = new CompilationEvent(this,  RetVal,  Out,  Err);
	    Iterator i = _compileEventListeners.iterator();
	    while(i.hasNext())	{
	      ((CompilationEventListener) i.next()).handleCompilationEvent(event);
	    }
	  }

	@Override
	public void propertyChange(PropertyChangeEvent arg0) {
		// TODO Auto-generated method stub
		//propertyChangeSupport.firePropertyChange("address", null, address);
	}
	
}



