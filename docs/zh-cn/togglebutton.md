# ToggleButton 状态按钮

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.ToggleButtonStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.ToggleButtonHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="ToggleButton">* 或 *<pu:KeyOnlyStyleDictionary Includes="ToggleButton">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/ToggleButton.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/ToggleButtonStyle.xaml*

---

## 小提示
1. 当状态按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  
2. 默认情况下，`HoverBackground`和`ClickBackground`的值会与`Background`属性绑定，并通过转换器转换成更浅的颜色。如果将`Background`设置为渐变色，则转换不会生效，悬浮和点击时不会出现颜色变化。如果不需要显示悬浮颜色和点击颜色，可以将相应属性的值设置为 `null` (在XAML中为 `{x:Null}` )。  
3. *IconHelper.Margin*属性的默认值是`0,0,5,0`。当`IconPlacement`属性的值不是`Left`时，可能需要微调图标的显示位置。  

## 属性
以下属性包含在辅助类*ToggleButtonHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CheckedBackground | *Brush* | *(自动计算)* | 选中时的背景色。值为`null`时，选中不出现变化。 |
| CheckedBorderBrush | *Brush* | *null* | 选中时的边框色。值为`null`时，选中不出现变化。 |
| CheckedBorderThickness | *Thickness?* | *null* | 选中时的边框粗细。值为`null`时，选中不出现变化。 |
| CheckedContent | *object* | *null* | 占位符文本内容，可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| CheckedCornerRadius | *CornerRadius?* | *null* | 选中时的边框圆角。值为`null`时，选中不出现变化。 |
| CheckedForeground | *Brush* | *null* | 选中时的前景色。值为`null`时，选中不出现变化。 |
| CheckedIcon | *object* | *null* | 选中时的图标或符号。可以是文本或图片路径，也可以是控件。图标的位置可以通过`IconPlacement`属性控制。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 | 
| CheckedShadowColor | *Color?* | *null* | 选中时的阴影色。值为`null`时，选中不出现变化。 |
| ClickBackground | *Brush* | *(自动计算)* | 点击时的背景色。值为`null`时，点击不出现变化。 |
| ClickBorderBrush | *Brush* | *null* | 点击时的边框色。值为`null`时，点击不出现变化。 |
| ClickBorderThickness | *Thickness?* | *null* | 点击时的边框粗细。值为`null`时，点击不出现变化。 |
| ClickCornerRadius | *CornerRadius?* | *null* | 点击时的边框圆角。值为`null`时，点击不出现变化。 |
| ClickForeground | *Brush* | *null* | 点击时的前景色。值为`null`时，点击不出现变化。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| HoverCornerRadius | *CornerRadius?* | *null* | 悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，获得键盘焦点不出现变化。 
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。图标的位置可以通过`IconPlacement`属性控制。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| IconPlacement | *IconPlacement* | *Left* | 图标的位置。`Left` 表示显示在内容的左侧，`Top` 表示显示在内容的上方，`Right` 表示显示在内容的右侧，`Bottom` 表示显示在内容的下方。 |
| IsPending | *bool* | *false* | 是否处于等待状态。等待状态下会在内容左侧显示一个*Spin 旋转* 控件，但不会禁用状态按钮。*Spin 旋转* 控件的样式可以通过`PendingSpinStyle`属性控制。与旧版本不同，当 `IsPending=True` 时，状态按钮不会被禁用。若要实现该效果，可以通过在Style中添加Trigger的方式来实现。 |
| PendingSpinStyle | *Style* | *(见内部资源键)* | 等待状态时显示的*Spin 旋转* 控件样式。 |
| ShadowColor | *Color?* | *null* | 控件的阴影。值为`null`时，不显示阴影。阴影的细节可以通过*ShadowHelper 阴影*辅助类控制。 |

## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/togglebutton-1-_theme_.jpg"></img>

```xml
<ToggleButton Content="ToggleButton" Height="40" Width="170" 
        pu:ToggleButtonHelper.CornerRadius="4" 
        Background="#36AAF7" Foreground="#FFFFFF"
        pu:ToggleButtonHelper.Icon="&#xe939;" pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}" pu:IconHelper.Margin="0,0,10,0"
        pu:ToggleButtonHelper.ShadowColor="#36AAF7" pu:ShadowHelper.BlurRadius="15" pu:ShadowHelper.ShadowDepth="5" />
```

### 示例2
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/togglebutton-2-_theme_.gif"></img>

```xml
<ToggleButton Content="ToggleButton" Height="40" Width="170" 
        pu:ToggleButtonHelper.CornerRadius="4"
        Background="#36AAF7" Foreground="#FFFFFF"
        pu:ToggleButtonHelper.IsPending="True">
    <pu:ToggleButtonHelper.PendingSpinStyle>
        <Style TargetType="pu:Spin" BasedOn="{StaticResource {x:Static pu:ToggleButtonHelper.PendingSpinStyleKey}}">
            <Setter Property="Margin" Value="0,0,10,0" />
            <Setter Property="SpinStyle" Value="Ring2" />
        </Style>
    </pu:ToggleButtonHelper.PendingSpinStyle>
</ToggleButton>
```

## 内部资源键

### PendingSpinStyle
`{StaticResource {x:Static pu:ToggleButtonHelper.PendingSpinStyleKey}}`  
控件类型：*pu:Spin 旋转*  
等待状态的Spin样式。  

示例：
```xml
<!--将Spin样式改为半圆环-->
<ToggleButton pu:ToggleButtonHelper.IsPending="True">
    <pu:ToggleButtonHelper.PendingSpinStyle>
        <Style TargetType="{x:Type pu:Spin}" BasedOn="{StaticResource {x:Static pu:ToggleButtonHelper.PendingSpinStyleKey}}">
            <Setter Property="SpinStyle" Value="Ring" />
        </Style>
    </pu:ToggleButtonHelper.PendingSpinStyle>
</ToggleButton>
```
