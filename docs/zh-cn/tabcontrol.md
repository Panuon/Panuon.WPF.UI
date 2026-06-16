# TabControl 选项卡

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.TabControlStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.TabControlHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="TabControl">* 或 *<pu:KeyOnlyStyleDictionary Includes="TabControl">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/TabControl.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/TabControlStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  
2. 默认情况下，`ItemsHoverBackground`和`ItemsSelectedBackground`的值会与`Background`属性绑定，并通过转换器转换成更浅的颜色。如果将`Background`设置为渐变色，则转换不会生效，悬浮和点击时不会出现颜色变化。如果不需要显示悬浮颜色和点击颜色，可以将相应属性的值设置为 `null` (在XAML中为 `{x:Null}` )。  
3. *IconHelper.Margin*属性的默认值是`0,0,5,0`。当`IconPlacement`属性的值不是`Left`时，可能需要微调图标的显示位置。  

## 属性
以下属性包含在辅助类*TabControlHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CanHeaderPanelScroll | *bool* | *true* | 标题面板是否可以滚动。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 边框的圆角。| 
| EndControl | *object* | *null* | 结束控件。可以是文本或图片路径，也可以是控件。 |
| FrontControl | *object* | *null* | 顶层控件。可以是文本或图片路径，也可以是控件。 |
| HeaderPanelAlignment | *TabControlHeaderPanelAlignment* | *Front* | 标题面板排列方式。`Center`表示居中， `End`表示在在末尾 ，`Front`表示在顶层， `Stretch`表示自动适应。 |
| HeaderPanelBackground | *Brush* | *(自动计算)* | 标题面板的背景色。 |
| HeaderPanelBorderBrush | *Brush* | *null* | 标题面板的边框色。值为`null`时，不出现变化。 |
| HeaderPanelBorderThickness | *Thickness?* | *null* | 标题面板的的边框粗细。值为`null`时，不出现变化。 |
| HeaderPanelCornerRadius | *CornerRadius* | *0,0,0,0* | 标题面板的圆角。| 
| HeaderPanelHeight | *double* | *(自动计算)* | 标题面板的高度。 |		
| HeaderPanelMargin | *Thickness* | *0,0,0,0* | 标题面板的外边距。 |
| HeaderPanelPadding | *Thickness* | *(跟随主控件)* | 标题面板的内边距。 |
| HeaderPanelRibbonLineBrush | *Brush* | *null* | 标题面板丝带线的前景色。值为`null`时，不出现变化。 |
| HeaderPanelRibbonLineCornerRadius | *CornerRadius* | *0,0,0,0* | 标题面板丝带线的边框圆角。 |
| HeaderPanelRibbonLineStrategy | *HeaderPanelRibbonLineStrategy* | *null* | 标题面板丝带线显示模式。`BothSides`表示显示在两侧， `Stretch`表示拉伸至适应。 |
| HeaderPanelRibbonLineThickness | *double* | *null* | 标题面板丝带线的粗细。 |
| HeaderPanelRibbonLineVisibility | *Visibility* | *Collapsed* | 是否显示标题面面板丝带线。 |
| HeaderPanelScrollButtonStyle | *Style* | *(见内部资源键)* | 标题面板滚动按钮样式。 |
| HeaderPanelShadowColor | *Color?* | *null* | 标题面板的阴影。值为`null`时，不显示阴影。阴影细节可以通过ShadowHelper 阴影辅助类控制。 |
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |
| ItemsBorderThickness | *Thickness?* | *null* | 子项的边框粗细。 |
| ItemsCornerRadius | *CornerRadius?* | *null* | 子项的边框圆角。 |
| ItemsFontFamily | *FontFamily* | *null* | 子项字体库。 |
| ItemsFontSize | *double* | *null* | 子项的字号。 |
| ItemsForeground | *Brush* | *null* | 子项的前景色。 |
| ItemsHeight | *double* | *(自动计算)* | 子项的高度。 |
| ItemsHorizontalAlignment | *HorizontalAlignment* | *Center* | 子项对齐方式，`Center`表示居中`Left`表示左对齐，`Right`表示右对齐， `Stretch`表示自动调整。 |
| ItemsHorizontalHeaderAlignment | *HorizontalAlignment* | *Left* | 子项标题对齐方式，`Center`表示居中，`Left`表示左对齐，`Right`表示右对齐， `Stretch`表示自动调整。 |
| ItemsHoverBackground | *Brush* | *(自动计算)* | 子项悬浮时的背景色。值为`null`时，悬浮不出现变化。。 |
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverBorderThickness | *Thickness?* | *null* | 子项悬浮时的边框粗细。值为`null`时，悬浮不出现变化。 |
| ItemsHoverCornerRadius | *CornerRadius?* | *null* | 子项悬浮时的边框圆角。值为`null`时，悬浮不出现变化。 |
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。值为`null`时，悬浮不出现变化。 |
| ItemsHoverRibbonLineBrush | *Brush* | *null* | 子项悬浮时丝带线的前景色。值为`null`时，不出现变化。 |
| ItemsHoverRibbonLineThickness | *double* | *null* | 子项悬浮时丝带线的粗细。 |
| ItemsIcon | *object* | *null* | 子项的图标。可以是文本或图片路径，也可以是控件。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]()  。 |
| ItemsIconPlacement | *IconPlacement* | *Left* | 子项图标的位置。`Left` 表示显示在内容的左侧，`Top` 表示显示在内容的上方，`Right` 表示显示在内容的右侧，`Bottom` 表示显示在内容的下方。 |
| ItemsMargin | *Thickness* | *0,0,0,0* | 子项的外边距。 |
| ItemsPadding | *Thickness* | *(跟随主控件)* | 子项的内边距。 |
| ItemsRemoveButtonVisibility | *AuxiliaryButtonVisibility* | *Collapsed* | 子项移除按钮的显示模式。`Collapsed` 表示隐藏，`Visible` 表示始终显示，`VisibleOnNonnull` 表示当单选下拉框的文本不为空时显示，`VisibleOnHover` 表示当鼠标悬浮在单选下拉框上时显示，`VisibleOnHoverAndNonnull` 表示当鼠标悬浮在单选下拉框上且文本不为空时显示，`VisibleOnFocused` 表示当单选下拉框获得键盘焦点时显示，`VisibleOnFocusedAndNonnull` 表示当单选下拉框获得键盘焦点且文本不为空时显示。 |
| ItemsRibbonLineBrush | *Brush* | *null* | 子项丝带线的前景色。值为`null`时，不出现变化。 |
| ItemsRibbonLineCornerRadius | *CornerRadius* | *0,0,0,0* | 子项丝带线的边框圆角。 |
| ItemsRibbonLineMargin | *Thickness* | *0,0,0,0* | 子项丝带线的外边距。 |
| ItemsRibbonLinePlacement | *RibbonLinePlacement* | *Left* | 子项丝带线的位置。`Bottom`表示在底部，`Left`表示在左侧，`Right`表示在右侧，`Top`表示在顶部。 |
| ItemsRibbonLineThickness | *double* | *null* | 子项丝带线的粗细。 |
| ItemsRibbonLineVisibility | *Visibility* | *Collapsed* | 是否显示丝带线。 |
| ItemsSelectedBackground | *Brush* | *null* | 子项被选中时的背景色。值为`null`时，被选中不出现变化。 |
| ItemsSelectedBorderBrush | *Brush* | *null* | 子项被选中时的边框色。值为`null`时，被选中不出现变化。 |
| ItemsSelectedBorderThickness | *Thickness?* | *null* | 子项被选中时的边框粗细。值为`null`时，被选中不出现变化。 |
| ItemsSelectedCornerRadius | *CornerRadius?* | *null* | 子项被选中时的边框圆角。值为`null`时，被选中不出现变化。 |
| ItemsSelectedFontSize | *double* | *null* | 子项被选中时的字号。 |
| ItemsSelectedForeground | *Brush* | *null* | 子项被选中时的前景色。值为`null`时，被选中不出现变化。 |
| ItemsSelectedHeight | *double?* | *null* | 子项被选中时的高度。值为`null`时，被选中不出现变化。 |
| ItemsSelectedRibbonLineBrush | *Brush* | *null* | 子项被选中时丝带线的颜色。 |
| ItemsSelectedRibbonLineThickness | *double* | *null* | 子项被选中时丝带线的粗细。 |
| ItemsSelectedWidth | *double?* | *null* | 子项被选中时的宽度。值为`null`时，被选中不出现变化。 |
| ItemsSeparatorBrush | *Brush* | *Gray* | 子项分隔符的颜色。 |
| ItemsSeparatorMargin | *Thickness* | *0,0,0,0* | 子项分隔符的外边距。 |
| ItemsSeparatorThickness | *double* | *1* | 子项分隔符的粗细。 |
| ItemsSeparatorVisibility | *Visibility* | *Collapsed* | 是否显示子项分隔符。 |
| ItemsVerticalAlignment | *VerticalAlignment* | *Center* | 子项的垂直内容布局。`Center`表示显示居中，`Top` 表示显示在内容的上方，`Bottom` 表示显示在内容的下方， `Stretch`表示自动调整。 |
| ItemsVerticalHeaderAlignment | *VerticalAlignment* | *Left* | 子项标题的垂直内容布局。`Left` 表示显示在内容的左侧，`Top` 表示显示在内容的上方，`Right` 表示显示在内容的右侧，`Bottom` 表示显示在内容的下方。 |
| ItemsWidth | *double* | *(自动计算)* | 子项的宽度。 |
| RemoveButtonStyle | *Style* | *(见内部资源键)* | 清空按钮的 Button 按钮 控件样式。 |
| RemovingAnimationDuration | *TimeSpan?* | *null* | 子项移除时的动画持续时间。值为`null`或`0`时，不会执行动画效果。 |
| RemovingAnimationEasing | *AnimationEasing* | *None* | 子项移除时的动画缓动函数。有关WPF缓动函数的更多信息，请查看[*WPF缓动函数文档*]()。 |
| ScrollButtonStyle | *Style* | *(见内部资源键)* | 滚动按钮的样式。 |
| ScrollButtonVisibility | *Visibility* | *true* | 滚动按钮是否可见。 |
| ShadowColor | *Color?* | *null* | 边框的阴影。阴影细节可以通过*ShadowHelper 阴影*辅助类控制。 |

