# ListView 列表视图

#### 资源键代码：  
`{StaticResource {x:Static pu:StyleKeys.ListViewStyle}}`  

#### 辅助类：  
_Panuon.WPF.UI.ListViewHelper_  

#### 依赖于：  
*<pu:StyleDictionary Includes="ListView">* 或 *<pu:KeyOnlyStyleDictionary Includes="ListView">*  

#### 实际资源字典：  
*pack://application:,,,/Panuon.WPF.UI;component/Styles/ListView.xaml* 或 *pack://application:,,,/Panuon.WPF.UI;component/Styles/ListViewStyle.xaml*

---

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性
以下属性包含在辅助类*ListViewHelper*中。  
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ColumnHeaderBackground | *Brush* | *null* | 列头的背景色。 |
| ColumnHeaderClickBackground | *Brush* | *(自动计算)* | 点击列头时的背景色。值为`null`时，点击不出现变化。 |
| ColumnHeaderClickBorderBrush | *Brush* | *null* | 点击列头时的边框色。值为`null`时，点击不出现变化。 |
| ColumnHeaderClickBorderThickness | *Thickness?* | *null* | 点击列头时的边框粗细。值为`null`时，点击不出现变化。 |
| ColumnHeaderClickForeground | *Brush* | *null* | 点击列头时的前景色。值为`null`时，点击不出现变化。 |
| ColumnHeaderFontSize | *double* | *null* | 列头的字号。 |
| ColumnHeaderFontWeight | *FontWeight* | *null* | 列头的字体粗细。 |
| ColumnHeaderForeground | *Brush* | *null* | 列头的前景色。 |
| ColumnHeaderHeight | *double* | *null* | 列头的高度。 |
| ColumnHeaderHorizontalContentAlignment | *HorizontalAlignmen* | *Left* | 列头内容水平对齐方式。`Center`表示居中对齐，`Left`表示左对齐， `Right`表示右对齐， `Stretch`表示拉伸对齐 |
| ColumnHeaderHoverBackground | *Brush* | *null* | 列头悬浮时的背景色。 |
| ColumnHeaderHoverBorderBrush | *Brush* | *null* | 列头悬浮时的边框色。 |
| ColumnHeaderHoverBorderThickness | *Thickness?* | *null* | 列头悬浮时的边框粗细。 |
| ColumnHeaderHoverForeground | *Brush* | *null* | 列头悬浮时的前景色。 |
| ColumnHeaderPadding | *Thickness* | *null* | 列头内边距。 |
| ColumnHeaderPanelSeparatorBrush | *Brush* | *null* | 列头面板分割线的颜色。 |
| ColumnHeaderPanelSeparatorVisibility | *Visibility* | *Hidden* | 是否显示列头面板分割线。`Collapsed`表示隐藏，不会占用任何布局空间，`Visible`表示始终显示，`Hidden`表示隐藏。 |
| ColumnHeaderVerticalContentAlignment | *VerticalAlignment* | *null* | 列头垂直对齐方式。`Bottom`表示底部对齐，`Center`表示居中显示，`Stretch`表示自动调整大小以填充，`Top`表示顶部对齐。 |
| ItemsBackground | *Brush* | *(自动计算)* | 子项的背景色。 |
| ItemsBorderBrush | *Brush* | *null* | 子项的边框色。 |
| ItemsBorderThickness | *Thickness?* | *null* | 子项的边框粗细。 |
| ItemsCornerRadius | *CornerRadius* | *null* | 子项的边框圆角。 |
| ItemsHeight | *double* | *(自动计算)* | 子项的高度。 |
| ItemsHoverBackground | *Brush* | *(自动计算)* | 子项悬浮时的背景色。值为null时，悬浮不出现变化。 |
| ItemsHoverBorderBrush | *Brush* | *null* | 子项悬浮时的边框色。值为null时，悬浮不出现变化。 |
| ItemsHoverForeground | *Brush* | *null* | 子项悬浮时的前景色。值为null时，悬浮不出现变化。 |
| ItemsMargin | *Thickness* | *0,0,0,0* | 子项的外边距。 |
| ItemsMaxHeight | *double* | *null* | 子项的最大高度。 |
| ItemsMinHeight | *double* | *null* | 子项的最小高度。 |
| ItemsPadding | *Thickness* | *(跟随主控件)* | 子项的内边距。 |
| ItemsSelectedBackground | *Brush* | *null* | 子项被选中时的背景色。值为null时，被选中不出现变化。 |
| ItemsSelectedBorderBrush | *Brush* | *null* | 子项被选中时的边框色。值为null时，被选中不出现变化。 |
| ItemsSelectedBorderThickness | *Thickness?* | *null* | 子项被选中时的边框粗细。值为null时，被选中不出现变化。 |
| ItemsSelectedForeground | *Brush* | *null* | 子项被选中时的前景色。值为null时，被选中不出现变化。 |
| ItemsSeparatorBrush | *Brush* | *null* | 子项分割线的颜色。 |
| ItemsSeparatorMargin | *Thickness* | *0,0,0,0* | 子项分割线的外边距。 |
| ItemsSeparatorThickness | *double* | *1* | 子项分割线的粗细。 |
| ItemsSeparatorVisibility | *Visibility* | *Hidden* | 是否显示子项分割线。`Collapsed`表示隐藏，不会占用任何布局空间，`Visible`表示始终显示，`Hidden`表示隐藏。 |
| ResizeThumbThickness | *double* | *null* | 拇指的厚度。 |
| Selectedltems | *IList* | *null* | 被选中的项。 |

