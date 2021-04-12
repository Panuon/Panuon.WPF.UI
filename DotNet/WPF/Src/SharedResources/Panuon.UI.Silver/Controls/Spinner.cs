using System.Windows;
using System.Windows.Controls;

namespace Panuon.UI.Silver
{
    public class Spinner : Control
    {
        #region Ctor
        static Spinner()
        {
            FocusableProperty.OverrideMetadata(typeof(Spinner), new FrameworkPropertyMetadata(false));
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Spinner), new FrameworkPropertyMetadata(typeof(Spinner)));
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
            DependencyProperty.Register("SpinnerStyle", typeof(SpinnerStyle), typeof(Spinner));
        #endregion

        #region Thickness
        public double Thickness
        {
            get { return (double)GetValue(ThicknessProperty); }
            set { SetValue(ThicknessProperty, value); }
        }

        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register("Thickness", typeof(double), typeof(Spinner));
        #endregion

        #region CornerRadius
        public double CornerRadius
        {
            get { return (double)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(double), typeof(Spinner));
        #endregion

        #region IsSpinning
        public bool IsSpinning
        {
            get { return (bool)GetValue(IsSpinningProperty); }
            set { SetValue(IsSpinningProperty, value); }
        }

        public static readonly DependencyProperty IsSpinningProperty =
            DependencyProperty.Register("IsSpinning", typeof(bool), typeof(Spinner));
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
            DependencyProperty.Register("Percent", typeof(double), typeof(Spinner));
        #endregion

        #endregion
    }
}
