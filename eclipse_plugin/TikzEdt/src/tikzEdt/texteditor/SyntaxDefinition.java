package tikzEdt.texteditor;

import java.io.InputStream;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.List;

import org.eclipse.jface.text.TextAttribute;
import org.eclipse.jface.text.rules.IRule;
import org.eclipse.jface.text.rules.IWordDetector;
import org.eclipse.jface.text.rules.SingleLineRule;
import org.eclipse.jface.text.rules.Token;
import org.eclipse.jface.text.rules.WordRule;
import org.eclipse.swt.SWT;
import org.eclipse.swt.graphics.Color;

import com.thoughtworks.xstream.XStream;
import com.thoughtworks.xstream.annotations.XStreamAlias;
import com.thoughtworks.xstream.annotations.XStreamAsAttribute;
import com.thoughtworks.xstream.annotations.XStreamImplicit;
import com.thoughtworks.xstream.io.xml.DomDriver;

/**
 * Wrapper class for handling a collection of items
 * using XStream API.
 */
@XStreamAlias("SyntaxDefinition")
public class SyntaxDefinition implements Serializable
{
	public static IRule[] getRules(InputStream in)
	{
//		File fXmlFile = new File(cFile);
//	if (!fXmlFile.exists())
//		return;
	
	// Init xStream.
	XStream xStreamXmlSerializer = new XStream( new DomDriver() );
	xStreamXmlSerializer.processAnnotations(SyntaxColor.class);
	xStreamXmlSerializer.processAnnotations(Span.class);
	xStreamXmlSerializer.processAnnotations(Keywords.class);
	xStreamXmlSerializer.processAnnotations(SyntaxDefinition.class);


	// XML -> Arr of Objects.
	SyntaxDefinition sd = ( SyntaxDefinition ) xStreamXmlSerializer.fromXML(in);
	System.out.println("n colors: " + sd.getColorList().size());
	if (sd.getRules() != null)
	{
		System.out.println("has Ruleset: ");
		RuleSet rs = sd.getRules();
		System.out.println("n KWLists: " + sd.getRules().getKeywordsList().size() );
	
		for (Iterator it = sd.getRules().getKeywordsList().iterator(); it.hasNext ();)
		{
		  Keywords kw = (Keywords) it.next ();
		  //for (Iterator it2 = kw.getWordList().iterator(); it2.hasNext ();)
		  //	  System.out.println (it2.next().toString());		 
		}
		
		System.out.println("n Spans: " + rs.getSpanList().size());		
		
	}
	
	String s = sd.toString();
	s=s+"c";
	
	
	// add rule list based on xshd (not 100% correct, since eclipse does 
	// not seem to support nested rules)
	for (SyntaxColor sc : sd.getColorList())
	{
		ColorManager.addColor(sc.getName(), ColorManager.getColorFromString(sc.getForeground()));
		System.out.println("Color added: "+sc.getName()+" " +sc.getForeground());
	}
	
	List<IRule> rules = new ArrayList<IRule>();
	RuleSet rs = sd.getRules();
	if (rs != null)
	{
		// add keywords
		for (Keywords kw : rs.getKeywordsList())
		{
			// find colors
			Color fg = ColorManager.getColorFromString(kw.getForeground());
			Color bg = ColorManager.getColorFromString(kw.getBackground());
			int fw = fontStyleFromString(kw.getFontweight());
			
			Token keyWord = new Token(new TextAttribute(fg, bg, fw));
			
			WordRule rule = new WordRule(new IWordDetector() {				
				@Override
				public boolean isWordStart(char c) {
					// TODO Auto-generated method stub
					return Character.isJavaIdentifierStart(c) || c == '\\';
				}
				
				@Override
				public boolean isWordPart(char c) {
					// TODO Auto-generated method stub
					return Character.isJavaIdentifierPart(c);
				}
			});
			
			for (String w : kw.getWordList())
			{
				
				rule.addWord(w, keyWord);
				System.out.println("kw added: " + w + ", " + kw.getForeground()+" "
						+ fg + " " + bg + " " + fw + " " + 
						kw.getFontweight());
			}
			rules.add(rule);
			
			
			
		}
	
		// add spans
		for (Span span : rs.getSpanList())
		{
			Color c = ColorManager.getColorFromString(span.getColor());
			Token token = new Token(new TextAttribute(c, null, 0));
			SingleLineRule rule = new SingleLineRule(span.getBegin(), span.getEnd(), token);
			rules.add(rule);
		}
		
	}
	
	
	
	
	
		return rules.toArray(new IRule[] { } );
	
		
	}
	
	private static int fontStyleFromString(String fontweight) {
		if (fontweight == null)
			return 0;
		
		fontweight = fontweight.trim().toLowerCase();
			if (fontweight.equals("bold") )
				return SWT.BOLD;
			else if (fontweight.equals("italic") )
				return SWT.ITALIC;
			else
				return 0;
		}
	
	@XStreamImplicit
    private List<SyntaxColor> ColorList = new ArrayList<SyntaxColor>();
	
	@XStreamAlias("RuleSet")
    private RuleSet Rules;
	
