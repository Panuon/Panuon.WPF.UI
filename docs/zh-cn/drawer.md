# Drawer 抽屉

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| AnimationDuration | *TimeSpan* | *null* | 展开/收起动画的持续时间。值为`null`或`0`时，不会执行动画效果。 |  
| AnimationEasing | *AnimationEasing* | *None* | 展开/收起动画的缓动函数。有关WPF缓动函数的更多信息，请查看WPF缓动函数文档。 | 
| IsOpen | *bool* | *true* | 是否展开抽屉。`true` 表示展开，`false` 表示折叠。 |  
| StaysOpen | *bool* | *true* | 是否保持展开。 |  
| Placement | *DrawerPlacement* | *Left* | `Bottom`表示Drawer位于底部，可以向上展开， `Left`表示Drawer位于左侧，可以向右展开， `Right`表示Drawer位于右侧，可以向左展开，  `Top`表示Drawer位于顶部，可以向下展开。 |  
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |  
| ShadowColor | *Color?* | *null* | 控件的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
|  Open | *附加事件* | *null* | Drawer展开事件。 | 
|  Closed | *附加事件* | *null* | Drawer折叠事件。 | 

## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/drawer-1-_theme_.gif"></img>

```xml
<pu:Drawer
    x:Name="DrwMenu"
    Height="180"
    MinWidth="60"
    MaxWidth="250"
    BorderThickness="1,1,1,1">
        <Grid>
            <ToggleButton
                Width="60"
                Height="60"
                Background="WhiteSmoke"
                HorizontalAlignment="Right"
                VerticalAlignment="Top"
                pu:ToggleButtonHelper.CheckedContent="&#xe924;"
                Content="&#xe926;"
                FontFamily="{StaticResource PanuonIconFont}"
                IsChecked="{Binding IsOpen, ElementName=DrwMenu, Mode=TwoWay}" />
        </Grid>
</pu:Drawer>
```

