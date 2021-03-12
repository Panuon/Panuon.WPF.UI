using Panuon.UI.Silver.Internal;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public static class LabelHelper
    {
        #region Icon
        public static object GetIcon(Label label)
        {
            return (object)label.GetValue(IconProperty);
        }

        public static void SetIcon(Label label, object value)
        {
            label.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(LabelHelper));
        #endregion

        #region IconPlacement
        public static IconPlacement GetIconPlacement(Label label)
        {
            return (IconPlacement)label.GetValue(IconPlacementProperty);
        }

        public static void SetIconPlacement(Label label, IconPlacement value)
        {
            label.SetValue(IconPlacementProperty, value);
        }

        public static readonly DependencyProperty IconPlacementProperty =
            DependencyProperty.RegisterAttached("IconPlacement", typeof(IconPlacement), typeof(LabelHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(Label label)
        {
            return (CornerRadius)label.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(Label label, CornerRadius value)
        {
            label.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(LabelHelper));
        #endregion

        #region ShadowColor
        public static Color? GetShadowColor(Label label)
        {
            return (Color?)label.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(Label label, Color? value)
        {
            label.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            VisualStateHelper.ShadowColorProperty.AddOwner(typeof(LabelHelper));
        #endregion
    }
}
