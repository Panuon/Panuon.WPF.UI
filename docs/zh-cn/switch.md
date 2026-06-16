# Switch 开关


## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| BoxHeight | *double* | *null* | 控件的高度。 | 
| BoxTemplate | *DataTemplate* | *null* | 控件的样式。 | 
| BoxWidth | *double* | *null* | 控件的宽度。 | 
| CheckedBackground | *Brush* | *(自动计算)* | 选中时的背景色。值为`null`时，选中不出现变化。 | 
| CheckedBorderBrush | *Brush* | *null* | 选中时的边框色。值为`null`时，选中不出现变化。 | 
| CheckedBorderThickness | *Thickness?* | *null* | 选中时的边框粗细。值为`null`时，选中不出现变化。 | 
| CheckedContent | *object* | *null* | 选中时的内容。 |
| CheckedCornerRadius | *CornerRadius?* | *null* | 选中时的边框的圆角。值为`null`时，选中不出现变化。 |
| CheckedForeground | *Brush* | *null* | 选中时的内容前景色。值为`null`时，选中不出现变化。 | 
| CheckedShadowColor | *Color?* | *null* | 选中时的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 | 
| CheckedToggleBrush | *Brush* | *null* | 选中时圆点的前景色。值为`null`时，选中不出现变化。 | 
| CheckedToggleCornerRadius | *CornerRadius?* | *null* | 选中时圆点的边框圆角。值为`null`时，选中不出现变化。 | 
| CheckedToggleShadowColor | *Color?* | *null* | 选中时圆点的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 | 
| ContentPlacement | *ContentPlacement* | *Right* | 内容的位置。`Left`表示在左边，`Right`表示在右边。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 | 
| CheckedToggleSize | *double?* | *null* | 选中时圆点的大小。 | 
| GroupName | *string* | *null* | 控件组名字。当设置名称为一样时，只能单选。 | 
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 | 
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 | 
| HoverCornerRadius | *CornerRadius?* | *null* | 悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 | 
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 | 
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |
| HoverToggleBrush | *Brush* | *null* | 悬浮时圆点的前景色。值为`null`时，悬浮不出现变化。 | 
| HoverToggleCornerRadius | *CornerRadius?* | *null* | 悬浮时圆点的边框圆角。值为`null`时，悬浮不出现变化。 |
| HoverToggleShadowColor | *Color?* | *null* | 悬浮时圆点的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 | 
| HoverToggleSize | *double?* | *null* | 悬浮时圆点的大小。值为`null`时，悬浮不出现变化。 | 
| ShadowColor | *Color?* | *null* | 控件的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 | 
| ToggleCornerRadius | *CornerRadius* | *null* | 圆点的边框圆角。 | 
| ToggleShadowColor | *Color?* | *null* | 圆点的阴影。值为`null`时，不显示阴影。 | 
| ToggleSize | *double* | *null* | 圆点的大小。 | 
| ToggleBrush | *Brush* | *null* | 圆点的前景色。值为`null`时，不出现变化。 | 

## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/switch-1-_theme_.gif"></img>

```xml
<pu:Switch
    BorderBrush="#030303"
    BoxHeight="30"
    BoxWidth="60"
    CheckedBackground="#36abff"
    CheckedBorderBrush="#36abff"
    CheckedContent="开"
    CheckedToggleBrush="#FFFFFF"
    Content="关"
    ToggleBrush="#030303"
    ToggleSize="25"
    FontSize="25" />
```