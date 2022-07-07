using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.UI.Silver.Internal
{
    class InternalSpin : Control
    {
        #region Ctor
        static InternalSpin()
        {
            FocusableProperty.OverrideMetadata(typeof(InternalSpin), new FrameworkPropertyMetadata(false));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InternalSpin), new FrameworkPropertyMetadata(typeof(InternalSpin)));
        }
        #endregion

        #region Properties

        #region SpinStyle
        public SpinStyle SpinStyle
        {
            get { return (SpinStyle)GetValue(SpinStyleProperty); }
            set { SetValue(SpinStyleProperty, value); }
        }

        public static readonly DependencyProperty SpinStyleProperty =
            DependencyProperty.Register("SpinStyle", typeof(SpinStyle), typeof(InternalSpin));
        #endregion

        #region Thickness
        public double Thickness
        {
            get { return (double)GetValue(ThicknessProperty); }
            set { SetValue(ThicknessProperty, value); }
        }

        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register("Thickness", typeof(double), typeof(InternalSpin));
        #endregion

        #region CornerRadius
        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(double), typeof(InternalSpin));
        #endregion

        #region IsSpinning
        public bool IsSpinning
        {
            get { return (bool)GetValue(IsSpinningProperty); }
            set { SetValue(IsSpinningProperty, value); }
        }

        public static readonly DependencyProperty IsSpinningProperty =
            DependencyProperty.Register("IsSpinning", typeof(bool), typeof(InternalSpin));
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
            DependencyProperty.Register("Percent", typeof(double), typeof(InternalSpin));
        #endregion

        #endregion
    }

}
