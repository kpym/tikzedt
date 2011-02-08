import java.io.*;
import org.antlr.runtime.*;
import org.antlr.runtime.debug.DebugEventSocketProxy;


public class __Test__ {

    public static void main(String args[]) throws Exception {
        simpletikzLexer lex = new simpletikzLexer(new ANTLRFileStream("C:\\Users\\thomas\\Documents\\Visual Studio 2010\\Projects\\tikzedt\\TikzEdt\\parser_testcases\\overlay2.tex", "UTF8"));
        CommonTokenStream tokens = new CommonTokenStream(lex);

        simpletikzParser g = new simpletikzParser(tokens, 49100, null);
        try {
            g.tikzdocument();
        } catch (RecognitionException e) {
            e.printStackTrace();
        }
    }
}