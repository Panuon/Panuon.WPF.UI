using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal
{
    class ClippingBorder : Border
    {
        #region Ctor
        public ClippingBorder()
        {
            OpacityMask = CreateOpacityMask();
        }
        #endregion

        #region Functions
        private VisualBrush CreateOpacityMask()
        {
            var clipBorder = new Border()
            {
                Background = Brushes.Black,
            };
            clipBorder.SetBinding(SnapsToDevicePixelsProperty, new Binding()
            {
                Path = new PropertyPath(SnapsToDevicePixelsProperty),
                Source = this,
            });
            clipBorder.SetBinding(CornerRadiusProperty, new Binding()
            {
                Path = new PropertyPath(CornerRadiusProperty),
                Source = this,
            });
            clipBorder.SetBinding(WidthProperty, new Binding()
            {
                Path = new PropertyPath(ActualWidthProperty),
                Source = this,
            });
            clipBorder.SetBinding(HeightProperty, new Binding()
            {
                Path = new PropertyPath(ActualHeightProperty),
                Source = this,
            });
            var visualBrush = new VisualBrush()
            {
                Visual = clipBorder,
            };
            return visualBrush;
        }
        #endregion
    }
}
