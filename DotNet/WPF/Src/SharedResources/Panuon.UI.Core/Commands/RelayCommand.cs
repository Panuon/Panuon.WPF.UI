using System;

namespace Panuon.UI.Core
{
    public class RelayCommand : RelayCommand<object>
    {
        #region Ctor
        /// <summary>
        /// Initializes a new instance of <see cref="DelegateCommand"/>.
        /// </summary>
        /// <param name="executed">Delegate to execute when Execute is called on the command.  This can be null to just hook up a CanExecute delegate.</param>
        /// <remarks><seealso cref="CanExecute"/> will always return true.</remarks>
        public RelayCommand(Action<object> executed)
            : base(executed, null)
        {
        }

        /// <summary>
        /// Creates a new command.
        /// </summary>
        /// <param name="executed">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayCommand(Action<object> executed, Predicate<object> canExecute)
            : base(executed, canExecute)
        {
        }
        #endregion
    }
}
