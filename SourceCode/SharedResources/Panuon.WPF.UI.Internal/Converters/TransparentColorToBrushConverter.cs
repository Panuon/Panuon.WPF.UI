using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal.Converters
{
    class TransparentColorToBrushConverter 
        : OneWayMultiValueConverterBase
    {
        #region Fields
        private static Brush _stackBrush;
        #endregion

        #region Ctor
        static TransparentColorToBrushConverter()
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
                             Brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#AAAAAA")),
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
                             Brush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F1F1F1")),
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
            var backgroundColor = values[2] as Color?;
            var borderBrush = values[3] as Brush;

            if(backgroundColor == null)
            {
                var nullBrush = new DrawingBrush()
                {
                    Drawing = new DrawingGroup()
                    {
                        Children = new DrawingCollection()
                        {
                            new GeometryDrawing(null, new Pen(borderBrush, 1.5), new LineGeometry(new Point(0, 0), new Point(width, height))),
                            new GeometryDrawing(null, new Pen(borderBrush, 1.5), new LineGeometry(new Point(0, height), new Point(width, 0))),
                        }
                    }
                };
                nullBrush.Freeze();
                return nullBrush;
            }
            var background = new SolidColorBrush((Color)backgroundColor);
            background.Freeze();

            var drawingBrush = new DrawingBrush()
            {
                Drawing = new DrawingGroup()
                {
                    Children = new DrawingCollection()
                    {
                          new GeometryDrawing(_stackBrush, null, new RectangleGeometry(new Rect(1, 1, Math.Max(0, width - 2), Math.Max(0, height - 2)))),
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
