using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace TikzEdt.ViewModels
{
    public static class CommandBindingExtensions
    {

        # region Commands and Command Bindings
        public static CommandBinding GetNewCommandBinding<T>(this MainWindowVM<T> vm) where T : class, ITEDoc, new()
        {
            return new CommandBinding(ApplicationCommands.New, (s,e)=> vm.CreateNewFile(e.Parameter != null));
        }
        public static CommandBinding GetOpenCommandBinding<T>(this MainWindowVM<T> vm) where T : class, ITEDoc, new()
        {
            return new CommandBinding(ApplicationCommands.Open, (s,e) => vm.Open(e.Parameter != null)); 
        }
        public static CommandBinding GetSaveCommandBinding<T>(this MainWindowVM<T> vm) where T : class, ITEDoc, new()
        {
            return new CommandBinding(ApplicationCommands.Save, (s,e) => vm.Save() ); 
        }
        public static CommandBinding GetSaveAsCommandBinding<T>(this MainWindowVM<T> vm) where T : class, ITEDoc, new()
        {
            return new CommandBinding(ApplicationCommands.SaveAs, (s,e) => vm.SaveAs() ); 
        }

        //public ICommand NewCommand { get { return new RelayCommand(o =>  CreateNewFile(o != null) ); } }
        #endregion


    }
}
