# ColorPicker 颜色选择器

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ClearButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 清空按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnNonnull` 表示当单选下拉框的文本不为空时显示，`VisibleOnHover` 表示当鼠标悬浮在单选下拉框上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在单选下拉框上且文本不为空时显示，`VisibleOnFocused` 表示当单选下拉框获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当单选下拉框获得键盘焦点且文本不为空时显示 |
| ColorChannels | *ColorChannels* | *null* | 颜色通道。 |
| ColorEditors | *ColorEditors* | *null* | 颜色编辑器。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| DefaultColor | *Color?* | *null* | 默认颜色。 |
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
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，悬浮不出现变化。 |
| PreviewTemplate | *DataTemplate* | *null* | 预览样式。 |
| SelectedColor | *Color?* | *null* | 当前选中颜色。 |
| StaysOpen | *bool* | *null* | 是否保持打开。 |
| ShadowColor | *Color?* | *null* | 控件的阴影。值为`null`时，不显示阴影。阴影的细节可以通过ShadowHelper 阴影辅助类控制。 |
| TextFormats | *ColorTextFormats* | *null* | 文本格式。 |
| Text | *string* | *null* | 文本。 |
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。图标的位置可以通过IconPlacement属性控制。要更改图标的间距、字体等属性，请查看 [*IconHelper 图标*]()。 |
| IsDropDownOpen | *bool* | *null* | 是否打开菜单。 |
| IsEditable | *bool* | *false* | 是否可编辑。 |
| Watermark | *object* | *null* | 占位符水印(Placeholder)。 |
| WatermarkForeground | *Brush* | *(自动计算)* | 占位符水印(Placeholder)的颜色。 |

### 示例1
<img height="300" src="https://assets.panuon.com/images/samples/wpf-ui/colorpicker-1-_theme_.gif"></img>

```xml
 <pu:ColorPicker
    Width="250"
    Height="50"                 
    Padding="5,0"
    pu:DropDownHelper.Height="250"
    pu:DropDownHelper.ShadowColor="#35303D"
    pu:DropDownHelper.Width="250"
    Background="White"
    ClearButtonVisibility="VisibleOnHoverAndNonnull"
    ColorChannels="ARGB"
    ColorEditors="HEX"
    CornerRadius="2"
    DefaultColor="{x:Null}"
    FocusedBorderBrush="#36AAF7"
    FocusedShadowColor="#6CBCEA"
    IsEditable="True"
    SelectedColor="White"
    TextFormats="ARGB"
    Watermark="选择一个颜色" />
```














