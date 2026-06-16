# Badge 徽章

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| AnimationDuration | *TimeSpan* | *null* | 展开/收起动画的持续时间。值为`null`或`0`时，不会执行动画效果。 |
| AnimationEasing | *AnimationEasing* | *None* | 展开/收起动画的缓动函数。有关WPF缓动函数的更多信息，请查看[*WPF缓动函数文档*]()。 |
| ClickBackground | *Brush* | *(自动计算)* | 点击时的背景色。值为`null`时，点击不出现变化。 |
| ClickBorderBrush | *Brush* | *null* | 点击时的边框色。值为`null`时，点击不出现变化。 |
| ClickBorderThickness | *Thickness?* | *null* | 点击时的边框粗细。值为`null`时，点击不出现变化。 |
| ClickCornerRadius | *CornerRadius?* | *null* | 点击时的边框圆角。值为`null`时，点击不出现变化。 |
| ClickEffect | *ClickEffect* | *None* | 点击特效。`None`表示没有点击特效，`Sink`表示点击时下沉，`Shake`表示点击时抖动。 |
| ClickForeground | *Brush* | *null* | 点击时的前景色。值为`null`时，点击不出现变化。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| HoverCornerRadius | *CornerRadius?* | *null* | 悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，悬浮不出现变化。 |
| IsWaving | *bool* | *null* | 是否开启波纹。 |
| ShadowColor | *Color?* | *null* | 控件的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |
| WaveBrush | *Brush* | *null* | 波纹颜色。值为`null`时，开启波纹时不出现变化。 |
| WaveScale | *double* | *null* | 波纹的缩放比例。 |
| WaveThickness | *Thickness* | *null* | 波纹粗细。 |

## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/badge-1-_theme_.gif"></img>

```xml
<pu:Badge
    Width="40"
    Height="40"
    Background="White"
    Content="1"
    CornerRadius="40,40,40,40"
    IsWaving="True"
    WaveBrush="#36AAF7"
    WaveThickness="5" />
```

### 示例2
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/badge-2-_theme_.gif"></img>

```xml
<pu:Badge
    Width="40"
    Height="40"
    Background="#33a3eb"
    BorderBrush="#2b6f9e"
    BorderThickness="2"
    Content="&#xe989;"
    CornerRadius="5,5,70,70"
    FontFamily="{StaticResource PanuonIconFont}"
    FontSize="20"
    Foreground="White"
    IsWaving="True"
    WaveBrush="#33a3eb"
    WaveThickness="10" />
```







