using Panuon.UI.Silver.Internal;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    [TemplatePart(Name = HeaderContentControlTemplateName, Type = typeof(ContentControl))]
    public class FormGroup : HeaderedContentControl
    {
        #region Fields
        private ContentControl _headerControl;

        private const string HeaderContentControlTemplateName = "PART_HeaderControl";
        #endregion

        #region Ctor
        static FormGroup()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FormGroup), new FrameworkPropertyMetadata(typeof(FormGroup)));
        }

        public FormGroup()
        {
            CollectSize += FormGroup_CollectSize;
            SizeDetemined += FormGroup_SizeDetemined;
        }
        #endregion

        #region Internal Events
        internal static event FormGroupCollectSizeEventHandler CollectSize;

        internal static event FormGroupSizeDeterminedEventHandler SizeDetemined;
        #endregion

        #region Properties

        #region Orientation
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(FormGroup), new PropertyMetadata(Orientation.Horizontal));
        #endregion

        #region IsPending
        public bool IsPending
        {
            get { return (bool)GetValue(IsPendingProperty); }
            set { SetValue(IsPendingProperty, value); }
        }

        public static readonly DependencyProperty IsPendingProperty =
            DependencyProperty.Register("IsPending", typeof(bool), typeof(FormGroup));
        #endregion

        #region PendingSpinnerStyle
        public Style PendingSpinnerStyle
        {
            get { return (Style)GetValue(PendingSpinnerStyleProperty); }
            set { SetValue(PendingSpinnerStyleProperty, value); }
        }

        public static readonly DependencyProperty PendingSpinnerStyleProperty =
            DependencyProperty.Register("PendingSpinnerStyle", typeof(Style), typeof(FormGroup));
        #endregion

        #region HeaderWidth
        public GridLength HeaderWidth
        {
            get { return (GridLength)GetValue(HeaderWidthProperty); }
            set { SetValue(HeaderWidthProperty, value); }
        }

        public static readonly DependencyProperty HeaderWidthProperty =
            DependencyProperty.Register("HeaderWidth", typeof(GridLength), typeof(FormGroup), new PropertyMetadata(new GridLength(1, GridUnitType.Auto), OnHeaderWidthOrHeightChanged));

        #endregion

        #region HeaderHeight
        public GridLength HeaderHeight
        {
            get { return (GridLength)GetValue(HeaderHeightProperty); }
            set { SetValue(HeaderHeightProperty, value); }
        }

        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.Register("HeaderHeight", typeof(GridLength), typeof(FormGroup), new PropertyMetadata(new GridLength(1, GridUnitType.Auto), OnHeaderWidthOrHeightChanged));
        #endregion

        #region HeaderForeground
        public Brush HeaderForeground
        {
            get { return (Brush)GetValue(HeaderForegroundProperty); }
            set { SetValue(HeaderForegroundProperty, value); }
        }

        public static readonly DependencyProperty HeaderForegroundProperty =
            DependencyProperty.Register("HeaderForeground", typeof(Brush), typeof(FormGroup));
        #endregion

        #region HeaderPadding
        public Thickness HeaderPadding
        {
            get { return (Thickness)GetValue(HeaderPaddingProperty); }
            set { SetValue(HeaderPaddingProperty, value); }
        }

        public static readonly DependencyProperty HeaderPaddingProperty =
            DependencyProperty.Register("HeaderPadding", typeof(Thickness), typeof(FormGroup));
        #endregion

        #region MessageHeight
        public double MessageHeight
        {
            get { return (double)GetValue(MessageHeightProperty); }
            set { SetValue(MessageHeightProperty, value); }
        }

        public static readonly DependencyProperty MessageHeightProperty =
            DependencyProperty.Register("MessageHeight", typeof(double), typeof(FormGroup), new PropertyMetadata(double.NaN));
        #endregion

        #region MinMessageHeight
        public double MinMessageHeight
        {
            get { return (double)GetValue(MinMessageHeightProperty); }
            set { SetValue(MinMessageHeightProperty, value); }
        }

        public static readonly DependencyProperty MinMessageHeightProperty =
            DependencyProperty.Register("MinMessageHeight", typeof(double), typeof(FormGroup), new PropertyMetadata(0d));
        #endregion

        #region MaxMessageHeight
        public double MaxMessageHeight
        {
            get { return (double)GetValue(MaxMessageHeightProperty); }
            set { SetValue(MaxMessageHeightProperty, value); }
        }

        public static readonly DependencyProperty MaxMessageHeightProperty =
            DependencyProperty.Register("MaxMessageHeight", typeof(double), typeof(FormGroup), new PropertyMetadata(double.PositiveInfinity));
        #endregion

        #region MessagePadding
        public Thickness MessagePadding
        {
            get { return (Thickness)GetValue(MessagePaddingProperty); }
            set { SetValue(MessagePaddingProperty, value); }
        }

        public static readonly DependencyProperty MessagePaddingProperty =
            DependencyProperty.Register("MessagePadding", typeof(Thickness), typeof(FormGroup));
        #endregion

        #region ValidateResult
        public ValidateResult ValidateResult
        {
            get { return (ValidateResult)GetValue(ValidateResultProperty); }
            set { SetValue(ValidateResultProperty, value); }
        }

        public static readonly DependencyProperty ValidateResultProperty =
            DependencyProperty.Register("ValidateResult", typeof(ValidateResult), typeof(FormGroup));
        #endregion

        #region Message
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(FormGroup));
        #endregion

        #region MessageTemplate
        public DataTemplate MessageTemplate
        {
            get { return (DataTemplate)GetValue(MessageTemplateProperty); }
            set { SetValue(MessageTemplateProperty, value); }
        }

        public static readonly DependencyProperty MessageTemplateProperty =
            DependencyProperty.Register("MessageTemplate", typeof(DataTemplate), typeof(FormGroup));
        #endregion

        #region HorizontalHeaderAlignment
        public HorizontalAlignment HorizontalHeaderAlignment
        {
            get { return (HorizontalAlignment)GetValue(HorizontalHeaderAlignmentProperty); }
            set { SetValue(HorizontalHeaderAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HorizontalHeaderAlignmentProperty =
            DependencyProperty.Register("HorizontalHeaderAlignment", typeof(HorizontalAlignment), typeof(FormGroup), new PropertyMetadata(HorizontalAlignment.Stretch));
        #endregion

        #region VerticalHeaderAlignment
        public VerticalAlignment VerticalHeaderAlignment
        {
            get { return (VerticalAlignment)GetValue(VerticalHeaderAlignmentProperty); }
            set { SetValue(VerticalHeaderAlignmentProperty, value); }
        }

        public static readonly DependencyProperty VerticalHeaderAlignmentProperty =
            DependencyProperty.Register("VerticalHeaderAlignment", typeof(VerticalAlignment), typeof(FormGroup), new PropertyMetadata(VerticalAlignment.Center));
        #endregion

        #region GroupName
        public string GroupName
        {
            get { return (string)GetValue(GroupNameProperty); }
            set { SetValue(GroupNameProperty, value); }
        }

        public static readonly DependencyProperty GroupNameProperty =
            DependencyProperty.Register("GroupName", typeof(string), typeof(FormGroup), new PropertyMetadata(OnGroupNameChanged));
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {


            _headerControl = GetTemplateChild(HeaderContentControlTemplateName) as ContentControl;
            _headerControl.SizeChanged += HeaderControl_SizeChanged;
        }

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            base.OnRenderSizeChanged(sizeInfo);
        }
        #endregion

        #region Internal Properties

        #region InternalHeaderWidth
        internal double InternalHeaderWidth
        {
            get { return (double)GetValue(InternalHeaderWidthProperty); }
            set { SetValue(InternalHeaderWidthProperty, value); }
        }

        internal static readonly DependencyProperty InternalHeaderWidthProperty =
            DependencyProperty.Register("InternalHeaderWidth", typeof(double), typeof(FormGroup), new PropertyMetadata(double.NaN));
        #endregion

        #region InternalHeaderHeight
        internal double InternalHeaderHeight
        {
            get { return (double)GetValue(InternalHeaderHeightProperty); }
            set { SetValue(InternalHeaderHeightProperty, value); }
        }

        internal static readonly DependencyProperty InternalHeaderHeightProperty =
            DependencyProperty.Register("InternalHeaderHeight", typeof(double), typeof(FormGroup), new PropertyMetadata(double.NaN));
        #endregion

        #endregion

        #region Event Handlers
        private void FormGroup_SizeDetemined(object sender, FormGroupSizeDeterminedEventArgs e)
        {
            if (_headerControl != null)
            {
                if (sender is FormGroup formGroup && formGroup != this && GroupName == formGroup.GroupName && Window.GetWindow(formGroup) == Window.GetWindow(this))
                {
                    if (e.Orientation == Orientation.Horizontal)
                    {
                        InternalHeaderWidth = e.Size;
                    }
                    else
                    {
                        InternalHeaderHeight = e.Size;
                    }
                }
            }
        }

        private void FormGroup_CollectSize(object sender, FormGroupCollectSizeEventArgs e)
        {
            if (_headerControl != null)
            {
                if (sender is FormGroup formGroup && formGroup != this && GroupName == formGroup.GroupName && Window.GetWindow(formGroup) == Window.GetWindow(this))
                {
                    if (e.Orientation == Orientation.Horizontal)
                    {
                        var width = GetComputedWidth(false);
                        e.Maximuim = Math.Max(e.Maximuim, width);
                    }
                    else
                    {
                        var height = GetComputedHeight(false);
                        e.Maximuim = Math.Max(e.Maximuim, height);
                    }
                }
            }
        }

        private void HeaderControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            DeteminingSize();
        }

        private static void OnHeaderWidthOrHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var formGroup = (FormGroup)d;
            formGroup.DeteminingSize();
        }

        private static void OnGroupNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var formGroup = (FormGroup)d;
            formGroup.DeteminingSize();
        }
        #endregion

        #region Functions
        private void DeteminingSize()
        {
            if (_headerControl == null)
            {
                return;
            }
            var size = 0d;
            if (Orientation == Orientation.Horizontal)
            {
                size = GetComputedWidth(false);
                var internalHeight = GetComputedHeight(true);
                if (double.IsNaN(internalHeight))
                {
                    FrameworkElementUtil.BindingProperty(this, InternalHeaderHeightProperty, this, ActualHeightProperty);
                }
                else
                {
                    InternalHeaderHeight = internalHeight;
                }
            }
            else
            {
                size = GetComputedHeight(false);
                var internalWidth = GetComputedWidth(true);
                if (double.IsNaN(internalWidth))
                {
                    FrameworkElementUtil.BindingProperty(this, InternalHeaderWidthProperty, this, ActualWidthProperty);
                }
                else
                {
                    InternalHeaderWidth = internalWidth;
                }
            }
            var collectSizeEventArgs = new FormGroupCollectSizeEventArgs(Orientation, size);
            if (!string.IsNullOrEmpty(GroupName))
            {
                CollectSize?.Invoke(this, collectSizeEventArgs);
            }
            if (Orientation == Orientation.Horizontal)
            {
                if (collectSizeEventArgs.Maximuim == InternalHeaderWidth)
                {
                    return;
                }
                InternalHeaderWidth = collectSizeEventArgs.Maximuim;
            }
            else
            {
                if (collectSizeEventArgs.Maximuim == InternalHeaderHeight)
                {
                    return;
                }
                InternalHeaderHeight = collectSizeEventArgs.Maximuim;
            }
            if (!string.IsNullOrEmpty(GroupName))
            {
                var sizeDeteminedEventArgs = new FormGroupSizeDeterminedEventArgs(Orientation, collectSizeEventArgs.Maximuim);
                SizeDetemined?.Invoke(this, sizeDeteminedEventArgs);
            }
        }

        private double GetComputedWidth(bool allowNaN)
        {
            var size = GridLengthUtil.ComputeValue(RenderSize.Width, HeaderWidth);
            if (double.IsNaN(size) && !allowNaN)
            {
                _headerControl.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
                return _headerControl.DesiredSize.Width;
            }
            return size;
        }

        private double GetComputedHeight(bool allowNaN)
        {
            var size = GridLengthUtil.ComputeValue(RenderSize.Height, HeaderHeight);
            if (double.IsNaN(size) && !allowNaN)
            {
                _headerControl.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
                return _headerControl.DesiredSize.Height;
            }
            return size;
        }
        #endregion
    }
}
