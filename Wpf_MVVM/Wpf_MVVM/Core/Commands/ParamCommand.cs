using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf_MVVM.Core.Commands
{
    class ParamCommand : ICommand
    {
        private Action<object> _action;
        private readonly Func<bool> _canExecute;

        public ParamCommand(Action<object> action, Func<bool> canExecute)
        {
            this._action = action;
            this._canExecute = canExecute;
        }

        public ParamCommand(Action<object> action)
        {
            this._action = action;
            this._canExecute = () => true;
        }

        public bool CanExecute(object paramenter)
        {
            if (this._canExecute == null)
                return true;
            else
            {
                bool result = this._canExecute.Invoke();
                return result;
            }
        }

        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
            {
                if (parameter != null)
                {
                    _action(parameter);
                    
                }

            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }

            remove { CommandManager.RequerySuggested -= value; }

        }

    }
}