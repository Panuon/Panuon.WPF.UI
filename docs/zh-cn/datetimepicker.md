# DateTimePicker 日期时间选择

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。
2. 如果要清除时为`null`，需要把`DefaultDateTime`值设为`null`，希望点击清除按钮后时间变为当天，请将`DefaultDateTime`设为`DateTime.Now`。

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ClearButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 清除按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnNonnull` 表示当日期控件的文本不为空时显示，`VisibleOnHover` 表示当鼠标悬浮在日期控件上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在日期控件上且文本不为空时显示，`VisibleOnFocused` 表示当日期控件获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当日期控件获得键盘焦点且文本不为空时显示。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框圆角。 |
| Culture | *CultureInfo* | *默认* | 特定的文化信息。 |
| DateTimeSeparatorBrush | *Brush* | *Gray* | 分隔符的颜色。 |
| DateTimeSeparatorMargin | *Thickness* | *0,0,0,0* | 分隔符的外边距。 |
| DateTimeSeparatorThickness | *double* | *1* | 分隔符的粗细。 |
| DateTimeSeparatorVisibility | *Visibility* | *Collapsed* | 是否显示分隔符。`Collapsed`和`Hidden`表示不可见，`Visible`表示可见。 |
| DefaultDateTime | *DateTime?* | *null* | 默认日期。 |
| FirstDayOfWeek | *DayOfWeek* | *Sunday* | 每周的第一天。 |
| FocusToEditor | *bool* | *null* | 是否将焦点集中到编辑器。 |
| FocusedBackground | *Brush* | *null* | 获得键盘焦点时的背景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderBrush | *Brush* | *null* | 获得键盘焦点时的边框色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderThickness | *Thickness?* | *null* | 获得键盘焦点时的边框粗细。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedCornerRadius | *CornerRadius?* | *null* | 获得键盘焦点时的边框圆角。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedForeground | *Brush* | *null* | 获得键盘焦点时的前景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedShadowColor | *Color?* | *null* | 获得键盘焦点时的阴影色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedWatermarkForeground | *Brush* | *null* | 获得键盘焦点时的占位符水印(Placeholder)前景色。值为`null`时，获得键盘焦点不出现变化。 |
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| HoverCornerRadius | *CornerRadius?* | *null* | 悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，悬浮不出现变化。 |
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| IsDropDownOpen | *bool* | *false* | 下拉框是否处于打开状态。 |
| IsEditable | *bool* | *true* | 是否可以编辑。 |
| InputTextStringFormat | *string* | *null* | 输入文本格式。 |
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |
| ItemsBorderThickness | *Thickness* | *null* | 子项的边框粗细。 |
| ItemsCheckedBackground | *Brush* | *null* | 子项被选中的背景色。 |
| ItemsCheckedBorderBrush | *Brush* | *null* | 子项被选中的边框色。 |
| ItemsCheckedBorderThickness | *Thickness?* | *null* | 子项被选中的边框粗细。 |
| ItemsCheckedCornerRadius | *CornerRadius?* | *null* | 子项被选中的边框圆角。 |
| ItemsCheckedForeground | *Brush* | *null* | 子项被选中的前景色。 |
| ItemsCheckedShadowColor | *Color?* | *null* | 子项被选中的阴影色。 |
| ItemsCornerRadius | *CornerRadius* | *null* | 子项的边框圆角。 |
| ItemsForeground | *Brush* | *null* | 子项的前景色。 |
| ItemsHoverBackground | *Brush* | *(自动计算)* | 子项悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderThickness | *Thickness?* | *null* | 子项悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| ItemsHoverCornerRadius | *CornerRadius?* | *null* | 子项悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverShadowColor | *Color?* | *null* | 子项悬浮时的阴影色。 |
| ItemsShadowColor | *Color?* | *null* | 子项阴影色。 |
| ItemsSpecialDayHighlightTemplate | *DataTemplate* | *null* | 定义在特殊日期高亮显示时的界面元素布局和外观。 |
| MaxDateTime | *DateTime?* | *null* | 最大日期。 |
| MinDateTime | *DateTime?* | *null* | 最小日期。 |
| Mode | *DateTimePickerMode* | *Date* | 日期时间选择器的显示模式。`Date`: 只选择日期，不包括时间，以年、月、日的形式表示。`DateHour`: 选择日期和小时，不包括分钟和秒，可以表示一个具体的日期和小时。`DateMinute`: 选择日期、小时和分钟，不包括秒，可以表示一个具体的日期、小时和分钟。`DateTime`: 选择完整的日期和时间，包括年、月、日、小时、分钟和秒。`Hour`: 只选择小时，不包括日期和分钟。通常表示一天中的具体小时。`Minute`: 只选择分钟，不包括日期和小时。通常表示一个小时内的具体分钟。`Month`: 只选择月份，不包括日期和年份。通常表示一年中的具体月份。`Time`: 只选择时间，不包括日期。通常包括小时、分钟和秒。`Year`: 只选择年份，不包括具体的月份和日期。通常用于选择特定的年份。 |
| SelectedDateTime | *DateTime?* | *null* | 选中的日期时间。 |
| ShadowColor | *Color?* | *null* | 边框的阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |
| StaysOpen | *bool* | *false* | 是否展开子项。 |
| Text | *string* | *null* | 文本内容。 |
| TextStringFormat | *string* | *null* | 文本格式。 |
| WatermarkForeground | *Brush* | *(自动计算)* | 占位符水印(Placeholder)的颜色。 |
| Watermark | *object* | *null* | 占位符水印(Placeholder)。 |
| YearStringFormat | *string* | *null* | 日期格式。 |

## 示例

### 示例1
<img height="300" src="https://assets.panuon.com/images/samples/wpf-ui/datetimepicker-1-_theme_.gif"></img>
```xml
<pu:DateTimePicker
    Width="250"
    Height="50"
    CornerRadius="10,10,10,10"  
    ItemsCheckedBackground="#36AAF7"
    ItemsCheckedBorderBrush="#36AAF7"
    ItemsCheckedBorderThickness="2"
    ItemsCheckedCornerRadius="5,5,5,5"                     
    ItemsCornerRadius="5,5,5,5"
    ItemsHoverBackground="#36AAF7"
    ItemsHoverCornerRadius="5,5,5,5"
    TextStringFormat="yyyy-MM-dd"        
    ClearButtonVisibility="VisibleOnHoverAndNonnull" /> 
