# RingProgressBar 环形进度条

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| AnimationDuration | *TimeSpan* | *null* |动画的持续时间。值为`null`或`0`时，不会执行动画效果。 |
| AnimationEasing | *AnimationEasing* | *null* | 动画的缓动函数。有关WPF缓动函数的更多信息，请查看[*WPF缓动函数文档*]()。 |
| BorderThickness | *double* | *null* | 边框粗细。 |
| FilledBorderBrush | *Brush* | *null* | 填充后颜色。 |
| IsPercentVisible | *bool* | *false* | 是否显示百分比。 |
| PercentStringFormat | *string* | *null* | 百分比字符串格式。 |
| ShadowColor | *Color?* | *null* | 控件的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |

## 事件 
| 事件 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ValueChanged | *附加事件* | *null* | 处理控件的值变化事件。 |

## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/ringprogressbar-1-_theme_.jpg"></img>

```xml
<pu:RingProgressBar
    Width="200"
    Height="200"
    Background="#00FFFFFF"
    BorderBrush="#eaf5f6"
    BorderThickness="20"
    Foreground="#FF6CBCEA"
    IsPercentVisible="True"
    Value="50" />
```
 

