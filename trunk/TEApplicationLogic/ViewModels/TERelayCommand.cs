using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TikzEdt.ViewModels
{

    public class TERelayCommand
    {
        #region Fields

        public readonly Action<object> _execute;
        public readonly Predicate<object> _canExecute;

        #endregion // Fields

        #region Constructors

        public TERelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        public TERelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }
        #endregion // Constructors

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        #endregion // ICommand Members
    }
    
}
