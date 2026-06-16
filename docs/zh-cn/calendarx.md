# CalendarX 日历

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| Animation | *CarouselAnimation* | *Slide* | 切换页面时的动画效果。`Fade`表示淡入淡出， `Flow`表示流动 `Scale`表示缩放 `Slide`表示滑动。 |
| AnimationEasing | *AnimationEasing* | *None* | 切换页面时的动画缓动函数。有关WPF缓动函数的更多信息，请查看[*WPF缓动函数文档*]()。 |
| AnimationDuration | *TimeSpan* | *0:0:0* | 动画的持续时间。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| Culture | *CultureInfo* | *默认* | 特定的文化信息。 |
| FirstDayOfWeek | *DayOfWeek* | *Sunday* | 每周的第一天。 |
| HeaderHeight | *string* | *null* | 标题高度。 |
| HeaderSeparatorBrush | *Brush* | *null* | 标题分隔符的边框色。 |
| HeaderSeparatorMargin | *Thickness* | *null* | 标题分隔符的外边距。 |
| HeaderSeparatorThickness | *double* | *null* | 标题分隔符边框粗细。 |
| HeaderSeparatorVisibility | *Visibility* | *Collapsed* | 是否显示标题分隔符。`Collapsed`和`Hidden`表示不可见，`Visible`表示可见。 |
| IsTodayHighlighted | *bool* | *false* | 是否将当天日期高亮显示。 |
| ItemsBackground | *Brush* | *null* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |
| ItemsBorderThickness | *Thickness?* | *null* | 子项的边框粗细。 |
| ItemsCheckedBackground | *Brush* | *null* | 子项被选中的背景色。值为`null`时，选中不出现变化。 |
| ItemsCheckedBorderBrush | *Brush* | *null* | 子项被选中的边框色。值为`null`时，选中不出现变化。 |
| ItemsCheckedBorderThickness | *Thickness?* | *null* | 子项被选中的边框粗细。值为`null`时，选中不出现变化。 |
| ItemsCheckedCornerRadius | *CornerRadius?* | *null* | 子项被选中的边框圆角。值为`null`时，选中不出现变化。 |
| ItemsCheckedForeground | *Brush* | *null* | 子项被选中的前景色。值为`null`时，选中不出现变化。 |
| ItemsCheckedShadowColor | *Color?* | *null* | 子项被选中的阴影色。值为`null`时，选中不出现变化。 |
| ItemsCornerRadius | *CornerRadius* | *null* | 子项的边框圆角。 |
| ItemsForeground | *Brush* | *null* | 子项的前景色。 |
| ItemsHoverBackground | *Brush* | *(自动计算)* | 子项悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderThickness | *Thickness?* | *null* | 子项悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| ItemsHoverCornerRadius | *CornerRadius?* | *null* | 子项悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverShadowColor | *Color?* | *null* | 子项悬浮时的阴影色。 |
| ItemsShadowColor | *Color?* | *null* | 子项阴影色。 |
| ItemsSpecialDayHighlightTemplate | *DataTemplate* | *null* | 当天日期高亮显示样式。 |
| Mode | *CalendarXMode* | *Date* | 日期时间选择器的显示模式。`Date`: 只选择日期，不包括时间，以年、月、日的形式表示。`Month`: 只选择月份，不包括日期和年份。通常表示一年中的具体月份。`Year`: 只选择年份，不包括具体的月份和日期。通常用于选择特定的年份。 |
| SelectedDate | *DateTime* | *null* | 选中的日期时间。 |
| ShadowColor | *Color?* | *null* | 边框的阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |
| MaxDate | *DateTime* | *null* | 最大日期。 |
| MinDate | *DateTime* | *null* | 最小日期。 |
| YearStringFormat | *string* | *null* | 日期格式。 |

## 示例

### 示例1
<img height="300" src="https://assets.panuon.com/images/samples/wpf-ui/calendarx-1-_theme_.gif"></img>

```xml
<pu:CalendarX IsTodayHighlighted="True"
    Height="300"
    Width="300"
    ItemsHoverBackground="#36AAF7"
    ItemsCheckedCornerRadius="10,10,10,10"
    ItemsCheckedBackground="#36AAF7" 
    ItemsHoverCornerRadius="10,10,10,10"
    Background="#FFFFFF"       
    HeaderSeparatorVisibility="Visible"  
    HeaderSeparatorThickness="1"/>
```

  
  


  
  