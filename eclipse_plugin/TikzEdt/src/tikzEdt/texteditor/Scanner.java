package tikzEdt.texteditor;

import java.net.URL;

import org.eclipse.core.runtime.FileLocator;
import org.eclipse.core.runtime.Path;
import org.eclipse.core.runtime.Platform;
import org.eclipse.jface.text.TextAttribute;
import org.eclipse.jface.text.rules.*;
import org.eclipse.swt.SWT;
import org.eclipse.swt.graphics.Color;
import org.eclipse.swt.widgets.Display;
import org.osgi.framework.Bundle;

public class Scanner extends RuleBasedScanner {
	public Scanner()
	{	
		
		Bundle bundle = Platform.getBundle(tikzEdt.Activator.PLUGIN_ID);
		try {
			URL fileURL = FileLocator.find(bundle, new Path("syntest.xshd"), null);
			setRules(SyntaxDefinition.getRules(fileURL.openStream()));
		} catch (Exception e)
		{
			e.printStackTrace();
		}
		
		/*
		
		Color blue = new Color(Display.getCurrent(), 0,0,255 );
		Color green = new Color(Display.getCurrent(), 0,200,0 );
		Color red = new Color(Display.getCurrent(), 200,0,0 );
		Token keyWord = new Token(new TextAttribute(blue, null, SWT.BOLD));
		Token comment = new Token(new TextAttribute(green, null, SWT.BOLD));
		Token string = new Token(new TextAttribute(red, null, SWT.BOLD));
		
		WordRule rule = new WordRule(new IWordDetector() {
			
			@Override
			public boolean isWordStart(char c) {
				// TODO Auto-generated method stub
				return Character.isJavaIdentifierStart(c);
			}
			
			@Override
			public boolean isWordPart(char c) {
				// TODO Auto-generated method stub
				return Character.isJavaIdentifierPart(c);
			}
		});
		
		rule.addWord("\\begin", keyWord);
		setRules(new IRule[]{
				rule,
				new SingleLineRule("\"", "\"", string),
				new SingleLineRule("%","\n", comment),
				new WhitespaceRule(new IWhitespaceDetector() {
					
					@Override
					public boolean isWhitespace(char c) {
						// TODO Auto-generated method stub
						return Character.isWhitespace(c);
					}
				})
		});*/
	}

}
