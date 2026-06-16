# TimeSelector 时间选择器

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| Culture | *CultureInfo* | *默认* | 特定的文化信息。 |
| HeaderHeight | *string* | *null* | 标题的高度。 |
| HeaderSeparatorBrush | *Brush* | *null* | 标题分隔符色。值为`null`时，不出现变化。 |
| HeaderSeparatorMargin | *Thickness* | *null* | 	标题分隔符的间距。 |
| HeaderSeparatorThickness | *double* | *null* | 标题分隔符的粗细。 |
| HeaderSeparatorVisibility | *Visibility* | *Collapsed* | 是否显示标题分隔符。 |
| HourName | *string* | *null* | 小时名称。 |
| ItemContainerStyle | *Style* | *(见内部资源键)* | 子项容器样式。 |
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |
| ItemsBorderThickness | *Thickness* | *null* | 子项的边框粗细。 |
| ItemsCheckedBackground | *Brush* | *null* | 子项被选中时的背景色。值为`null`时，被选中时不出现变化。 |
| ItemsCheckedBorderBrush | *Brush* | *null* | 子项被选中时的边框色。值为`null`时，被选中时不出现变化。 |
| ItemsCheckedCornerRadius | *CornerRadius?* | *null* | 子项被选中时的边框圆角。值为`null`时，被选中时不出现变化。 |
| ItemsCheckedBorderThickness | *Thickness?* | *null* | 子项被选中时的边框粗细。值为`null`时，被选中时不出现变化。 |
| ItemsCheckedForeground | *Brush* | *null* | 子项被选中时的前景色。值为`null`时，被选中时不出现变化。 |
| ItemsCheckedShadowColor | *Color?* | *null* | 子项被选中时的阴影色。值为`null`时，被选中时不出现变化。 |
| ItemsCornerRadius | *CornerRadius* | *0,0,0,0* | 子项的边框圆角。 |
| ItemsForeground | *Brush* | *null* | 子项的前景色。 |
| ItemsHeight | *double* | *null* | 子项的高度。 |
| ItemsHoverBackground | *Brush* | *null* | 子项悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderThickness | *Thickness?* | *null* | 子项悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| ItemsHoverCornerRadius | *CornerRadius?* | *null* | 子项悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverShadowColor | *Color?* | *null* | 子项悬浮时的阴影色。值为`null`时，悬浮不出现变化。 |
| ItemsShadowColor | *Color?* | *null* | 子项的阴影色。值为`null`时，悬浮不出现变化。 |
| MaxTime | *DateTime* | *null* | 最大时间。 |
| MinTime | *DateTime* | *null* | 最小时间。 |
| MinuteName | *string* | *null* | 分钟名称。 |
| Mode | *TimeSelectorMode* | *Time* | 日期时间选择器的显示模式。 `Minute`表示显示小时、分， `Hour`表示显示小时， `Time`表示显示小时、分、秒。 |
| SecondName | *string* | *null* | 秒名称。 |
| SelectedTime | *DateTime* | *null* | 选定时间。 |
| ShadowColor | *Color?* | *null* | 阴影色。值为`null`时，不出现变化。 |
| TimeSeparatorBrush | *Brush* | *null* | 时间分隔符的颜色。 |
| TimeSeparatorMargin | *Thickness* | *0,0,0,0* | 时间分隔符的外边距。 |
| TimeSeparatorThickness | *double* | *null* | 时间分隔符的粗细。 |
| TimeSeparatorVisibility | *Visibility* | *Collapsed* | 是否显示时间分隔符。 |

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| SelectedTimeChanged | *附加事件* | *null* | 所选时间发生改变事件。 |

## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/timeselector-1-_theme_.gif"></img>

```xml
<pu:TimeSelector
    Width="300"
    Height="180"
    CornerRadius="10,10,10,10"  
    ItemsCheckedBackground="#36AAF7"
    ItemsCheckedBorderBrush="#36AAF7"
    ItemsCheckedBorderThickness="2"
    ItemsCheckedCornerRadius="5,5,5,5"                     
    ItemsCornerRadius="5,5,5,5"
    ItemsHoverBackground="#36AAF7"
    ItemsHoverCornerRadius="5,5,5,5"/>
```

