using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace my_cmd
{
    /// <summary>
    /// Very dumb program that just executes the files provided in the argument.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() == 0)
            {
                try
                {
                    Process.Start("cmd");
                }
                catch (Exception)
                {

                }
            }
            else
            {
                foreach (string s in args)
                {
                    try
                    {
                        Process.Start(s);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
}
