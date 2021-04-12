using System;

namespace Panuon.UI.Core
{
    public class RelayCommand : RelayCommand<object>
    {
        #region Ctor
        /// <summary>
        /// Initializes a new instance of <see cref="DelegateCommand"/>.
        /// </summary>
        /// <param name="execute">Delegate to execute when Execute is called on the command.  This can be null to just hook up a CanExecute delegate.</param>
        /// <remarks><seealso cref="CanExecute"/> will always return true.</remarks>
        public RelayCommand(Action<object> execute)
            : base(execute, null)
        {
        }

        /// <summary>
        /// Creates a new command.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
            : base(execute, canExecute)
        {
        }
        #endregion
    }
}
