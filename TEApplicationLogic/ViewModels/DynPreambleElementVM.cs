using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace TikzEdt.DynPreamble
{

    [Serializable()]
    public class DynPreambleElement
    {
        public bool IsActive = false;
        public string Name = "MyStyles";
        public string Code = "% some LaTeX code";
    }

    public class DynPreambleElementVM : ViewModels.ViewModelBase
    {

        /// <summary>
        /// This is the model
        /// </summary>
        private DynPreambleElement element = new DynPreambleElement();

        public DynPreambleElement GetModel() { return element; }

  /*      /// <summary>
        /// Displays a dialog allowing the user to edit the dynamic preamble.
        /// </summary>
        public void Edit()
        {
            string name, code;
            if (DynPreambleEditDialog.ShowDynPreambleEditDialog(Name, Code, out name, out code) == true)
            {
                Code = code;
                Name = name;
            }
        }*/

        public bool IsActive
        {
            get { return element.IsActive; }
            set
            {
                if (element.IsActive != value)
                {
                    element.IsActive = value;
                    NotifyPropertyChanged("IsActive");
                }
            }
        }
        public string Name
        {
            get { return element.Name; }
            set
            {
                if (element.Name != value)
                {
                    element.Name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }
        public string Code
        {
            get { return element.Code; }
            set
            {
                if (element.Code != value)
                {
                    element.Code = value;
                    NotifyPropertyChanged("Code");
                    NotifyPropertyChanged("CodeOneLine");
                }
            }
        }

        /// <summary>
        /// Gets only the first line of Code for display.
        /// </summary>
        public string CodeOneLine
        {
            get
            {
                if (Code == null)
                    return null;
                return element.Code.Split(new string[] { Environment.NewLine, "\r", "\n" }, StringSplitOptions.None)[0];
            }
        }

        public DynPreambleElementVM()
        {

        }
        public DynPreambleElementVM(DynPreambleElement Element)
        {
            element = Element;
        }

        public override string ToString()
        {
            return Code;
        }
    }
}
