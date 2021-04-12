using Panuon.UI.Core;
using System;
using System.Globalization;
using System.Windows;

namespace Panuon.UI.Silver.Internal.Converters
{
    class WindowXCaptionDataContextConverter : ValueConverterBase
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is Window)
            {
                return "";
            }
            return value;
        }
    }
}
