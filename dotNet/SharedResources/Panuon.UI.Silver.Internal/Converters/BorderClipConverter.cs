using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Converters
{
    class BorderClipConverter : MultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var width = (double)values[0];
            var height = (double)values[1];
            var cornerRadius = (CornerRadius)values[2];
            if(cornerRadius.TopLeft == 0 && cornerRadius.TopRight == 0 && cornerRadius.BottomRight == 0 && cornerRadius.BottomLeft == 0)
            {
                return null;
            }
            var clip = new RectangleGeometry(new Rect(0, 0, width, height), cornerRadius.TopLeft, cornerRadius.TopLeft);
            clip.Freeze();
            return clip;
        }
    }
}