## 事件
以下属性包含在辅助类*TabControlHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ItemRemoving | *附加事件* | *null* | 移除子项事件。 |
| ItemRemoved | *附加事件* | *null* | 正在移除子项事件。 |

## 示例

### 示例1
<img height="300" src="https://assets.panuon.com/images/samples/wpf-ui/tabcontrol-1-_theme_.gif"></img>

```xml
<TabControl
    Width="150"             
    pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}"
    pu:TabControlHelper.CornerRadius="4,4,4,4"
    pu:TabControlHelper.HeaderPanelAlignment="Stretch"
    pu:TabControlHelper.HeaderPanelMargin="0,15,0,0"
    pu:TabControlHelper.ItemsBackground="Transparent"
    pu:TabControlHelper.ItemsHeight="40"
    pu:TabControlHelper.ItemsHorizontalHeaderAlignment="Left"
    pu:TabControlHelper.ItemsHoverBackground="#36AAF7"
    pu:TabControlHelper.ItemsHoverForeground="#FFFFFF"
    pu:TabControlHelper.ItemsPadding="20,0,0,0"
    pu:TabControlHelper.ItemsRibbonLineCornerRadius="4"
    pu:TabControlHelper.ItemsRibbonLineMargin="0,5,0,5"
    pu:TabControlHelper.ItemsRibbonLineThickness="4"
    pu:TabControlHelper.ItemsRibbonLineVisibility="Visible"
    pu:TabControlHelper.ItemsSelectedBackground="#36AAF7"
    pu:TabControlHelper.ItemsSelectedForeground="#FFFFFF"
    pu:TabControlHelper.ItemsSelectedRibbonLineBrush="#FFFFFF"
    pu:TabControlHelper.ItemsSelectedRibbonLineThickness="2"
    pu:TabControlHelper.ItemsWidth="150"
    TabStripPlacement="Left">
            <TabItem pu:TabItemHelper.Icon="&#xe941;" 
                Header="推荐" />
            <TabItem pu:TabItemHelper.Icon="&#xe96c;"
                Header="音乐"
                IsSelected="True" />
            <TabItem pu:TabItemHelper.Icon="&#xe96e;" 
                Header="下载" />
            <TabItem pu:TabItemHelper.Icon="&#xe928;" 
                Header="搜索" />
            <TabItem pu:TabItemHelper.Icon="&#xe939;" 
                Header="用户" />
            <TabItem pu:TabItemHelper.Icon="&#xe952;" 
                Header="喜欢" />
</TabControl>
```

