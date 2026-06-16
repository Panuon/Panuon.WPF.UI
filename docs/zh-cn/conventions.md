# 命名与规范
  
## 命名
  
### 原生控件的Helper辅助类
对于WPF原生控件，Panuon.WPF.UI通过 `Helper辅助类` 来调整样式。  
例如， _Button 按钮_ 的辅助类为 _ButtonHelper_ ， _TextBox 输入框_ 的辅助类为 _TextBoxHelper_ 。  
在 `Visual Studio` 编辑器的 _Button 按钮_ 控件上，输入以下代码中的最后一个小数点后，弹出的智能感知中就会展示出所有支持的属性。

```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
...

<Button pu:ButtonHelper. />
```

善加利用Visual Studio的智能感知功能，可以帮助你更好地熟悉控件库提供的属性。  
  
### 特殊的通用辅助类

#### GlobalSettings 全局设置
可以全局设置所有控件渐变动画的时长、禁用时的透明度、字体、图标字体等属性。  

#### WindowXCaption WindowX标题栏
可以且仅可以用于调整 _WindowX 窗体X_ 控件的标题栏区域。  

#### WindowXModalDialog WindowX模态对话框
可以且仅可以用于调整  _WindowX 窗体X_ 控件的模态按钮栏区域。  

#### IconHelper 图标
可以用于调整任何带有 _Icon 图标_ 属性的控件（例如 _Button 按钮_ 、 _DateTimePickerX 日期时间选择器_ 等）的图标样式。  

#### ShadowHelper 阴影
 可以用于调整任何带有 _ShadowColor 阴影_ 或 _XxxShadowColor Xxx阴影_ 属性（例如 _HoverShadowColor_ 和 _CheckedShadowColor_ 等）的控件（如 _Button 按钮_ 、 _DateTimePicker_ 等）的阴影效果。  

#### DropDownHelper 下拉框
可以用于调整任何带有 _PopupX_ 弹出框的控件（例如 _ComboBox 下拉框_ 、 _Menu 菜单_ 、 _ContextMenu 右键菜单_ 、 _DateTimePickerX 日期时间选择器_ 、 _DropDown 下拉菜单_ 等）的弹出框样式。  

### 属性
无论是原生控件还是Panuon.WPF.UI中提供的自定义控件，所有属性均采用相似的命名方式。  
  
#### 常规
  
定义悬浮效果的属性名称通常为`HoverXxx`，而定义选中效果的属性名称为`SelectedXxx` 或 `CheckedXxx` 。  
对于复杂控件，例如 _DataGrid_ ，属性还会增加前缀。例如，修改标头样式的属性名称为 `ColumnHeaderXxx`，修改单元格样式的属性名称为`CellXxx`，修改行样式的属性名称为`RowXxx`。  
  
#### 派生自ItemsControl的控件
  
对于派生自 _ItemsControl 项控件_ 的原生控件（例如 _ComboBox 下拉框_ 、_ListBox 列表_ 、 _TabControl 标签页_ 等），其控件和子项控件的属性会分别使用 _XxxHelper_ 和 _XxxItemHelper_ 做区分。
这里以 _ComboBox 下拉框_ 控件举例：
```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
···

<ComboBox pu:ComboBoxHelper.ItemsHoverBackground="Red">
    <ComboBoxItem Content="Item 1" />
    <ComboBoxItem Content="Item 2" />
    <ComboBoxItem Content="Item 3"
                  pu:ComboBoxItemHelper.HoverBackground="Blue" />
</ComboBox>
```
当鼠标悬浮在第1、2个 _ComboBoxItem_ 上时，它的背景色会变成红色；当鼠标悬浮在第3个子项上时， _ComboBoxItem_ 的背景色会变成蓝色。  
  
***
  
## 组件资源键
如果Panuon.WPF.UI在控件内使用了其他控件（例如 _WindowX 窗体X_ 标题栏中的最小化按钮 _Button 按钮_ 控件），并且你需要重新定义该控件的样式，就需要通过资源键来继承原有样式的属性值，并在此基础上进行修改。  
通常情况下，组件资源键的样式中只包含与显示效果有关的属性。这意味着，继承组件资源键的样式并不是必须的；但如果不从该资源键上继承样式，你可能需要通过添加更多的新属性来保证显示效果。  
  
### 资源键的格式
资源键的格式通常为（以控件文档中提供的为准）：  
`$PropertyName$Key`  
上述格式中的 _$PropertyName$_ 应当被替换为属性的名称。  
这是一个代码示例：
```xml
<pu:WindowXCaption.MinimizeButtonStyle>
    <Style TargetType="Button" BasedOn="{StaticResource {x:Static pu:WindowXCaption.MinimizeButtonStyleKey}}">
    </Style>
</pu:WindowXCaption.MinimizeButtonStyle>
```
上述示例演示了继承WindowX最小化按钮样式的方法。其中，资源键的名称 = 属性名称 + `Key` 后缀。在Panuon.WPF.UI中，所有的资源键命名都遵循这种格式。  
  

> 注意：内部控件的样式不依赖任何资源字典。在不引用任何资源字典的情况下，就能继承资源键中的样式。  