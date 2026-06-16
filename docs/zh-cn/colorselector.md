# ColorSelector 颜色下拉框

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ColorEditors | *ColorEditors* | *null* | 颜色编辑器。`ARGB`表示支持编码方式，`Both`表示支持同时支持`ARGB`和`HEX`，`HEX`表示支持十六进制，`None`表示没有选择任何特定的颜色表示方式。 | 
| EditorPanelMargin | *Thickness* | *null* | 颜色编辑器面板外边距。 | 
| SelectedColor | *Color* | *null* | 当前选中颜色。 | 
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 | 
| ColorEditorTagVisibility | *Visibility* | *Visible* | 是否显示标记颜色编辑器。 | 
| ColorChannels | *ColorChannels* | *null* | 颜色通道模式（`ARGB`、`RGB`）。 |

## 事件 
| 事件 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| SelectedColorChanged | *附加事件* | *null* | 颜色选择改变事件。 |

## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/colorselector-1-_theme_.gif"></img>

```xml
<pu:ColorSelector
    Width="300"
    Height="250"
    Padding="5,0"
    Background="White"
    ColorChannels="ARGB"
    ColorEditors="HEX"
    CornerRadius="2"
    SelectedColor="White" />
```





