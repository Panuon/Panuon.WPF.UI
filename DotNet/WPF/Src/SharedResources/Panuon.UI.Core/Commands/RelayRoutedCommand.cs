using System;
using System.Reflection;
using System.Windows.Input;

namespace Panuon.UI.Core
{
    public class RelayRoutedCommand : ICommand
    {
        #region Fields
        private readonly ExecutedRoutedEventHandler _executed;
        private readonly CanExecuteRoutedEventHandler _canExecute;
        #endregion

        #region Ctor
        /// <summary>
        /// Initializes a new instance."/>.
        /// </summary>
        /// <param name="executed">Delegate to execute when Execute is called on the command.  This can be null to just hook up a CanExecute delegate.</param>
        /// <remarks><seealso cref="CanExecute"/> will always return true.</remarks>
        public RelayRoutedCommand(ExecutedRoutedEventHandler executed)
            : this(executed, null)
        {
        }

        /// <summary>
        /// Creates a new command.
        /// </summary>
        /// <param name="executed">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayRoutedCommand(ExecutedRoutedEventHandler executed, 
            CanExecuteRoutedEventHandler canExecute)
        {
            _executed = executed;
            _canExecute = canExecute;
        }
        #endregion

        #region ICommand Members
        ///<summary>
        ///Defines the method that determines whether the command can execute in its current state.
        ///</summary>
        ///<param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        ///<returns>
        ///true if this command can be executed; otherwise, false.
        ///</returns>
        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }
            else
            {
                var eventArgs = (CanExecuteRoutedEventArgs)Activator.CreateInstance(typeof(CanExecuteRoutedEventArgs),
                             BindingFlags.NonPublic | BindingFlags.Instance, null,
                             new object[2] { parameter, parameter }, null);
                _canExecute.Invoke(this, eventArgs);
                
                return eventArgs.CanExecute;
            }
        }

        ///<summary>
        ///Occurs when changes occur that affect whether or not the command should execute.
        ///</summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        ///<summary>
        ///Defines the method to be called when the command is invoked.
        ///</summary>
        ///<param name="parameter">Data used by the command. If the command does not require data to be passed, this object can be set to <see langword="null" />.</param>
        public void Execute(object parameter)
        {
            var eventArgs = (ExecutedRoutedEventArgs)Activator.CreateInstance(typeof(ExecutedRoutedEventArgs),
                             BindingFlags.NonPublic | BindingFlags.Instance, null,
                             new object[2] { parameter, parameter }, null);

            _executed.Invoke(this, eventArgs);
        }
        #endregion
    }
}
