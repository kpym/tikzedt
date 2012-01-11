package tikzEdt.texteditor;

import java.lang.reflect.Field;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

import org.eclipse.swt.graphics.Color;
import org.eclipse.swt.graphics.RGB;
import org.eclipse.swt.widgets.Display;

public class ColorManager {

	protected Map fColorTable = new HashMap(10);

	public void dispose() {
		Iterator e = fColorTable.values().iterator();
		while (e.hasNext())
			 ((Color) e.next()).dispose();
	}
	public Color getColor(RGB rgb) {
		Color color = (Color) fColorTable.get(rgb);
		if (color == null) {
			color = new Color(Display.getCurrent(), rgb);
			fColorTable.put(rgb, color);
		}
		return color;
	}
	
	
	static Map<String, Color> AllColors = new HashMap<String, Color>();
	public static void addColor(String alias, Color c)
	{
		AllColors.put(alias, c);
	}
	
	// Returns a Color based on 'colorName' which must be one of the predefined colors in
	// java.awt.Color. Returns null if colorName is not valid.
	public static Color getColorFromString(String colorName) {
	    // look in Dictionary
		if (AllColors.containsKey(colorName))
			return AllColors.get(colorName);
		
		
		try {
	        // Find the field and value of colorName
	        Field field = Class.forName("java.awt.Color").getField(colorName.toLowerCase());
	        
	        java.awt.Color c =  (java.awt.Color)field.get(null);
	        return new Color(Display.getCurrent(), c.getRed(), c.getGreen(), c.getBlue());
	    } catch (Exception e) {
	        return null;
	    }
	}
	
}
