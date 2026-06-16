# ShadowHelper 阴影辅助类

## 属性
以下属性包含在辅助类*ShadowHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| BlurRadius | *double* | *10* | 阴影的模糊半径（单位：像素），值越大边缘越柔和 |
| Direction | *double* | *315* | 光源角度（0-360度），`0`表示右侧，`90`表示上方，`180`表示左侧，`270`表示下方 |
| Opacity | *double* | *1* | 阴影透明度（0.0-1.0），`1`表示完全不透明，`0`表示完全透明 |
| RenderingBias | *RenderingBias* | *Performance* | 渲染模式：`Performance`表示性能优先，`Quality`表示质量优先 |
| ShadowDepth | *double* | *0* | 阴影的投射距离（单位：像素），控制阴影偏移量 |

### 示例
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/button-1-_theme_.jpg"></img>

```xml
<Button Content="Button" 
        Height="40" Width="170"      
        Background="#36AAF7" 
        Foreground="#FFFFFF"
        pu:ButtonHelper.CornerRadius="4" 
        pu:ButtonHelper.Icon="&#xe939;"
        pu:ButtonHelper.ShadowColor="#36AAF7"  
        pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}" 
        pu:IconHelper.Margin="0,0,10,0"
        pu:ShadowHelper.BlurRadius="15" 
        pu:ShadowHelper.ShadowDepth="5" />
``` 


 