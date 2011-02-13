using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace TikzEdt.ViewModels
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public ObservableCollection<TEDocumentVM> Documents { get;  private set; }

        public TEDocumentVM ActiveDocument { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
