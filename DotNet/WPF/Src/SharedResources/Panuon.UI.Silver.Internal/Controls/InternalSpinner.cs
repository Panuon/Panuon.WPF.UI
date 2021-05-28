using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.UI.Silver.Internal
{
    class InternalSpinner : Control
    {
        #region Ctor
        static InternalSpinner()
        {
            FocusableProperty.OverrideMetadata(typeof(InternalSpinner), new FrameworkPropertyMetadata(false));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InternalSpinner), new FrameworkPropertyMetadata(typeof(InternalSpinner)));
        }
        #endregion

        #region Properties

        #region SpinnerStyle
        public SpinnerStyle SpinnerStyle
        {
            get { return (SpinnerStyle)GetValue(SpinnerStyleProperty); }
            set { SetValue(SpinnerStyleProperty, value); }
        }

        public static readonly DependencyProperty SpinnerStyleProperty =
            DependencyProperty.Register("SpinnerStyle", typeof(SpinnerStyle), typeof(InternalSpinner));
        #endregion

        #region Thickness
        public double Thickness
        {
            get { return (double)GetValue(ThicknessProperty); }
            set { SetValue(ThicknessProperty, value); }
        }

        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register("Thickness", typeof(double), typeof(InternalSpinner));
        #endregion

        #region CornerRadius
        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(double), typeof(InternalSpinner));
        #endregion

        #region IsSpinning
        public bool IsSpinning
        {
            get { return (bool)GetValue(IsSpinningProperty); }
            set { SetValue(IsSpinningProperty, value); }
        }

        public static readonly DependencyProperty IsSpinningProperty =
            DependencyProperty.Register("IsSpinning", typeof(bool), typeof(InternalSpinner));
        #endregion

        #endregion

        #region Internal Properties

        #region Percent
        internal double Percent
        {
            get { return (double)GetValue(PercentProperty); }
            set { SetValue(PercentProperty, value); }
        }

        internal static readonly DependencyProperty PercentProperty =
            DependencyProperty.Register("Percent", typeof(double), typeof(InternalSpinner));
        #endregion

        #endregion
    }

}
