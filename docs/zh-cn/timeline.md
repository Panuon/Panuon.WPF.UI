# Timeline 时间轴控件


## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  
2. 默认情况下，`ItemsStickStrokeThickness`的值会与`ItemsToggleStrokeThickness`属性绑定。  

## 属性 

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ShowIndex | *bool* | *false* | 是否显示索引。 | 
| ItemsBackground | *Brush* | *null* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |
| ItemsBorderThickness | *Thickness* | *null* | 子项的边框粗细。 |
| ItemsCompletedGlyphBrush | *Brush* | *(自动计算)* | 子项被标记为完成时的符号颜色。 |
| ItemsCompletedStickFill | *Brush* | *(自动计算)* | 子项已完成的标记线色。 |
| ItemsCompletedStickStroke | *Brush* | *null* | 子项已完成的标记线描边色。 |
| ItemsCompletedStickStrokeThickness | *double* | *null* | 子项已完成的标记线边框粗细。 |
| ItemsCompletedToggleFill | *Brush* | *null* | 子项已完成的按钮填充色。 |
| ItemsCompletedToggleStroke | *Brush* | *null* | 子项已完成的按钮边框色。 |
| ItemsCompletedToggleStrokeThickness | *double* | *null* | 子项已完成的按钮边框粗细。 |
| ItemsCornerRadius | *CornerRadius* | *0，0，0，0* | 子项的圆角。 |
| ItemsForeground | *Brush* | *null* | 子项的前景色。 |
| ItemsHeaderBackground | *Brush* | *null* | 子项标题的背景色。 |
| ItemsHeaderBorderBrush | *Brush* | *null* | 子项标题的边框色。 |
| ItemsHeaderBorderThickness | *Thickness* | *null* | 子项标题的边框粗细。 |
| ItemsHeaderCornerRadius | *CornerRadius* | *0，0，0，0* | 子项标题的圆角。 |
| ItemsHeaderFontSize | *double* | *null* | 子项标题的字体大小。 |
| ItemsHeaderFontWeight | *FontWeight* | *null* | 子项标题的字体粗细。 |
| ItemsHeaderForeground | *Brush* | *null* | 子项标题的前景色。 |
| ItemsHeaderHeight | *double* | *null* | 子项标题的高度。 |
| ItemsHeaderHorizontalContentAlignment | *HorizontalAlignment* | *Left* | 子项的标题水平对齐方式。 |
| ItemsHeaderPadding | *Thickness* | *null* | 子项标题的边缘间距。 |
| ItemsHeaderPlacement | *HeaderPlacement* | *null* | 子项标题的位置。`Top` 表示显示在内容的顶部，`Bottom`表示显示在内容的底部。 |
| ItemsHeaderShadowColor | *Color?* | *null* | 子项标题的阴影色。 |
| ItemsHeaderVerticalContentAlignment | *VerticalAlignment* | *null* | 子项的标题竖直对齐方式。 |
| ItemsHeight | *double* | *null* | 子项的高度。 |
| ItemsMargin | *Thickness* | *null* | 子项的边缘间距。 |
| ItemsMaxHeight | *double* | *null* | 子项的最大高度。 |
| ItemsMaxWidth | *double* | *null* | 子项的最大宽度。 |
| ItemsMinHeight | *double* | *null* | 子项的最小高度。 |
| ItemsMinWidth | *double* | *null* | 子项的最小宽度。  |
| ItemsPendingSpinGlyphBrush | *Brush* | *null* | 子项等待旋转的前景色。 |
| ItemsPendingSpinGlyphThickness | *double* | *null* | 子项等待旋转的边框粗细。 |
| ItemsSeparatorBrush | *Brush* | *null* | 分割符的前景色。 |
| ItemsSeparatorMargin | *Thickness* | *null* | 分割符的边缘间距。 |
| ItemsSeparatorThickness | *double | *null* | 分割符的粗细。 |
| ItemsSeparatorVisibility | *Visibility* | *Collapsed* | 是否显示分割符。 |
| ItemsShadowColor | *Color?* | *null* | 子项的阴影色。 |
| ItemsStickFill | *Brush* | *null* | 子项标记线的填充色。 |
| ItemsStickStroke | *Brush* | *null* | 子项标记线的边框色。 |
| ItemsStickStrokeThickness | *double* | *(自动计算)* | 子项标记线的边框粗细。默认与`ItemsToggleStrokeThickness`进行绑定。 |
| ItemsStickThickness | *double* | *null* | 子项标记线的粗细。 |
| ItemsToggleFill | *Brush* | *null* | 子项按钮的填充色。 |
| ItemsToggleSize | *double* | *null* | 子项按钮的大小。 |
| ItemsToggleStroke | *Brush* | *null* | 子项按钮的边框色。 |
| ItemsToggleStrokeThickness | *double* | *null* | 子项按钮的边框粗细。 |
| ItemsWidth | *double* | *null* | 子项的宽度。 |
| Orientation | *Orientation* | *Vertical* | 时间轴的取向。`Horizontal`表示水平，`Vertical`表示竖直。 |
| Scrollable | *bool* | *false* | 是否可以滚动。 |
 


## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/timeline-1-_theme_.gif"></img>

```xml

<pu:Timeline 
    ItemsToggleStroke="#36AAF7"
    ItemsToggleStrokeThickness="1.5"
    ItemsStickFill="#36AAF7"
    ItemsStickThickness="1.5"
    ItemsHeaderForeground="Black"
    ItemsHeaderFontSize="16"
    ItemsCompletedToggleFill="#36AAF7"
    ItemsForeground="#000000"
    ShowIndex="True">
    <pu:TimelineItem IsCompleted="True"
                     Header="Time 1"
                     Content="Content of time 1." />
    <pu:TimelineItem IsPending="True"
                     Header="Time 2"
                     Content="Content of time 1." />
    <pu:TimelineItem Header="Time 3"
                     Content="Content of time 1." />
</pu:Timeline>
```

