# Card 卡片

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ClickBackground | *Brush* | *(自动计算)* | 点击时的背景色。值为`null`时，点击不出现变化。 | 
| ClickForeground | *Brush* | *null* | 点击时的前景色。值为`null`时，点击不出现变化。 | 
| ClickBorderBrush | *Brush* | *null* | 点击时的边框色。值为`null`时，点击不出现变化。 | 
| ClickBorderThickness | *Thickness?* | *null* | 点击时的边框粗细。值为`null`时，点击不出现变化。 | 
| ClickEffect | *ClickEffect* | *None* | 点击特效。`None` 表示没有点击特效，`Sink` 表示点击时下沉，`Shake` 表示点击时抖动。 |  
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 | 
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 | 
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 | 
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 | 
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，获得键盘焦点不出现变化。 | 
| ShadowColor | *Color?* | *null* | 控件的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 | 

## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/card-1-_theme_.gif"></img>

```xml
<pu:Card
     pu:ShadowHelper.BlurRadius="30"
     pu:ShadowHelper.Direction="270"
     pu:ShadowHelper.Opacity="0.3"
     pu:ShadowHelper.ShadowDepth="15"
     Background="#3480F1"
     BorderThickness="0"
     ClickBackground="#1f4d91"
     CornerRadius="10"
     HoverBackground="#2a66c1"
     ShadowColor="#2a66c1" />
```




