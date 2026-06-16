# TextBox 输入框

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.TextBoxStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.TextBoxHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="TextBox">* 或 *<pu:KeyOnlyStyleDictionary Includes="TextBox">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/TextBox.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/TextBoxStyle.xaml*
  
> 早期翻译工作不充分，为了做好国际化，在后续的大版本中，以下内容可能会重命名。请留意更新说明。  
Watermark -> Placeholder  
Nonnull -> NotEmpty
  
---

## 小提示
1. 当输入框被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。    
2. 默认情况下，`WatermarkForeground`的值会与`Foreground`属性绑定，并通过转换器转换成更浅的颜色。如果将`Foreground`设置为渐变色，则转换不会生效，占位符的。
3. 请勿将`HoverForeground`属性设置为渐变色，这会在悬浮时抛出底层异常（WPF的历史遗留问题）。如果不需要显示悬浮颜色和获得键盘焦点颜色，可以将相应属性的值设置为 `null` (在XAML中为 `{x:Null}` )。  

## 属性
以下属性包含在辅助类*TextBoxHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| ClearButtonStyle | *Style* | *(见内部资源键)* | 清空按钮的 _Button 按钮_ 控件样式。 |
| ClearButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 清空按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnNonnull` 表示当输入框的文本不为空时显示，`VisibleOnHover` 表示当鼠标悬浮在输入框上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在输入框上且文本不为空时显示，`VisibleOnFocused` 表示当输入框获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当输入框获得键盘焦点且文本不为空时显示。 |
| FocusedBackground | *Brush* | *null* | 获得键盘焦点时的背景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderBrush | *Brush* | *null* | 获得键盘焦点时的边框色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderThickness | *Thickness?* | *null* | 获得键盘焦点时的边框粗细。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedCornerRadius | *CornerRadius?* | *null* | 获得键盘焦点时的边框圆角。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedForeground | *Brush* | *null* | 获得键盘焦点时的前景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedWatermarkForeground | *Brush* | *null* | 获得键盘焦点时的占位符水印(Placeholder)前景色。值为`null`时，获得键盘焦点不出现变化。 |
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| HoverCornerRadius | *CornerRadius?* | *null* | 悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，获得键盘焦点不出现变化。 |
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| IsPending | *bool* | *false* | 是否处于等待状态。等待状态下会在内容左侧显示一个*Spin 旋转* 控件，但不会禁用输入框。*Spin 旋转* 控件的样式可以通过`ClearButtonStyle`属性控制。 |
| ShadowColor | *Color?* | *null* | 输入框的阴影。值为`null`时，不显示阴影。阴影细节可以通过*ShadowHelper 阴影*辅助类控制。 |
| Watermark | *object* | *null* | 占位符水印(Placeholder)。 |
| WatermarkForeground | *Brush* | *(自动计算)* | 占位符水印(Placeholder)的颜色。 |

## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/textbox-1-_theme_.gif"></img>

```xml
<TextBox Height="35" Width="200" Padding="10,0"
         pu:TextBoxHelper.CornerRadius="4"
         BorderBrush="Gray" BorderThickness="1.5"
         pu:TextBoxHelper.FocusedBorderBrush="#36AAF7" pu:TextBoxHelper.FocusedForeground="#36AAF7"
         pu:TextBoxHelper.Watermark="Input your text" pu:TextBoxHelper.WatermarkForeground="Gray" pu:TextBoxHelper.FocusedWatermarkForeground="LightGray"
         pu:TextBoxHelper.ClearButtonVisibility="VisibleOnHover" />
```

### 示例2
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/textbox-2-_theme_.gif"></img>

```xml
<TextBox Height="35" Width="200"
         pu:TextBoxHelper.CornerRadius="4"
         pu:TextBoxHelper.Icon="&#xe939;" pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}"
         pu:TextBoxHelper.Watermark="Input your text"
         pu:TextBoxHelper.FocusedForeground="#36AAF7" pu:TextBoxHelper.FocusedBorderBrush="#36AAF7" 
         pu:TextBoxHelper.FocusedShadowColor="#36AAF7"
         pu:ShadowHelper.Opacity="0.5" pu:ShadowHelper.BlurRadius="15" pu:ShadowHelper.ShadowDepth="5" />
```

## 内部资源键

### ClearButtonStyle
`{StaticResource {x:Static pu:TextBoxHelper.ClearButtonStyleKey}}`  
控件类型：*Button 按钮*  
清空按钮的样式。  

示例：
```xml
<!--修改清空按钮的图标-->
<TextBox>
    <pu:TextBoxHelper.ClearButtonStyle>
        <Style TargetType="Button" BasedOn="{StaticResource {x:Static pu:TextBoxHelper.ClearButtonStyleKey}}">
            <Setter Property="Content" Value="&#xe933;" />
        </Style>
    </pu:TextBoxHelper.ClearButtonStyle>
</TextBox>
```