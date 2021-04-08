using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Panuon.UI.Silver
{
    class Switch : ToggleButton
    {
        #region Ctor
        static Switch()
        {
            KeyboardNavigation.AcceptsReturnProperty.OverrideMetadata(typeof(Switch), new FrameworkPropertyMetadata(false));
        }

        public Switch()
        {
            SwitchChecked += Switch_SwitchChecked;
        }
        #endregion

        #region Events
        event EventHandler<string> SwitchChecked;
        #endregion

        #region Overrides

        #endregion

        #region Properties

        #region GroupName
        public string GroupName
        {
            get { return (string)GetValue(GroupNameProperty); }
            set { SetValue(GroupNameProperty, value); }
        }

        public static readonly DependencyProperty GroupNameProperty =
            DependencyProperty.Register("GroupName", typeof(string), typeof(Switch), new PropertyMetadata(null, OnGroupNameChanged));
        #endregion

        #endregion

        #region Event Handlers
        private static void OnGroupNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var switchControl = (Switch)d;
            switchControl.OnGroupNameChanged();
        }

        private void Switch_SwitchChecked(object sender, string e)
        {
            if(!string.IsNullOrEmpty(e) && e == GroupName)
            {
                SetCurrentValue(IsCheckedProperty, false);
            }
        }
        #endregion

        #region Functions
        private void OnGroupNameChanged()
        {
        }

       
        #endregion
    }
}
