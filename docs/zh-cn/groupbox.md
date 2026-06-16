# GroupBox 分组框

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.GroupBoxStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.GroupBoxHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="GroupBox">* 或 *<pu:KeyOnlyStyleDictionary Includes="GroupBox">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/GroupBox.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/GroupBoxStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性
以下属性包含在辅助类*GroupBoxHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框圆角。 |
| HeaderBackground | *Brush* | *null* | 表头的背景色。 |
| HeaderBorderBrush | *Brush* | *null* | 表头的边框色。 |
| HeaderBorderThickness | *Thickness* | *null* | 表头的边框粗细。 |
| HeaderCornerRadius | *CornerRadius* | *null* | 表头的的边框圆角。 |
| HeaderFontSize | *double* | *null* | 表头的字号。 |
| HeaderFontWeight | *FontWeight* | *null* | 表头的字体粗细。 |
| HeaderForeground | *Brush* | *null* | 表头的前景色。 |
| HeaderHeight | *double* | *null* | 表头的高度。 |
| HeaderHorizontalContentAlignment | *HorizontalAlignment* | *null* | 表头水平对齐方式。`Center`表示居中对齐，`Left`表示左对齐， `Right`表示右对齐， `Stretch`表示拉伸对齐。 |
| HeaderPadding | *Thickness* | *null* | 表头内边距。 |
| HeaderPlacement | *HeaderPlacement* | *Top* | 表头位置。`Bottom`表示底部，`Top`表示顶部。 |
| HeaderSeparatorBrush | *Brush* | *null* | 表头分隔符的颜色。 |
| HeaderSeparatorMargin | *Thickness* | *null* | 表头分隔符的外边距。 |
| HeaderSeparatorThickness | *double* | *null* | 表头分隔符的粗细。 |
| HeaderSeparatorVisibility | *Visibility* | *Collapsed* | 是否显示表头分隔符。 |
| HeaderShadowColor | *Color?* | *null* | 表头阴影。 |
| HeaderVerticalContentAlignment | *VerticalAlignment* | *null* | 表头垂直对齐方式。`Bottom`表示底部对齐`Center`表示居中对齐`Stretch`表示拉伸对齐`Top`表示顶部对齐。 |
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]()。 |
| ShadowColor | *Color?* | *null* | 	边框的阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |

## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/groupbox-1-_theme_.jpg"></img>

```xml
<GroupBox
    Width="200"
    Height="200"
    Padding="7,7,7,7"
    pu:GroupBoxHelper.CornerRadius="10,10,10,10"
    pu:GroupBoxHelper.HeaderBackground="#FFD0DDEE"
    pu:GroupBoxHelper.HeaderBorderBrush="#00FFFFFF"
    pu:GroupBoxHelper.HeaderCornerRadius="10,10,0,0"
    pu:GroupBoxHelper.HeaderHeight="35"
    pu:GroupBoxHelper.HeaderHorizontalContentAlignment="Left"
    BorderBrush="#FFD0DDEE"
    Header="Header" />
```
