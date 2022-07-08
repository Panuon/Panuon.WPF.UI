using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;

namespace Panuon.WPF.UI.Internal.Converters
{
    class ColorSelectorThumbFenceBackgroundConverter 
        : ValueConverterBase
    {
        #region Fields
        private static Brush _firstStackBrush;

        private static Brush _secondStackBrush;
        #endregion

        #region Ctor
        static ColorSelectorThumbFenceBackgroundConverter()
        {
            _firstStackBrush = new LinearGradientBrush()
            {
                StartPoint = new Point(1, 0),
                EndPoint = new Point(0, 0),
                GradientStops = new GradientStopCollection()
                {
                    new GradientStop(Color.FromArgb(0, 255, 255, 255), 0),
                    new GradientStop(Color.FromArgb(128, 255, 255, 255), 0.5),
                    new GradientStop(Colors.White, 1),
                }
            };
            _firstStackBrush.Freeze();
            _secondStackBrush = new LinearGradientBrush()
            {
                StartPoint = new Point(0, 0),
                EndPoint = new Point(0, 1),
                GradientStops = new GradientStopCollection()
                {
                    new GradientStop(Color.FromArgb(0, 0, 0, 0), 0),
                    new GradientStop(Color.FromArgb(128, 0, 0, 0), 0.5),
                    new GradientStop(Colors.Black, 1),
                }
            };
            _secondStackBrush.Freeze();
        }
        #endregion

        #region Methods
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var backgroundColor = (Color)value;
            var background = new SolidColorBrush(backgroundColor);
            background.Freeze();

            var drawingBrush = new DrawingBrush()
            {
                Drawing = new DrawingGroup()
                {
                    Children = new DrawingCollection()
                      {
                          new GeometryDrawing(background, null, new RectangleGeometry(new System.Windows.Rect(0,0,1,1))),
                          new GeometryDrawing(_firstStackBrush, null, new RectangleGeometry(new System.Windows.Rect(0,0,1,1))),
                          new GeometryDrawing(_secondStackBrush, null, new RectangleGeometry(new System.Windows.Rect(0,0,1,1))),
                      }
                }
            };
            drawingBrush.Freeze();
            return drawingBrush;
        }
        #endregion
    }
}
