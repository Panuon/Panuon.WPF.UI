# Carousel 轮播


## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  
2. 当容器大小发生改变时，会触发无动画效果的重新布局事件。如果在更改`CurrentIndex`的过程中改变了轮播控件的大小，该次动画效果将失效。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| Animation | *CarouselAnimation* | *Slide* | 切换页面时的动画效果。`Fade`表示淡入淡出， `Flow`表示流动 `Scale`表示缩放 `Slide`表示滑动。 | 
| AnimationEasing | *AnimationEasing* | *None* | 切换页面时的动画缓动函数。有关WPF缓动函数的更多信息，请查看[WPF缓动函数文档](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/graphics-multimedia/easing-functions?view=netframeworkdesktop-4.8)。 |  
| AnimationDuration | *TimeSpan* | *0:0:0* | 动画的持续时间。 | 
| CurrentIndex | *int* | *null* | 当前索引。 | 
| Orientation | *Orientation* | *Horizontal* | 轮播的内容布局方向。`Horizontal`表示水平排列，`Vertical`表示垂直排列。 |  
| IsCyclic | *bool* | *true* | 是否循环播放。属性值为`True`时，从最后一张滚动到下一张时会返回第一页。 | 
| AutoPlayDuration | *TimeSpan* | *null* | 自动轮播的时间间隔。 |
| CanTurnPageWithKeys | *bool* | *true* | 是否可以使用键盘按键来控制翻页。 |
| PageTurnButtonVisibility | *DecorationVisibility* | *VisibleOnHover* | 翻页按钮的可见性。`Visible`表示始终显示，`VisibleOnHover`表示悬浮时显示，`Collapsed`表示隐藏。 |
| PageTurnButtonStyle | *Style* | *(见内部资源键)* | 翻页按钮的样式。 |
| IndicatorPosition | *IndicatorPosition* | *RightOrBottom* | 指示器位置。 |
| IndicatorVisibility | *DecorationVisibility* | *Visible* | 指示器是否可见。`LeftOrTop`表示显示在左侧或顶部，`RightOrBottom`表示显示在右侧或底部。 |
| IndicatorPaginationStyle | *Style* | *(见内部资源键)* | 指示器的样式。 |

## 事件 
| 名称 | 类型 | 描述 |
| --- | --- | ----------- |
|  CurrentIndexChanged | *SelectedValueChangedRoutedEventHandler<int>* | 当前索引更改时，触发此事件。 | 

## 示例

### 示例1
<img height="300" src="https://assets.panuon.com/images/samples/wpf-ui/carousel-1-_theme_.gif"></img>

```xml
 <pu:Carousel 
    AutoPlayDuration="0:0:2"
    Height="300"
    TextBlock.FontSize="40"
    TextBlock.TextAlignment="Center">
    <Border Background="#94cab8">
        <TextBlock Text="Page 1"
            VerticalAlignment="Center" />
    </Border>
    <Border Background="#d99eaa">
        <TextBlock Text="Page 2"
            VerticalAlignment="Center" />
    </Border>
    <Border Background="#9fc3c2">
        <TextBlock Text="Page 3"
            VerticalAlignment="Center" />
    </Border>
    <Border Background="#dadfb5">
        <TextBlock Text="Page 4"
            VerticalAlignment="Center" />
    </Border>
    <Border Background="#ada8ad">
        <TextBlock Text="Page 5"
            VerticalAlignment="Center" />
    </Border>
 </pu:Carousel>
```

## 内部资源键

### IndicatorPaginationStyle
`{StaticResource {x:Static pu:Carousel.IndicatorPaginationStyleKey}}`  
控件类型：*pu:Pagination*  
指示器的样式。  

示例：
```xml
<pu:Carousel>
    <pu:Carousel.IndicatorPaginationStyle>
        <Style TargetType="pu:Pagination"
            BasedOn="{StaticResource {x:Static pu:Carousel.IndicatorPaginationStyleKey}}">
            <Setter Property="ItemsBackground"
                Value="#22FFFFFF" />
            <Setter Property="ItemsSelectedBackground"
                Value="#FF7327" />
        </Style>
    </pu:Carousel.IndicatorPaginationStyle>
</pu:Carousel >
```