```  

### 示例2
<img height="300" src="https://assets.panuon.com/images/samples/wpf-ui/datetimepicker-2-_theme_.gif"></img>

```xml
<pu:DateTimePicker
     Width="250"
     Height="50"
     pu:DropDownHelper.MinWidth="NaN"
     pu:DropDownHelper.Width="NaN"
     pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}"
     pu:IconHelper.FontSize="20"
     pu:IconHelper.Foreground="#FFFFFF"
     pu:IconHelper.Margin="15,0,5,0"
     Background="#333742"
     ClearButtonVisibility="VisibleOnHoverAndNonnull"
     CornerRadius="10,10,10,10"
     Foreground="#FFFFFF"
     Icon="&#xe9bc;"
     IsDropDownOpen="True"
     Mode="DateTime"
     TextStringFormat="yyyy-MM-dd HH:mm:ss"
     Watermark="Select time from dropdown">
     <pu:DateTimePicker.CalendarXStyle>
         <Style BasedOn="{StaticResource {x:Static pu:DateTimePicker.CalendarXStyleKey}}" TargetType="pu:CalendarX">
             <Setter Property="ItemsCornerRadius" Value="5" />
             <Setter Property="ItemsBackground" Value="#3b3f4a" />
             <Setter Property="ItemsForeground" Value="#7c808b" />
             <Setter Property="ItemsBorderThickness" Value="2" />
             <Setter Property="ItemsBorderBrush" Value="#333742" />
             <Setter Property="ItemsCornerRadius" Value="10,10,10,10" />
             <Setter Property="ItemsBackground" Value="#373b46" />
             <Setter Property="ItemsCheckedBackground" Value="#36AAF7" />
             <Setter Property="ItemsCheckedForeground" Value="#FFFFFF" />
             <Setter Property="ItemsCheckedCornerRadius" Value="10,10,10,10" />
             <Setter Property="ItemsCheckedBorderThickness" Value="2" />
             <Setter Property="ItemsHoverBackground" Value="#FF2A4375" />
             <Setter Property="ItemsHoverBorderBrush" Value="#FF1D5CFF" />
             <Setter Property="ItemsHoverBorderThickness" Value="2" />
             <Setter Property="ItemsHoverForeground" Value="#FFFFFF" />
             <Setter Property="ItemsHoverCornerRadius" Value="10,10,10,10" />
             <Setter Property="Background" Value="#313540" />
             <Setter Property="HeaderSeparatorVisibility" Value="Visible" />
             <Setter Property="HeaderSeparatorThickness" Value="1" />
             <Setter Property="Width" Value="{Binding ActualWidth, RelativeSource={RelativeSource AncestorType=pu:DateTimePicker}}" />
         </Style>
     </pu:DateTimePicker.CalendarXStyle>
     <pu:DateTimePicker.TimeSelectorStyle>
         <Style BasedOn="{StaticResource {x:Static pu:DateTimePicker.TimeSelectorStyleKey}}" TargetType="pu:TimeSelector">
             <Setter Property="ItemsCornerRadius" Value="5" />
             <Setter Property="ItemsBackground" Value="#3b3f4a" />
             <Setter Property="ItemsForeground" Value="#7c808b" />
             <Setter Property="ItemsBorderThickness" Value="2" />
             <Setter Property="ItemsCornerRadius" Value="10,10,10,10" />
             <Setter Property="ItemsCheckedBackground" Value="#36AAF7" />
             <Setter Property="ItemsCheckedForeground" Value="#FFFFFF" />
             <Setter Property="ItemsHoverBackground" Value="#FF2A4375" />
             <Setter Property="ItemsHoverBorderBrush" Value="#FF1D5CFF" />
             <Setter Property="ItemsHoverBorderThickness" Value="2" />
             <Setter Property="ItemsHoverForeground" Value="#FFFFFF" />
             <Setter Property="ItemsCheckedCornerRadius" Value="10,10,10,10" />
             <Setter Property="ItemsCheckedBorderThickness" Value="2" />
             <Setter Property="ItemsBackground" Value="#373b46" />
             <Setter Property="ItemsHoverCornerRadius" Value="10,10,10,10" />
             <Setter Property="Background" Value="#313540" />
             <Setter Property="HeaderSeparatorVisibility" Value="Visible" />
             <Setter Property="HeaderSeparatorThickness" Value="1" />
             <Setter Property="Width" Value="{Binding ActualWidth, RelativeSource={RelativeSource AncestorType=pu:DateTimePicker}}" />
         </Style>
     </pu:DateTimePicker.TimeSelectorStyle>
 </pu:DateTimePicker>
