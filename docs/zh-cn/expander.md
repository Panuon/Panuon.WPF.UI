# Expander 手风琴容器

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.ExpanderStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.ExpanderHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="Expander">* 或 *<pu:KeyOnlyStyleDictionary Includes="Expander">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/Expander.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/ExpanderStyle.xaml*

---

## 小提示
1. 当手风琴容器被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。    

## 属性
以下属性包含在辅助类*ExpanderHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| AnimationDuration | *TimeSpan* | *null* | 展开/收起动画的持续时间。值为`null`或`0`时，不会执行动画效果。 |
| AnimationEasing | *AnimationEasing* | *None* | 展开/收起动画的缓动函数。有关WPF缓动函数的更多信息，请查看[WPF缓动函数文档](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/graphics-multimedia/easing-functions?view=netframeworkdesktop-4.8)。  |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| ExpandedBackground | *Brush* | *null* | 展开时的背景色。值为`null`时，展开不出现变化。 |
| ExpandedBorderBrush | *Brush* | *null* | 展开时的边框色。值为`null`时，展开不出现变化。 |
| ExpandedBorderThickness | *Thickness?* | *null* | 展开时的边框粗细。值为`null`时，展开不出现变化。 |
| ExpandedCornerRadius | *CornerRadius?* | *null* | 展开时的边框圆角。值为`null`时，展开不出现变化。 |
| ExpandedHeaderBackground | *Brush* | *null* | 展开时的标题背景色。值为`null`时，展开不出现变化。 |
| ExpandedHeaderBorderBrush | *Brush* | *null* | 展开时的标题边框色。值为`null`时，展开不出现变化。 | | *
| ExpandedHeaderBorderThickness | *Thickness?* | *null* | 展开时的标题边框粗细。值为`null`时，展开不出现变化。 |
| ExpandedHeaderCornerRadius | *CornerRadius* | *0,0,0,0* | 展开时的标题边框圆角。 |
| ExpandedHeaderForeground | *Brush* | *null* | 展开时的标题字体前景色。值为`null`时，展开不出现变化。 |
| ExpandedHeaderShadowColor | *Color?* | *null* | 展开时的标题阴影色。值为`null`时，展开不出现变化。 |
| ExpandedShadowColor | *Color?* | *null* | 展开时的阴影色。值为`null`时，展开不出现变化。 |
| ExtendControl | *object* | *null* | 显示在标题栏最右侧/底部的扩展内容。可以是文本或图片路径，也可以是控件。 |
| HeaderBackground | *Brush* | *null* | 标题背景色。值为`null`时，展开不出现变化。 |
| HeaderBorderBrush | *Brush* | *null* | 标题边框色。值为`null`时，展开不出现变化。 |
| HeaderBorderThickness | *Thickness?* | *null* | 标题边框粗细。值为`null`时，展开不出现变化。 |
| HeaderCornerRadius | *CornerRadius* | *0,0,0,0* | 标题圆角。 |
| HeaderFontFamily | *FontFamily* | *PanuonIconFont* | 标题字体。 |
| HeaderFontSize | *double* | *null* | 标题字体大小。 |
| HeaderFontWeight | *FontWeight* | *null* | 标题字体加粗样式。 |
| HeaderForeground | *Brush* | *null* | 标题字体前景色。值为`null`时，展开不出现变化。 |
| HeaderHeight | *double* | *null* | 标题高度。 |
| HeaderHorizontalContentAlignment | *HorizontalAlignment* | *left* | 标题水平对齐方式。`Center`表示居中显示，`Left`表示左对齐，`Right`表示右对齐，`Stretch`表示自动调整大小以填充。 |
| HeaderPadding | *Thickness* | *(跟随主控件)* | 标题内边距。 |
| HeaderSeparatorBrush | *Brush* | *null* | 标题分隔符色。值为`null`时，展开不出现变化。 |
| HeaderSeparatorMargin | *Thickness* | *null* | 标题分隔符的间距。 |
| HeaderSeparatorThickness | *double* | *null* | 标题分隔符的粗细。 |
| HeaderSeparatorVisibility | *Visibility* | *Collapsed* | 展开时是否显示标题分隔符。 |
| HeaderShadowColor | *Color?* | *null* | 展开时的标题阴影色。值为`null`时，展开不出现变化。 |
| HeaderVerticalContentAlignment | *VerticalAlignment* | *left* | 标题垂直对齐方式。`Bottom`表示底部对齐，`Center`表示居中显示，`Stretch`表示自动调整大小以填充，`Top`表示顶部对齐。 |
| Icon | *object* | *null* | 标题的图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]()。 |
| ShadowColor | *Color?* | *null* | 阴影色。值为`null`时，展开不出现变化。 |
| ToggleArrowPlacement | *ToggleArrowPlacement* | *left* | 展开图标位置。 |
| ToggleArrowTransformControlStyle | *Style* | *(见内部资源键)* | 图标按钮样式。 |


## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/expander-1-_theme_.gif"></img>

```xml
<Expander Header="Expander" Width="200" VerticalAlignment="Center"
          BorderThickness="1" BorderBrush="#36AAF7"
          pu:ExpanderHelper.AnimationDuration="0:0:0.2" pu:ExpanderHelper.AnimationEasing="CubicInOut"
          pu:ExpanderHelper.CornerRadius="5"
          pu:ExpanderHelper.HeaderPadding="10,5" pu:ExpanderHelper.HeaderFontSize="15"
          pu:ExpanderHelper.HeaderBackground="#36AAF7" pu:ExpanderHelper.HeaderForeground="#FFFFFF">
    <Border Height="30"/>
</Expander>
```



## 内部资源键

### ToggleArrowTransformControlStyle
`{StaticResource {x:Static pu:ExpanderHelper.ToggleArrowTransformControlStyleKey}}`  
控件类型：*pu:TransformControl 变形控件*  
下拉三角符号的样式。  

示例：
```xml
<!--修改下拉三角的样式-->
<ExpanderHelper>
    <pu:ExpanderHelper.ToggleArrowTransformControlStyle>
         <Style BasedOn="{StaticResource {x:Static pu:ExpanderHelper.ToggleArrowTransformControlStyleKey}}" TargetType="pu:TransformControl">
             <Setter Property="Content" Value="&#xe933;" />
         </Style>
    </pu:ExpanderHelper.ToggleArrowTransformControlStyle>
</PasswordBox>
```