# ComboBox 单选下拉框

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.ComboBoxStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.ComboBoxHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="ComboBox">* 或 *<pu:KeyOnlyStyleDictionary Includes="ComboBox">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/ComboBox.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/ComboBoxStyle.xaml*
  
> 早期翻译工作不充分，为了做好国际化，在后续的大版本中，以下内容可能会重命名。请留意更新说明。  
Watermark -> Placeholder  
Nonnull -> NotEmpty
  
---

## 小提示
1. 当单选下拉框被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。    
2. 默认情况下，`WatermarkForeground`的值会与`Foreground`属性绑定，并通过转换器转换成带有`透明度`的颜色。
3. 请勿将`HoverForeground`属性设置为渐变色，这会在悬浮时抛出底层异常（WPF的历史遗留问题）。如果不需要显示悬浮颜色和获得键盘焦点颜色，可以将相应属性的值设置为 `null` (在XAML中为 `{x:Null}` )。  
4. 考虑到虚拟化容器和MVVM绑定，Panuon没有也无法实现搜索逻辑。必须接收`SearchTextChanged`事件，并在代码中进行处理。[示例3](#示例3)中提供了一个例子。
5. 若要调整下拉框样式，可以使用`DropDownHelper`调整下拉框的样式，有关`DropDownHelper`的更多内容, 请查看[*DropDown 下拉列表*]()。  

## 属性
以下属性包含在辅助类*ComboBoxHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| BindToEnum | *CornerRadius* | *0,0,0,0* | 设置要绑定到的枚举值。使用方式参加[示例2](#示例2)。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| ClearButtonStyle | *Style* | *(见内部资源键)* | 清空按钮的 _Button 按钮_ 控件样式。 |
| ClearButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 清空按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnNonnull` 表示当单选下拉框的文本不为空时显示，`VisibleOnHover` 表示当鼠标悬浮在单选下拉框上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在单选下拉框上且文本不为空时显示，`VisibleOnFocused` 表示当单选下拉框获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当单选下拉框获得键盘焦点且文本不为空时显示。 |
| FocusedBackground | *Brush* | *null* | 获得键盘焦点时的背景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderBrush | *Brush* | *null* | 获得键盘焦点时的边框色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderThickness | *Thickness?* | *null* | 获得键盘焦点时的边框粗细。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedCornerRadius | *CornerRadius?* | *null* | 获得键盘焦点时的边框圆角。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedForeground | *Brush* | *null* | 获得键盘焦点时的前景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedShadowColor | *Color?* | *null* | 获得键盘焦点时的阴影色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedWatermarkForeground | *Brush* | *null* | 获得键盘焦点时的占位符水印(Placeholder)前景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusToEditor | *bool* | *false* | 获得键盘焦点时，将焦点直接 转移到编辑*TextBox 输入框*控件上。仅当`IsEditable="True"`时有效。 |
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| HoverCornerRadius | *CornerRadius?* | *null* | 悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，悬浮不出现变化。 |
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| RemoveButtonStyle | *Style* | *(见内部资源键)* | 清空按钮的 _Button 按钮_ 控件样式。 |
| RemovingAnimationDuration | *TimeSpan?* | *null* | 子项移除时的动画持续时间。值为`null`或`0`时，不会执行动画效果。 |
| RemovingAnimationEasing | *AnimationEasing* | *None* | 子项移除时的动画缓动函数。有关WPF缓动函数的更多信息，请查看[WPF缓动函数文档](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/graphics-multimedia/easing-functions?view=netframeworkdesktop-4.8) |
| SearchTextBoxVisibility | *Visibility* | *Collapsed* | 是否显示搜索框。 |
| SearchTextBoxStyle | *Style* | *null* | 搜索框的*TextBox 输入框*控件样式。 |
| SearchText | *string* | *null* | 获取用户输入的搜索文本。有关如何处理搜索文本，参加[示例3](#示例3) |
| ShadowColor | *Color?* | *null* | 边框的阴影。阴影细节可以通过*ShadowHelper 阴影*辅助类控制。 |
| ToggleArrowTransformControlStyle | *Style* | *(见内部资源键)* | 下拉三角箭头的*TransformControl 变形控件*控件样式。 |
| Watermark | *object* | *null* | 占位符水印(Placeholder)。 |
| WatermarkForeground | *Brush* | *(自动计算)* | 占位符水印(Placeholder)的颜色。 |
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |
| ItemsBorderThickness | *Thickness?* | *null* | 子项的边框粗细。 |
| ItemsCornerRadius | *CornerRadius?* | *null* | 子项的边框圆角。 |
| ItemsForeground | *Brush* | *null* | 子项的前景色。 |
| ItemsFontSize | *double* | *(跟随主控件)* | 子项的字号。 |
| ItemsHeight | *double* | *(自动计算)* | 子项的高度。 |
| ItemsHorizontalContentAlignment | *HorizontalAlignment* | *Stretch* | 子项的垂直内容布局。 |
| ItemsHoverBackground | *Brush* | *(自动计算)* | 子项悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderThickness | *Thickness?* | *null* | 子项悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| ItemsHoverCornerRadius | *CornerRadius?* | *null* | 子项悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| ItemsIcon | *object* | *null* | 子项的图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| ItemsIconWidth | *double* | *NaN* | 子项的图标容器宽度。即使子项没有图标，也会保留宽度，用于使内容对齐。 |
| ItemsMargin | *Thickness* | *0,0,0,0* | 子项的外边距。 |
| ItemsPadding | *Thickness* | *(跟随主控件)* | 子项的内边距。 |
| ItemsRemoveButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 子项移除按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnNonnull` 表示当单选下拉框的文本不为空时显示，`VisibleOnHover` 表示当鼠标悬浮在单选下拉框上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在单选下拉框上且文本不为空时显示，`VisibleOnFocused` 表示当单选下拉框获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当单选下拉框获得键盘焦点且文本不为空时显示。 |
| ItemsSelectedBackground | *Brush* | *null* | 子项被选中时的背景色。值为`null`时，被选中不出现变化。 |
| ItemsSelectedBorderBrush | *Brush* | *null* | 子项被选中时的边框色。值为`null`时，被选中不出现变化。 |
| ItemsSelectedBorderThickness | *Thickness?* | *null* | 子项被选中时的边框粗细。值为`null`时，被选中不出现变化。 |
| ItemsSelectedCornerRadius | *CornerRadius?* | *null* | 子项被选中时的边框圆角。值为`null`时，被选中不出现变化。 |
| ItemsSelectedForeground | *Brush* | *null* | 子项被选中时的前景色。值为`null`时，被选中不出现变化。 |
| ItemsSelectedWatermarkForeground | *Brush* | *null* | 子项被选中时的占位符水印(Placeholder)前景色。值为`null`时，被选中不出现变化。 |
| ItemsSeparatorBrush | *Brush* | *Gray* | 子项分隔符的颜色。 |
| ItemsSeparatorMargin | *Thickness* | *0,0,0,0* | 子项分隔符的外边距。 |
| ItemsSeparatorThickness | *double* | *1* | 子项分隔符的粗细。 |
| ItemsSeparatorVisibility | *Visibility* | *Collapsed* | 是否显示子项分隔符。 |
| ItemsVerticalContentAlignment | *VerticalAlignment* | *Center* | 子项的垂直内容布局。 |
| ItemsWidth | *double* | *(自动计算)* | 子项的宽度。 |
## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/combobox-1-_theme_.gif"></img>

```xml
<ComboBox
    Width="200"
    Height="35"
    Padding="10,0"
    pu:ComboBoxHelper.ClearButtonVisibility="VisibleOnHover"
    pu:ComboBoxHelper.CornerRadius="4"
    pu:ComboBoxHelper.ItemsHoverBackground="#2236AAF7"
    pu:ComboBoxHelper.ItemsSelectedBackground="#36AAF7"
    pu:ComboBoxHelper.ItemsSelectedForeground="#FFFFFF"
    pu:ComboBoxHelper.OpenedBorderThickness="0"
    pu:ComboBoxHelper.OpenedCornerRadius="4,4,0,0"
    pu:ComboBoxHelper.OpenedForeground="#36AAF7"
    pu:ComboBoxHelper.OpenedShadowColor="#36AAF7"
    pu:ComboBoxHelper.Watermark="Select an option"
    pu:ComboBoxHelper.WatermarkForeground="Gray"
    pu:DropDownHelper.BorderThickness="0"
    pu:DropDownHelper.CornerRadius="0,0,4,4"
    pu:DropDownHelper.ShadowColor="#36AAF7"
    pu:DropDownHelper.VerticalOffset="-1"
    pu:ShadowHelper.BlurRadius="15"
    pu:ShadowHelper.ShadowDepth="5"
    BorderBrush="LightGray"
    BorderThickness="1.5">
    <ComboBoxItem Content="Item 1" />
    <ComboBoxItem Content="Item 2" />
    <ComboBoxItem Content="Item 3" />
</ComboBox>
```

### 示例2
这个示例将演示如何使用`BindToEnum`属性。  

<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/combobox-2-_theme_.jpg"></img>

```cs
namespace WpfApp1
{
    public enum Sex
    {
        [Description("男")]
        Male,
        [Description("女")]
        Female,
        [Description("其他")]
        Other,
    }
}
```
```xml
xmlns:local="clr-namespace:WpfApp1"
...

<ComboBox Height="35" Width="200" Padding="10,0"
          pu:ComboBoxHelper.CornerRadius="4"
          pu:ComboBoxHelper.BindToEnum="{x:Static local:Sex.Male}" />
```
可以使用 `SelectedValue` 原生属性获取或设置选中的值，支持绑定。  

### 示例3
这个示例将演示如何使用搜索框。  

<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/combobox-3-_theme_.jpg"></img>

```xml
xmlns:pw="https://opensource.panuon.com/wpf"
...

<ComboBox x:Name="Cmb" Height="35" Width="200" Padding="10,0"
          DisplayMemberPath="DisplayName"
          pu:ComboBoxHelper.CornerRadius="4"
          pu:ComboBoxHelper.SearchTextBoxVisibility="Visible"
          pu:ComboBoxHelper.SearchTextChanged="ComboBox_SearchTextChanged">
    <ComboBox.ItemContainerStyle>
        <Style TargetType="ComboBoxItem" BasedOn="{StaticResource {x:Static pu:StyleKeys.ComboBoxItemStyle}}">
            <Setter Property="Visibility" Value="{Binding IsVisible, Converter={x:Static pw:Converters.FalseToCollapseConverter}}" />
        </Style>
    </ComboBox.ItemContainerStyle>
</ComboBox>
```
```cs
public class OptionItem : NotifyPropertyChangedBase
{
    public string DisplayName { get => _displayName; set => Set(ref _displayName, value); }
    private string _displayName;

    public bool IsVisible { get => _isVisible; set => Set(ref _isVisible, value); }
    private bool _isVisible;
}
```
```cs
var optionItems = new List<OptionItem>();
for (int i = 0; i < 100; i++)
{
    optionItems.Add(new OptionItem() { DisplayName = $"Item {i + 1}", IsVisible = true });
}
Cmb.ItemsSource = optionItems;
```
```cs
private void ComboBox_SearchTextChanged(object sender, SearchTextChangedRoutedEventArgs e)
{
    var optionItems = Cmb.ItemsSource as IEnumerable<OptionItem>;
    foreach(var optionItem in optionItems)
    {
        optionItem.IsVisible = string.IsNullOrEmpty(e.Text) ? true : optionItem.DisplayName.Contains(e.Text);
    }
}
```
## 内部资源键

### ClearButtonStyle
`{StaticResource {x:Static pu:ComboBoxHelper.ClearButtonStyleKey}}`  
控件类型：*Button 按钮*  
清空按钮的样式。  


示例：
```xml
<!--修改清空按钮的图标-->
<ComboBox>
    <pu:ComboBoxHelper.ClearButtonStyle>
        <Style TargetType="Button" BasedOn="{StaticResource {x:Static pu:ComboBoxHelper.ClearButtonStyleKey}}">
            <Setter Property="Content" Value="&#xe933;" />
        </Style>
    </pu:ComboBoxHelper.ClearButtonStyle>
</ComboBox>
```

### RemoveButtonStyle
`{StaticResource {x:Static pu:ComboBoxHelper.RemoveButtonStyleKey}}`  
控件类型：*Button 按钮*  
移除按钮的样式。  

示例：  
```xml
<!--修改移除按钮的图标-->
<ComboBox>
    <pu:ComboBoxHelper.RemoveButtonStyle>
        <Style TargetType="Button" BasedOn="{StaticResource {x:Static pu:ComboBoxHelper.RemoveButtonStyleKey}}">
            <Setter Property="Content" Value="&#xe933;" />
        </Style>
    </pu:ComboBoxHelper.RemoveButtonStyle>
</ComboBox>
```

### ToggleArrowTransformControlStyle
`{StaticResource {x:Static pu:ComboBoxHelper.ToggleArrowTransformControlStyleKey}}`  
控件类型：*pu:TransformControl 变形控件*  
下拉三角符号的样式。  

示例：  
```xml
<!--修改下拉三角的样式-->
<ComboBox>
    <pu:ComboBoxHelper.ToggleArrowTransformControlStyle>
        <Style TargetType="pu:TransformControl" BasedOn="{StaticResource {x:Static pu:ComboBoxHelper.ToggleArrowTransformControlStyleKey}}">
            <Setter Property="Content" Value="&#xe91f;" />
        </Style>
    </pu:ComboBoxHelper.ToggleArrowTransformControlStyle>
</ComboBox>
```