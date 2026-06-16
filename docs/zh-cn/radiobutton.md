# RadioButton 单选按钮

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.RadioButtonStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.RadioButtonHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="RadioButton">* 或 *<pu:KeyOnlyStyleDictionary Includes="RadioButton">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/RadioButton.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/RadioButtonStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。    

## 属性
以下属性包含在辅助类*RadioButtonHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| BoxRadius | *double* | *null* | 勾选框半径。 |
| CheckedBackground | *Brush* | *null* | 被选中时的背景色。值为`null`时，被选中时不出现变化。 |
| CheckedBorderBrush | *Brush* | *null* | 被选中时的边框色。值为`null`时，被选中时不出现变化。 |
| CheckedBorderThickness | *Thickness?* | *null* | 被选中的边框粗细。值为`null`时，被选中时不出现变化。 |
| CheckedContent | *object* | *null* | 被选中时的内容。 |
| CheckedForeground | *Brush* | *null* | 被选中时的前景色。值为`null`时，被选中时不出现变化。 |
| CheckedShadowColor | *Color?* | *null* | 被选中时的阴影色。值为`null`时，被选中时不出现变化。 |
| CheckedToggleBrush | *Brush* | *null* | 被选中时的内圆钮颜色。 |
| ContentPlacement | *ContentPlacement* | *Right* | 内容的位置。Left 表示显示在复选框的左侧，Right 表示显示在复选框的右侧。 |
| HoverBackground | *Brush* | *null* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，悬浮不出现变化。 |
| HoverToggleBrush | *Brush* | *null* | 悬浮时的内圆钮颜色。值为`null`时，悬浮不出现变化。 |
| NullBackground | *Brush* | *null* | 状态未确定时的背景色。值为`null`时，不出现变化。 |
| NullBorderBrush | *Brush* | *null* | 状态未确定时的边框色。值为`null`时，不出现变化。 |
| NullBorderThickness | *Thickness?* | *null* | 状态未确定时的边框粗细。值为`null`时，不出现变化。 |
| NullForeground | *Brush* | *null* | 状态未确定时的前景色。值为`null`时，不出现变化。 |
| NullToggleBrush | *Brush* | *null* | 状态未确定时内圆钮颜色。值为`null`时，不出现变化。 |
| ShadowColor | *Color?* | *null* | 阴影色。值为`null`时，不出现变化。 |
| ToggleBrush | *Brush* | *null* | 内圆钮颜色。值为`null`时，不出现变化。 |
| ToggleRadius | *double* | *null* | 内圆钮半径。 |


## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/radiobutton-1-_theme_.gif"></img>

```xml
<RadioButton
    HorizontalAlignment="Center"
    VerticalAlignment="Center"
    HorizontalContentAlignment="Center"
    pu:RadioButtonHelper.BoxRadius="30"
    pu:RadioButtonHelper.CheckedBorderBrush="#d1d6d8"
    pu:RadioButtonHelper.CheckedBorderThickness="8"
    Background="#FFFFFFFF"
    BorderBrush="#FFABB7CB"
    BorderThickness="8">
    <pu:RadioButtonHelper.CheckedToggleBrush>
<LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
    <GradientStop Offset="0.0" Color="#FFFD790D" />
    <GradientStop Offset="1.0" Color="#FFFFFFFF" />
</LinearGradientBrush>
    </pu:RadioButtonHelper.CheckedToggleBrush>
    <pu:RadioButtonHelper.ToggleBrush>
<LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
    <GradientStop Offset="0.0" Color="#FFE1E1E1" />
    <GradientStop Offset="1.0" Color="#FFFFFFFF" />
</LinearGradientBrush>
    </pu:RadioButtonHelper.ToggleBrush>
</RadioButton>
```