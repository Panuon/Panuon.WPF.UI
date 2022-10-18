using Panuon.WPF;
using Panuon.WPF.UI.Internal;
using Panuon.WPF.UI.Internal.Utils;
using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    [ContentProperty(nameof(Items))]
    public class SearchBox
        : ItemsControl
    {
        #region Fields
        private const string EditorTextBoxTemplateName = "PART_EditableTextBox";
        private const string PopupTemplateName = "PART_Popup";

        private TextBox _editorTextBox;
        private PopupX _popup;

        private DelayAction _delayAction;

        private bool _isInternalSetText;
        #endregion

        #region Ctor
        static SearchBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SearchBox), new FrameworkPropertyMetadata(typeof(SearchBox)));
        }
        #endregion

        #region Properties

        #region Icon
        public object Icon
        {
            get { return (object)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(object), typeof(SearchBox));
        #endregion

        #region Watermark
        public object Watermark
        {
            get { return (object)GetValue(WatermarkProperty); }
            set { SetValue(WatermarkProperty, value); }
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.Register("Watermark", typeof(object), typeof(SearchBox));
        #endregion

        #region WatermarkForeground
        public Brush WatermarkForeground
        {
            get { return (Brush)GetValue(WatermarkForegroundProperty); }
            set { SetValue(WatermarkForegroundProperty, value); }
        }

        public static readonly DependencyProperty WatermarkForegroundProperty =
            VisualStateHelper.WatermarkForegroundProperty.AddOwner(typeof(SearchBox));
        #endregion

        #region ShadowColor
        public Color? ShadowColor
        {
            get { return (Color?)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.Register("ShadowColor", typeof(Color?), typeof(SearchBox));
        #endregion

        #region CornerRadius
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(SearchBox));
        #endregion

        #region IsDropDownOpen
        public bool IsDropDownOpen
        {
            get { return (bool)GetValue(IsDropDownOpenProperty); }
            set { SetValue(IsDropDownOpenProperty, value); }
        }

        public static readonly DependencyProperty IsDropDownOpenProperty =
            DependencyProperty.Register("IsDropDownOpen", typeof(bool), typeof(SearchBox));
        #endregion

        #region Text
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(SearchBox));
        #endregion

        #region MaxDropDownHeight
        public double MaxDropDownHeight
        {
            get { return (double)GetValue(MaxDropDownHeightProperty); }
            set { SetValue(MaxDropDownHeightProperty, value); }
        }

        public static readonly DependencyProperty MaxDropDownHeightProperty =
            DependencyProperty.Register("MaxDropDownHeight", typeof(double), typeof(SearchBox), new PropertyMetadata(150d));
        #endregion

        #region SearchDelay
        public int SearchDelay
        {
            get { return (int)GetValue(SearchDelayProperty); }
            set { SetValue(SearchDelayProperty, value); }
        }

        public static readonly DependencyProperty SearchDelayProperty =
            DependencyProperty.Register("SearchDelay", typeof(int), typeof(SearchBox), new PropertyMetadata(200, OnSearchDelayChanged));
        #endregion

        #region HoverBackground
        public Brush HoverBackground
        {
            get { return (Brush)GetValue(HoverBackgroundProperty); }
            set { SetValue(HoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            VisualStateHelper.HoverBackgroundProperty.AddOwner(typeof(SearchBox));
        #endregion

        #region HoverForeground
        public Brush HoverForeground
        {
            get { return (Brush)GetValue(HoverForegroundProperty); }
            set { SetValue(HoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            VisualStateHelper.HoverForegroundProperty.AddOwner(typeof(SearchBox));
        #endregion

        #region HoverBorderBrush
        public Brush HoverBorderBrush
        {
            get { return (Brush)GetValue(HoverBorderBrushProperty); }
            set { SetValue(HoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty HoverBorderBrushProperty =
            VisualStateHelper.HoverBorderBrushProperty.AddOwner(typeof(SearchBox));
        #endregion

        #region HoverShadowColor
        public Color? HoverShadowColor
        {
            get { return (Color?)GetValue(HoverShadowColorProperty); }
            set { SetValue(HoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty HoverShadowColorProperty =
            VisualStateHelper.HoverShadowColorProperty.AddOwner(typeof(SearchBox));
        #endregion

        #region FocusedBackground
        public Brush FocusedBackground
        {
            get { return (Brush)GetValue(FocusedBackgroundProperty); }
            set { SetValue(FocusedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedBackgroundProperty =
            VisualStateHelper.FocusedBackgroundProperty.AddOwner(typeof(SearchBox));
        #endregion

        #region FocusedForeground
        public Brush FocusedForeground
        {
            get { return (Brush)GetValue(FocusedForegroundProperty); }
            set { SetValue(FocusedForegroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedForegroundProperty =
            VisualStateHelper.FocusedForegroundProperty.AddOwner(typeof(SearchBox));
        #endregion

        #region FocusedBorderBrush
        public Brush FocusedBorderBrush
        {
            get { return (Brush)GetValue(FocusedBorderBrushProperty); }
            set { SetValue(FocusedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty FocusedBorderBrushProperty =
            VisualStateHelper.FocusedBorderBrushProperty.AddOwner(typeof(SearchBox));
        #endregion

        #region FocusedShadowColor
        public Color? FocusedShadowColor
        {
            get { return (Color?)GetValue(FocusedShadowColorProperty); }
            set { SetValue(FocusedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty FocusedShadowColorProperty =
            VisualStateHelper.FocusedShadowColorProperty.AddOwner(typeof(SearchBox));
        #endregion

        #region FocusedWatermarkForeground
        public Brush FocusedWatermarkForeground
        {
            get { return (Brush)GetValue(FocusedWatermarkForegroundProperty); }
            set { SetValue(FocusedWatermarkForegroundProperty, value); }
        }

        public static readonly DependencyProperty FocusedWatermarkForegroundProperty =
            VisualStateHelper.FocusedWatermarkForegroundProperty.AddOwner(typeof(SearchBox));
        #endregion

        #region ClearTextOnClick
        public bool ClearTextOnClick
        {
            get { return (bool)GetValue(ClearTextOnClickProperty); }
            set { SetValue(ClearTextOnClickProperty, value); }
        }

        public static readonly DependencyProperty ClearTextOnClickProperty =
            DependencyProperty.Register("ClearTextOnClick", typeof(bool), typeof(SearchBox), new PropertyMetadata(false));
        #endregion

        #region ClearButtonStyle
        public Style ClearButtonStyle
        {
            get { return (Style)GetValue(ClearButtonStyleProperty); }
            set { SetValue(ClearButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty ClearButtonStyleProperty =
            DependencyProperty.Register("ClearButtonStyle", typeof(Style), typeof(SearchBox));
        #endregion

        #region ClearButtonVisibility
        public AuxiliaryButtonVisibility ClearButtonVisibility
        {
            get { return (AuxiliaryButtonVisibility)GetValue(ClearButtonVisibilityProperty); }
            set { SetValue(ClearButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ClearButtonVisibilityProperty =
            DependencyProperty.Register("ClearButtonVisibility", typeof(AuxiliaryButtonVisibility), typeof(SearchBox));
        #endregion

        #region ClearCommand
        internal ICommand ClearCommand
        {
            get { return (ICommand)GetValue(ClearCommandProperty); }
        }

        internal static readonly DependencyPropertyKey ClearCommandPropertyKey =
            DependencyProperty.RegisterReadOnly("ClearCommand", typeof(ICommand), typeof(SearchBox), new PropertyMetadata(new RelayCommand<SearchBox>(OnClearCommandExecute)));

        public static readonly DependencyProperty ClearCommandProperty =
            ClearCommandPropertyKey.DependencyProperty;
        #endregion

        #region Items Properties

        #region ItemsIcon
        public object ItemsIcon
        {
            get { return (object)GetValue(ItemsIconProperty); }
            set { SetValue(ItemsIconProperty, value); }
        }

        public static readonly DependencyProperty ItemsIconProperty =
            DependencyProperty.Register("ItemsIcon", typeof(object), typeof(SearchBox));
        #endregion

        #region ItemsHeight
        public double ItemsHeight
        {
            get { return (double)GetValue(ItemsHeightProperty); }
            set { SetValue(ItemsHeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.Register("ItemsHeight", typeof(double), typeof(SearchBox), new PropertyMetadata(30d));
        #endregion

        #region ItemsCornerRadius
        public CornerRadius ItemsCornerRadius
        {
            get { return (CornerRadius)GetValue(ItemsCornerRadiusProperty); }
            set { SetValue(ItemsCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.Register("ItemsCornerRadius", typeof(CornerRadius), typeof(SearchBox));
        #endregion

        #region ItemsShadowColor
        public Color? ItemsShadowColor
        {
            get { return (Color?)GetValue(ItemsShadowColorProperty); }
            set { SetValue(ItemsShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsShadowColorProperty =
            DependencyProperty.Register("ItemsShadowColor", typeof(Color?), typeof(SearchBox));
        #endregion

        #region ItemsMargin
        public Thickness ItemsMargin
        {
            get { return (Thickness)GetValue(ItemsMarginProperty); }
            set { SetValue(ItemsMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.Register("ItemsMargin", typeof(Thickness), typeof(SearchBox));
        #endregion

        #region ItemsPadding
        public Thickness ItemsPadding
        {
            get { return (Thickness)GetValue(ItemsPaddingProperty); }
            set { SetValue(ItemsPaddingProperty, value); }
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.Register("ItemsPadding", typeof(Thickness), typeof(SearchBox));
        #endregion

        #region ItemsForeground
        public Brush ItemsForeground
        {
            get { return (Brush)GetValue(ItemsForegroundProperty); }
            set { SetValue(ItemsForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsForegroundProperty =
            DependencyProperty.Register("ItemsForeground", typeof(Brush), typeof(SearchBox));
        #endregion

        #region ItemsBackground
        public Brush ItemsBackground
        {
            get { return (Brush)GetValue(ItemsBackgroundProperty); }
            set { SetValue(ItemsBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.Register("ItemsBackground", typeof(Brush), typeof(SearchBox), new PropertyMetadata(Brushes.Transparent));
        #endregion

        #region ItemsBorderBrush
        public Brush ItemsBorderBrush
        {
            get { return (Brush)GetValue(ItemsBorderBrushProperty); }
            set { SetValue(ItemsBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.Register("ItemsBorderBrush", typeof(Brush), typeof(SearchBox));
        #endregion

        #region ItemsBorderThickness
        public Thickness ItemsBorderThickness
        {
            get { return (Thickness)GetValue(ItemsBorderThicknessProperty); }
            set { SetValue(ItemsBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.Register("ItemsBorderThickness", typeof(Thickness), typeof(SearchBox));
        #endregion

        #region ItemsHoverBackground
        public Brush ItemsHoverBackground
        {
            get { return (Brush)GetValue(ItemsHoverBackgroundProperty); }
            set { SetValue(ItemsHoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.Register("ItemsHoverBackground", typeof(Brush), typeof(SearchBox));
        #endregion

        #region ItemsHoverForeground
        public Brush ItemsHoverForeground
        {
            get { return (Brush)GetValue(ItemsHoverForegroundProperty); }
            set { SetValue(ItemsHoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.Register("ItemsHoverForeground", typeof(Brush), typeof(SearchBox));
        #endregion

        #region ItemsHoverBorderBrush
        public Brush ItemsHoverBorderBrush
        {
            get { return (Brush)GetValue(ItemsHoverBorderBrushProperty); }
            set { SetValue(ItemsHoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.Register("ItemsHoverBorderBrush", typeof(Brush), typeof(SearchBox));
        #endregion

        #region ItemsHoverShadowColor
        public Color? ItemsHoverShadowColor
        {
            get { return (Color?)GetValue(ItemsHoverShadowColorProperty); }
            set { SetValue(ItemsHoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverShadowColorProperty =
            DependencyProperty.Register("ItemsHoverShadowColor", typeof(Color?), typeof(SearchBox));
        #endregion

        #region ItemsClickBackground
        public Brush ItemsClickBackground
        {
            get { return (Brush)GetValue(ItemsClickBackgroundProperty); }
            set { SetValue(ItemsClickBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsClickBackgroundProperty =
            DependencyProperty.Register("ItemsClickBackground", typeof(Brush), typeof(SearchBox));
        #endregion

        #region ItemsClickForeground
        public Brush ItemsClickForeground
        {
            get { return (Brush)GetValue(ItemsClickForegroundProperty); }
            set { SetValue(ItemsClickForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsClickForegroundProperty =
            DependencyProperty.Register("ItemsClickForeground", typeof(Brush), typeof(SearchBox));
        #endregion

        #region ItemsClickBorderBrush
        public Brush ItemsClickBorderBrush
        {
            get { return (Brush)GetValue(ItemsClickBorderBrushProperty); }
            set { SetValue(ItemsClickBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsClickBorderBrushProperty =
            DependencyProperty.Register("ItemsClickBorderBrush", typeof(Brush), typeof(SearchBox));
        #endregion

        #region ItemsClickBorderThickness
        public Thickness? ItemsClickBorderThickness
        {
            get { return (Thickness?)GetValue(ItemsClickBorderThicknessProperty); }
            set { SetValue(ItemsClickBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsClickBorderThicknessProperty =
            DependencyProperty.Register("ItemsClickBorderThickness", typeof(Thickness?), typeof(SearchBox));
        #endregion

        #region ItemsClickEffect
        public ClickEffect ItemsClickEffect
        {
            get { return (ClickEffect)GetValue(ItemsClickEffectProperty); }
            set { SetValue(ItemsClickEffectProperty, value); }
        }

        public static readonly DependencyProperty ItemsClickEffectProperty =
            DependencyProperty.Register("ItemsClickEffect", typeof(ClickEffect), typeof(SearchBox));
        #endregion

        #region ItemsSeparatorBrush
        public Brush ItemsSeparatorBrush
        {
            get { return (Brush)GetValue(ItemsSeparatorBrushProperty); }
            set { SetValue(ItemsSeparatorBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorBrushProperty =
            DependencyProperty.Register("ItemsSeparatorBrush", typeof(Brush), typeof(SearchBox));
        #endregion

        #region ItemsSeparatorThickness
        public double ItemsSeparatorThickness
        {
            get { return (double)GetValue(ItemsSeparatorThicknessProperty); }
            set { SetValue(ItemsSeparatorThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorThicknessProperty =
            DependencyProperty.Register("ItemsSeparatorThickness", typeof(double), typeof(SearchBox));
        #endregion

        #region ItemsSeparatorMargin
        public Thickness ItemsSeparatorMargin
        {
            get { return (Thickness)GetValue(ItemsSeparatorMarginProperty); }
            set { SetValue(ItemsSeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorMarginProperty =
            DependencyProperty.Register("ItemsSeparatorMargin", typeof(Thickness), typeof(SearchBox));
        #endregion

        #region ItemsSeparatorVisibility
        public Visibility ItemsSeparatorVisibility
        {
            get { return (Visibility)GetValue(ItemsSeparatorVisibilityProperty); }
            set { SetValue(ItemsSeparatorVisibilityProperty, value); }
        }

        public static readonly DependencyProperty ItemsSeparatorVisibilityProperty =
            DependencyProperty.Register("ItemsSeparatorVisibility", typeof(Visibility), typeof(SearchBox));
        #endregion

        #region ItemsHorizontalContentAlignment
        public HorizontalAlignment ItemsHorizontalContentAlignment
        {
            get { return (HorizontalAlignment)GetValue(ItemsHorizontalContentAlignmentProperty); }
            set { SetValue(ItemsHorizontalContentAlignmentProperty, value); }
        }

        public static readonly DependencyProperty ItemsHorizontalContentAlignmentProperty =
            DependencyProperty.Register("ItemsHorizontalContentAlignment", typeof(HorizontalAlignment), typeof(SearchBox));
        #endregion

        #region ItemsVerticalContentAlignment
        public VerticalAlignment ItemsVerticalContentAlignment
        {
            get { return (VerticalAlignment)GetValue(ItemsVerticalContentAlignmentProperty); }
            set { SetValue(ItemsVerticalContentAlignmentProperty, value); }
        }

        public static readonly DependencyProperty ItemsVerticalContentAlignmentProperty =
            DependencyProperty.Register("ItemsVerticalContentAlignment", typeof(VerticalAlignment), typeof(SearchBox));
        #endregion

        #endregion

        #endregion

        #region Events

        #region Open and Close
        public event EventHandler Closed;

        public event EventHandler Opened;
        #endregion

        #region SearchTextChanged
        public event SearchTextChangedRoutedEventHandler SearchTextChanged
        {
            add { AddHandler(SearchTextChangedEvent, value); }
            remove { RemoveHandler(SearchTextChangedEvent, value); }
        }

        public static readonly RoutedEvent SearchTextChangedEvent =
            EventManager.RegisterRoutedEvent("SearchTextChanged", RoutingStrategy.Bubble, typeof(SearchTextChangedRoutedEventHandler), typeof(SearchBox));
        #endregion

        #region ItemClick
        public event RoutedEventHandler ItemClick
        {
            add { AddHandler(ItemClickEvent, value); }
            remove { RemoveHandler(ItemClickEvent, value); }
        }

        public static readonly RoutedEvent ItemClickEvent =
            EventManager.RegisterRoutedEvent("ItemClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SearchBox));
        #endregion        

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _editorTextBox = GetTemplateChild(EditorTextBoxTemplateName) as TextBox;

            _editorTextBox.PreviewMouseDown += EditorTextBox_PreviewMouseDown;
            _editorTextBox.LostKeyboardFocus += EditorTextBox_LostKeyboardFocus;
            _editorTextBox.TextChanged += EditorTextBox_TextChanged;

            _popup = GetTemplateChild(PopupTemplateName) as PopupX;
            _popup.PreviewMouseLeftButtonDown += Popup_MouseLeftButtonDown;
            _popup.Opened += Popup_Opened;
            _popup.Closed += Popup_Closed;

            var parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.MouseDown += ParentWindow_MouseDown;
            }
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is SearchBoxItem;
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new SearchBoxItem();
        }

        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            var searchItem = element as SearchBoxItem;
            if (LogicalTreeHelper.GetParent(searchItem) == null)
            {
                AddLogicalChild(searchItem);
            }
            base.PrepareContainerForItemOverride(element, item);
        }

        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            if(e.Key != Key.Up
                && e.Key != Key.Down
                && e.Key != Key.Enter)
            {
                return;
            }

            e.Handled = true;

            var currentIndex = -1;
            SearchBoxItem currentItem = null;

            for (int i = 0; i < Items.Count; i++)
            {
                var currentContainer = ItemContainerGenerator.ContainerFromIndex(i) as SearchBoxItem;
                if (currentContainer != null
                    && (currentContainer.IsKeyboardHover || currentContainer.IsMouseOver))
                {
                    currentItem = currentContainer;
                    currentIndex = i;
                    break;
                }
            }

            switch (e.Key)
            {
                case Key.Up:
                    if(currentIndex == -1)
                    {
                        currentIndex = Items.Count - 1;
                    }
                    else
                    {
                        currentIndex--;
                    }
                    break;
                case Key.Down:
                    currentIndex++;
                    break;
                case Key.Enter:
                    OnItemClicked(currentItem);
                    return;
            }

            System.Diagnostics.Debug.WriteLine(currentIndex);
            
            if (currentIndex >= 0
                && currentIndex < Items.Count)
            {
                var currentContainer = ItemContainerGenerator.ContainerFromIndex(currentIndex) as SearchBoxItem;
                if (currentContainer != null)
                {
                    currentContainer.SetCurrentValue(SearchBoxItem.IsKeyboardHoverProperty, true);
                }
            }

        }
        #endregion

        #region Event Handlers
        private static void OnSearchDelayChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var searchBox = (SearchBox)d;
            searchBox.OnSearchDelayChanged();
        }

        private void EditorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_isInternalSetText)
            {
                return;
            }

            if (_delayAction == null)
            {
                OnSearch();
            }
            else
            {
                _delayAction.StartOrRefresh();
            }

            SetCurrentValue(IsDropDownOpenProperty, true);
        }

        private void Popup_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var elemenet = e.Source as FrameworkElement;
            while (elemenet != null)
            {
                if (elemenet == _popup
                    || elemenet == _editorTextBox
                    || elemenet == this)
                {
                    return;
                }
                elemenet = LogicalTreeHelper.GetParent(elemenet) as FrameworkElement;
            }
            e.Handled = true;
        }

        private void ParentWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
            SetCurrentValue(IsDropDownOpenProperty, false);
        }

        private void EditorTextBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            SetCurrentValue(IsDropDownOpenProperty, false);
        }

        private void EditorTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            SetCurrentValue(IsDropDownOpenProperty, true);
            _editorTextBox.Focus();
            e.Handled = true;
        }

        private void Popup_Closed(object sender, EventArgs e)
        {
            Closed?.Invoke(this, EventArgs.Empty);
        }

        private void Popup_Opened(object sender, EventArgs e)
        {
            Opened?.Invoke(this, EventArgs.Empty);
        }

        private static void OnClearCommandExecute(SearchBox searchTextBox)
        {
            searchTextBox.SetCurrentValue(TextProperty, null);
        }
        #endregion

        #region Internal Methods
        internal void OnItemClicked(SearchBoxItem item)
        {
            if (item == null)
            {
                return;
            }

            var selectedValue = item.DataContext;

            _isInternalSetText = true;

            _editorTextBox.Text = ClearTextOnClick
                ? null
                : item.Content?.ToString();
            _editorTextBox.CaretIndex = string.IsNullOrEmpty(_editorTextBox.Text)
                ? 0
                : _editorTextBox.Text.Length;

            _isInternalSetText = false;

            SetCurrentValue(IsDropDownOpenProperty, false);

            RaiseEvent(new RoutedEventArgs(ItemClickEvent, item));
        }

        internal void OnItemHoverChanged(SearchBoxItem item)
        {
            if (item == null)
            {
                return;
            }

            for (int i = 0; i < Items.Count; i++)
            {
                var currentContainer = ItemContainerGenerator.ContainerFromIndex(i) as SearchBoxItem;
                if (currentContainer != null
                    && currentContainer != item
                    && currentContainer.IsKeyboardHover)
                {
                    currentContainer.SetCurrentValue(SearchBoxItem.IsKeyboardHoverProperty, false);
                }
            }
        }
        #endregion

        #region Functions
        private void OnSearchDelayChanged()
        {
            if (_delayAction != null)
            {
                _delayAction.Cancel();
            }

            if (SearchDelay == 0)
            {
                _delayAction = null;
            }
            else
            {
                _delayAction = new DelayAction(SearchDelay, OnSearch);
            }
        }

        private void OnSearch()
        {
            Dispatcher.Invoke(() =>
            {
                RaiseEvent(new SearchTextChangedRoutedEventArgs(SearchTextChangedEvent, _editorTextBox.Text));
            });
        }
        #endregion
    }
}