```
### 示例3
<img height="300" src="https://assets.panuon.com/images/samples/wpf-ui/datetimepicker-3-_theme_.gif"></img>

```xml
<pu:DateTimePicker
    Width="250"
    Height="40"
    pu:DropDownHelper.MinWidth="NaN"
    pu:DropDownHelper.Width="NaN"
    ClearButtonVisibility="VisibleOnHoverAndNonnull"
    CornerRadius="10,10,10,10"
    ItemsCheckedBackground="#36AAF7"
    ItemsCheckedBorderBrush="#36AAF7"
    ItemsCheckedBorderThickness="2"
    ItemsCheckedCornerRadius="5,5,5,5"
    ItemsCornerRadius="5,5,5,5"
    ItemsHoverBackground="#36AAF7"
    ItemsHoverCornerRadius="5,5,5,5"
    Mode="Time">
    <pu:DateTimePicker.TimeSelectorStyle>
        <Style BasedOn="{StaticResource {x:Static pu:DateTimePicker.TimeSelectorStyleKey}}" TargetType="pu:TimeSelector">
            <Setter Property="ItemsCornerRadius" Value="5" />
            <Setter Property="ItemsCheckedBackground" Value="#36AAF7" />
            <Setter Property="ItemsCheckedForeground" Value="#FFFFFF" />
            <Setter Property="Width" Value="{Binding ActualWidth, RelativeSource={RelativeSource AncestorType=pu:DateTimePicker}}" />
        </Style>
    </pu:DateTimePicker.TimeSelectorStyle>
