using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    [TemplatePart(Name = ItemsControlTemplatePartName, Type = typeof(ItemsControl))]
    public class RateControl
        : Control
    {
        #region Fields
        private const string ItemsControlTemplatePartName = "PART_ItemsControl";

        private ItemsControl _itemsControl;

        private readonly List<RateGlyph> _rateGlyphs;
        #endregion

        #region Ctor
        static RateControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RateControl), new FrameworkPropertyMetadata(typeof(RateControl)));
        }

        public RateControl()
        {
            _rateGlyphs = new List<RateGlyph>() 
            {
                new RateGlyph(),
                new RateGlyph(),
                new RateGlyph(),
                new RateGlyph(),
                new RateGlyph(),
            };
        }
        #endregion

        #region Events

        #region RateChanged
        public event RoutedEventHandler RateChanged
        {
            add { AddHandler(RateChangedEvent, value); }
            remove { RemoveHandler(RateChangedEvent, value); }
        }

        public static readonly RoutedEvent RateChangedEvent =
            EventManager.RegisterRoutedEvent("RateChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Breadcrumb));
        #endregion

        #endregion

        #region Properties

        #region Rate
        /// <summary>
        /// From 0 to 5.
        /// </summary>
        public double Rate
        {
            get { return (double)GetValue(RateProperty); }
            set { SetValue(RateProperty, value); }
        }

        public static readonly DependencyProperty RateProperty =
            DependencyProperty.Register("Rate", typeof(double), typeof(RateControl), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnRateChanged));
        #endregion

        #region CanSelectHalf
        public bool CanSelectHalf
        {
            get { return (bool)GetValue(CanSelectHalfProperty); }
            set { SetValue(CanSelectHalfProperty, value); }
        }

        public static readonly DependencyProperty CanSelectHalfProperty =
            DependencyProperty.Register("CanSelectHalf", typeof(bool), typeof(RateControl));
        #endregion

        #region GlyphTemplate
        public DataTemplate GlyphTemplate
        {
            get { return (DataTemplate)GetValue(GlyphTemplateProperty); }
            set { SetValue(GlyphTemplateProperty, value); }
        }

        public static readonly DependencyProperty GlyphTemplateProperty =
            DependencyProperty.Register("GlyphTemplate", typeof(DataTemplate), typeof(RateControl));
        #endregion

        #region IsReadOnly
        public bool IsReadOnly
        {
            get { return (bool)GetValue(IsReadOnlyProperty); }
            set { SetValue(IsReadOnlyProperty, value); }
        }

        public static readonly DependencyProperty IsReadOnlyProperty =
            DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(RateControl));
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _itemsControl = GetTemplateChild(ItemsControlTemplatePartName) as ItemsControl;
            _itemsControl.MouseMove += ItemsControl_MouseMove;
            _itemsControl.MouseLeave += ItemsControl_MouseLeave;
            _itemsControl.MouseLeftButtonDown += ItemsControl_MouseLeftButtonDown;
            _itemsControl.ItemsSource = _rateGlyphs;
        }
        #endregion

        #region Event Handlers
        private static void OnRateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var rateControl = (RateControl)d;
            rateControl.OnRateChanged();
        }

        private void ItemsControl_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (IsReadOnly)
            {
                return;
            }
            var rate = CalculateRateOnCurrentPosition();
            UpdateDisplay(rate);
        }

        private void ItemsControl_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (IsReadOnly)
            {
                return;
            }
            UpdateDisplay(Rate);
        }

        private void ItemsControl_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (IsReadOnly)
            {
                return;
            }
            var rate = CalculateRateOnCurrentPosition();
            Rate = rate;
        }
        #endregion

        #region Functions
        private void OnRateChanged()
        {
            UpdateDisplay(Rate);
            RaiseEvent(new RoutedEventArgs(RateChangedEvent, this));
        }

        private double CalculateRateOnCurrentPosition()
        {
            var mousePosition = Mouse.GetPosition(_itemsControl);
            var actualWidth = _itemsControl.ActualWidth;
            var percent = mousePosition.X / actualWidth;

            var rate = percent * 5;
            var fraction = rate % 1;
            if (fraction < 0.3)
            {
                rate = Math.Floor(rate);
            }
            else if (fraction > 0.6)
            {
                rate = Math.Ceiling(rate);
            }
            else
            {
                rate = (int)rate + 0.5;
            }
            return rate;
        }

        private void UpdateDisplay(double rate)
        {
            for (int i = 0; i < 5; i++)
            {
                var singleRate = Math.Max(0, Math.Min(1, rate));

                _rateGlyphs[i].Rate = singleRate == 0
                    ? 0
                    : (singleRate == 1
                        ? 1
                        : (CanSelectHalf ? 0.5 : 1));

                rate--;
            }
        }
        #endregion
    }

    internal class RateGlyph
        : DependencyObject
    {
        #region Rate
        public double Rate
        {
            get { return (double)GetValue(RateProperty); }
            set { SetValue(RateProperty, value); }
        }

        public static readonly DependencyProperty RateProperty =
            DependencyProperty.Register("Rate", typeof(double), typeof(RateGlyph));
        #endregion
    }
}
