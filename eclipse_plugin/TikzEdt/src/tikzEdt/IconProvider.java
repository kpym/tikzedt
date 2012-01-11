package tikzEdt;

import java.io.IOException;
import java.net.URL;

import org.eclipse.core.runtime.FileLocator;
import org.eclipse.core.runtime.Path;
import org.eclipse.core.runtime.Platform;
import org.eclipse.swt.graphics.Image;
import org.eclipse.swt.widgets.Display;
import org.osgi.framework.Bundle;

public class IconProvider {
	public static Image RefreshIcon;
	public static Image CompileIcon;
	public static Image AbortIcon;
	public static Image ZoomInIcon;
	public static Image ZoomOutIcon;
	
	
	static
	{
		Bundle bundle = Platform.getBundle(tikzEdt.Activator.PLUGIN_ID);
		Display d = Display.getCurrent();
		try {
			URL fileURL = FileLocator.find(bundle, new Path("icons/refresh.gif"), null);
			RefreshIcon = new Image(d, fileURL.openStream());
			fileURL = FileLocator.find(bundle, new Path("icons/compile.gif"), null);
			CompileIcon = new Image(d, fileURL.openStream());
			fileURL = FileLocator.find(bundle, new Path("icons/abort.gif"), null);
			AbortIcon = new Image(d, fileURL.openStream());
			fileURL = FileLocator.find(bundle, new Path("icons/ZoomIn.png"), null);
			ZoomInIcon = new Image(d, fileURL.openStream());
			fileURL = FileLocator.find(bundle, new Path("icons/ZoomOut.png"), null);
			ZoomOutIcon = new Image(d, fileURL.openStream());
			
		} catch (IOException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
		
		
	}
	
}