</pu:DateTimePicker>
```
### 示例4
<img height="300" src="https://assets.panuon.com/images/samples/wpf-ui/datetimepicker-4-_theme_.gif"></img>
```xml
<pu:DateTimePicker
    Width="250"
    Height="50"
    Margin="20"
    pu:DropDownHelper.MinWidth="NaN"
    pu:DropDownHelper.Width="NaN"
    pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}"
    pu:IconHelper.FontSize="20"
    pu:IconHelper.Foreground="#FFFFFF"
    pu:IconHelper.Margin="15,0,5,0"
    Background="#36AAF7"
    BorderBrush="#36AAF7"
    BorderThickness="3"
    ClearButtonVisibility="VisibleOnHoverAndNonnull"
    CornerRadius="10"
    Foreground="#FFFFFF"
    HoverBorderBrush="#2b88c6"
    HoverBorderThickness="3"
    Icon="&#xe9bc;"
    IsDropDownOpen="True"
    ShadowColor="#36AAF7"
    TextStringFormat="yyyy-MM-dd HH:mm:ss"
    Watermark="Select time from dropdown">
    <pu:DateTimePicker.CalendarXStyle>
        <Style BasedOn="{StaticResource {x:Static pu:DateTimePicker.CalendarXStyleKey}}" TargetType="pu:CalendarX">
            <Setter Property="ItemsCornerRadius" Value="5" />
            <Setter Property="ItemsBackground" Value="#36AAF7" />
            <Setter Property="ItemsForeground" Value="#cccccc" />
            <Setter Property="ItemsBorderThickness" Value="3" />
            <Setter Property="ItemsBorderBrush" Value="#36AAF7" />
            <Setter Property="ItemsCheckedBackground" Value="#2b88c6" />
            <Setter Property="ItemsCheckedForeground" Value="#FFFFFF" />
            <Setter Property="ItemsCheckedCornerRadius" Value="5" />
            <Setter Property="ItemsCheckedBorderThickness" Value="3" />
            <Setter Property="ItemsCheckedBorderBrush" Value="#4094cc" />
            <Setter Property="ItemsHoverBackground" Value="#86ccfa" />
            <Setter Property="ItemsHoverBorderBrush" Value="#36AAF7" />
            <Setter Property="ItemsHoverBorderThickness" Value="3" />
            <Setter Property="ItemsHoverForeground" Value="#FFFFFF" />
            <Setter Property="ItemsHoverCornerRadius" Value="5" />
            <Setter Property="Background" Value="#36AAF7" />
            <Setter Property="HeaderSeparatorVisibility" Value="Visible" />
            <Setter Property="HeaderSeparatorThickness" Value="1" />
            <Setter Property="ItemsShadowColor" Value="#2b88c6" />
            <Setter Property="Width" Value="{Binding ActualWidth, RelativeSource={RelativeSource AncestorType=pu:DateTimePicker}}" />
        </Style>
    </pu:DateTimePicker.CalendarXStyle>
</pu:DateTimePicker>
```  