	private String name;
	private String xmlns;
    public SyntaxDefinition()
    {}

    public List<SyntaxColor> getColorList()
    {
        //Collections.sort( ( ArrayList ) this.hiscoreList );
        return this.ColorList;
    }

    public void setColorList( List<SyntaxColor> ColorList )
    {
        this.ColorList = ColorList;
    }
    public String getName()
    {
        return this.name;
    }

    public void setName( String name )
    {
        this.name = name;
    }

	public RuleSet getRules() {
		return Rules;
	}

	public void setRules(RuleSet rules) {
		Rules = rules;
	}
}

@XStreamAlias("Color")
class SyntaxColor implements Serializable
{
    //private Collection ColorList = new ArrayList();
	@XStreamAlias("name")
	@XStreamAsAttribute
	private String name;
	@XStreamAsAttribute
	private String foreground;
	@XStreamAsAttribute
	private String background;
    
    public SyntaxColor()
    {}

    public String getName()
    {
        return this.name;
    }

    public void setName( String name )
    {
        this.name = name;
    }
    public String getForeground()
    {
        return this.foreground;
    }

    public void setForeground( String Foreground )
    {
        this.foreground = Foreground;
    }
    public String getBackground()
    {
        return this.background;
    }

    public void setBackground( String Background )
    {
        this.background = Background;
    }
    
}

@XStreamAlias("Keywords")
class Keywords implements Serializable
{
	public String getForeground() {
		return foreground;
	}

	public void setForeground(String foreground) {
		this.foreground = foreground;
	}

	public String getBackground() {
		return background;
	}

	public void setBackground(String background) {
		this.background = background;
	}

	public String getFontweight() {
		return fontweight;
	}

	public void setFontweight(String fontweight) {
		this.fontweight = fontweight;
	}

	public Collection<String> getWordList() {
		return WordList;
	}

	
	public void setWordList(List<String> wordList) {
		WordList = wordList;
	}

	@XStreamAlias("foreground")
	@XStreamAsAttribute
	private String foreground;
	@XStreamAsAttribute
	private String background;
	@XStreamAsAttribute
	private String fontweight;
	
	@XStreamImplicit(itemFieldName="Word")
	private List<String> WordList = new ArrayList<String>();
	
	public Keywords()
	{}
}

@XStreamAlias("Span")
class Span implements Serializable
{
	@XStreamAsAttribute
	private String color;
	
	public String getColor() {
		return color;
	}
	public void setColor(String color) {
		this.color = color;
	}
	public String getBegin() {
		return begin;
	}
	public void setBegin(String begin) {
		this.begin = begin;
	}
	public String getEnd() {
		return end;
	}
	public void setEnd(String end) {
		this.end = end;
	}

	@XStreamAlias("Begin")
	@XStreamAsAttribute
	private String begin;
	@XStreamAlias("End")
	@XStreamAsAttribute
	private String end;
	
	@XStreamAlias("RuleSet")
	private RuleSet Rules;
	public Span()
	{
	}
	public void setRules(RuleSet rules) {
		Rules = rules;
	}
	public RuleSet getRules() {
		return Rules;
	}

	
}

/*
@XStreamAlias("Word")
class Word implements Serializable
{
	String content;
	public Word(String content) { this.content = content; }
	
	@Override
	public String toString()
	{
		return content;
	}
}*/

@XStreamAlias("Rule")
class Rule implements Serializable
{
	
	public Rule() {}
}

@XStreamAlias("RuleSet")
class RuleSet implements Serializable
{
	@XStreamImplicit
	private List<Keywords> KeywordsList = new ArrayList<Keywords>();
	
	@XStreamImplicit
	private List<Rule> RuleList = new ArrayList<Rule>();
	
	@XStreamImplicit
	private List<Span> SpanList = new ArrayList<Span>();
	
	private String foreground;
	
	private String background;
	
	private String fontweight;

    public String getFontweight()
    {
        return this.fontweight;
    }

    public void setFontweight( String fontweight )
    {
        this.fontweight = fontweight;
    }
    public String getForeground()
    {
        return this.foreground;
    }

    public void setForeground( String Foreground )
    {
        this.foreground = Foreground;
    }
    public String getBackground()
    {
        return this.background;
    }

    public void setBackground( String Background )
    {
        this.background = Background;
    }
    public RuleSet()
    {}

    public List<Keywords> getKeywordsList()
    {
        //Collections.sort( ( ArrayList ) this.hiscoreList );
        return this.KeywordsList;
    }
    public void setKeywordsList( List<Keywords> KeywordsList )
    {
        this.KeywordsList = KeywordsList;
    }

    public void setRuleList( List<Rule> RuleList )
    {
        this.RuleList = RuleList;
    }
    public Collection<Rule> getRuleList()
    {
        //Collections.sort( ( ArrayList ) this.hiscoreList );
        return this.RuleList;
    }

    public void setSpanList( List<Span> SpanList )
    {
        this.SpanList = SpanList;
    }
    public List<Span> getSpanList()
    {
        //Collections.sort( ( ArrayList ) this.hiscoreList );
        return this.SpanList;
    }
}