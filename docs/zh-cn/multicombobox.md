# MultiComboBox 多选下拉框

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CheckedIconTemplate | *DataTemplate* | *null* | 选中图标样式。 |
| ClearButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 清空按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnNonnull` 表示当单选下拉框的文本不为空时显示，VisibleOnHover 表示当鼠标悬浮在单选下拉框上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在单选下拉框上且文本不为空时显示，`VisibleOnFocused` 表示当单选下拉框获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当单选下拉框获得键盘焦点且文本不为空时显示。 |
| ClearTextOnClick | *bool* | *false* | 单击输入框内的文本时是否清除文本。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| FocusedBackground | *Brush* | *null* | 获得键盘焦点时的背景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderBrush | *Brush* | *null* | 获得键盘焦点时的边框色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderThickness | *Thickness?* | *null* | 获得键盘焦点时的边框粗细。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedCornerRadius | *CornerRadius?* | *null* |  获得键盘焦点时的边框圆角。值为`null`时，获得键盘焦点不出现变化。。 |
| FocusedForeground | *Brush* | *null* | 获得键盘焦点时的前景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedShadowColor | *Color?* | *null* | 获得键盘焦点时的阴影色。值为`null`时，获得键盘焦点不出现变化。 |
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，悬浮不出现变化。 |
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| IsDropDownOpen | *bool* | *false* | 下拉列表框是否处于打开状态。 |
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |
| ItemsBorderThickness | *Thickness* | *null* | 子项的边框粗细。 |
| ItemsCheckBoxVisibility | *Visibility* | *Collapsed* | 下拉列表框中每个条目前的复选框的可见性。 |
| ItemsCornerRadius | *CornerRadius* | *null* | 子项的边框圆角。 |
| ItemsForeground | *Brush* | *null* | 子项的前景色。 |
| ItemsHeight | *double* | *(自动计算)* | 子项的高度。 |
| ItemsHorizontalContentAlignment | *HorizontalAlignment* | *Stretch* | 子项的垂直内容布局。 |
| ItemsHoverBackground | *Brush* | *(自动计算)* | 子项悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverShadowColor | *Color?* | *null* | 子项悬浮时的阴影。 |
| ItemsIcon | *object* | *null* | 子项的图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| ItemsIconWidth | *double* | *NaN* | 子项的图标容器宽度。即使子项没有图标，也会保留宽度，用于使内容对齐。 |
| ItemsMargin | *Thickness* | *0,0,0,0* | 子项的外边距。 |
| ItemsPadding | *Thickness* | *(跟随主控件)* | 子项的内边距。 |
| ItemsRemoveButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 子项移除按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnNonnull` 表示当单选下拉框的文本不为空时显示，`VisibleOnHover` 表示当鼠标悬浮在单选下拉框上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在单选下拉框上且文本不为空时显示，`VisibleOnFocused` 表示当单选下拉框获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当单选下拉框获得键盘焦点且文本不为空时显示。 |
| ItemsSelectedBackground | *Brush* | *null* | 子项被选中时的背景色。值为`null`时，被选中不出现变化。 |
| ItemsSelectedBorderBrush | *Brush* | *null* | 子项被选中时的边框色。值为`null`时，被选中不出现变化。 |
| ItemsSelectedBorderThickness | *Thickness?* | *null* | 子项被选中时的边框粗细。值为`null`时，被选中不出现变化。 |
| ItemsSelectedForeground | *Brush* | *null* | 子项被选中时的前景色。值为`null`时，被选中不出现变化。 |
| ItemsSeparatorBrush | *Brush* | *Gray* | 子项分隔符的颜色。 |
| ItemsSeparatorMargin | *Thickness* | *0,0,0,0* | 子项分隔符的外边距。 |
| ItemsSeparatorThickness | *double* | *1* | 子项分隔符的粗细。 |
| ItemsSeparatorVisibility | *Visibility* | *Collapsed* | 是否显示子项分隔符。 |
| ItemsVerticalContentAlignment | *VerticalAlignment* | *Center* | 子项的垂直内容布局。 |
| ItemsWidth | *double* | *(自动计算)* | 子项的宽度。 |
| MaxDropDownHeight | *double* | *null* | 下拉列表框展开时的最大高度。 |
| RemovingAnimationDuration | *TimeSpan?* | *null* | 移除动画的持续时间。值为null或0时，不会执行动画效果。。 |
| RemovingAnimationEasing | *AnimationEasing* | *None* | 移除动画的缓动函数。有关WPF缓动函数的更多信息，请查看[*WPF缓动函数文档*]() 。 |
| SelectionBoxItemLabelStyle | *Style* | *(见内部资源键)* | 选择框项的标签的样式。 |
| ToggleArrowTransformControlStyle | *Style* | *(见内部资源键)* | 下拉箭头变换时的样式。 |
| UncheckedIconTemplate | *DataTemplate* | *null* | 未选中状态下显示的图标或内容模板。 |
| Watermark | *object* | *null* | 占位符水印(Placeholder)。 |
| WatermarkForeground | *Brush* | *(自动计算)* | 占位符水印(Placeholder)的颜色。 |

## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/multicombobox-1-_theme_.gif"></img>

```xml
<pu:MultiComboBox Width="200"
  Height="35"
  Padding="10,0,10,0"
  BorderBrush="#FF36AAF7"
  CornerRadius="4,4,4,4"
  ShadowColor="#FF36AAF7"
  ItemsPadding="7,0,7,0"
  ItemsHoverBackground="#FF36AAF7"
  ItemsSelectedBackground="#FF36AAF7"
  ItemsSelectedBorderThickness="0,0,0,0"
  ItemsSelectedCornerRadius="0,0,0,0" >
    <pu:MultiComboBoxItem Content="Item 1" />
    <pu:MultiComboBoxItem Content="Item 2" />
    <pu:MultiComboBoxItem Content="Item 3" />
</pu:MultiComboBox>
```
 ### 示例2
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/multicombobox-2-_theme_.gif"></img>


```C#
    public class ShellViewModel : PropertyChangedBase
    {            
        private ObservableCollection<ItemSource> _ItemSource;
        public ObservableCollection<ItemSource> ItemSource
        {
            get => _ItemSource;
            set
            {
                _ItemSource = value;
                NotifyOfPropertyChange(() => ItemSource);
            }
        }
        public ShellViewModel()
        {         
            ItemSource = new ObservableCollection<ItemSource>
            {
                new ItemSource { Name = "管理员", Value = "Admin" },
                new ItemSource { Name = "编辑员", Value = "Editor" },
                new ItemSource { Name = "查看员", Value = "Viewer" }
            };
        }
    }
    public class ItemSource : PropertyChangedBase
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }

        private string _value;
        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                NotifyOfPropertyChange(() => Value);
            }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                NotifyOfPropertyChange(() => IsSelected);
            }
        }
    }
 ```

```xml
<pu:MultiComboBox
    x:Name="ItemSource"
    Width="200"
    Height="35"
    Padding="10,0,10,0"
    BorderBrush="#FF36AAF7"
    CornerRadius="4,4,4,4"
    DisplayMemberPath="Name"
    ItemsHoverBackground="#FF36AAF7"
    ItemsPadding="7,0,7,0"
    ItemsSelectedBackground="#FF36AAF7"
    ItemsSelectedBorderThickness="0,0,0,0"
    ItemsSelectedCornerRadius="0,0,0,0"
    ItemsSource="{Binding ItemSource}"
    SelectedValuePath="Value"
    ShadowColor="#FF36AAF7"
    Watermark="选择用户角色">
    <pu:MultiComboBox.ItemContainerStyle>
        <Style BasedOn="{StaticResource {x:Type pu:MultiComboBoxItem}}" TargetType="{x:Type pu:MultiComboBoxItem}">
            <Setter Property="IsSelected" Value="{Binding IsSelected, UpdateSourceTrigger=PropertyChanged, Mode=TwoWay}" />
        </Style>
    </pu:MultiComboBox.ItemContainerStyle>
</pu:MultiComboBox>
```