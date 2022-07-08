using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal.Converters
{
    class ColorSelectorOpacitySliderBackgroundConverter 
        : OneWayMultiValueConverterBase
    {
        #region Fields
        private static Brush _stackBrush;
        #endregion

        #region Ctor
        static ColorSelectorOpacitySliderBackgroundConverter()
        {
            _stackBrush = new DrawingBrush()
            {
                Viewport = new Rect(0, 0, 12, 12),
                ViewportUnits = BrushMappingMode.Absolute,
                Stretch = Stretch.None,
                TileMode = TileMode.Tile,
                Drawing = new DrawingGroup()
                {
                    Children = new DrawingCollection()
                     {
                         new GeometryDrawing()
                         {
                             Brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D0CEC7")),
                             Geometry = new GeometryGroup()
                             {
                                 Children = new GeometryCollection()
                                 {
                                     new RectangleGeometry(new Rect(0, 0, 6, 6)),
                                     new RectangleGeometry(new Rect(6, 6, 6, 6)),
                                 }
                            },
                         },
                         new GeometryDrawing()
                         {
                             Brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#E7E7E2")),
                             Geometry = new RectangleGeometry(new Rect(0, 6, 12, 0)),
                         }
                     }
                }
            };
            _stackBrush.Freeze();
        }
        #endregion

        #region Methods
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var width = (double)values[0];
            var height = (double)values[1];
            var backgroundColor = (Color)values[2];
            var background = new LinearGradientBrush()
            {
                StartPoint = new Point(0, 1),
                EndPoint = new Point(0, 0),
                GradientStops = new GradientStopCollection()
                {
                    new GradientStop(backgroundColor, 0),
                    new GradientStop(Colors.Transparent, 1),
                }
            };
            background.Freeze();

            var drawingBrush = new DrawingBrush()
            {
                Drawing = new DrawingGroup()
                {
                    Children = new DrawingCollection()
                    {
                          new GeometryDrawing(_stackBrush, null, new RectangleGeometry(new Rect(0, 0, width, height))),
                          new GeometryDrawing(background, null, new RectangleGeometry(new Rect(0, 0, width, height))),
                     }
                }
            };
            drawingBrush.Freeze();
            return drawingBrush;
        }
        #endregion
    }
}
