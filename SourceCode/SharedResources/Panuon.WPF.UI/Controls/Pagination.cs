using Panuon.WPF;
using Panuon.WPF.UI.Internal;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Panuon.WPF.UI
{
    public class Pagination 
        : Control
    {
        #region Fields
        private object _pageListLock = new object();
        #endregion

        #region Ctor
        static Pagination()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Pagination), new FrameworkPropertyMetadata(typeof(Pagination)));

            CommandManager.RegisterClassCommandBinding(typeof(Pagination), new CommandBinding(PageUpCommand, OnPageUpExecuted, OnCanPageUpExecuted));
            CommandManager.RegisterClassInputBinding(typeof(Pagination), new InputBinding(PageUpCommand, new KeyGesture(Key.Left)));

            CommandManager.RegisterClassCommandBinding(typeof(Pagination), new CommandBinding(PageDownCommand, OnPageDownExecuted, OnCanPageDownExecuted));
            CommandManager.RegisterClassInputBinding(typeof(Pagination), new InputBinding(PageDownCommand, new KeyGesture(Key.Right)));
        }

        public Pagination()
        {
            AddHandler(PaginationItem.ClickEvent, new RoutedEventHandler(OnPaginationItemClick));
        }
        #endregion

        #region Commands
        public static readonly RoutedCommand PageUpCommand = new RoutedCommand("PageUp", typeof(Pagination));

        public static readonly RoutedCommand PageDownCommand = new RoutedCommand("PageDown", typeof(Pagination));
        #endregion

        #region Events

        #region CurrentPageChanged
        public event SelectedValueChangedRoutedEventHandler<int> CurrentPageChanged
        {
            add { AddHandler(CurrentPageChangedEvent, value); }
            remove { RemoveHandler(CurrentPageChangedEvent, value); }
        }

        public static readonly RoutedEvent CurrentPageChangedEvent =
            EventManager.RegisterRoutedEvent("CurrentPageChanged", RoutingStrategy.Bubble, typeof(SelectedValueChangedRoutedEventHandler<int>), typeof(Pagination));
        #endregion

        #endregion

        #region ComponentResourceKeys
        public static ComponentResourceKey PageTurnButtonStyleKey { get; } =
            new ComponentResourceKey(typeof(Pagination), nameof(PageTurnButtonStyleKey));

        public static ComponentResourceKey OmittingTextBlockStyleKey { get; } =
          new ComponentResourceKey(typeof(Pagination), nameof(OmittingTextBlockStyleKey));
        #endregion

        #region Properties

        #region Orientation
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(Pagination));
        #endregion

        #region MinPage
        public int MinPage
        {
            get { return (int)GetValue(MinPageProperty); }
            set { SetValue(MinPageProperty, value); }
        }

        public static readonly DependencyProperty MinPageProperty =
            DependencyProperty.Register("MinPage", typeof(int), typeof(Pagination), new PropertyMetadata(1, OnEffectivePageValueChanged));

        #endregion

        #region MaxPage
        public int MaxPage
        {
            get { return (int)GetValue(MaxPageProperty); }
            set { SetValue(MaxPageProperty, value); }
        }

        public static readonly DependencyProperty MaxPageProperty =
            DependencyProperty.Register("MaxPage", typeof(int), typeof(Pagination), new PropertyMetadata(1, OnEffectivePageValueChanged));
        #endregion

        #region CurrentPage
        public int CurrentPage
        {
            get { return (int)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register("CurrentPage", typeof(int), typeof(Pagination), new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnCurrentPageChanged, OnCurrentPageCoerceValue));
        #endregion

        #region ItemContainerStyle
        public Style ItemContainerStyle
        {
            get { return (Style)GetValue(ItemContainerStyleProperty); }
            set { SetValue(ItemContainerStyleProperty, value); }
        }

        public static readonly DependencyProperty ItemContainerStyleProperty =
            DependencyProperty.RegisterAttached("ItemContainerStyle", typeof(Style), typeof(Pagination));
        #endregion

        #region PageTurnButtonVisibility
        public Visibility PageTurnButtonVisibility
        {
            get { return (Visibility)GetValue(PageTurnButtonVisibilityProperty); }
            set { SetValue(PageTurnButtonVisibilityProperty, value); }
        }

        public static readonly DependencyProperty PageTurnButtonVisibilityProperty =
            DependencyProperty.Register("PageTurnButtonVisibility", typeof(Visibility), typeof(Pagination), new PropertyMetadata(Visibility.Visible));
        #endregion

        #region PageTurnButtonStyle
        public static Style GetPageTurnButtonStyle(Pagination pagination)
        {
            return (Style)pagination.GetValue(PageTurnButtonStyleProperty);
        }

        public static void SetPageTurnButtonStyle(Pagination pagination, Style value)
        {
            pagination.SetValue(PageTurnButtonStyleProperty, value);
        }

        public static readonly DependencyProperty PageTurnButtonStyleProperty =
            DependencyProperty.RegisterAttached("PageTurnButtonStyle", typeof(Style), typeof(Pagination));
        #endregion

        #region OmittingTextBlockStyle
        public static Style GetOmittingTextBlockStyle(Pagination pagination)
        {
            return (Style)pagination.GetValue(OmittingTextBlockStyleProperty);
        }

        public static void SetOmittingTextBlockStyle(Pagination pagination, Style value)
        {
            pagination.SetValue(OmittingTextBlockStyleProperty, value);
        }

        public static readonly DependencyProperty OmittingTextBlockStyleProperty =
            DependencyProperty.RegisterAttached("OmittingTextBlockStyle", typeof(Style), typeof(Pagination));
        #endregion

        #region ItemsWidth
        public double ItemsWidth
        {
            get { return (double)GetValue(ItemsWidthProperty); }
            set { SetValue(ItemsWidthProperty, value); }
        }

        public static readonly DependencyProperty ItemsWidthProperty =
            DependencyProperty.Register("ItemsWidth", typeof(double), typeof(Pagination));
        #endregion

        #region ItemsHeight
        public double ItemsHeight
        {
            get { return (double)GetValue(ItemsHeightProperty); }
            set { SetValue(ItemsHeightProperty, value); }
        }

        public static readonly DependencyProperty ItemsHeightProperty =
            DependencyProperty.Register("ItemsHeight", typeof(double), typeof(Pagination));
        #endregion

        #region ItemsMargin
        public Thickness ItemsMargin
        {
            get { return (Thickness)GetValue(ItemsMarginProperty); }
            set { SetValue(ItemsMarginProperty, value); }
        }

        public static readonly DependencyProperty ItemsMarginProperty =
            DependencyProperty.Register("ItemsMargin", typeof(Thickness), typeof(Pagination));
        #endregion

        #region ItemsPadding
        public Thickness ItemsPadding
        {
            get { return (Thickness)GetValue(ItemsPaddingProperty); }
            set { SetValue(ItemsPaddingProperty, value); }
        }

        public static readonly DependencyProperty ItemsPaddingProperty =
            DependencyProperty.Register("ItemsPadding", typeof(Thickness), typeof(Pagination));
        #endregion

        #region ItemsShadowColor
        public Color? ItemsShadowColor
        {
            get { return (Color?)GetValue(ItemsShadowColorProperty); }
            set { SetValue(ItemsShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsShadowColorProperty =
            DependencyProperty.Register("ItemsShadowColor", typeof(Color?), typeof(Pagination));
        #endregion

        #region ItemsCornerRadius
        public CornerRadius ItemsCornerRadius
        {
            get { return (CornerRadius)GetValue(ItemsCornerRadiusProperty); }
            set { SetValue(ItemsCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsCornerRadiusProperty =
            DependencyProperty.Register("ItemsCornerRadius", typeof(CornerRadius), typeof(Pagination));
        #endregion

        #region ItemsBackground
        public Brush ItemsBackground
        {
            get { return (Brush)GetValue(ItemsBackgroundProperty); }
            set { SetValue(ItemsBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsBackgroundProperty =
            DependencyProperty.Register("ItemsBackground", typeof(Brush), typeof(Pagination), new PropertyMetadata(Brushes.Transparent));

        #endregion

        #region ItemsForeground
        public Brush ItemsForeground
        {
            get { return (Brush)GetValue(ItemsForegroundProperty); }
            set { SetValue(ItemsForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsForegroundProperty =
            DependencyProperty.Register("ItemsForeground", typeof(Brush), typeof(Pagination));
        #endregion

        #region ItemsBorderBrush
        public Brush ItemsBorderBrush
        {
            get { return (Brush)GetValue(ItemsBorderBrushProperty); }
            set { SetValue(ItemsBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderBrushProperty =
            DependencyProperty.Register("ItemsBorderBrush", typeof(Brush), typeof(Pagination));
        #endregion

        #region ItemsBorderThickness
        public Thickness ItemsBorderThickness
        {
            get { return (Thickness)GetValue(ItemsBorderThicknessProperty); }
            set { SetValue(ItemsBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsBorderThicknessProperty =
            DependencyProperty.Register("ItemsBorderThickness", typeof(Thickness), typeof(Pagination));
        #endregion

        #region ItemsHoverBackground
        public Brush ItemsHoverBackground
        {
            get { return (Brush)GetValue(ItemsHoverBackgroundProperty); }
            set { SetValue(ItemsHoverBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBackgroundProperty =
            DependencyProperty.Register("ItemsHoverBackground", typeof(Brush), typeof(Pagination));
        #endregion

        #region ItemsHoverForeground
        public Brush ItemsHoverForeground
        {
            get { return (Brush)GetValue(ItemsHoverForegroundProperty); }
            set { SetValue(ItemsHoverForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverForegroundProperty =
            DependencyProperty.Register("ItemsHoverForeground", typeof(Brush), typeof(Pagination));
        #endregion

        #region ItemsHoverBorderBrush
        public Brush ItemsHoverBorderBrush
        {
            get { return (Brush)GetValue(ItemsHoverBorderBrushProperty); }
            set { SetValue(ItemsHoverBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBorderBrushProperty =
            DependencyProperty.Register("ItemsHoverBorderBrush", typeof(Brush), typeof(Pagination));
        #endregion

        #region ItemsHoverBorderThickness
        public Thickness? ItemsHoverBorderThickness
        {
            get { return (Thickness?)GetValue(ItemsHoverBorderThicknessProperty); }
            set { SetValue(ItemsHoverBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverBorderThicknessProperty =
            DependencyProperty.Register("ItemsHoverBorderThickness", typeof(Thickness?), typeof(Pagination));
        #endregion

        #region ItemsHoverCornerRadius
        public CornerRadius? ItemsHoverCornerRadius
        {
            get { return (CornerRadius?)GetValue(ItemsHoverCornerRadiusProperty); }
            set { SetValue(ItemsHoverCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverCornerRadiusProperty =
            DependencyProperty.Register("ItemsHoverCornerRadius", typeof(CornerRadius?), typeof(Pagination));
        #endregion

        #region ItemsHoverShadowColor
        public Color? ItemsHoverShadowColor
        {
            get { return (Color?)GetValue(ItemsHoverShadowColorProperty); }
            set { SetValue(ItemsHoverShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsHoverShadowColorProperty =
            DependencyProperty.Register("ItemsHoverShadowColor", typeof(Color?), typeof(Pagination));
        #endregion

        #region ItemsSelectedBackground
        public Brush ItemsSelectedBackground
        {
            get { return (Brush)GetValue(ItemsSelectedBackgroundProperty); }
            set { SetValue(ItemsSelectedBackgroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsSelectedBackgroundProperty =
            DependencyProperty.Register("ItemsSelectedBackground", typeof(Brush), typeof(Pagination));

        #endregion

        #region ItemsSelectedForeground
        public Brush ItemsSelectedForeground
        {
            get { return (Brush)GetValue(ItemsSelectedForegroundProperty); }
            set { SetValue(ItemsSelectedForegroundProperty, value); }
        }

        public static readonly DependencyProperty ItemsSelectedForegroundProperty =
            DependencyProperty.Register("ItemsSelectedForeground", typeof(Brush), typeof(Pagination));
        #endregion

        #region ItemsSelectedBorderBrush
        public Brush ItemsSelectedBorderBrush
        {
            get { return (Brush)GetValue(ItemsSelectedBorderBrushProperty); }
            set { SetValue(ItemsSelectedBorderBrushProperty, value); }
        }

        public static readonly DependencyProperty ItemsSelectedBorderBrushProperty =
            DependencyProperty.Register("ItemsSelectedBorderBrush", typeof(Brush), typeof(Pagination));
        #endregion

        #region ItemsSelectedBorderThickness
        public Thickness? ItemsSelectedBorderThickness
        {
            get { return (Thickness?)GetValue(ItemsSelectedBorderThicknessProperty); }
            set { SetValue(ItemsSelectedBorderThicknessProperty, value); }
        }

        public static readonly DependencyProperty ItemsSelectedBorderThicknessProperty =
            DependencyProperty.Register("ItemsSelectedBorderThickness", typeof(Thickness?), typeof(Pagination));
        #endregion

        #region ItemsSelectedCornerRadius
        public CornerRadius? ItemsSelectedCornerRadius
        {
            get { return (CornerRadius?)GetValue(ItemsSelectedCornerRadiusProperty); }
            set { SetValue(ItemsSelectedCornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty ItemsSelectedCornerRadiusProperty =
            DependencyProperty.Register("ItemsSelectedCornerRadius", typeof(CornerRadius?), typeof(Pagination));
        #endregion

        #region ItemsSelectedShadowColor
        public Color? ItemsSelectedShadowColor
        {
            get { return (Color?)GetValue(ItemsSelectedShadowColorProperty); }
            set { SetValue(ItemsSelectedShadowColorProperty, value); }
        }

        public static readonly DependencyProperty ItemsSelectedShadowColorProperty =
            DependencyProperty.Register("ItemsSelectedShadowColor", typeof(Color?), typeof(Pagination));
        #endregion

        #endregion

        #region Overrides
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            OnEffectivePageValueChanged();
            OnCurrentPageChanged(CurrentPage, 1);
        }
        #endregion

        #region Internal Properties

        #region PageList
        internal ObservableCollection<int?> PageList
        {
            get { return (ObservableCollection<int?>)GetValue(PageListProperty); }
            set { SetValue(PageListProperty, value); }
        }

        internal static readonly DependencyProperty PageListProperty =
            DependencyProperty.Register("PageList", typeof(ObservableCollection<int?>), typeof(Pagination));
        #endregion

        #endregion

        #region Event Handlers
        private void OnPaginationItemClick(object sender, RoutedEventArgs e)
        {
            if(e.OriginalSource is PaginationItem paginationItem)
            {
                if(paginationItem.DataContext is int page)
                {
                    SetCurrentValue(CurrentPageProperty, page);
                }
            }
        }

        private static void OnCurrentPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var pagination = (Pagination)d;
            pagination.OnCurrentPageChanged((int)e.OldValue, (int)e.NewValue);
        }

        private static object OnCurrentPageCoerceValue(DependencyObject d, object baseValue)
        {
            var pagination = (Pagination)d;
            var currentPage = (int)baseValue;
            if (currentPage > pagination.MaxPage)
            {
                return pagination.MaxPage;
            }
            else if (currentPage < pagination.MinPage)
            {
                return pagination.MinPage;
            }
            return baseValue;
        }

        private static void OnEffectivePageValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var pagination = (Pagination)d;
            pagination.OnEffectivePageValueChanged();
        }

        private static void OnPageUpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var pagination = (Pagination)sender;
            pagination.PageUp();
        }

        private static void OnCanPageUpExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            var pagination = (Pagination)sender;
            e.CanExecute = pagination.CurrentPage > pagination.MinPage;
        }

        private static void OnPageDownExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            var pagination = (Pagination)sender;
            pagination.PageDown();
        }

        private static void OnCanPageDownExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            var pagination = (Pagination)sender;
            e.CanExecute = pagination.CurrentPage < pagination.MaxPage;
        }
        #endregion

        #region Methods

        #region PageUp
        public void PageUp()
        {
            SetCurrentValue(CurrentPageProperty, CurrentPage - 1);
        }
        #endregion

        #region PageDown
        public void PageDown()
        {
            SetCurrentValue(CurrentPageProperty, CurrentPage + 1);
        }
        #endregion

        #endregion

        #region Functions
        private void OnEffectivePageValueChanged()
        {
            if (!IsInitialized)
            {
                return;
            }
            lock (_pageListLock)
            {
                if (PageList == null)
                {
                    SetCurrentValue(PageListProperty, new ObservableCollection<int?>());
                }
                else
                {
                    PageList.Clear();
                }

                var delta = MaxPage - MinPage;
                if (delta >= 0)
                {
                    if (MaxPage <= 7)
                    {
                        for (var i = MinPage; i <= MaxPage; i++)
                        {
                            PageList.Add(i);
                        }
                    }
                    else
                    {
                        PageList.Add(MinPage);
                        PageList.Add(MinPage + 1);

                        if (CurrentPage >= MinPage && CurrentPage <= MinPage + 3)
                        {
                            PageList.Add(MinPage + 2);
                            PageList.Add(MinPage + 3);
                            PageList.Add(MinPage + 4);
                        }
                        PageList.Add(null);

                        if (CurrentPage >= MaxPage - 3)
                        {
                            PageList.Add(null);

                            for (var i = MaxPage - 4; i <= MaxPage; i++)
                            {
                                PageList.Add(i);
                            }
                            return;
                        }
                        if (!(CurrentPage >= MinPage && CurrentPage <= MinPage + 3))
                        {
                            for (var i = CurrentPage - 1; i <= CurrentPage + 1; i++)
                            {
                                PageList.Add(i);
                            }
                        }
                        PageList.Add(null);
                        for (var i = MaxPage - 1; i <= MaxPage; i++)
                        {
                            PageList.Add(i);
                        }
                    }
                }
            }
        }

        private void OnCurrentPageChanged(int oldPage, int newPage)
        {
            if (!IsInitialized)
            {
                return;
            }
            
            lock (_pageListLock)
            {
                var index = 0;
                var delta = MaxPage - MinPage;
                if (delta >= 0)
                {
                    if (MaxPage <= 7)
                    {
                        for (var i = MinPage; i <= MaxPage; i++)
                        {
                            PageList[index++] = i;
                        }
                    }
                    else
                    {
                        PageList[index++] = MinPage;
                        PageList[index++] = MinPage + 1;

                        if (CurrentPage >= MinPage && CurrentPage <= MinPage + 3)
                        {
                            PageList[index++] = MinPage + 2;
                            PageList[index++] = MinPage + 3;
                            PageList[index++] = MinPage + 4;
                        }
                        PageList[index++] = null;

                        if (CurrentPage >= MaxPage - 3)
                        {
                            PageList[index++] = null;

                            for (var i = MaxPage - 4; i <= MaxPage; i++)
                            {
                                PageList[index++] = i;
                            }
                            RaiseEvent(new SelectedValueChangedRoutedEventArgs<int>(CurrentPageChangedEvent, oldPage, newPage));
                            return;
                        }
                        if (!(CurrentPage >= MinPage && CurrentPage <= MinPage + 3))
                        {
                            for (var i = CurrentPage - 1; i <= CurrentPage + 1; i++)
                            {
                                PageList[index++] = i;
                            }
                        }
                        PageList[index++] = null;
                        for (var i = MaxPage - 1; i <= MaxPage; i++)
                        {
                            PageList[index++] = i;
                        }
                    }
                }
            }
            RaiseEvent(new SelectedValueChangedRoutedEventArgs<int>(CurrentPageChangedEvent, oldPage, newPage));

        }
        #endregion
    }
}