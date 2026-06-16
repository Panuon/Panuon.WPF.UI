# Slider 滑块

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.SliderStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.SliderHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="Slider">* 或 *<pu:KeyOnlyStyleDictionary Includes="Slider">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/Slider.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/SliderStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  
2. 原生的*Background*、*BorderBrush*等属性可用于控制轨道的颜色。  

## 属性
以下属性包含在辅助类*SliderHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CoveredBackground | *Brush* | *Gray* | 滑轨已覆盖背景色。 |
| IsTextVisible | *bool* | *false* | 是否显示数值文本。 |
| TextSpacing | *double* | *0* | 数值文本与滑块条的间距。 |
| TextStringFormat | *string* | *N2* | 滑块条值的文本化格式。 |
| ThumbBackground | *Brush* | *White* | 滑块的背景色。值为`null`时，滑块无法选中 |
| ThumbBorderBrush | *Brush* | *null* | 滑块的边框色。 |
| ThumbBorderThickness | *Thickness* | *0* | 滑块的边框粗细。 |
| ThumbCornerRadius | *CornerRadius* | *0,0,0,0* | 滑块的边框圆角，默认滑块为圆形。 |
| ThumbHeight | *double* | *(绑定到父控件)* | 滑块的高度。 |
| ThumbShadowColor | *Color?* | *LightGray* | 滑块的阴影色。 |
| ThumbStyle | *Style* | *(见内部资源键)* | 滑块的样式。 |
| ThumbWidth | *double* | *(与ThumbHeight绑定)* | 滑块的宽度。 |
| TickBarForeground | *Brush* | *null* | 刻度条的前景色。 |
| TickBarThickness | *double* | *null* | 刻度条的厚度。 |
| TrackCornerRadius | *CornerRadius* | *null* | 滑块轨道的圆角。 |
| TrackThickness | *double* | *null* | 滑块轨道的粗细。 |

## 事件
以下事件包含在辅助类*SliderHelper*中。  

| 事件 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| GeneratingValueText | *附加事件* | *null* | 通过附加事件来处理显示滑块条值样式。 |

## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/slider-1-_theme_.gif"></img>

```xml
<Slider Width="200" VerticalAlignment="Center"
        Foreground="DimGray"
        pu:SliderHelper.IsTextVisible="True" pu:SliderHelper.TextSpacing="3" pu:SliderHelper.TextStringFormat="N0"
        pu:SliderHelper.TrackThickness="6"
        IsSnapToTickEnabled="True" TickFrequency="0.5">
    <Slider.Background>
        <LinearGradientBrush>
            <GradientStop Color="#447CCBFC" />
            <GradientStop Color="#44FF6BB8" Offset="1" />
        </LinearGradientBrush>
    </Slider.Background>
    <pu:SliderHelper.CoveredBackground>
        <LinearGradientBrush>
            <GradientStop Color="#7CCBFC" />
            <GradientStop Color="#FF6BB8" Offset="1" />
        </LinearGradientBrush>
    </pu:SliderHelper.CoveredBackground>
</Slider>
```

## 内部资源键

### ThumbStyle
`{StaticResource {x:Static pu:SliderHelper.ThumbStyleKey}}`  
控件类型：*pu:Thumb *  
Thumb样式。  

示例：  
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/slider-2-_theme_.jpg"></img>
```xml
<!--将滑块样式改为五角星-->
<Slider Value="5" Width="200" VerticalAlignment="Center"
        pu:SliderHelper.ThumbBackground="Transparent"
        pu:SliderHelper.ThumbWidth="NaN" pu:SliderHelper.ThumbHeight="NaN"
        pu:SliderHelper.TrackThickness="2">
    <pu:SliderHelper.ThumbStyle>
        <Style BasedOn="{StaticResource {x:Static pu:SliderHelper.ThumbStyleKey}}" TargetType="Thumb">
            <Setter Property="pu:ThumbHelper.ContentTemplate">
                <Setter.Value>
                    <DataTemplate>
                        <Grid RenderTransformOrigin="0.5,0.5">
                            <Grid.RenderTransform>
                                <RotateTransform Angle="25"/>
                            </Grid.RenderTransform>
                            <TextBlock Text="&#xe958;"
                                       FontSize="22" Foreground="White" FontFamily="{StaticResource PanuonIconFont}" />
                            <TextBlock Text="&#xe956;"
                                       FontSize="22" Foreground="Gray" FontFamily="{StaticResource PanuonIconFont}" />
                        </Grid>
                    </DataTemplate>
                </Setter.Value>
            </Setter>
        </Style>
    </pu:SliderHelper.ThumbStyle>
</Slider>
```