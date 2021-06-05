using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Panuon.UI.Silver
{
    [ContentProperty(nameof(Child))]
    public class DropDown : ContentControl
    {
        #region Fields
        internal const string ToggleButtonTemplateName = "PART_ToggleButton";
        #endregion

        #region Ctor
        static DropDown()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DropDown), new FrameworkPropertyMetadata(typeof(DropDown)));
        }
        #endregion

        #region Properties

        #region IsOpen
        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(DropDown));
        #endregion

        #region StaysOpen
        public bool StaysOpen
        {
            get { return (bool)GetValue(StaysOpenProperty); }
            set { SetValue(StaysOpenProperty, value); }
        }

        public static readonly DependencyProperty StaysOpenProperty =
            DependencyProperty.Register("StaysOpen", typeof(bool), typeof(DropDown));
        #endregion

        #region ToggleButtonStyle
        public Style ToggleButtonStyle
        {
            get { return (Style)GetValue(ToggleButtonStyleProperty); }
            set { SetValue(ToggleButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty ToggleButtonStyleProperty =
            DependencyProperty.Register("ToggleButtonStyle", typeof(Style), typeof(DropDown));
        #endregion

        #region Child
        public object Child
        {
            get { return (object)GetValue(ChildProperty); }
            set { SetValue(ChildProperty, value); }
        }

        public static readonly DependencyProperty ChildProperty =
            DependencyProperty.Register("Child", typeof(object), typeof(DropDown));
        #endregion

        #endregion
    }
}
