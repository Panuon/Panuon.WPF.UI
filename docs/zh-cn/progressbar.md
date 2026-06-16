# ProgressBar 进度条

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.ProgressBarStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.ProgressBarHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="ProgressBar">* 或 *<pu:KeyOnlyStyleDictionary Includes="ProgressBar">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/ProgressBar.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/ProgressBarStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。   

## 属性
以下属性包含在辅助类*ProgressBarHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| AnimationDuration | *TimeSpan* | *null* | 动画持续时间。 |  
| AnimationEasing | *AnimationEasing* | *null* | 动画缓动函数。有关WPF缓动函数的更多信息，请查看[*WPF缓动函数文档*]()。 |  
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框圆角。 | 
| Direction | *ProgressDirection* | *Normal* | 进度条的方向，`Inverse`表示反转，`Normal`表示正常。 | 
| FilledBackground | *Brush* | *null* | 进度条填充后背景颜色。 | 
| InvertedForeground | *Brush* | *null* | 文本被进度条填充后显示的反转颜色。 | 
| IsPercentVisible | *bool* | *false* | 是否显示百分比。 |  
| PercentStringFormat | *string* | *P0* | 百分比文本化格式。 |    
| ShadowColor | *Color?* | *null* | 边框的阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 | 

## 事件
以下事件包含在辅助类*ProgressBarHelper*中。  

| 事件 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| GeneratingPercentText | *附加事件* | *null* | 处理生成百分比文本事件。 | 


## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/progressbar-1-_theme_.png"></img>

```xml
<ProgressBar
    Width="200"
    Height="50"
    BorderBrush="#cfebfd"
    BorderThickness="1"
    pu:ProgressBarHelper.AnimationDuration="0:0:0.3"
    pu:ProgressBarHelper.AnimationEasing="CubicInOut"
    pu:ProgressBarHelper.CornerRadius="10"
    pu:ProgressBarHelper.IsPercentVisible="True"
    Background="#fbfcf7"
    Foreground="#2A9BDD"
    Value="70" />
```