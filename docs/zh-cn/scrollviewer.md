# ScrollViewer 滚动视图

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.ScrollViewerStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.ScrollViewerHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="ScrollViewer">* 或 *<pu:KeyOnlyStyleDictionary Includes="ScrollViewer">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/ScrollViewer.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/ScrollViewerStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。   

## 属性
以下属性包含在辅助类*ScrollViewerHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| AnimationDuration | *TimeSpan* | *null* | 展开/收起动画的持续时间。值为`null`或`0`时，不会执行动画效果。 |
| AnimationEasing | *AnimationEasing* | *None* | 展开/收起动画的缓动函数。有关WPF缓动函数的更多信息，请查看[*WPF缓动函数文档*]() 。 |
| ContentSpacing | *double* | *(自动计算)* | 内容间距。 |
| HandleMouseWheel | *bool* | *true* | 是否允许滚动视图在接收到鼠标滚轮事件时进行相应的滚动操作。 |
| HorizontalOffset | *double* | *null* | 水平滚动偏移量。 |
| MouseWheelDelta | *double?* | *null* | 鼠标滚轮事件中的滚动增量。 |
| MouseWheelUnit | *int* | *null* | 每次滚动的基本增量。 |
| ScrollBarPosition | *ScrollBarPosition* | *Outside* | 滚动条的位置。`Horizontallnside`表示在水平方向的内部,`Inside`表示在内部,`Outside`表示在外部,`Verticallnside`表示在垂直方向的内部。 |
| ScrollBarThickness | *double* | *null* | 滚动条的边框粗细。 |
| VerticalOffset | *double* | *null* | 锤子滚动偏移量。 |
| WheelScrollingDirection | *WheelScrollingDirection* | *null* | 滚轮滚动的方向。`Both`。 `Horizontal`水平方向上的滚动。 `HorizontalThenVertical`首先在水平方向上进行滚动，然后在垂直方向上进行滚动。 `Vertical`在垂直方向上的滚动。 `VerticalThenHorizontal`首先在垂直方向上进行滚动，然后在水平方向上进行滚动。 |

## 示例

### 示例1
<img height="300" src="https://assets.panuon.com/images/samples/wpf-ui/scrollviewer-1-_theme_.gif"></img>

```xml
<ScrollViewer
    pu:ScrollViewerHelper.ContentSpacing="15"
    pu:ScrollViewerHelper.ScrollBarPosition="Outside"
    pu:ScrollViewerHelper.ScrollBarThickness="10">
        <Border Background="#e7f1e3">
            <TextBlock
                Height="500"
                FontSize="35"
                Text="Page 1"
                TextAlignment="Center" />
        </Border>
</ScrollViewer>
```
