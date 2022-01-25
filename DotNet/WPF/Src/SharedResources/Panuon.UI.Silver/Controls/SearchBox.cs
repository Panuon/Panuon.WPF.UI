using Panuon.UI.Core;
using Panuon.UI.Silver.Internal.Utils;
using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace Panuon.UI.Silver
{
    [ContentProperty(nameof(Items))]
    [TemplatePart(Name = SearchTextBoxTemplateName, Type = typeof(TextBox))]
    [TemplatePart(Name = DropDownTemplateName, Type = typeof(DropDown))]
    [TemplatePart(Name = ListBoxContainerTemplateName, Type = typeof(Decorator))]
    public class SearchBox
        : Control
    {
        #region Fields
        private const string SearchTextBoxTemplateName = "PART_SearchTextBox";

        private const string DropDownTemplateName = "PART_DropDown";

        private const string ListBoxContainerTemplateName = "PART_ListBoxContainer";

        private TextBox _textBox;

        private DropDown _dropDown;

        private ListBox _listBox;
        #endregion

        #region Ctor
        static SearchBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SearchBox), new FrameworkPropertyMetadata(typeof(SearchBox)));
        }

        public SearchBox()
        {
            _listBox = new ListBox();
            FrameworkElementUtil.BindingProperty(_listBox, ListBox.ItemsSourceProperty, this, ItemsSourceProperty);
            FrameworkElementUtil.BindingProperty(_listBox, ListBox.ItemTemplateProperty, this, ItemTemplateProperty);
            FrameworkElementUtil.BindingProperty(_listBox, ListBox.ItemTemplateSelectorProperty, this, ItemTemplateSelectorProperty);
            FrameworkElementUtil.BindingProperty(_listBox, ListBox.ItemStringFormatProperty, this, ItemStringFormatProperty);
            FrameworkElementUtil.BindingProperty(_listBox, ListBox.StyleProperty, this, ListBoxStyleProperty);

            ListBoxHelper.AddItemClickHandler(_listBox, OnListBoxItemClick);
        }
        #endregion

        #region Events

        public event EventHandler Closed;

        public event EventHandler Opened;

        #region SearchTextChanged
        public event SearchTextChangedEventHandler SearchTextChanged
        {
            add { AddHandler(SearchTextChangedEvent, value); }
            remove { RemoveHandler(SearchTextChangedEvent, value); }
        }

        public static readonly RoutedEvent SearchTextChangedEvent =
            EventManager.RegisterRoutedEvent("SearchTextChanged", RoutingStrategy.Bubble, typeof(SearchTextChangedEventHandler), typeof(SearchBox));
        #endregion

        #region SelectionChanged
        public event SelectedValueChangedEventHandler<object> SelectionChanged
        {
            add { AddHandler(SelectionChangedEvent, value); }
            remove { RemoveHandler(SelectionChangedEvent, value); }
        }

        public static readonly RoutedEvent SelectionChangedEvent =
            EventManager.RegisterRoutedEvent("SelectionChanged", RoutingStrategy.Bubble, typeof(SelectedValueChangedEventHandler<object>), typeof(SearchBox));
        #endregion

        #endregion

        #region Overrides
        public override void OnApplyTemplate()
        {
            _textBox = GetTemplateChild(SearchTextBoxTemplateName) as TextBox;
            _textBox.KeyUp += TextBox_KeyUp;
            _textBox.GotKeyboardFocus += TextBox_GotKeyboardFocus;

            _dropDown = GetTemplateChild(DropDownTemplateName) as DropDown;
            _dropDown.Opened += DropDown_Opened;
            _dropDown.Closed += DropDown_Closed;

            var decorator = GetTemplateChild(ListBoxContainerTemplateName) as Decorator;
            decorator.Child = _listBox;
        }

        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                    if (_listBox.SelectedIndex > 0)
                    {
                        _listBox.SetCurrentValue(ListBox.SelectedIndexProperty, Math.Max(0, _listBox.SelectedIndex - 1));
                        if (_listBox.SelectedItem != null)
                        {
                            _listBox.ScrollIntoView(_listBox.SelectedItem);
                        }
                    }
                    break;
                case Key.Down:
                    _listBox.SetCurrentValue(ListBox.SelectedIndexProperty, _listBox.SelectedIndex + 1);
                    if (_listBox.SelectedItem != null)
                    {
                        _listBox.ScrollIntoView(_listBox.SelectedItem);
                    }
                    break;
                case Key.Enter:
                    if (_dropDown.IsOpen)
                    {
                        RaiseSelectionChanged();
                    }
                    break;
            }
            base.OnPreviewKeyDown(e);
        }

        #endregion

        #region ComponentResourceKeys
        public static ComponentResourceKey TextBoxStyle { get; } =
            new ComponentResourceKey(typeof(SearchBox), nameof(TextBoxStyle));

        public static ComponentResourceKey ListBoxStyle { get; } =
            new ComponentResourceKey(typeof(SearchBox), nameof(ListBoxStyle));
        #endregion

        #region Properties

        #region IsOpen
        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register("IsOpen", typeof(bool), typeof(SearchBox));
        #endregion

        #region StaysOnOpen
        public bool StaysOnOpen
        {
            get { return (bool)GetValue(StaysOnOpenProperty); }
            set { SetValue(StaysOnOpenProperty, value); }
        }

        public static readonly DependencyProperty StaysOnOpenProperty =
            DependencyProperty.Register("StaysOnOpen", typeof(bool), typeof(SearchBox));
        #endregion

        #region OpenOnFocus
        public bool OpenOnFocus
        {
            get { return (bool)GetValue(OpenOnFocusProperty); }
            set { SetValue(OpenOnFocusProperty, value); }
        }

        public static readonly DependencyProperty OpenOnFocusProperty =
            DependencyProperty.Register("OpenOnFocus", typeof(bool), typeof(SearchBox), new PropertyMetadata(true));
        #endregion

        #region TextBoxStyle
        public static Style GetTextBoxStyle(WindowX windowX)
        {
            return (Style)windowX.GetValue(TextBoxStyleProperty);
        }

        public static void SetTextBoxStyle(WindowX windowX, Style value)
        {
            windowX.SetValue(TextBoxStyleProperty, value);
        }

        public static readonly DependencyProperty TextBoxStyleProperty =
            DependencyProperty.RegisterAttached("TextBoxStyle", typeof(Style), typeof(SearchBox));
        #endregion

        #region ListBoxStyle
        public static Style GetListBoxStyle(WindowX windowX)
        {
            return (Style)windowX.GetValue(ListBoxStyleProperty);
        }

        public static void SetListBoxStyle(WindowX windowX, Style value)
        {
            windowX.SetValue(ListBoxStyleProperty, value);
        }

        public static readonly DependencyProperty ListBoxStyleProperty =
            DependencyProperty.RegisterAttached("ListBoxStyle", typeof(Style), typeof(SearchBox));
        #endregion

        #region Items
        public ItemCollection Items => _listBox.Items;
        #endregion

        #region ItemsSource
        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(SearchBox));
        #endregion

        #region ItemTemplate
        public DataTemplate ItemTemplate
        {
            get { return (DataTemplate)GetValue(ItemTemplateProperty); }
            set { SetValue(ItemTemplateProperty, value); }
        }

        public static readonly DependencyProperty ItemTemplateProperty =
            DependencyProperty.Register("ItemTemplate", typeof(DataTemplate), typeof(SearchBox));
        #endregion

        #region ItemTemplateSelector
        public DataTemplateSelector ItemTemplateSelector
        {
            get { return (DataTemplateSelector)GetValue(ItemTemplateSelectorProperty); }
            set { SetValue(ItemTemplateSelectorProperty, value); }
        }

        public static readonly DependencyProperty ItemTemplateSelectorProperty =
            DependencyProperty.Register("ItemTemplateSelector", typeof(DataTemplateSelector), typeof(SearchBox));
        #endregion

        #region ItemStringFormat
        public string ItemStringFormat
        {
            get { return (string)GetValue(ItemStringFormatProperty); }
            set { SetValue(ItemStringFormatProperty, value); }
        }

        public static readonly DependencyProperty ItemStringFormatProperty =
            DependencyProperty.Register("ItemStringFormat", typeof(string), typeof(SearchBox));
        #endregion

        #endregion

        #region Methods
        public void ScrollIntoView(object item)
        {
            if (_listBox.ItemContainerGenerator.ContainerFromItem(item) is FrameworkElement element)
            {
                element.BringIntoView();
            }
        }
        #endregion

        #region Event Handlers
        private void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (OpenOnFocus)
            {
                _dropDown.IsOpen = true;
            }
        }

        private void DropDown_Opened(object sender, EventArgs e)
        {
            Opened?.Invoke(this, EventArgs.Empty);
        }

        private void DropDown_Closed(object sender, EventArgs e)
        {
            _listBox.UnselectAll();

            FrameworkElementUtil.RemoveFocus(this);

            Closed?.Invoke(this, EventArgs.Empty);
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Up:
                case Key.Down:
                case Key.Enter:
                    return;
            }

            if (!_dropDown.IsOpen)
            {
                _dropDown.IsOpen = true;
                _textBox.Focus();
            }

            RaiseEvent(new SearchTextChangedEventArgs(SearchTextChangedEvent, _textBox.Text));
        }

        private void OnListBoxItemClick(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is ListBoxItem listboxItem)
            {
                RaiseSelectionChanged(listboxItem.DataContext);
                e.Handled = true;
            }
        }
        #endregion

        #region Functions
        private void RaiseSelectionChanged(object selectedItem = null)
        {
            selectedItem = selectedItem ?? _listBox.SelectedItem;
            _textBox.Clear();
            _dropDown.IsOpen = false;
            RaiseEvent(new SelectedValueChangedEventArgs<object>(SelectionChangedEvent, null, selectedItem));

        }
        #endregion

    }
}
