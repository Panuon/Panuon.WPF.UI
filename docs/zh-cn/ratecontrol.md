# RateControl 评分


## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CanSelectHalf | *bool* | *false* | 是否可以选择半星。 | 
| GlyphTemplate | *DataTemplate* | *null* | 星级样式。 |
| IsReadOnly | *bool* | *false* | 是否只读。 |
| Rate | *double* | *null* | 星级。从0-5的值。 | 

## 事件 
| 事件 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| RateChanged | *附加事件* | *null* | 星级变化事件。 | 

## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/ratecontrol-1-_theme_.gif"></img>

```xml
<pu:RateControl FontSize="30"
    Rate="2.5"
    CanSelectHalf="True"
    RateChanged="RateControl_RateChanged" />
```
### 示例2
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/ratecontrol-2-_theme_.jpg"></img>

```xml
<pu:RateControl FontSize="30"
                Rate="2.5"
                CanSelectHalf="True"
                IsReadOnly="True"
                Foreground="HotPink"
                RateChanged="RateControl_RateChanged">
    <pu:RateControl.GlyphTemplate>
        <DataTemplate>
            <TextBlock x:Name="TxtGlyph"
                       Cursor="Hand"
                       Text="&#xe96f;"
                       FontFamily="/Panuon.WPF.UI;component/Resources/#PanuonIcon" />
            <DataTemplate.Triggers>
                <DataTrigger Binding="{Binding Rate}"
                             Value="0.5">
                    <Setter TargetName="TxtGlyph"
                            Property="Text"
                            Value="&#xe970;" />
                </DataTrigger>
                <DataTrigger Binding="{Binding Rate}"
                             Value="1">
                    <Setter TargetName="TxtGlyph"
                            Property="Text"
                            Value="&#xe971;" />
                </DataTrigger>
            </DataTemplate.Triggers>
        </DataTemplate>
    </pu:RateControl.GlyphTemplate>
</pu:RateControl>
```