using System.Windows;

namespace Panuon.WPF.UI
{
    public abstract class WindowXEffect : DependencyObject
    {
        #region Methods
        protected internal abstract void Enable(WindowX window);

        protected internal abstract void Disable();
        #endregion
    }
}
