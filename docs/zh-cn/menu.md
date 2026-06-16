# Menu 菜单

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.MenuStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.MenuHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="Menu">* 或 *<pu:KeyOnlyStyleDictionary Includes="Menu">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/Menu.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/MenuStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性
以下属性包含在辅助类*MenuHelper*中。  

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ArrowIconTemplate | *DataTemplate* | *null* | 箭头图标外观模板。 |
| CheckedIconTemplate | *DataTemplate* | *null* | 选中图标模板。 |
| CornerRadius | *CornerRadius* | *null* | 边框圆角。 |
| SubmenuArrowIconTemplate | *DataTemplate* | *null* | 子菜单项箭头图标外观模板。 |
| Scrollable | *bool* | *true* | 是否可以滚动。 |
| SubmenuItemsHorizontalContentAlignment | *double* | *null* | 子菜单项中内容的水平对齐方式。 | 
| SubmenuItemsVerticalContentAlignment | *double* | *null* | 子菜单项中内容的垂直对齐方式。 |
| SubmenuItemsIconWidth | *double* | *null* | 子菜单项图标的宽度。 | 
| SubmenuItemsHeight | *double* | *null* | 子菜单项的高度。 |
| SubmenuItemsWidth | *double* | *null* | 子菜单项的宽度。 | 
| SubmenuItemsPadding | *Thickness* | *null* | 子菜单项的内边距。 |
| SubmenuItemsMargin | *Thickness* | *null* | 子菜单项的外边距。 |   
| SubmenuItemsIcon | *object* | *null* | 子菜单项的字体图标，可以是文本或图片路径，也可以是控件。图标的位置可以通过IconPlacement属性控制。要更改图标的间距、字体等属性，请查看IconHelper 图标。 |
| SubmenuItemsBackground | *Brush* | *null* | 子菜单项的背景色。 | 
| SubmenuItemsForeground | *Brush* | *null* | 子菜单项的前景色。 |
| SubmenuItemsBorderBrush | *Brush* | *null* | 子菜单项的边框色。 | 
| SubmenuItemsBorderThickness | *Thickness* | *null* | 子菜单项的边框粗细。 |
| SubmenuItemsCornerRadius | *CornerRadius* | *null* | 子菜单项的圆角。 | 
| SubmenuItemsHoverBackground | *Brush* | *null* | 子菜单项悬浮时的背景色。 |
| SubmenuItemsHoverForeground | *Brush* | *null* | 子菜单项悬浮时的前景色。 |  
| SubmenuItemsHoverBorderBrush | *Brush* | *null* | 子菜单项悬浮时的边框色。 | 
| SubmenuItemsHoverBorderThickness | *Thickness?* | *null* | 子菜单项悬浮时的边框粗细。 |  
| SubmenuItemsHoverCornerRadius | *CornerRadius?* | *null* | 子菜单项悬浮时的圆角。 |  
| SubmenuItemsClickBackground | *Brush* | *null* | 子菜单项点击时的背景色。 | 
| SubmenuItemsClickForeground | *Brush* | *null* | 子菜单项点击时的前景色。 |   
| SubmenuItemsClickBorderBrush | *Brush* | *null* | 子菜单项点击时的边框色。 |  
| SubmenuItemsClickBorderThickness | *Thickness?* | *null* | 子菜单项点击时的边框粗细。 | 
| SubmenuItemsClickCornerRadius | *CornerRadius?* | *null* | 子菜单项点击时的圆角。 |  
| SubmenuItemsOpenedBackground | *Brush* | *null* | 子菜单项展开时的背景色。 |  
| SubmenuItemsOpenedForeground | *Brush* | *null* | 子菜单项展开时的前景色。 | 
| SubmenuItemsOpenedBorderBrush | *Brush* | *null* | 子菜单项展开时的边框色。 |
| SubmenuItemsOpenedBorderThickness | *Thickness?* | *null* | 子菜单项展开时的白边框粗细。 |  
| SubmenuItemsOpenedCornerRadius | *CornerRadius?* | *null* | 子菜单项展开时的边框圆角。 | 
| SubmenuItemsCheckedBackground | *Brush* | *null* | 子菜单项选中时的背景色。 |  
| SubmenuItemsCheckedForeground | *Brush* | *null* | 子菜单项选中时的前景色。 |  
| SubmenuItemsCheckedBorderBrush | *Brush* | *null* | 子菜单项选中时的边框色。 | 
| SubmenuItemsCheckedBorderThickness | *Thickness?* | *null* | 子菜单项选中时的边框粗细。 |  
| SubmenuItemsCheckedCornerRadius | *CornerRadius?* | *null* | 子菜单项选中时的圆角。 | 
| SubmenuItemsSeparatorBrush | *Brush* | *null* | 子菜单项分隔线的颜色。 |  
| SubmenuItemsSeparatorThickness | *double* | *null* | 子菜单项分隔线的粗细。 | 
| SubmenuItemsSeparatorMargin | *Thickness* | *null* | 子菜单项分隔线的外边距。 |  
| SubmenuItemsSeparatorVisibility | *Visibility* | *null* | 子菜单项分隔线的的显示方式，`Collapsed`、`Hidden`表示隐藏，`Visible` 表示始终显示。 | 
| SubmenuDropDownPlacement | *PopupXPlacement* | *null* | 子菜单项的下拉菜单展开位置。 | 
| SubmenuDropDownHorizontalOffset | *double* | *null* | 子菜单项的下拉菜单的水平偏移量。 |  
| SubmenuDropDownVerticalOffset | *double* | *null* | 一子菜单项的下拉菜单的垂直偏移量。 |
| TopLevelArrowIconTemplate | *DataTemplate* | *null* | 一级标题的箭头图标样式。 | 
| TopLevelItemsHorizontalContentAlignment | *double* | *null* | 一级标题中内容的水平对齐方式。 |
| TopLevelItemsVerticalContentAlignment | *double* | *null* | 一级标题中内容的垂直对齐方式。 |
| TopLevelItemsIconWidth | *double* | *null* | 一级标题字体图标宽度。 |
| TopLevelItemsHeight | *double* | *null* | 一级标题高度。 |
| TopLevelItemsWidth | *double* | *null* | 一级标题宽度。 |
| TopLevelItemsPadding | *Thickness* | *null* | 一级标题的内边距。 |
| TopLevelItemsMargin | *Thickness* | *null* | 一级标题的外边距。 |
| TopLevelItemsIcon | *object* | *null* | 一级标题的字体图标，可以是文本或图片路径，也可以是控件。图标的位置可以通过IconPlacement属性控制。要更改图标的间距、字体等属性，请查看IconHelper 图标。 |
| TopLevelItemsBackground | *DataTemplate* | *null* | 一级标题的背景色。 |
| TopLevelItemsForeground | *Brush* | *null* | 一级标题的前景色。 |
| TopLevelItemsBorderBrush | *Brush* | *null* | 一级标题的边框色。 |
| TopLevelItemsBorderThickness | *Thickness* | *null* | 一级标题的边框粗细。 |
| TopLevelItemsCornerRadius | *CornerRadius* | *null* | 一级标题的边框圆角。 |
| TopLevelItemsHoverBackground| *Brush* | *null* | 一级标题悬浮时的背景色。 |
| TopLevelItemsHoverForeground | *Brush* | *null* | 一级标题悬浮时的前景色。 |
| TopLevelItemsHoverBorderBrush | *Brush* | *null* | 一级标题悬浮时的边框色。 |
| TopLevelItemsHoverBorderThickness | *Thickness?* | *null* | 一级标题悬浮时的边框粗细。 |
| TopLevelItemsHoverCornerRadius | *CornerRadius?* | *null* | 一级标题悬浮时的边框圆角 |
| TopLevelItemsClickBackground | *Brush* | *null* | 一级标题点击时的边背景色。 |
| TopLevelItemsClickForeground | *Brush* | *null* | 一级标题点击时的前景色。 |
| TopLevelItemsClickBorderBrush | *Brush* | *null* | 一级标题点击时的边框色。 |
| TopLevelItemsClickBorderThickness | *Thickness?* | *null* | 一级标题点击时的边框粗细。 |
| TopLevelItemsClickCornerRadius | *CornerRadius?* | *null* | 一级标题点击时的边框圆角。 |
| TopLevelItemsOpenedBackground | *Brush* | *null* | 一级标题展开时的边框色。 |
| TopLevelItemsOpenedForeground | *Brush* | *null* | 一级标题展开时的前景色。 |
| TopLevelItemsOpenedBorderBrush | *Brush* | *null* | 一级标题展开时的边框色。 |  
| TopLevelItemsOpenedBorderThickness | *Thickness?* | *null* | 一级标题展开时的边框粗细。 |
| TopLevelItemsOpenedCornerRadius | *CornerRadius?* | *null* | 一级标题展开时的圆角。 |
| TopLevelItemsCheckedBackground | *Brush* | *null* | 一级标题选中时的背景色。 |
| TopLevelItemsCheckedForeground | *Brush* | *null* | 一级标题选中时的前景色。 |
| TopLevelItemsCheckedBorderBrush | *Brush* | *null* | 一级标题选中时的边框色。 |
| TopLevelItemsCheckedBorderThickness | *Thickness?* | *null* | 一级标题选中时的边框粗细。 | 
| TopLevelItemsCheckedCornerRadius | *CornerRadius?* | *null* | 一级标题选中时的边框圆角。 |
| TopLevelItemsSeparatorBrush | *Brush* | *null* | 一级标题的分隔线颜色。 |
| TopLevelItemsSeparatorThickness | *double* | *null* | 一级标题的分隔线粗细。 |
| TopLevelItemsSeparatorMargin | *Thickness* | *null* | 一级标题的分隔线外边距。 |
| TopLevelItemsSeparatorVisibility | *Visibility* | *null* | 一级标题的显示方式，`Collapsed`、`Hidden`表示隐藏，`Visible` 表示始终显示。 |
| TopLevelDropDownPlacement | *PopupXPlacement* | *null* | 一级标题的下拉菜单展开位置。 |  
| TopLevelDropDownHorizontalOffset | *double* | *null* | 一级标题的下拉菜单的水平偏移量。 | 
| TopLevelDropDownVerticalOffset | *double* | *null* | 一级标题的下拉菜单的垂直偏移量。 |    


## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/menu-1-_theme_.gif"></img>

```xml
<Menu
    Width="200"
    Height="30"
    pu:DropDownHelper.Width="120"
    pu:MenuHelper.CornerRadius="10,10,10,10"
    pu:MenuHelper.SubmenuItemsBackground="#02FFFFFF"
    pu:MenuHelper.SubmenuItemsBorderBrush="#00FFFFFF"
    pu:MenuHelper.SubmenuItemsCheckedBackground="#708249CC"
    pu:MenuHelper.SubmenuItemsCheckedBorderBrush="#02FFFFFF"
    pu:MenuHelper.SubmenuItemsCheckedBorderThickness="0,0,0,0"
    pu:MenuHelper.SubmenuItemsCheckedCornerRadius="10,10,10,10"
    pu:MenuHelper.SubmenuItemsCheckedForeground="#FFFFFFFF"
    pu:MenuHelper.SubmenuItemsCornerRadius="10,10,10,10"
    pu:MenuHelper.SubmenuItemsForeground="#FFFFFFFF"
    pu:MenuHelper.SubmenuItemsHoverBackground="#4a1b98"
    pu:MenuHelper.SubmenuItemsHoverBorderBrush="#00FFFFFF"
    pu:MenuHelper.SubmenuItemsHoverBorderThickness="0,0,0,0"
    pu:MenuHelper.SubmenuItemsHoverCornerRadius="10,10,10,10"
    pu:MenuHelper.SubmenuItemsHoverForeground="#FFFFFFFF"
    pu:MenuHelper.SubmenuItemsMargin="2,2,2,2"
    pu:MenuHelper.SubmenuItemsOpenedBackground="#708249CC"
    pu:MenuHelper.SubmenuItemsOpenedBorderBrush="#00FFFFFF"
    pu:MenuHelper.SubmenuItemsOpenedBorderThickness="0,0,0,0"
    pu:MenuHelper.SubmenuItemsOpenedCornerRadius="10,10,10,10"
    pu:MenuHelper.SubmenuItemsOpenedForeground="#FFFFFFFF"
    pu:MenuHelper.SubmenuItemsPadding="7,0,7,0"
    pu:MenuHelper.TopLevelItemsBorderBrush="#00FFFFFF"
    pu:MenuHelper.TopLevelItemsCheckedBackground="#FF8249CC"
    pu:MenuHelper.TopLevelItemsCheckedBorderBrush="#00FFFFFF"
    pu:MenuHelper.TopLevelItemsCheckedBorderThickness="0,0,5,0"
    pu:MenuHelper.TopLevelItemsCheckedCornerRadius="10,10,10,10"
    pu:MenuHelper.TopLevelItemsCheckedForeground="#FFFFFFFF"
    pu:MenuHelper.TopLevelItemsCornerRadius="10,10,10,10"
    pu:MenuHelper.TopLevelItemsForeground="#C4FFFFFF"
    pu:MenuHelper.TopLevelItemsHoverBackground="#4a1b98"
    pu:MenuHelper.TopLevelItemsHoverBorderBrush="#00FFFFFF"
    pu:MenuHelper.TopLevelItemsHoverBorderThickness="0,0,5,0"
    pu:MenuHelper.TopLevelItemsHoverCornerRadius="10,10,10,10"
    pu:MenuHelper.TopLevelItemsHoverForeground="#FFFFFFFF"
    pu:MenuHelper.TopLevelItemsPadding="7,0,7,0"
    Background="#FF6A27D9"
    BorderBrush="#00FFFFFF"
    FontFamily="Microsoft YaHei UI"
    Foreground="#FFFFFFFF">
    <MenuItem Header="File">
<MenuItem Header="New" />
<MenuItem Header="Open" />
<MenuItem Header="Exit" />
    </MenuItem>
    <MenuItem Header="Edit">
<MenuItem Header="Undo" />
<MenuItem Header="Redo" />
    </MenuItem>
    <MenuItem Header="Help">
<MenuItem Header="About" />
    </MenuItem>
</Menu>
```
