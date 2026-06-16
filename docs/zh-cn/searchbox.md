# SearchBox 搜索框

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ClearButtonStyle | *Style* | *(见内部资源键)* | 清空按钮样式。 |
| ClearButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 清空按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnNonnull` 表示当单选下拉框的文本不为空时显示，`VisibleOnHover` 表示当鼠标悬浮在单选下拉框上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在单选下拉框上且文本不为空时显示，`VisibleOnFocused` 表示当单选下拉框获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当单选下拉框获得键盘焦点且文本不为空时显示。 |
| ClearTextOnClick | *bool* | *false* | 点击文本框时自动清空文本框中内容。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| FocusedBackground | *Brush* | *null* | 获得键盘焦点时的背景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderBrush | *Brush* | *null* | 获得键盘焦点时的边框色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderThickness | *Thickness?* | *null* | 获得键盘焦点时的边框粗细。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedCornerRadius | *CornerRadius?* | *null* | 获得键盘焦点时的边框圆角。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedForeground | *Brush* | *null* | 获得键盘焦点时的前景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedShadowColor | *Color?* | *null* | 获得键盘焦点时的阴影色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedWatermarkForeground | *Brush* | *null* | 获得键盘焦点时的占位符水印(Placeholder)前景色。值为`null`时，获得键盘焦点不出现变化。 |
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| HoverCornerRadius | *CornerRadius?* | *null* | 悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，获得键盘焦点不出现变化。 |
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| IsDropDownOpen | *bool* | *false* | 是否展开子项列表。 |
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |
| ItemsBorderThickness | *Thickness* | *null* | 子项的边框粗细。值为`null`时，点击不出现变化。 |
| ItemsClickBackground | *Brush* | *null* | 子项点击时的背景色。值为`null`时，点击不出现变化。 |
| ItemsClickBorderBrush | *Brush* | *null* | 子项点击时的边框色。值为`null`时，点击不出现变化。 |
| ItemsClickBorderThickness | *Thickness?* | *null* | 子项点击时的边框粗细。值为`null`时，点击不出现变化。 |
| ItemsClickEffect | *ClickEffect* | *None* | 点击特效。`None` 表示没有点击特效，`Sink` 表示点击时下沉，`Shake` 表示点击时抖动。 |
| ItemsClickForeground | *Brush* | *null* | 子项点击时的前景色。值为`null`时，点击不出现变化。 |
| ItemsCornerRadius | *CornerRadius* | *null* | 子项的边框圆角。 |
| ItemsForeground | *Brush* | *null* | 子项的前景色。 |
| ItemsHeight | *double* | *(自动计算)* | 子项的高度。 |
| ItemsHorizontalContentAlignment | *HorizontalAlignment* | *Left* | 子项内容水平对齐方式。`Center`表示居中显示，`Left`表示靠左显示，`Right`表示靠右显示，`Stretch`表示自动调整大小以填充。 |
| ItemsHoverBackground | *Brush* | *(自动计算)* | 子项悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderThickness | *Thickness?* | *null* | 子项悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| ItemsHoverCornerRadius | *CornerRadius?* | *null* | 子项悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverShadowColor | *Color?* | *null* | 子项悬浮时的阴影色。值为`null`时，悬浮不出现变化。 |
| ItemsIcon | *object* | *null* | 子项的图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| ItemsMargin | *Thickness* | *0,0,0,0* | 子项的外边距。 |
| ItemsPadding | *Thickness* | *(跟随主控件)* | 子项的内边距。 |
| ItemsSeparatorBrush | *Brush* | *null* | 子项分隔符的颜色。 |
| ItemsSeparatorMargin | *Thickness* | *0,0,0,0* | 子项分隔符的外边距。 |
| ItemsSeparatorThickness | *double* | *null* | 子项分隔符的粗细。 |
| ItemsSeparatorVisibility | *Visibility* | *false* | 是否显示分隔符。 |
| ItemsShadowColor | *Color?* | *null* | 子项边框的阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |
| ItemsVerticalContentAlignment | *VerticalAlignment* | *Center* | 标题垂直对齐方式。`Bottom`表示底部对齐，`Center`表示居中显示，`Stretch`表示自动调整大小以填充，`Top`表示顶部对齐。 |
| MaxDropDownHeight | *double* | *(自动计算)* | 选择列表的最大高度。 |
| SearchDelay | *int* | *null* | 搜索延迟。 |
| ShadowColor | *Color?* | *null* | 控件的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |
| Text | *string* | *null* | 搜索框文本。 |
| Watermark | *object* | *null* | 占位符水印(Placeholder)。 |
| WatermarkForeground | *Brush* | *(自动计算)* | 占位符水印(Placeholder)的颜色。 |

 ## 事件 
| 事件 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| SearchTextChanged | *附加事件*| *null* | 搜索文本改变事件。 |
| ItemClick | *附加事件*| *null* | 点击子项事件。 |
| Opened | *附加事件*| *null* | 展开子项列表事件。 |

## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/searchbox-1-_theme_.gif"></img>

```xml
<pu:SearchBox
    Width="220"
    Height="26"
    Padding="10,0,30,0"
    VerticalAlignment="Center"
    CornerRadius="13"
    FocusedShadowColor="#C62F2F"
    FontSize="12"
    ItemsBorderBrush="#C62F2F"
    ItemsCornerRadius="4"
    ItemsForeground="#1E1E1E"
    ItemsHeight="35"
    ItemsHoverBackground="{x:Null}"
    ItemsHoverForeground="#C62F2F"
    Watermark="Search musics, vedios, radios" />
```

### 示例2
#### 这个示例将演示如何使用搜索框。
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/searchbox-2-_theme_.gif"></img>

```xml
<pu:SearchBox
    x:Name="SchBox"
    Width="220"
    Height="26"
    Padding="10,0,30,0"
    VerticalAlignment="Center"
    CornerRadius="13"
    FocusedShadowColor="#C62F2F"
    FontSize="12"
    ItemsBorderBrush="#C62F2F"
    ItemsCornerRadius="4"
    ItemsForeground="#1E1E1E"
    ItemsHeight="35"
    ItemsHoverBackground="{x:Null}"
    ItemsHoverForeground="#C62F2F"
    Opened="SchBox_Opened"
    SearchTextChanged="SchBox_SearchTextChanged"
    ItemClick="SchBox_ItemClick"
    Watermark="Search musics, vedios, radios"/>
```

```xml
private readonly List<string> _searchList = new List<string>()
{
    "Beautiful - Said The Sky",
    "Buzz - Before You Exit",
    "Slience - Before You Exit",
    "Feels - WATTS/Khalid",
    "Shotgun - Us The Duo"
};  
```   
```xml 
private void SchBox_Opened(object sender, System.EventArgs e)
{
    var searchBox = sender as SearchBox;
    searchBox.ItemsSource = _searchList.ToList();
}
```
```xml 
private void SchBox_SearchTextChanged(object sender, SearchTextChangedRoutedEventArgs e)
{
    var searchBox = sender as SearchBox;
    var searchText = e.Text?.Trim()?.ToLower();

    searchBox.ItemsSource = string.IsNullOrEmpty(searchText)
    ? _searchList
    : _searchList.Where(x => x.ToLower().Contains(searchText)).ToList();
}
```
```xml 
private void SchBox_ItemClick(object sender, System.Windows.RoutedEventArgs e)
{
    //do something
}
```