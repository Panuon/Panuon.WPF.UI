# NumberInput 数字输入框


---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  
2. 默认情况下，`WatermarkForeground`的值会与`Foreground`属性绑定，并通过转换器转换成更浅的颜色。如果将`Foreground`设置为渐变色，则转换不会生效。  

## 属性
以下属性包含在辅助类*NumberInputHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| AllowDrop | *bool* | *false* | 是否可以拖放。 |
| Background | *Brush* | *null* | 背景色。值为`null`时，不出现变化。 |
| BorderBrush | *Brush* | *null* | 边框色。值为`null`时，悬浮不出现变化。 |
| BorderThickness | *Thickness?* | *null* | 边框粗细。值为`null`时，悬浮不出现变化。 |
| ClearButtonStyle | *Style* | *(见内部资源键)* | 清空按钮样式。 |
| ClearButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 清空按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnFocused` 表示当输入框获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当输入框获得键盘焦点且文本不为空时显示，`VisibleOnHover` 表示当鼠标悬浮在输入框上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在输入框上且文本不为空时显示，`VisibleOnNonnull` 表示当输入框的文本不为空时显示。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| DefaultValue | *double?* | *默认值* |  值为`null`时，清空时为`null`。 |
| FocusedBackground | *Brush* | *null* | 获得键盘焦点时的背景色。值为`null`时，获得键盘焦点不出现变化 。 |
| FocusedBorderBrush | *Brush* | *null* | 获得键盘焦点时的边框色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedBorderThickness | *Thickness?* | *null* | 获得键盘焦点时的边框粗细。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedCornerRadius | *CornerRadius?* | *null* | 获得键盘焦点时的边框圆角。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedForeground | *Brush* | *null* | 获得键盘焦点时的前景色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedShadowColor | *Color?* | *null* | 获得键盘焦点时的阴影色。值为`null`时，获得键盘焦点不出现变化。 |
| FocusedWatermarkForeground | *Brush* | *(自动计算)* | 获得键盘焦点时占位符水印(Placeholder)的颜色。值为`null`时， 获得键盘焦点时不出现变化。 |
| HorizontalAlignment | *HorizontalAlignment* | *null* | 控件的水平对齐方式。 |
| HorizontalContentAlignment | *HorizontalAlignment* | *Left* | 值的水平对齐方式。 |
| HoverBackground | *Brush* | *(自动计算)* | 悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| HoverBorderBrush | *Brush* | *null* | 悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| HoverBorderThickness | *Thickness?* | *null* | 悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| HoverCornerRadius | *CornerRadius?* | *null* | 悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| HoverForeground | *Brush* | *null* | 悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| HoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，获得键盘焦点不出现变化。 |
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。图标的位置可以通过`IconPlacement`属性控制。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| Interval | *double* | *1* | 改变数值的最小增减量（点击按钮或输入）。 |
| IsSnapToIntervalEnabled | *bool* | *true* | 是否允许调整数值而不受到预设间隔的限制。 |
| IsReadOnly | *bool* | *false* | 是否只读状态。 |
| Maximum | *double* | *null* | 最大值，设置最大值的时，点击增加按钮达到最大值时数值不再变化。 |
| Minimum | *double* | *null* | 最小值，设置最小值的时，点击减少按钮达到最小值时数值不再变化。 |
| ShadowColor | *Color?* | *null* | 输入框的阴影。值为`null`时，不显示阴影。阴影细节可以通过`ShadowHelper` 阴影辅助类控制 。 |
| SelectAllOnFocus | *bool* | *false* | 获得键盘焦点是是否全选。 |
| StepFactor | *int* | *1* | 按钮每次增减数值的倍率 (实际增减量 =`Interval` * `StepFactor` )。它的默认值为`1`。 |
| UpDownButtonStyle | *Style* | *(见内部资源键)* | 增减按钮样式。 |
| UpDownButtonVisibility | *AuxiliaryButtonVisibility* | *Visible* | 上下按钮的显示状态。 |
| UpDownButtonsOrientation | *Orientation* | *Vertical* | 上下按钮的排列方式。 |
| Value | *double?* | *null* | 输入框的值，值的格式会受`Interval`的影响。 |
| VerticalAlignment | *VerticalAlignment* | *null* | 控件的垂直对齐方式。 |
| VerticalContentAlignment | *VerticalAlignment* | *Center* | 值的垂直对齐方式。 |
| Watermark | *object* | *null* | 占位符水印(Placeholder) 。 |
| WatermarkForeground | *Brush* | *(自动计算)* | 占位符水印(Placeholder)的颜色 。 |

## 事件
以下事件包含在辅助类*NumberInputHelper*中。  

| 事件 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ValueChanged | *附加事件* | *null* | 处理控件的值变化事件。 |


## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/numberInput-1-_theme_.gif"></img>

```xml
<pu:NumberInput 
    Height="50"
    Width="180"
    Minimum="0"
    Maximum="100"
    Interval="0.5"
    Value="50"
    Watermark="Input number"
    ValueChanged="NumberInput_ValueChanged"/>
```

### 示例2

<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/numberInput-2-_theme_.gif"></img>

```xml
<pu:NumberInput 
    Height="50"
    Width="180"
    Minimum="0"
    Maximum="100"
    Value="50"
    Watermark="数字"
    UpDownButtonsOrientation="Horizontal"
    ValueChanged="NumberInput_ValueChanged">
    <pu:NumberInput.UpDownButtonStyle>
        <Style TargetType="RepeatButton"
               BasedOn="{StaticResource {x:Static pu:NumberInput.UpDownButtonStyleKey}}">
            <Style.Triggers>
                <Trigger Property="Tag"
                         Value="Up">
                    <Setter Property="Content"
                            Value="&#xe934;" />
                </Trigger>
                <Trigger Property="Tag"
                         Value="Down">
                    <Setter Property="Content"
                            Value="&#xe935;" />
                </Trigger>
            </Style.Triggers>
        </Style>
    </pu:NumberInput.UpDownButtonStyle>
</pu:NumberInput>
```

## 内部资源键

### UpDownButtonStyle
`{StaticResource {x:Static pu:NumberInput.UpDownButtonStyleKey}}`  
控件类型：*pu:UpDownButton*  
UpDownButton样式。  

示例：
```xml
<!--将按钮修改为加减样式-->
<pu:NumberInput>
    <pu:NumberInput.UpDownButtonStyle>
        <Style TargetType="RepeatButton"
               BasedOn="{StaticResource {x:Static pu:NumberInput.UpDownButtonStyleKey}}">
            <Style.Triggers>
                <Trigger Property="Tag"
                         Value="Up">
                    <Setter Property="Content"
                            Value="&#xe934;" />
                </Trigger>
                <Trigger Property="Tag"
                         Value="Down">
                    <Setter Property="Content"
                            Value="&#xe935;" />
                </Trigger>
            </Style.Triggers>
        </Style>
    </pu:NumberInput.UpDownButtonStyle>
</pu:NumberInput>
```