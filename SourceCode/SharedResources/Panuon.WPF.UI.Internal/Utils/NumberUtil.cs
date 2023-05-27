using System.Globalization;

namespace Panuon.WPF.UI.Internal.Utils
{
    static class NumberUtil
    {
        public static string Format(double value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
