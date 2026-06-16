# IconHelper 图标辅助类

## 小提示
1. 当`Width`和`Height`的属性值未设置的时候，`VerticalAlignment`和`HorizontalAlignment`将会失效。


## 属性
以下属性包含在辅助类*IconHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| FontFamily | *FontFamily* | *MessageFontFamily* | 图标字体家族 |
| FontSize | *double* | *12* | 图标字体大小 |
| Foreground | *Brush* | *Black* | 图标前景色 |
| Height | *double* | *null* | 图标的高度 |
| HiddenOnNull | *bool* | *false* | 当图标内容为空`{x:Null}`时是否隐藏该图标，`True`表示即使图标内容为空，仍然显示该图标的位置或占位符、`False`表示当图标内容为空时，直接隐藏该图标，不占据任何布局空间 |
| HorizontalAlignment | *HorizontalAlignment* | *Center* | 图标的水平对齐方式，`Center`表示水平居中、`Left`表示左侧对齐、`Right`表示右侧对齐、`Stretch`表示拉伸填充 |
| MinHeight | *double* | *null* | 图标的最小高度 |
| MinWidth | *double* | *null* | 图标的最小宽度 |
| MaxHeight | *double* | *null* | 图标的最大高度 |
| MaxWidth | *double* | *null* | 图标的最大宽度 |
| Margin | *Thickness* | *null* | 图标的外边距。 |
| ToggleArrowFontSize | *double* | *12* | 切换箭头图标的字体大小 |
| ToolTip | *object* | *null* | 图标的提示内容 |
| VerticalAlignment | *VerticalAlignment* | *Center* | 图标的垂直对齐方式，`Bottom`表示底部对齐、`Center`表示垂直居中、`Stretch`表示拉伸填充、`Top`表示顶部对齐 |
| Width | *double* | *null* | 图标的宽度 |

### 示例
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/button-1-_theme_.jpg"></img>

```xml
<Button Content="Button" 
        Height="40" Width="170"      
        Background="#36AAF7" 
        Foreground="#FFFFFF"
        pu:ButtonHelper.CornerRadius="4" 
        pu:ButtonHelper.Icon="&#xe939;"
        pu:ButtonHelper.ShadowColor="#36AAF7"  
        pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}" 
        pu:IconHelper.Margin="0,0,10,0"
        pu:ShadowHelper.BlurRadius="15" 
        pu:ShadowHelper.ShadowDepth="5" />
``` 


 