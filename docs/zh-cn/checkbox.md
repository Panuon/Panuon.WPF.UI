# CheckBox 复选框

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.CheckBoxStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.CheckBoxHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="CheckBox">* 或 *<pu:KeyOnlyStyleDictionary Includes="CheckBox">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/CheckBox.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/CheckBoxStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。   

## 属性
以下属性包含在辅助类*CheckBoxHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| BoxHeight | *double* | *null* | 复选框的框高度。 | 
| BoxWidth | *double* | *null* | 复选框的框宽度。 | 
| CheckedBackground | *Brush* | *null* | 被选中时的背景色。值为`null`时，被选中时不出现变化。 | 
| CheckedBorderBrush | *Brush* | *null* | 被选中时的边框色。值为`null`时，被选中时不出现变化。 | 
| CheckedBorderThickness | *Thickness?* | *null* | 被选中的边框粗细。值为`null`时，被选中时不出现变化。 | 
| CheckedContent | *object* | *null* | 被选中时的内容。 | 
| CheckedCornerRadius | *CornerRadius?* | *null* | 被选中时的边框圆角值为`null`时，被选中时不出现变化。 | 
| CheckedForeground | *Brush* | *null* | 被选中时的前景色。值为`null`时，被选中时不出现变化。 | 
| CheckedGlyphBrush | *Brush* | *null* | 被选中时的符号颜色。值为`null`时，被选中时不出现变化。 | 
| CheckedShadowColor | *Color?* | *null* | 被选中时的阴影色。值为`null`时，被选中时不出现变化。 | 
| ContentPlacement | *ContentPlacement* | *Right* | 内容的位置。`Left` 表示显示在复选框的左侧，`Right` 表示显示在复选框的右侧。 | 
| CornerRadius | *CornerRadius* | *0,0,0,0* | 未选中时的边框圆角。 | 
| GlyphBrush | *Brush* | *null* | 未选中时的符号颜色。值为`null`时，被选中时不出现变化。 |
| GlyphThickness | *double* | *null* | 未选中时的符号粗细。 | 
| HoverBackground | *Brush* | *null* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 | 
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 | 
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 | 
| HoverCornerRadius | *CornerRadius?* | *null* | 悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 | 
| HoverForeground | *Brush* | *null* | 	悬浮时的前景色。值为`null`时，悬浮不出现变化。 | 
| HoverGlyphBrush | *Brush* | *null* | 悬浮时的符号前景色。值为`null`时，悬浮不出现变化。被选中时，悬浮不出现变化。 | 
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，悬浮不出现变化。 | 
| NullBackground | *Brush* | *null* | 状态未确定时的背景色。值为`null`时，不出现变化。 | 
| NullBorderBrush | *Brush* | *null* | 状态未确定时的边框色。值为`null`时，不出现变化。 | 
| NullBorderThickness | *Thickness?* | *null* | 状态未确定时的边框粗细。值为`null`时，不出现变化。 |  
| NullForeground | *Brush* | *null* | 状态未确定时的前景色。值为`null`时，不出现变化。 | 
| NullGlyphBrush | *Brush* | *null* | 状态未确定时的符号前景色。值为`null`时，不出现变化。 | 
| ShadowColor | *Color?* | *null* | 阴影色。值为`null`时，不出现变化.。 | 

## 示例

### 示例1
<img height="50" src="https://assets.panuon.com/images/samples/wpf-ui/checkbox-1-_theme_.gif"></img>

```xml
 <CheckBox
    pu:CheckBoxHelper.BoxHeight="30"
    pu:CheckBoxHelper.BoxWidth="30"
    pu:CheckBoxHelper.CheckedBackground="#36AAF7"
    pu:CheckBoxHelper.CheckedBorderBrush="#36AAF7"
    pu:CheckBoxHelper.CheckedBorderThickness="2"
    pu:CheckBoxHelper.CheckedCornerRadius="5,5,5,5"
    pu:CheckBoxHelper.CheckedGlyphBrush="White"
    pu:CheckBoxHelper.CornerRadius="5,5,5,5"
    pu:CheckBoxHelper.GlyphBrush="LightGray"
    pu:CheckBoxHelper.GlyphThickness="4"
    BorderBrush="#afb8ba"
    BorderThickness="2"
    Content="CheckBox"
    FontSize="15"/>
```