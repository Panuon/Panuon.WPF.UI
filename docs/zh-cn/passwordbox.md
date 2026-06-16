# PasswordBox 密码输入框

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.PasswordBoxStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.PasswordBoxHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="PasswordBox">* 或 *<pu:KeyOnlyStyleDictionary Includes="PasswordBox">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/PasswordBox.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/PasswordBoxStyle.xaml*

---

## 小提示
1. 当输入框被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  
2. 默认情况下，`WatermarkForeground`会与`Foreground`属性绑定，并通过转换器转换成更浅的颜色。如果将`Foreground`设置为渐变色，则转换不会生效，占位符的。  

## 属性
以下属性包含在辅助类*PasswordBoxHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| ClearButtonStyle | *Style* | *(见内部资源键)* | 清空按钮的 Button 按钮 控件样式。 |
| ClearButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 清空按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnNonnull` 表示当输入框的文本不为空时显示，`VisibleOnHover` 表示当鼠标悬浮在输入框上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在输入框上且文本不为空时显示，`VisibleOnFocused` 表示当输入框获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当输入框获得键盘焦点且文本不为空时显示。 |
| FocusedBackground | *Brush* | *null* | 获得键盘焦点时的背景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderBrush | *Brush* | *null* | 获得键盘焦点时的边框色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderThickness | *Thickness?* | *null* | 获得键盘焦点时的边框粗细。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedCornerRadius | *CornerRadius?* | *null* | 获得键盘焦点时的边框圆角。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedForeground | *Brush* | *null* | 获得键盘焦点时的前景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedWatermarkForeground | *Brush* | *null* | 获得键盘焦点时的占位符水印(Placeholder)前景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedShadowColor | *Color?* | *null* | 获得键盘焦点时的阴影色。值为`null`时，获得键盘焦点不出现变化。
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| HoverCornerRadius | *CornerRadius?* | *null* | 悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，获得键盘焦点不出现变化。 |
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看IconHelper 图标。 |
| IsReadOnly | *bool* | *false* | 是否处于只读模式。如果设置为 `True`，则无法编辑 PasswordBox 中的文本内容。 | 
| Password | *object* | *null* | 占位符文本内容。 |
| SelectAllOnFocus | *bool* | *false* | 获得焦点时是否全选。 |
| ShadowColor | *Color?* | *null* | 输入框的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |
| Watermark | *object* | *null* | 占位符水印(Placeholder)。 |
| WatermarkForeground | *Brush* | *(自动计算)* | 占位符水印(Placeholder)的颜色。 |

## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/passwordbox-1-_theme_.gif"></img>

```xml
<PasswordBox Height="35" Width="200"
         pu:PasswordBoxHelper.CornerRadius="4" 
         pu:PasswordBoxHelper.ClearButtonVisibility="VisibleOnHover" pu:PasswordBoxHelper.PlainButtonVisibility="VisibleOnHover"
         pu:PasswordBoxHelper.Icon="&#xe966;" pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}"
         pu:PasswordBoxHelper.Watermark="Input your password"
         pu:PasswordBoxHelper.FocusedForeground="#36AAF7" pu:PasswordBoxHelper.FocusedBorderBrush="#36AAF7" 
         pu:PasswordBoxHelper.FocusedShadowColor="#36AAF7"
         pu:ShadowHelper.Opacity="0.5" pu:ShadowHelper.BlurRadius="15" pu:ShadowHelper.ShadowDepth="5" />
```


## 内部资源键

### ClearButtonStyle
`{StaticResource {x:Static pu:PasswordBoxHelper.ClearButtonStyleKey}}`  
控件类型：Button 按钮
清空按钮的样式。  

示例：
```xml
<!--修改清空按钮的图标-->
<PasswordBox>
    <pu:PasswordBoxHelper.ClearButtonStyle>
         <Style BasedOn="{StaticResource {x:Static pu:PasswordBoxHelper.ClearButtonStyleKey}}" TargetType="Button">
             <Setter Property="Content" Value="&#xe933;" />
         </Style>
    </pu:PasswordBoxHelper.ClearButtonStyle>
</PasswordBox>
```