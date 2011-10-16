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
using TESharedComponents;

namespace TEAppLogicNUnitTests
{


    [TestFixture, RequiresSTA]
    public class MainWindowVMTests
    {

        [TestFixtureSetUp]
        public static void MyClassInitialize()
        {

        }

        [Test]
        public void TestTest()
        {
            BackgroundWorker bw = new BackgroundWorker();
            Process p= new Process();
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            double x = 0, y=0;

            bw.DoWork += (s, e) => x = 35;
            bw.RunWorkerCompleted += (s, e) => y = 35;

            bw.RunWorkerAsync();

            Thread.Sleep(1000);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Assert.AreEqual(35, x);
            Assert.AreEqual(35, y);
        }

        [Test]
        public void StdFileHandlingTest()
        {

            MainWindowVM target = new MainWindowVM(TheCompiler.Instance); 
            // To execute commands, we need to take a detour and bind them in a dummy
            StackPanel dummy = new StackPanel();
            dummy.CommandBindings.Add(target.SaveAsCommandBinding);
            dummy.CommandBindings.Add(target.NewCommandBinding);
            dummy.CommandBindings.Add(target.SaveCommandBinding);
            dummy.CommandBindings.Add(target.OpenCommandBinding);

            Console.WriteLine(Directory.GetCurrentDirectory());                        

            // create a new file 
            ApplicationCommands.New.Execute(null, dummy);
            GlobalUI.LastMessage = "";
            GlobalUI.MockResult = MessageBoxResult.Cancel;
            // create a new file again, the file was not changed, so the use should not be asked to save
            ApplicationCommands.New.Execute(null, dummy);
            Assert.AreEqual(GlobalUI.LastMessage, "");
            //Application.DoEvents();
        //    Thread.Sleep(10000);
            //DispatcherUtil.DoEvents();
            //Application.DoEvents();

            // now change the file a bit
            target.TheDocument.Document.Insert(0, "   ");
            string oldText = target.TheDocument.Document.Text;

          //  Thread.Sleep(1000);
            //DispatcherUtil.DoEvents();

            // try to override again
            ApplicationCommands.New.Execute(null, dummy);
            // now a messagebox must have been shown, and the file contents should be unchanged
            Assert.IsTrue(GlobalUI.LastMessage != "");
            Assert.AreEqual(target.TheDocument.Document.Text, oldText);

         //   Thread.Sleep(1000);
            //DispatcherUtil.DoEvents();

            // Now save the file to a temp file
            string filename = Directory.GetCurrentDirectory() + "\\temp.tex";
            if (File.Exists(filename))
                File.Delete(filename);

            Thread.Sleep(1000);
           // DispatcherUtil.DoEvents();

            GlobalUI.MockFileDialogFileName = filename;
            GlobalUI.MockFileDialogResult = true;
            ApplicationCommands.SaveAs.Execute(null, dummy);
            Assert.IsTrue(File.Exists(filename));
                       

            // Let pdflatex do its job (hack)
       //     Thread.Sleep(2000);
            //DispatcherUtil.DoEvents();

            //return;
            // check that temp files are removed, but pdf should exist
            Assert.IsTrue(File.Exists(filename+".preview.pdf"));
            //Assert.IsFalse(File.Exists("temp.tex.preview.log")); // are deleted upon destruction
            //Assert.IsFalse(File.Exists("temp.tex.preview.aux"));
            
            // change file on disk... change should be detected, and user asked to reload file
            GlobalUI.MockResult = MessageBoxResult.Yes; // reload the file
            File.WriteAllText(filename, "\\begin{tikzpicture} \r\n blabla\r\n \\end{tikzpicture}");
        //    System.Threading.Thread.Sleep(2000);
            System.Threading.Thread.Sleep(1000);
            DispatcherUtil.DoEvents();
            System.Threading.Thread.Sleep(1000);
            DispatcherUtil.DoEvents();
            Assert.IsTrue(target.TheDocument.Document.Text.Contains("blabla"));
            // file should not be marked as changed
            Assert.IsFalse(target.TheDocument.ChangesMade);

      //      Thread.Sleep(1000);

        }

    }

     [SetUpFixture]
      public class MySetUpClass
      {
        [SetUp]
	    public static void RunBeforeAnyTests()
	    {
            Helper.SetAppdataPath(Helper.AppdataPathOptions.ExeDir);
            GlobalUI.OnGlobalStatus += (s, e) => Console.WriteLine("*** " + e.StatusLine);
            TheCompiler.Instance.OnCompileEvent += (s, e) => Console.WriteLine("+++ " + e.Message);
            TheCompiler.Instance.OnTexOutput += (s, e) => Console.WriteLine("xxx " + e.Message);
            TheCompiler.Instance.JobDone += (s, e) => Console.WriteLine("xxx Done with Exit Code "+e.ExitCode);

            MyBackgroundWorker.IsSynchronous = true;
	    }

        [TearDown]
        public static void RunAfterAnyTests()
	    {
	      // ...
	    }
      }


    public static class DispatcherUtil
    {
        [SecurityPermissionAttribute(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        public static void DoEvents()
        {
            DispatcherFrame frame = new DispatcherFrame();
            Dispatcher.CurrentDispatcher.BeginInvoke(DispatcherPriority.Background,
                new DispatcherOperationCallback(ExitFrame), frame);
            Dispatcher.PushFrame(frame);
        }

        private static object ExitFrame(object frame)
        {
            ((DispatcherFrame)frame).Continue = false;
            return null;
        }
    }
}
