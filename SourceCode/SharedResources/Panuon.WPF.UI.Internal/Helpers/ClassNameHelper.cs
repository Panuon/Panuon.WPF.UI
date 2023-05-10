using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal
{
    internal static class ClassNameHelper
    {
        #region Fields
        private static Dictionary<Type, ClassNameInfo> _classNameRegistDictionary
            = new Dictionary<Type, ClassNameInfo>();
        #endregion

        #region Properties
        public static readonly DependencyProperty ClassNameProperty =
            DependencyProperty.RegisterAttached("ClassName", typeof(string), typeof(ClassNameHelper), new PropertyMetadata(OnClassNameChanged));
        #endregion

        #region Event Handlers
        private static void OnClassNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is string className)
            {
                var classNamePropertyValues = DeserializeClassName(className);

                var control = d as FrameworkElement;
                var controlType = control.GetType();
                if (_classNameRegistDictionary.ContainsKey(controlType))
                {
                    var classNameInfo = _classNameRegistDictionary[controlType];
                    var callback = classNameInfo.ClassNameChangedCallback;
                    callback.Invoke(control, classNamePropertyValues);
                }
            }
        }
        #endregion

        #region Methods
        internal static void Regist(Type controlType,
            IEnumerable<string> abbrs,
            Action<FrameworkElement, Dictionary<string, string>> classNameChangedCallback)
        {
            _classNameRegistDictionary[controlType] = new ClassNameInfo()
            {
                Abbrs = abbrs,
                ClassNameChangedCallback = classNameChangedCallback
            };
        }

        #region Convert
        internal static bool TryToBoolean(string value, out bool? result)
        {
            result = null;
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else if (value == "null")
            {
                return true;
            }
            if (bool.TryParse(value, out bool boolResult))
            {
                result = boolResult;
                return true;
            }
            System.Diagnostics.Debug.WriteLine($"Can not convert {value} to bool.");
            return false;
        }

        internal static bool TryToDouble(string value, out double? result)
        {
            result = null;
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else if (value == "null")
            {
                return true;
            }
            if (double.TryParse(value, out double doubleResult))
            {
                result = doubleResult;
                return true;
            }
            System.Diagnostics.Debug.WriteLine($"Can not convert {value} to double.");
            return false;
        }

        internal static bool TryToIcon(string value, out string icon, out IconPlacement? placement)
        {
            icon = null;
            placement = null;
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else if (value == "null")
            {
                return true;
            }
            try
            {
                if (value.Contains(","))
                {
                    var splits = value.Split(',');
                    icon = splits[0];
                    if (Enum.TryParse(splits[1], true, out IconPlacement iconPlacement))
                    {
                        placement = iconPlacement;
                    }
                }
                else
                {
                    icon = value;
                }

                if (int.TryParse(icon, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int unicodeValue))
                {
                    icon = ((char)unicodeValue).ToString();
                }
                return true;
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine($"Can not convert {value} to icon.");
                return false;
            }
        }

        internal static bool TryToBrush(string value, out Brush result)
        {
            result = null;
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else if (value == "null")
            {
                return true;
            }
            try
            {
                if (!value.Contains("~")) //Solid
                {
                    result = new SolidColorBrush((Color)ColorConverter.ConvertFromString(value));
                    return true;
                }
                else if (value.StartsWith("radial,"))
                {
                    value = value.Remove(0, 7);
                    var radialBrush = new RadialGradientBrush();
                    InitGradientBrush(radialBrush, value);
                    result = radialBrush;
                    return true;
                }
                else if (value.StartsWith("linear,"))
                {
                    value = value.Remove(0, 7);
                    var radialBrush = new LinearGradientBrush();
                    InitGradientBrush(radialBrush, value);
                    result = radialBrush;
                    return true;
                }
                else
                {
                    var radialBrush = new LinearGradientBrush();
                    InitGradientBrush(radialBrush, value);
                    result = radialBrush;
                    return true;
                }
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine($"Can not convert {value} to brush.");
                return false;
            }
        }

        internal static bool TryToThickness(string value, out Thickness? result)
        {
            result = null;
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else if (value == "null")
            {
                return true;
            }

            string[] parts = value.Split(',');

            if (parts.Length == 1 && double.TryParse(parts[0].Trim(), out double uniformValue))
            {
                result = new Thickness(uniformValue);
                return true;
            }
            else if (parts.Length == 2 && double.TryParse(parts[0].Trim(), out double horizontalValue) && double.TryParse(parts[1].Trim(), out double verticalValue))
            {
                result = new Thickness(horizontalValue, verticalValue, horizontalValue, verticalValue);
                return true;
            }
            else if (parts.Length == 4 && double.TryParse(parts[0].Trim(), out double left) && double.TryParse(parts[1].Trim(), out double top) && double.TryParse(parts[2].Trim(), out double right) && double.TryParse(parts[3].Trim(), out double bottom))
            {
                result = new Thickness(left, top, right, bottom);
                return true;
            }
            System.Diagnostics.Debug.WriteLine($"Can not convert {value} to thickness.");
            return false;
        }

        internal static bool TryToCornerRadius(string value, out CornerRadius? result)
        {
            result = null;
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            else if (value == "null")
            {
                return true;
            }

            string[] parts = value.Split(',');

            if (parts.Length == 1 && double.TryParse(parts[0].Trim(), out double uniformValue))
            {
                result = new CornerRadius(uniformValue);
                return true;
            }
            else if (parts.Length == 2 && double.TryParse(parts[0].Trim(), out double nwValue) && double.TryParse(parts[1].Trim(), out double esValue))
            {
                result = new CornerRadius(nwValue, esValue, nwValue, esValue);
                return true;
            }
            else if (parts.Length == 4 && double.TryParse(parts[0].Trim(), out double topLeft) && double.TryParse(parts[1].Trim(), out double topRight) && double.TryParse(parts[2].Trim(), out double bottomRight) && double.TryParse(parts[3].Trim(), out double bottomLeft))
            {
                result = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft);
                return true;
            }
            System.Diagnostics.Debug.WriteLine($"Can not convert {value} to cornerradius.");
            return false;
        }

        #endregion

        #endregion

        #region Functions
        private static Dictionary<string, string> DeserializeClassName(string className)
        {
            var propertyValues = new Dictionary<string, string>();
            var propertyValuePairs = className.Split();

            foreach (string pair in propertyValuePairs)
            {
                int separatorIndex = pair.LastIndexOf('-');
                if (separatorIndex != -1)
                {
                    string key = pair.Substring(0, separatorIndex);
                    string value = pair.Substring(separatorIndex + 1);
                    propertyValues.Add(key, value);
                }
            }

            return propertyValues;
        }

        private static void InitGradientBrush(GradientBrush gradientBrush,
            string value)
        {
            var colorPairs = value.Split('~')
                .ToList();

            var delta = (100d / colorPairs.Count) * 0.01;
            var offset = 0d;

            foreach (var stopPair in colorPairs)
            {
                Color color = Colors.Transparent;
                if (stopPair.Contains(","))
                {
                    var colorOffsetPair = stopPair.Split(',');
                    gradientBrush.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString(colorOffsetPair[0]), double.Parse(colorOffsetPair[1])));
                }
                else
                {
                    gradientBrush.GradientStops.Add(new GradientStop(color, offset));
                }
                offset += delta;
            }
        }
        #endregion
    }
}
