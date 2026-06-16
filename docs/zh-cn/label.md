# Label 标签

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.LabelStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.LabelHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="Label">* 或 *<pu:KeyOnlyStyleDictionary Includes="Label">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/Label.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/Label.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性
以下属性包含在辅助类*LabelHelper*中。  
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 |
| Icon | *object* | *null* | 图标。可以是文本或图片路径，也可以是控件。图标的位置可以通过`IconPlacement`属性控制。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]() 。 |
| IconPlacement | *IconPlacement* | *Left* | 图标的位置。`Left` 表示显示在内容的左侧，`Top` 表示显示在内容的上方，`Right` 表示显示在内容的右侧，`Bottom` 表示显示在内容的下方。 |
| ShadowColor | *Color?* | *null* | 边框的阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/label-1-_theme_.jpg"></img>

```xml
<Label
     Width="350"
     Height="200"
     Margin="50"
     Padding="0,0,0,0"
     HorizontalContentAlignment="Center"
     VerticalContentAlignment="Center"
     pu:LabelHelper.CornerRadius="20,20,20,20"
     pu:ShadowHelper.BlurRadius="10"
     pu:ShadowHelper.Direction="315"
     pu:ShadowHelper.ShadowDepth="0"
     Background="#ffffff"
     BorderBrush="#cccccc"
     BorderThickness="5,5,5,5"
     FontSize="50"
     Foreground="#000000">
     <Label.ContentTemplate>
         <DataTemplate>
             <TextBlock
                 FontStyle="Normal"
                 FontWeight="Medium"
                 Text="Panuon.WPF.UI" />
         </DataTemplate>
     </Label.ContentTemplate>
 </Label>
```