using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace Panuon.UI.Silver
{
    [TemplatePart(Name = PopupTemplateName, Type = typeof(Popup))]
    [ContentProperty(nameof(Child))]
    public class DropDown : ContentControl
    {
        #region Fields
        private const string PopupTemplateName = "PART_Popup";

        private Popup _popup; 
        #endregion

        #region Ctor
        static DropDown()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DropDown), new FrameworkPropertyMetadata(typeof(DropDown)));
        }
        #endregion

        #region Events
        public event EventHandler Closed;

        public event EventHandler Opened;
        #endregion

        #region Properties

        #region IsOpen
        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(DropDown), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
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

        #region Overrides

        public override void OnApplyTemplate()
        {
            _popup = GetTemplateChild(PopupTemplateName) as Popup;
            _popup.Opened += Popup_Opened;
            _popup.Closed += Popup_Closed;
        }
        #endregion

        #region Functions
        private void Popup_Closed(object sender, EventArgs e)
        {
            Closed?.Invoke(this, e);
        }

        private void Popup_Opened(object sender, EventArgs e)
        {
            Opened?.Invoke(this, e);
        }
        #endregion
    }
}
