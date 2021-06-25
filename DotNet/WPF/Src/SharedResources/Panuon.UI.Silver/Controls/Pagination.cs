using Panuon.UI.Core;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Panuon.UI.Silver
{
    public class Pagination : Control
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
        public static readonly RoutedCommand PageUpCommand = new RoutedCommand("PageUp", typeof(ScrollBar));

        public static readonly RoutedCommand PageDownCommand = new RoutedCommand("PageDown", typeof(ScrollBar));
        #endregion

        #region Events

        #region CurrentPageChanged
        public event SelectedValueChangedEventHandler<int> CurrentPageChanged
        {
            add { AddHandler(CurrentPageChangedEvent, value); }
            remove { RemoveHandler(CurrentPageChangedEvent, value); }
        }

        public static readonly RoutedEvent CurrentPageChangedEvent =
            EventManager.RegisterRoutedEvent("CurrentPageChanged", RoutingStrategy.Bubble, typeof(SelectedValueChangedEventHandler<int>), typeof(Pagination));
        #endregion

        #endregion

        #region Properties

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

        #region TurnPageButtonStyle
        public Style TurnPageButtonStyle
        {
            get { return (Style)GetValue(TurnPageButtonStyleProperty); }
            set { SetValue(TurnPageButtonStyleProperty, value); }
        }

        public static readonly DependencyProperty TurnPageButtonStyleProperty =
            DependencyProperty.Register("TurnPageButtonStyle", typeof(Style), typeof(Pagination));
        #endregion

        #region PaginationItemStyle
        public Style PaginationItemStyle
        {
            get { return (Style)GetValue(PaginationItemStyleProperty); }
            set { SetValue(PaginationItemStyleProperty, value); }
        }

        public static readonly DependencyProperty PaginationItemStyleProperty =
            DependencyProperty.Register("PaginationItemStyle", typeof(Style), typeof(Pagination));
        #endregion

        #region OmittingTextBlockStyle
        public Style OmittingTextBlockStyle
        {
            get { return (Style)GetValue(OmittingTextBlockStyleProperty); }
            set { SetValue(OmittingTextBlockStyleProperty, value); }
        }

        public static readonly DependencyProperty OmittingTextBlockStyleProperty =
            DependencyProperty.Register("OmittingTextBlockStyle", typeof(Style), typeof(Pagination));
        #endregion

        #endregion

        #region Overrides
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            OnEffectivePageValueChanged();
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
                    PageList = new ObservableCollection<int?>();
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
                            RaiseEvent(new SelectedValueChangedEventArgs<int>(CurrentPageChangedEvent, oldPage, newPage));
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
            RaiseEvent(new SelectedValueChangedEventArgs<int>(CurrentPageChangedEvent, oldPage, newPage));

        }
        #endregion
    }
}