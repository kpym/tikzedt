using TikzEdt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
//using System.Query;
using System.Collections.Generic;

namespace TEApplicationLogicUnitTests
{
    
    
    /// <summary>
    ///This is a test class for TexOutputParserTest and is intended
    ///to contain all TexOutputParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TexOutputParserTest
    {


        private TestContext testContextInstance;

        string TexOutput_NoError =
@"
This is pdfTeX, Version 3.1415926-2.3-1.40.12 (MiKTeX 2.9)
entering extended mode
(C:\Users\thomas\AppData\Local\Temp\mydummyfile.tex
LaTeX2e <2011/06/27>
Babel <v3.8m> and hyphenation patterns for english, afrikaans, ancientgreek, arabic, armenian, assamese, basque, bengali, bokmal, bulgarian, catalan, coptic, croatian, czech, danish, dutch, esperanto, estonian, farsi, finnish, french, galician, german, german-x-2009-06-19, greek, gujarati, hindi, hungarian, icelandic, indonesian, interlingua, irish, italian, kannada, kurmanji, lao, latin, latvian, lithuanian, malayalam, marathi, mongolian, mongolianlmc, monogreek, ngerman, ngerman-x-2009-06-19, nynorsk, oriya, panjabi, pinyin, polish, portuguese, romanian, russian, sanskrit, serbian, slovak, slovenian, spanish, swedish, swissgerman, tamil, telugu, turkish, turkmen, ukenglish, ukrainian, uppersorbian, usenglishmax, welsh, loaded.
(C:\Users\thomas\AppData\Local\Temp\mydummyfile.aux)
ABD: EveryShipout initializing macros
(""C:\Program Files (x86)\MiKTeX 2.9\tex\context\base\supp-pdf.mkii""
[Loading MPS to PDF converter (version 2006.09.02).]
)
*geometry* driver: auto-detecting
*geometry* detected driver: pdftex
Preview: Fontsize 10pt
Preview: PDFoutput 1
Preview: Tightpage -32891 -32891 32891 32891
[1] (C:\Users\thomas\AppData\Local\Temp\mydummyfile.aux) )
Output written on temp_preview10552.pdf (1 page, 1253 bytes).
Transcript written on mydummyfile.log.
";

        string TexOutput_Err1 =
    @"
This is pdfTeX, Version 3.1415926-2.3-1.40.12 (MiKTeX 2.9)
entering extended mode
(C:\Users\thomas\AppData\Local\Temp\mydummyfile.tex
LaTeX2e <2011/06/27>
Babel <v3.8m> and hyphenation patterns for english, afrikaans, ancientgreek, arabic, armenian, assamese, basque, bengali, bokmal, bulgarian, catalan, coptic, croatian, czech, danish, dutch, esperanto, estonian, farsi, finnish, french, galician, german, german-x-2009-06-19, greek, gujarati, hindi, hungarian, icelandic, indonesian, interlingua, irish, italian, kannada, kurmanji, lao, latin, latvian, lithuanian, malayalam, marathi, mongolian, mongolianlmc, monogreek, ngerman, ngerman-x-2009-06-19, nynorsk, oriya, panjabi, pinyin, polish, portuguese, romanian, russian, sanskrit, serbian, slovak, slovenian, spanish, swedish, swissgerman, tamil, telugu, turkish, turkmen, ukenglish, ukrainian, uppersorbian, usenglishmax, welsh, loaded.
(C:\Users\thomas\AppData\Local\Temp\mydummyfile.aux)
ABD: EveryShipout initializing macros
(""C:\Program Files (x86)\MiKTeX 2.9\tex\context\base\supp-pdf.mkii""
[Loading MPS to PDF converter (version 2006.09.02).]
)
*geometry* driver: auto-detecting
*geometry* detected driver: pdftex
Preview: Fontsize 10pt
Preview: PDFoutput 1

! Package tikz Error: Giving up on this path. Did you forget a semicolon?.

See the tikz package documentation for explanation.
Type  H <return>  for immediate help.
 ...                                              
                                                  
l.7 \usetikzlibrary
                   {calc}
!  ==> Fatal error occurred, no output PDF file produced!
Transcript written on mydummyfile.log.


";


        string TexOutput_Err2 =
@"This is pdfTeX, Version 3.1415926-2.3-1.40.12 (MiKTeX 2.9)
entering extended mode
(C:\Users\thomas\AppData\Local\Temp\mydummyfile.tex
LaTeX2e <2011/06/27>
Babel <v3.8m> and hyphenation patterns for english, afrikaans, ancientgreek, arabic, armenian, assamese, basque, bengali, bokmal, bulgarian, catalan, coptic, croatian, czech, danish, dutch, esperanto, estonian, farsi, finnish, french, galician, german, german-x-2009-06-19, greek, gujarati, hindi, hungarian, icelandic, indonesian, interlingua, irish, italian, kannada, kurmanji, lao, latin, latvian, lithuanian, malayalam, marathi, mongolian, mongolianlmc, monogreek, ngerman, ngerman-x-2009-06-19, nynorsk, oriya, panjabi, pinyin, polish, portuguese, romanian, russian, sanskrit, serbian, slovak, slovenian, spanish, swedish, swissgerman, tamil, telugu, turkish, turkmen, ukenglish, ukrainian, uppersorbian, usenglishmax, welsh, loaded.
(C:\Users\thomas\AppData\Local\Temp\mydummyfile.aux)
ABD: EveryShipout initializing macros
(""C:\Program Files (x86)\MiKTeX 2.9\tex\context\base\supp-pdf.mkii""
[Loading MPS to PDF converter (version 2006.09.02).]
)
*geometry* driver: auto-detecting
*geometry* detected driver: pdftex
Preview: Fontsize 10pt
Preview: PDFoutput 1
! Undefined control sequence.
l.9 \sdfsdf
           
!  ==> Fatal error occurred, no output PDF file produced!
Transcript written on mydummyfile.log.
";

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void TestSetup()
        {

            job = new TexCompiler.Job() { path = @"C:\Users\thomas\AppData\Local\Temp\mydummyfile.tex" };
            
        }
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        TexCompiler.Job job;

        [TestMethod()]
        public void parseOutputTest1()
        {
            TexOutputParser.ParseResult ret = TexOutputParser.parseOutput(TexOutput_NoError, job);
            var errors = ret.Errors.ToList();
            Assert.AreEqual(errors.Count, 0);
        }

        [TestMethod()]
        public void parseOutputTest2()
        {
            TexOutputParser.ParseResult ret = TexOutputParser.parseOutput(TexOutput_Err1, job);
            var errors = ret.Errors.ToList();
            Assert.AreNotEqual(errors.Count, 0);
            Assert.AreEqual(errors[0].Line, 7);
            Assert.IsTrue(errors[0].severity == Severity.ERROR);
        }

        [TestMethod()]
        public void parseOutputTest3()
        {
            TexOutputParser.ParseResult ret = TexOutputParser.parseOutput(TexOutput_Err2, job);
            var errors = ret.Errors.ToList();
            Assert.AreNotEqual(errors.Count, 0);
            Assert.AreEqual(errors[0].Line, 9);
            Assert.IsTrue(errors[0].Message.Contains("control sequence"));
            Assert.IsTrue(errors[0].severity == Severity.ERROR);
        }

        [TestMethod()]
        public void parseOutputTest_withInsertions()
        {
            job.AddOffset(3, 3);
            TexOutputParser.ParseResult ret = TexOutputParser.parseOutput(TexOutput_Err1, job);
            var errors = ret.Errors.ToList();

            Assert.AreEqual(4, errors[0].Line);
            job.OffsetClear();
            job.AddOffset(8, 3);
            ret = TexOutputParser.parseOutput(TexOutput_Err1, job);
            errors = ret.Errors.ToList();
            Assert.AreEqual(7, errors[0].Line);
            job.AddOffset(6, 3);
            ret = TexOutputParser.parseOutput(TexOutput_Err1, job);
            errors = ret.Errors.ToList();
            Assert.AreEqual(6, errors[0].Line);
            
        }
  
        /// <summary>
        ///A test for parseOutput
        ///</summary>
        [Ignore]
        [TestMethod()]
        public void parseOutputTest()
        {
            //TexOutputParser target = new TexOutputParser(); // TODO: Initialize to an appropriate value
            //TexCompiler.Job job = new TexCompiler.Job(); // TODO: Initialize to an appropriate value
            
            //bool expected = false; // TODO: Initialize to an appropriate value
            //bool actual;
            //actual = target.parseOutput(job);
            //Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }


    }
}
