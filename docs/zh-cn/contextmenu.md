# ContextMenu 标签

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.ContextMenuStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.ContextMenuHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="ContextMenu">* 或 *<pu:KeyOnlyStyleDictionary Includes="ContextMenu">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/ContextMenu.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/ContextMenu.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。
2. `ContextMenuHelper.Background`属性可以加在Window或者Grid等容器上，让里面所有子项的ContextMenu的背景色都改变。  

## 属性
以下属性包含在辅助类*ContextMenuHelper*中。  
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ArrowlconTemplate | *DataTemplate* | *null* | 自定义箭头模板。 |
| Background | *Brush* | *null* | 控件的背景色，值为`null`时，不出现变化。 |
| BorderBrush | *Brush* | *null* | 控件的边框色。 |
| BorderThickness | *Thickness* | *1,1,1,1* | 控件的边框粗细。 |
| CheckedlconTemplate | *DataTemplate* | *null* | 被选中时自定义箭头模板。 |
| CornerRadius | *CornerRadius* | *0,0,0,0* | 控件的边框圆角。 |
| Foreground | *Brush* | *null* | 前景色，值为`null`时，不出现变化。 |
| Height | *double* | *null* | 控件的高度。 |
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |
| ItemsBorderThickness | *Thickness* | *null* | 子项的边框粗细。 |
| ItemsCheckedBackground | *Brush* | *null* | 子项被选中时的背景色。 |
| ItemsCheckedBorderBrush | *Brush* | *null* | 子项被选中时的边框色。 |
| ItemsCheckedBorderThickness | *Thickness* | *0,0,0,0* | 子项被选中时的边框粗细。 |
| ItemsCheckedCornerRadius | *CornerRadius* | *null* | 子项被选中时的边框圆角。 |
| ItemsCheckedForeground | *Brush* | *nul* | 子项被选中时的前景色。 |
| ItemsClickBackground | *Brush* | *null* | 点击子项的背景色。 |
| ItemsClickBorderBrush | *Brush* | *null* | 点击子项的边框色。 |
| ItemsClickBorderThickness | *Thickness* | *0,0,0,0* | 点击子项的边框粗细。 |
| ItemsClickCornerRadius | *CornerRadius* | *null* | 点击子项的边框圆角。 |
| ItemsClickForeground | *Brush* | *null* | 点击子项的前景色。 |
| ItemsCornerRadius | *CornerRadius* | *null* | 子项的边框圆角。 |
| ItemsHeight | *double* | *null* | 子项的高度。 |
| ItemsHoverBackground | *Brush* | *null* | 子项悬浮时的背景色。 |
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。 |
| ItemsHoverBorderThickness | *Thickness* | *0,0,0,0* | 子项悬浮时的边框粗细。 |
| ItemsHoverCornerRadius | *CornerRadius* | *null* | 子项悬浮时的边框圆角。 |
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。 |
| ItemsIcon | *object* | *null* | 子项图标。可以是文本或图片路径，也可以是控件。图标的位置可以通过`IconPlacement`属性控制。要更改图标的间距、字体等属性，请查看[*IconHelper 图标*]()。 |
| ItemsIconWidth | *double* | *null* | 子项图标宽度。 |
| ItemsMargin | *Thickness* | *0,0,0,0* | 子项的外边距。 |
| ItemsOpenedBackground | *Brush* | *null* | 子项打开时的背景色。 |
| ItemsOpenedBorderBrush | *Brush* | *null* | 子项打开时的边框色。 |
| ItemsOpenedBorderThickness | *Thickness* | *0,0,0,0* | 子项打开时的边框粗细。 |
| ItemsOpenedCornerRadius | *Thickness* | *0,0,0,0* | 子项打开时的边框圆角。 |
| ItemsOpenedForeground | *Brush* | *null* | 子项打开时的前景色。 |
| ItemsPadding | *Thickness* | *(跟随主控件)* | 子项的内边距。 |
| ItemsSeparatorBrush | *Brush* | *null* | 子项分割线颜色。 |
| ItemsSeparatorMargin | *Thickness* | *0,0,0,0* | 子项分割线外边距。 |
| ItemsSeparatorThickness | *double* | *1* | 子项分割线的粗细。 |
| ItemsSeparatorVisibility | *Visibility* | *Collapsed* | 是否显示子项分割线，`Hidden`、`Collapsed` 表示隐藏，`Visible` 表示始终显示。 |
| ItemsWidth | *double* | *(自动计算)* | 子项的宽度。 |
| MaxHeight | *double* | *null* | 控件的最大高度。 |
| MaxWidth | *double* | *null* | 控件的最大宽度。 |
| MinHeight | *double* | *null* | 控件的最小高度。 |
| MinWidth | *double* | *null* | 控件的最小宽度。 |
| Padding | *Thickness* | *(跟随主控件)* | 控件的内边距。 |
| ShadowColor | *Color?* | *null* | 控件的阴影。 |
| Width | *double* | *null* | 控件的宽度。 |

## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/contextmenu-1-_theme_.gif"></img>
```xml
<Button
    Width="170"
    Height="40"
    Margin="50"
    pu:ButtonHelper.CornerRadius="4"
    pu:ButtonHelper.ShadowColor="#36AAF7"
    pu:IconHelper.Margin="0,0,10,0"
    pu:ShadowHelper.BlurRadius="15"
    pu:ShadowHelper.ShadowDepth="5"
    Background="#36AAF7"
    Content="右键点击"
    Foreground="#FFFFFF">
    <Button.ContextMenu>
        <ContextMenu
            pu:ContextMenuHelper.Background="#36AAF7"
            pu:ContextMenuHelper.BorderBrush="#2b88c6"
            pu:ContextMenuHelper.BorderThickness="1"
            pu:ContextMenuHelper.CornerRadius="5"
            pu:ContextMenuHelper.Foreground="#e6e6e6"
            pu:ContextMenuHelper.Height="200"
            pu:ContextMenuHelper.ItemsBorderBrush="{x:Null}"
            pu:ContextMenuHelper.ItemsBorderThickness="2"
            pu:ContextMenuHelper.ItemsCornerRadius="5"
            pu:ContextMenuHelper.ItemsHeight="50"
            pu:ContextMenuHelper.ItemsHoverBackground="#3199df"
            pu:ContextMenuHelper.ItemsHoverForeground="#ffffff"
            pu:ContextMenuHelper.ItemsMargin="10,0,10,0"
            pu:ContextMenuHelper.ItemsSeparatorVisibility="Hidden">
            <MenuItem Header="菜单项 1" />
            <MenuItem Header="菜单项 2" />
            <MenuItem Header="菜单项 3" />
        </ContextMenu>
    </Button.ContextMenu>
</Button>
```