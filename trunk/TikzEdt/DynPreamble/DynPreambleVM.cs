using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;
using TikzEdt.ViewModels;
using System.Windows.Input;

namespace TikzEdt.DynPreamble
{
    class DynPreambleVM : ViewModels.ViewModelBase
    {

        public ObservableCollection<DynPreambleElementVM> ElementList {get; private set; }
        public int CurrentIndex { get; set; }

        public ICommand AddCommand { get { return new RelayCommand(o => 
        {
            DynPreambleElementVM vm = new DynPreambleElementVM();
            vm.PropertyChanged += (oo,e) => NotifyPropertyChanged("Preamble");
            ElementList.Add(vm); 
        }); } }
        public ICommand DeleteCommand { get { return new RelayCommand(o => 
        {
            if (CurrentIndex >= 0 && CurrentIndex < ElementList.Count)
                if (GlobalUI.UI.ShowMessageBox("Really delete the dynamic preamble '" + ElementList[CurrentIndex].Name + "'?", "Delete",
                    System.Windows.Forms.MessageBoxButtons.YesNoCancel, System.Windows.Forms.MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)            
                    ElementList.RemoveAt(CurrentIndex); 
        }); } }
        public ICommand EditCommand { get { return new RelayCommand(o => { if (CurrentIndex >= 0 && CurrentIndex < ElementList.Count) ElementList[CurrentIndex].Edit(); } ); } }
        public ICommand ToggleSelectedCommand { get { return new RelayCommand(o => { if (CurrentIndex >= 0 && CurrentIndex < ElementList.Count) ElementList[CurrentIndex].IsActive = !ElementList[CurrentIndex].IsActive; }); } }    

        public ICommand MoveUpCommand { get { return new RelayCommand(o => MoveItem(true)); } }
        public ICommand MoveDownCommand { get { return new RelayCommand(o => MoveItem(false)); } }

        private void MoveItem(bool Up)
        {
            if (CurrentIndex >= 0 && CurrentIndex < ElementList.Count && ElementList.Count > 1)
            {                
                int newIndex = CurrentIndex + (Up?-1:1);
                if (newIndex >= 0 && newIndex < ElementList.Count)
                {
                    ElementList.Move(CurrentIndex, newIndex);
                }
            }
        }

        /// <summary>
        /// Loads the preambles file
        /// </summary>
        public void LoadPreambles(string PreamblesFile)
        {
            ElementList.Clear();
            try
            {
                if (File.Exists(PreamblesFile))
                {
                    XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<DynPreambleElement>));
                    using (TextReader tr = new StreamReader(PreamblesFile))
                    {
                        List<DynPreambleElement> l = serializer.Deserialize(tr) as List<DynPreambleElement>;
                        if (l != null)
                        {
                            foreach (var model in l)
                                ElementList.Add(new DynPreambleElementVM(model));

                            // register property change handlers
                            foreach (var vm in ElementList)
                                vm.PropertyChanged += (o, e) => NotifyPropertyChanged("Preamble");
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Saves the current Preamble List to an XML file
        /// </summary>
        public void SavePreambles(string PreamblesFile)
        {
            try
            {
                XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<DynPreambleElement>));
                using (TextWriter tw = new StreamWriter(PreamblesFile))
                {
                    serializer.Serialize(tw, ElementList.Select(vm => vm.GetModel()).ToList());
                }
            }
            catch (Exception e)
            {
                string s = e.Message;
            }
        }

        /// <summary>
        /// Returns the current dynamic Preamble
        /// </summary>
        public string Preamble
        {
            get { return String.Join(Environment.NewLine, ElementList.Where(vm => vm.IsActive).Select(vm => vm.ToString()).ToArray()); }
        }

        public DynPreambleVM()
        {
            ElementList = new ObservableCollection<DynPreambleElementVM>();
            ElementList.CollectionChanged += (o, e) => NotifyPropertyChanged("Preamble");
        }

    }

  
}
