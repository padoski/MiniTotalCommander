using System;
using System.Windows.Input;

namespace Commander.ViewModel.Commands
{
    class CommandHandlerParameter : ICommand
    {
        private readonly Action<int> _action;
        private readonly Func<bool> _canExecute;

        public CommandHandlerParameter(Action<int> action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }


        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke();
        }

        public void Execute(object parameter)
        {
            _action((int)parameter);
        }
    }
}
