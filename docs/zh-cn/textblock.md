# TextBlock 文本

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.TextBlockStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.TextBlockHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="TextBlock">* 或 *<pu:KeyOnlyStyleDictionary Includes="TextBlock">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/TextBlock.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/TextBlock.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性
以下属性包含在辅助类*TextBlockHelper*中。  
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| HighlightBackground | *Brush* | *null* | 高亮文本的背景色。 |
| HighlightForeground | *Brush* | *null* | 高亮文本的前景色。 |
| HighlightRegex | *string* | *null* | 正则表达式，用于匹配文本块中需要高亮的部分。 |
| HighlightRule | *HighlightRule* | *null* | 高亮显示的规则。`All`匹配的所有的文本高亮显示， `FirstOnly`匹配的第一个文本高亮显示。 |
| HighlightText | *string* | *null* | 高亮显示的文本。 |

## 示例
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/textblock-1-_theme_.gif"></img>

```xml
<TextBlock
    Width="300"
    Height="70"
    pu:TextBlockHelper.HighlightBackground="LightGray"
    pu:TextBlockHelper.HighlightForeground="Red"
    pu:TextBlockHelper.HighlightRule="FirstOnly"
    pu:TextBlockHelper.HighlightText="Panuon.WPF.UI！"
    Text="欢迎使用 Panuon.WPF.UI！" />
```