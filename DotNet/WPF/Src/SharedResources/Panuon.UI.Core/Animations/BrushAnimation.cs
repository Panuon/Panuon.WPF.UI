using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Panuon.UI.Core
{
    public class BrushAnimation : AnimationTimeline
    {
        #region Fields
        private VisualBrush _visualBrush;
        #endregion

        #region Properties

        #region From
        public Brush From
        {
            get { return (Brush)GetValue(FromProperty); }
            set { SetValue(FromProperty, value); }
        }

        public static readonly DependencyProperty FromProperty =
            DependencyProperty.Register("From", typeof(Brush), typeof(BrushAnimation));
        #endregion

        #region To
        public Brush To
        {
            get { return (Brush)GetValue(ToProperty); }
            set { SetValue(ToProperty, value); }
        }

        public static readonly DependencyProperty ToProperty =
            DependencyProperty.Register("To", typeof(Brush), typeof(BrushAnimation));
        #endregion

        #region TargetPropertyType
        public override Type TargetPropertyType => typeof(Brush);
        #endregion

        #endregion

        #region Overrides
        public override object GetCurrentValue(object from, object to, AnimationClock clock)
        {
            return GetCurrentValue(from as Brush, to as Brush, clock);
        }

        protected override Freezable CreateInstanceCore()
        {
            return new BrushAnimation();
        }

        public object GetCurrentValue(Brush from, Brush to, AnimationClock clock)
        {
            if (!clock.CurrentProgress.HasValue)
            {
                return null;
            }

            from = From ?? from;
            to = To ?? to;

            if (clock.CurrentProgress.Value == 0)
            {
                return from;
            }
            if (clock.CurrentProgress.Value == 1)
            {
                return to;
            }

            var reverse = false;
            var opacityTo = 1.0;
            var opacityFrom = 1.0;

            if (to != null && from != null)
            {
                opacityTo = to is SolidColorBrush toBrush
                      ? (toBrush.Color.A / 255.0) * to.Opacity
                      : to.Opacity;
                opacityFrom = from is SolidColorBrush fromBrush
                      ? (fromBrush.Color.A / 255.0) * from.Opacity
                      : from.Opacity;

                if (opacityTo < 1)
                {
                    if (opacityTo < opacityFrom)
                    {
                        reverse = true;
                    }
                }
            }
            else if (to == null && from != null)
            {
                reverse = true;
            }

            var opacity = reverse ? (1 - clock.CurrentProgress.Value) : clock.CurrentProgress.Value;
            if (opacityFrom < 1 && opacityTo < 1)
            {
                if (_visualBrush == null)
                {
                    _visualBrush = CreateGridVisualBrush(reverse ? to : from, reverse ? from : to, 1 - opacity, opacity);
                }
                else
                {
                    if (_visualBrush.Visual is Grid grid && grid.Children.Count > 1)
                    {
                        if (grid.Children[0] is Rectangle rect1)
                        {
                            rect1.Opacity = 1 - opacity;
                        }
                        if (grid.Children[1] is Rectangle rect2)
                        {
                            rect2.Opacity = opacity;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            else
            {
                if (_visualBrush == null)
                {
                    _visualBrush = CreateBorderVisualBrush(reverse ? to : from, reverse ? from : to, opacity);
                }
                else
                {
                    var border = _visualBrush.Visual as Border;
                    if (!(border?.Child is Rectangle rect))
                    {
                        return null;
                    }
                    else
                    {
                        rect.Opacity = opacity;
                    }
                }
            }


            return _visualBrush;
        }

        #endregion

        #region Function
        private VisualBrush CreateBorderVisualBrush(Brush background, Brush foreground, double opacity)
        {
            var border = new Border()
            {
                Width = 1,
                Height = 1,
                Background = background,
                Child = new Rectangle()
                {
                    Fill = foreground,
                    Opacity = opacity,
                }
            };
            return new VisualBrush(border);
        }

        private VisualBrush CreateGridVisualBrush(Brush background, Brush foreground, double opacity1, double opacity2)
        {
            var grid = new Grid()
            {
                Width = 1,
                Height = 1,
            };
            grid.Children.Add(new Rectangle()
            {
                Fill = background,
                Opacity = opacity1,
            });
            grid.Children.Add(new Rectangle()
            {
                Fill = foreground,
                Opacity = opacity2,
            });
            return new VisualBrush(grid);
        }
        #endregion
    }
}
