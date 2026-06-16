# RepeatButton 重复按钮

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.RepeatButtonStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.RepeatButtonHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="RepeatButton">* 或 *<pu:KeyOnlyStyleDictionary Includes="RepeatButton">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/RepeatButton.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/RepeatButtonStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  
2. 默认情况下，`HoverBackground`和`ClickBackground`的值会与`Background`属性绑定，并通过转换器转换成更浅的颜色。如果将`Background`设置为渐变色，则转换不会生效，悬浮和点击时不会出现颜色变化。如果不需要显示悬浮颜色和点击颜色，可以将相应属性的值设置为 `null` (在XAML中为 `{x:Null}` )。  
3. *IconHelper.Margin*属性的默认值是`0,0,5,0`。当`IconPlacement`属性的值不是`Left`时，可能需要微调图标的显示位置。  

## 属性
以下属性包含在辅助类*RepeatButtonHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ClickBackground | *Brush* | *(自动计算)* | 点击时的背景色。值为`null`时，点击不出现变化。 |
| ClickBorderBrush | *Brush* | *null* | 点击时的边框色。值为`null`时，点击不出现变化。 |
| ClickBorderThickness | *Thickness?* | *null* | 点击时的边框粗细。值为`null`时，点击不出现变化。 |
| ClickCornerRadius | *CornerRadius?* | *null* | 点击时的边框圆角。值为`null`时，点击不出现变化。 |
| ClickForeground | *Brush* | *null* | 点击时的前景色。值为`null`时，点击不出现变化。 |
| ClickEffect | *ClickEffect* | *None* | 点击特效。`None` 表示没有点击特效，`Sink` 表示点击时下沉，`Shake` 表示点击时抖动。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| HoverCornerRadius | *CornerRadius?* | *null* | 悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，获得键盘焦点不出现变化。 |
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。图标的位置可以通过`IconPlacement`属性控制。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| IconPlacement | *IconPlacement* | *Left* | 图标的位置。`Left` 表示显示在内容的左侧，`Top` 表示显示在内容的上方，`Right` 表示显示在内容的右侧，`Bottom` 表示显示在内容的下方。 |
| IsPending | *bool* | *false* | 是否处于等待状态。等待状态下会在内容左侧显示一个*Spin 旋转* 控件，但不会禁用按钮。*Spin 旋转* 控件的样式可以通过`PendingSpinStyle`属性控制。 |
| PendingSpinStyle | *Style* | *(见内部资源键)* | 等待状态时显示的*Spin 旋转* 控件样式。 |
| ShadowColor | *Color?* | *null* | 控件的阴影。值为`null`时，不显示阴影。阴影细节可以通过*ShadowHelper 阴影*辅助类控制。 |

## 示例
### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/repeatbutton-1-_theme_.jpg"></img>

```xml
<RepeatButton
    Width="170"
    Height="40"
    pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}"
    pu:IconHelper.Margin="0,0,10,0"
    pu:RepeatButtonHelper.CornerRadius="4"
    pu:RepeatButtonHelper.Icon="&#xe939;"
    pu:RepeatButtonHelper.ShadowColor="#36AAF7"
    pu:ShadowHelper.BlurRadius="15"
    pu:ShadowHelper.ShadowDepth="5"
    Background="#36AAF7"
    Content="Button"
    Foreground="#FFFFFF" />
```