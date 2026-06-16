# Breadcrumb 面包屑


## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  
2. 当`子项背景`或`子项的边框色`属性为空时，`子项阴影色`和`子项悬浮时的阴影`无效。

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 | 
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。 | 
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 | 
| ItemsBorderThickness | *Thickness* | *null* | 子项的边框粗细。 | 
| ItemsClickBackground | *Brush* | *null* | 子项点击时的背景色。 | 
| ItemsClickBorderBrush | *Brush* | *null* | 子项点击时的边框色。 | 
| ItemsClickBorderThickness | *Thickness* | *null* | 子项点击时的边框粗细。 | 
| ItemsClickCornerRadius | *CornerRadius?* | *null* | 子项点击时的边框圆角。 | 
| ItemsClickEffect | *ClickEffect* | *null* | 子项点击特效。`None`表示没有点击特效，`Sink`表示点击时下沉，`Shake`表示点击时抖动。 | 
| ItemsClickForeground | *Brush* | *null* | 子项点击时的前景色。值为`null`时，点击不出现变化。 | 
| ItemsCornerRadius | *CornerRadius* | *null* | 子项的边框圆角。 | 
| ItemsHoverBackground | *Brush* | *null* | 子项悬浮时的背景色。 | 
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。 | 
| ItemsHoverBorderThickness | *Thickness?* | *null* | 子项悬浮时的边框粗细。 | 
| ItemsHoverCornerRadius | *CornerRadius?* | *null* | 子项悬浮时的边框圆角。 | 
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。 | 
| ItemsHoverShadowColor | *Color?* | *null* | 子项悬浮时的阴影。 | 
| ItemsIcon | *object* | *null* | 子项的图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]()。 | 
| ItemsMargin | *Thickness* | *null* | 子项的外边距。 | 
| ItemsPadding | *Thickness* | *null* | 子项的内边距。 | 
| ItemsSeparatorMargin | *Thickness* | *null* | 子项分隔符的外边距。 | 
| ItemsSeparatorTemplate | *DataTemplate* | *null* | 子项分隔符样式。 | 
| ItemsShadowColor | *Color?* | *null* | 子项的阴影。 | 
| ShadowColor | *Color?* | *null* | 控件的阴影。值为null时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 | 

## 事件 
| 事件 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ItemClick | *附加事件* | *null* | 子项点击事件。 |

## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/breadcrumb-1-_theme_.png"></img>

```xml
 <pu:Breadcrumb
    Width="200"
    Height="40"
    Margin="30,0,0,0"
    HorizontalContentAlignment="Center"
    VerticalContentAlignment="Center"
    CornerRadius="20,20,20,20"
    Foreground="White"
    ItemsBorderThickness="2"
    ItemsHoverBackground="#36AAF7"
    ItemsSeparatorMargin="0,10,0,0">
    <pu:BreadcrumbItem Content="Home" />
    <pu:BreadcrumbItem Content="Categony" />
    <pu:BreadcrumbItem Content="Detail" />
    <pu:Breadcrumb.Background>
        <LinearGradientBrush StartPoint="0,0" EndPoint="1,1">
            <GradientStop Offset="0.0" Color="#fb57a8" />
            <GradientStop Offset="1.0" Color="#7a4af4" />
        </LinearGradientBrush>
    </pu:Breadcrumb.Background>
    <pu:Breadcrumb.ItemsSeparatorTemplate>
        <DataTemplate>
            <TextBlock Text="/" />
        </DataTemplate>
    </pu:Breadcrumb.ItemsSeparatorTemplate>
</pu:Breadcrumb>
```
