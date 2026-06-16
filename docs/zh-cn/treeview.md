# TreeView 树视图

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.TreeViewStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.TreeViewHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="TreeView">* 或 *<pu:KeyOnlyStyleDictionary Includes="TreeView">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/TreeView.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/TreeViewStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性
以下属性包含在辅助类*TreeViewHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框圆角。 |
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |
| ItemsBorderThickness | *Thickness?* | *null* | 子项的边框粗细。 |
| ItemsCornerRadius | *CornerRadius* | *null* | 子项的边框圆角。 |
| ItemsExpandedBackground | *Brush* | *null* | 子项展开的背景色。 |
| ItemsExpandedBorderBrush | *Brush* | *null* | 子项展开的边框色。 |
| ItemsExpandedBorderThickness | *Thickness?* | *null* | 子项展开的边框粗细。 |
| ItemsExpandedCornerRadius | *CornerRadius?* | *null* | 子项展开的边框圆角。 |
| ItemsExpandedForeground | *Brush* | *null* | 子项展开的前景色。 |
| ItemsExpandedShadowColor | *Color?* | *null* | 子项展开的阴影。 |
| ItemsExpandedToggleBrush | *Brush* | *null* | 子项展开的切换箭头颜色。 |
| ItemsHeight | *double* | *(自动计算)* | 子项的高度。 |
| ItemsHoverBackground | *Brush* | *(自动计算)* | 子项悬浮时的背景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderThickness | *Thickness?* | *null* | 子项悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| ItemsHoverCornerRadius | *CornerRadius?* | *null* | 子项悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverShadowColor | *Color?* | *null* | 子项悬浮时的阴影色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverToggleBrush | *Brush* | *null* | 子项悬浮时的切换箭头颜色。 |
| ItemsIcon | *object* | *null* | 子项的图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]()。 |
| ItemsIconWidth | *double* | *NaN* | 子项的图标容器宽度。即使子项没有图标，也会保留宽度，用于使内容对齐。 |
| ItemsMargin | *Thickness* | *0,0,0,0* | 子项的外边距。 |
| ItemsPadding | *Thickness* | *(跟随主控件)* | 子项的内边距。 |
| ItemsRulerLineBrush | *Brush* | *null* | 子项标尺线的颜色。 |
| ItemsRulerLineDashArray | *DoubleCollection* | *null* | 子项标尺线虚线数组。 |
| ItemsRulerLineThickness | *double* | *null* | 子项标尺线的粗细。 |
| ItemsRulerLineVisibility | *RulerLineVisibility* | *null* | 子项标尺线的显示方式。`Both`表示水平和垂直方向上同时显示，`Horizontal`表示水平显示，`None`表示不显示，`Vertica`表示垂直显示。 |
| ItemsSelectedBackground | *Brush* | *null* | 子项被选中时的背景色。值为`null`时，被选中不出现变化。 |
| ItemsSelectedBorderBrush | *Brush* | *null* | 子项被选中时的边框色。值为`null`时，被选中不出现变化。 |
| ItemsSelectedBorderThickness | *Thickness?* | *null* | 子项被选中时的边框粗细。值为`null`时，被选中不出现变化。 |
| ItemsSelectedCornerRadius | *CornerRadius?* | *null* | 子项被选中时的边框圆角。值为`null`时，被选中不出现变化。 |
| ItemsSelectedForeground | *Brush* | *null* | 子项被选中时的前景色。值为`null`时，被选中不出现变化。 |
| ItemsSelectedShadowColor | *Color?* | *null* | 子项被选中时的阴影。值为`null`时，被选中不出现变化。 |
| ItemsSelectedToggleBrush | *Brush* | *null* | 子项被选中时的切换箭头颜色。值为`null`时，被选中不出现变化。 |
| ItemsSeparatorBrush | *Brush* | *Gray* | 子项分隔符的颜色。 |
| ItemsSeparatorMargin | *Thickness* | *0,0,0,0* | 子项分隔符的外边距。 |
| ItemsSeparatorThickness | *double* | *1* | 子项分隔符的粗细。 |
| ItemsSeparatorVisibility | *Visibility* | *Collapsed* | 是否显示子项分隔符。 |
| ItemsShadowColor | *Color?* | *null* | 子项阴影。 |
| ItemsToggleBrush | *Brush* | *null* | 子项切换箭头颜色。 |
| ItemsWidth | *double* | *(自动计算)* | 子项的宽度。 |
| Scrollable | *bool* | *true* | 是否可以滚动。 |
| ShadowColor | *Color?* | *null* | 控件的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |
| ToggleArrowPlacement | *ToggleArrowPlacement* | *Left* | 切换箭头的位置。`Left`表示在左边，`Right`表示在右边。 |
| ToggleArrowToggleButtonStyle | *Style* | *(见内部资源键)* | 切换箭头样式。 |

## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/treeview-1-_theme_.gif"></img>

```xml
<TreeView
    Width="300"
    Height="300"
    pu:TreeViewHelper.CornerRadius="10,10,10,10"
    pu:TreeViewHelper.ItemsBackground="#FFFFFFFF"
    pu:TreeViewHelper.ItemsBorderBrush="#00FFFFFF"
    pu:TreeViewHelper.ItemsCornerRadius="10,10,10,10"
    pu:TreeViewHelper.ItemsHoverBackground="#FFFFFFFF"
    pu:TreeViewHelper.ItemsHoverBorderBrush="#00FFFFFF"
    pu:TreeViewHelper.ItemsHoverBorderThickness="0,0,0,0"
    pu:TreeViewHelper.ItemsHoverCornerRadius="10,10,10,10"
    pu:TreeViewHelper.ItemsHoverForeground="#FF000000"
    pu:TreeViewHelper.ItemsMargin="2,2,2,2"
    pu:TreeViewHelper.ItemsPadding="7,5,7,5"
    pu:TreeViewHelper.ItemsSelectedBackground="#FFFFFFFF"
    pu:TreeViewHelper.ItemsSelectedBorderBrush="#02FFFFFF"
    pu:TreeViewHelper.ItemsSelectedBorderThickness="0,0,0,0"
    pu:TreeViewHelper.ItemsSelectedCornerRadius="10,10,10,10"
    pu:TreeViewHelper.ItemsSelectedForeground="#FFF87406"
    pu:TreeViewHelper.ShadowColor="#FFF3DADA"
    Background="#FFF9FBFA"
    BorderBrush="#FFF9FBFA"
    Foreground="#FF818181">
    <TreeViewItem Header="Item 1">
<TreeViewItem Header="Item 1.1">
    <TreeViewItem Header="Item 1.1.1" />
    <TreeViewItem Header="Item 1.1.2" />
</TreeViewItem>
<TreeViewItem Header="Item 1.2" />
    </TreeViewItem>
    <TreeViewItem Header="Item 2">
<TreeViewItem Header="Item 2.1" />
<TreeViewItem Header="Item 2.2">
    <TreeViewItem Header="Item 2.2.1" />
</TreeViewItem>
    </TreeViewItem>
</TreeView>
```
