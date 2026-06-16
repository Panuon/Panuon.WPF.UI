# Pagination 分页控件


## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CurrentPage | *int* | *0* | 当前页码。 | 
| ItemContainerStyle | *Style* | *(见内部资源键)* | 项目容器样式。 | 
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |  
| ItemsBorderThickness | *Thickness* | *null* | 子项的边框粗细。 | 
| ItemsCornerRadius | *CornerRadius* | *null* | 子项的边框圆角。 |  
| ItemsForeground | *Brush* | *null* | 子项的前景色。 |  
| ItemsHeight | *double* | *(自动计算)* | 子项的高度。 |  
| ItemsHoverBackground | *Brush* | *(自动计算)* | 子项悬浮时的背景色。值为`null`时，悬浮不出现变化。 |   
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。值为`null`时，悬浮不出现变化。 |  
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverShadowColor | *Color?* | *null* | 悬浮时的阴影色。值为`null`时，悬浮不出现变化。 |    
| ItemsMargin | *Thickness* | *0,0,0,0* | 子项的外边距。 |   
| ItemsPadding | *Thickness* | *(跟随主控件)* | 子项的内边距。 |  
| ItemsSelectedBackground | *Brush* | *null* | 子项被选中时的背景色。值为`null`时，被选中不出现变化。 |  
| ItemsSelectedBorderBrush | *Brush* | *null* | 子项被选中时的边框色。值为`null`时，被选中不出现变化。 |  
| ItemsSelectedBorderThickness | *Thickness?* | *null* | 子项被选中时的边框粗细。值为`null`时，被选中不出现变化。 | 
| ItemsSelectedForeground | *Brush* | *null* | 子项被选中时的前景色。值为`null`时，被选中不出现变化。 |  
| ItemsSelectedShadowColor | *Color?* | *null* | 子项被选中时边框的阴影。值为`null`时，被选中不出现变化。 | 
| ItemsShadowColor | *Color?* | *null* | 子项的阴影色。值为`null`时，悬浮不出现变化。 |   
| ItemsWidth | *double* | *(自动计算)* | 子项的宽度。 |   
| MaxPage | *int* | *null* | 最大页码。 |   
| MinPage | *int* | *null* | 最小页码。 |
| OmittingTextBlockStyleKey | *ComponentResourceKey* | *(见内部资源键)* | 省略文本样式。 |  
| Orientation | *Orientation* | *Horizontal* | 排列方向。`Horizontal`表示水平， `Vertical`表示竖直。 |   
| PageTurnButtonStyleKey | *ComponentResourceKey* | *(见内部资源键)* | 翻页按钮样式。 |   
| PageTurnButtonVisibility | *Visibility* | *true* | 是否显示翻页按钮。 |  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CurrentPageChanged | *附加事件* | *null* | 当前页变化事件。 | 

## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/pagination-1-_theme_.gif"></img>

```xml
<pu:Pagination
    Height="24"
    HorizontalAlignment="Left"
    Foreground="#FFFFFF"
    ItemsBackground="Transparent"
    ItemsCornerRadius="12"
    ItemsSelectedBackground="#36AAF7"
    MaxPage="10" />
```

## 内部资源键

### PageTurnButtonStyle
`{StaticResource {x:Static pu:Pagination.PageTurnButtonStyleKey}}`  
控件类型：*pu:Pagination.PageTurnButtonStyle*  
翻页按钮显示样式。  

### 示例：
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/pagination-2-_theme_.gif"></img>

```xml
<pu:Pagination >
    <pu:Pagination.PageTurnButtonStyle>
        <Style TargetType="RepeatButton"
            BasedOn="{StaticResource {x:Static pu:Pagination.PageTurnButtonStyleKey}}">
            <Setter Property="Background"
                Value="Transparent" />
            <Setter Property="pu:RepeatButtonHelper.HoverForeground"
                Value="#FFFFFF" />
            <Setter Property="pu:RepeatButtonHelper.HoverBackground"
                Value="#36AAF7" />
            <Setter Property="pu:RepeatButtonHelper.CornerRadius"
                Value="12" />
            <Setter Property="Foreground"
                Value="#FFFFFF" />
        </Style>
    </pu:Pagination.PageTurnButtonStyle>
</pu:Pagination >
```