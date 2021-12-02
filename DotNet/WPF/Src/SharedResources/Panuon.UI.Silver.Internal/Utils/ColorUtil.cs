using System;
using System.Windows.Media;

namespace Panuon.UI.Silver.Internal.Utils
{
    static class ColorUtil
    {
        #region Methods
        public static Color GetScreenColor(double x, double y)
        {
            var hwnd = Win32Util.GetDC(IntPtr.Zero);
            var pixel = Win32Util.GetPixel(hwnd, (int)x, (int)y);
            Win32Util.ReleaseDC(IntPtr.Zero, hwnd);
            return Color.FromRgb((byte)(pixel & 0x000000FF),
                (byte)((pixel & 0x0000FF00) >> 8),
                (byte)((pixel & 0x00FF0000) >> 16));
        }

        public static string ToHEXString(Color color, bool includeAlpha, bool includeTag)
        {
            var colorString = includeAlpha
                ? string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", color.A, color.R, color.G, color.B)
                : string.Format("{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B);
            if (includeTag)
            {
                colorString = "#" + colorString;
            }
            return colorString;
        }

        public static Color? FromHEXString(string text)
        {
            try
            {
                if (!text.StartsWith("#"))
                {
                    text = "#" + text;
                }
                return (Color)ColorConverter.ConvertFromString(text);
            }
            catch
            {
                return null;
            }
        }

        internal static string ToARGBString(Color color, bool includeAlpha)
        {
            var colorString = includeAlpha
                ? string.Format("{0}, {1}, {2}, {3}", color.A, color.R, color.G, color.B)
                : string.Format("{0}, {1}, {2}", color.R, color.G, color.B);
            return colorString;
        }

        public static Color? FromARGBString(string text)
        {
            try
            {
                text = text.Replace(" ", "");
                var argbs = text.Split(',');
                if(argbs.Length == 3)
                {
                    if(byte.TryParse(argbs[0], out byte r)
                        && byte.TryParse(argbs[1], out byte g)
                        && byte.TryParse(argbs[2], out byte b))
                    {
                        return Color.FromArgb(255, r, g, b);
                    }
                }
                else if(argbs.Length == 4)
                {
                    if (byte.TryParse(argbs[0], out byte a)
                        && byte.TryParse(argbs[1], out byte r)
                        && byte.TryParse(argbs[2], out byte g)
                        && byte.TryParse(argbs[3], out byte b))
                    {
                        return Color.FromArgb(a, r, g, b);
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
