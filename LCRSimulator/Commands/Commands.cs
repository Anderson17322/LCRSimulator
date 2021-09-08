using LCRSimulator.ViewModels;
using System;
using System.Windows.Input;

namespace LCRSimulator.Commands
{
    public class DelegatingCommand : ICommand
    {
        private readonly Action<object> _action;
        private readonly Func<object, bool> _canExecute;
        public ViewModelBase ViewModel { get; set; }
        public DelegatingCommand(ViewModelBase vewModel)
        {
            this.ViewModel = vewModel;
        }
        public DelegatingCommand(Action action)
            : this((o) => action())
        { }
        public DelegatingCommand(Action<object> action)
            : this(action, (o) => true)
        { }
        public DelegatingCommand(Action<object> action, Func<object, bool> canExecute)
        {
            _action = action;
            this._canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            // ViewModel.CloseForm();
            this._action(parameter);
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
