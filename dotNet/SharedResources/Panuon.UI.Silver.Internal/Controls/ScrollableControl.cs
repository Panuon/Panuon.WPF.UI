using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.UI.Silver.Internal
{
    class ScrollableControl : ContentControl
    {
        #region 
        static ScrollableControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ScrollableControl), new FrameworkPropertyMetadata(typeof(ScrollableControl)));
        }
        #endregion

        #region Properties

        #region ScrollButtonStyle
        public Style ScrollButtonStyle
        {
            get { return (Style)GetValue(ScrollButtonStyleProperty); }
            set { SetValue(ScrollButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty ScrollButtonStyleProperty =
            DependencyProperty.Register("ScrollButtonStyle", typeof(Style), typeof(ScrollableControl));
        #endregion

        #region ScrollButtonVisibility
        public ScrollButtonVisibility ScrollButtonVisibility
        {
            get { return (ScrollButtonVisibility)GetValue(ScrollButtonVisibilityProperty); }
            set { SetValue(ScrollButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ScrollButtonVisibilityProperty =
            DependencyProperty.Register("ScrollButtonVisibility", typeof(ScrollButtonVisibility), typeof(ScrollableControl));
        #endregion

        #region Orientation
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(ScrollableControl));
        #endregion 

        #endregion
    }
}