## 示例

### 示例1
<img height="200" src="https://assets.panuon.com/images/samples/wpf-ui/listview-1-_theme_.gif"></img>

```xml
<ListView
    Name="myListView"
    Padding="7,5,7,5"
    HorizontalAlignment="Center"
    HorizontalContentAlignment="Center"
    pu:ListViewHelper.ColumnHeaderBackground="#FFFFFFFF"
    pu:ListViewHelper.ColumnHeaderClickBackground="#FFF5F5F8"
    pu:ListViewHelper.ColumnHeaderClickBorderBrush="#00FFFFFF"
    pu:ListViewHelper.ColumnHeaderClickBorderThickness="0,0,0,0"
    pu:ListViewHelper.ColumnHeaderClickForeground="#FF3FCC8F"
    pu:ListViewHelper.ColumnHeaderForeground="#000000"
    pu:ListViewHelper.ColumnHeaderHoverBackground="#FFF5F5F8"
    pu:ListViewHelper.ColumnHeaderHoverBorderBrush="#00FFFFFF"
    pu:ListViewHelper.ColumnHeaderHoverBorderThickness="0,0,0,0"
    pu:ListViewHelper.ColumnHeaderHoverForeground="#FF3FCC8F"
    pu:ListViewHelper.ItemsCornerRadius="5"
    pu:ListViewHelper.ItemsHoverBackground="#86ccfa"
    pu:ListViewHelper.ItemsHoverForeground="#000000"
    pu:ListViewHelper.ItemsMargin="10,0,10,10"
    pu:ListViewHelper.ItemsSelectedBackground="#36aaf7"
    pu:ListViewHelper.ItemsSelectedForeground="#FFFFFFFF"
    Background="#FFFFFFFF"
    BorderBrush="#FFFFFFFF"
    BorderThickness="0,0,0,0"
    Foreground="#4e5154">
    <ListView.View>
        <GridView>
            <GridViewColumn
                Width="100"
                DisplayMemberBinding="{Binding ID}"
                Header="ID" />
            <GridViewColumn
                Width="100"
                DisplayMemberBinding="{Binding Name}"
                Header="Name" />
            <GridViewColumn
                Width="100"
                DisplayMemberBinding="{Binding Age}"
                Header="Age" />
        </GridView>
    </ListView.View>
</ListView>
```
```xml
public List<Person> People { get; set; }
public MainWindow()
{
    InitializeComponent();
    People = new List<Person>
        {
            new Person { ID = 1, Name = "John Doe", Age = 25 },
            new Person { ID = 2, Name = "Jane Smith", Age = 30 },
            new Person { ID = 3, Name = "Alice Johnson", Age = 28 }
        };
    myListView.ItemsSource = People;
}

public class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
```