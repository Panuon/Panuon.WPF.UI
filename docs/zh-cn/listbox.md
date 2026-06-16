# ListBox 列表框

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.ListBoxStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.ListBoxHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="ListBox">* 或 *<pu:KeyOnlyStyleDictionary Includes="ListBox">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/ListBox.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/ListBoxStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。   

## 属性
以下属性包含在辅助类*ListBoxHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| AutoScrolllntoView | *bool* | *false* | 是否自动滚动到视图。 | 
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。 | 
| EmptyContent | *object* | *null* | 子项为空的文本。 | 
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。值为`null`时，不出现变化。 | 
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。值为`null`时，不出现变化。 | 
| ItemsBorderThickness | *Thickness* | *null* | 子项的边框粗细。 | 
| ItemsCornerRadius | *CornerRadius* | *0,0,0,0* | 子项的边框圆角。 | 
| ItemsHeight | *double* | *null* | 子项的高度。 | 
| ItemsHoverBackground | *Brush* | *(自动计算)* | 子项悬浮时的背景色。值为`null`时，悬浮不出现变化。 | 
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。值为`null`时，悬浮不出现变化。 | 
| ItemsHoverBorderThickness | *Thickness?* | *null* | 子项悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 | 
| ItemsHoverCornerRadius | *CornerRadius?* | *null* | 子项悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 | 
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。值为`null`时，悬浮不出现变化。 | 
| ItemsHoverShadowColor | *Color?* | *null* | 子项悬浮时边框的阴影。值为`null`时，悬浮不出现变化。阴影细节可以通过ShadowHelper 阴影辅助类控制。 | 
| ItemsIcon | *object* | *null* | 子项的图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]()。 | 
| ItemsIconPlacement | *IconPlacement* | *left* | 子项的图标位置。 | 
| ItemsIconWidth | *double* | *null* | 子项的图标宽度。 | 
| ItemsMargin | *Thickness* | *null* | 子项的外边距。 | 
| ItemsMaxHeight | *double* | *null* | 子项的最大高度。 | 
| ItemsMaxWidth | *double* | *null* | 子项的最大宽度。 | 
| ItemsMinHeight | *double* | *null* | 子项的最小高度。 | 
| ItemsMinWidth | *double* | *null* | 子项的最小宽度。 | 
| ItemsPadding | *Thickness* | *(跟随主控件)* | 子项的内边距。 | 
| ItemsRemoveButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 子项移除按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnNonnull` 表示当单选下拉框的文本不为空时显示，`VisibleOnHover` 表示当鼠标悬浮在单选下拉框上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在单选下拉框上且文本不为空时显示，`VisibleOnFocused` 表示当单选下拉框获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当单选下拉框获得键盘焦点且文本不为空时显示。。 | 
| ItemsSelectedBackground | *Brush* | *null* | 子项被选中时的背景色。值为`null`时，被选中不出现变化。 | 
| ItemsSelectedBorderBrush | *Brush* | *null* | 子项被选中时的边框色。值为`null`时，被选中不出现变化。。 | 
| ItemsSelectedBorderThickness | *Thickness?* | *null* | 子项被选中时的边框粗细。值为`null`时，被选中不出现变化。 | 
| ItemsSelectedCornerRadius | *CornerRadius?* | *null* | 子项被选中时的边框圆角。值为`null`时，被选中不出现变化。 | 
| ItemsSelectedForeground | *Brush* | *null* | 子项被选中时的前景色。值为`null`时，被选中不出现变化。 | 
| ItemsSelectedShadowColor | *Color?* | *null* | 子项被选中时边框的阴影。值为`null`时，被选中不出现变化。 | 
| ItemsSeparatorBrush | *Brush* | *null* | 子项分隔符的颜色。 | 
| ItemsSeparatorMargin | *Thickness* | *null* | 子项分隔符的间距。 | 
| ItemsSeparatorOrientation | *Orientatio* | *Vertical* | 子项分隔符的方向。 | 
| ItemsSeparatorThickness | *double* | *null* | 子项分隔符的粗细。 | 
| ItemsSeparatorVisibility | *Visibility* | *null* | 子项分隔符的显示模式。 | 
| ItemsShadowColor | *Color?* | *null* | 子项边框的阴影。值为`null`时，不出现变化。 | 
| ItemsWidth | *double* | *null* | 子项的宽度。 | 
| RemoveButtonStyle | *Style* | *(见内部资源键)* | 移除按钮的样式。 | 
| RemovingAnimationDuration | *TimeSpan?* | *null* | 移除动画的持续时间。值为`null`或`0`时，不会执行动画效果。 | 
| RemovingAnimationEasing | *AnimationEasing* | *null* | 移除动画的缓动函数。有关WPF缓动函数的更多信息，请查看[*WPF缓动函数文档*]()。 | 
| Scrollable | *bool* | *true* | 是否显示滚动条。 | 
| SelectedItems | *IList* | *null* | 选择的子项。 | 
| ShadowColor | *Color?* | *null* | 边框的阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 | 

## 事件
以下事件包含在辅助类*ListBoxHelper*中。  

| 事件 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ItemClick | *附加事件* | *null* | 点击子项事件。 | 
| ItemRemoved | *附加事件* | *null* | 移除子项事件。 | 
| ItemRemoving | *附加事件* | *null* | 正在移除子项事件。 | 


## 示例

### 示例1
<img height="60" src="https://assets.panuon.com/images/samples/wpf-ui/listbox-1-_theme_.gif"></img>

```xml
 <ListBox
    Width="250"
    Height="70"
    pu:ListBoxHelper.CornerRadius="5"
    pu:ListBoxHelper.ItemsHeight="50"
    pu:ListBoxHelper.ItemsHoverBackground="#5ebbf7"
    pu:ListBoxHelper.ItemsHoverBorderBrush="#5ebbf7"
    pu:ListBoxHelper.ItemsHoverBorderThickness="2"
    pu:ListBoxHelper.ItemsHoverCornerRadius="4,4,4,4"
    pu:ListBoxHelper.ItemsSelectedBackground="#5ebbf7"
    pu:ListBoxHelper.ItemsSelectedCornerRadius="4,4,4,4"
    pu:ListBoxHelper.ItemsWidth="60"
    BorderBrush="White">
        <ListBox.ItemsPanel>
            <ItemsPanelTemplate>
                <StackPanel Orientation="Horizontal" />
            </ItemsPanelTemplate>
        </ListBox.ItemsPanel>
    <ListBoxItem Content="Item 1" />
    <ListBoxItem Content="Item 2" />
    <ListBoxItem Content="Item 3" />
</ListBox>
```