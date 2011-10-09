using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TikzEdt;
using TikzEdt.ViewModels;
using NUnit.Framework;
using System.Threading;
using System.IO;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Permissions;
using System.Windows.Threading;

namespace TEAppLogicNUnitTests
{
    [TestFixture, RequiresSTA]
    class TEDocumentVMTests
    {
         
        [TestFixtureSetUp]
        public static void MyClassInitialize()
        {

        }

        [Test]
        public void SavePdfTest()
        {
            TexCompiler tc = new TexCompiler();
            //MainWindowVM parent = new MainWindowVM(tc); // TODO: Initialize to an appropriate value
            string cFile = string.Empty; // TODO: Initialize to an appropriate value
            TEDocumentVM target = new TEDocumentVM(null, tc);
            GlobalUI.MockResult = MessageBoxResult.Cancel;
            GlobalUI.LastMessage = "";
            // try to save pdf -> should not work, file should be saved first
            string pdffile = target.SavePdf(false);
            Assert.AreEqual("", pdffile);
            
            // now save file                      
            string filename = GlobalUI.MockFileDialogFileName = Directory.GetCurrentDirectory() + "\\" + "temp2.tex";
            GlobalUI.MockFileDialogResult = true;
            target.SaveCurFile();

            pdffile = target.SavePdf(false);            
            Assert.That(pdffile, Is.EqualTo(Helper.RemoveFileExtension(filename) + ".pdf").IgnoreCase);

            // check that file is actually there
            Assert.IsTrue(File.Exists(pdffile));

        }

        [Test]
        public void ExportFileTest()
        {
            TexCompiler tc = new TexCompiler();                     
            //MainWindowVM parent = new MainWindowVM(tc); // TODO: Initialize to an appropriate value
            TEDocumentVM target = new TEDocumentVM(null, tc);           

            GlobalUI.MockResult = MessageBoxResult.Cancel;
            GlobalUI.LastMessage = "";
            string jpgfile = GlobalUI.MockFileDialogFileName = Directory.GetCurrentDirectory() + "\\test.jpg";
            if (File.Exists(jpgfile))
                File.Delete(jpgfile);
            GlobalUI.MockFileDialogResult = true;
            target.ExportFileCommand.Execute(null);
            Assert.IsTrue(File.Exists(jpgfile));
            
            // now save file, and try again with different extension
            string filename = GlobalUI.MockFileDialogFileName = Directory.GetCurrentDirectory() + "\\" + "temp2.tex";
            GlobalUI.MockFileDialogResult = true;
            target.SaveCurFile();

            jpgfile = GlobalUI.MockFileDialogFileName = GlobalUI.MockFileDialogFileName = Directory.GetCurrentDirectory() + "\\test.png";
            if (File.Exists(jpgfile))
                File.Delete(jpgfile);
            target.ExportFileCommand.Execute(null);
            // check that file is actually there
            Assert.IsTrue(File.Exists(jpgfile));

        }

        [Test]
        public void TryDisposeFileTest()
        {
            TexCompiler tc = new TexCompiler();
            //MainWindowVM parent = new MainWindowVM(tc); // TODO: Initialize to an appropriate value
            TEDocumentVM target = new TEDocumentVM(null, tc);

            GlobalUI.MockResult = MessageBoxResult.Cancel;
            GlobalUI.LastMessage = "";

            // no changes made -> user should not be asked
            bool ret = target.TryDisposeFile();
            Assert.AreEqual(GlobalUI.LastMessage, "");
            Assert.IsTrue(ret);

            // make a change 
            target.Document.Insert(0, " ");
            ret = target.TryDisposeFile();
            Assert.AreNotEqual(GlobalUI.LastMessage, "");
            Assert.IsFalse(ret);
            Assert.IsTrue(target.ChangesMade);

            // say we don't want to save changes
            GlobalUI.MockResult = MessageBoxResult.No;
            ret = target.TryDisposeFile();
            Assert.IsTrue(ret);

        }
        


    }
}
