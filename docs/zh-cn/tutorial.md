# 开始使用

>在接下来的代码中，我们将创建一个名称为 `WpfApp1` 的 `WPF应用程序` 项目。请将代码段中名为 `WpfApp1` 的部分替换为你自己的项目名称。  
使用 `pu:` 前缀时，不要忘记在页面顶部添加 `xmlns:pu="https://opensource.panuon.com/wpf-ui"` 命名空间。

---

## 安装Nuget包
1. 在“解决方案资源管理器”中，右击你的WPF项目，选择 “管理 Nuget 程序包。”  
2. 在Nuget包管理器中，搜索 `Panuon.WPF.UI` ，并点击安装按钮。当前的最新版本为<img src="https://img.shields.io/nuget/v/Panuon.WPF.UI" />  
3. 等待安装完成。

## 确定使用方式
你希望将原生控件的默认样式都替换为Panuon.WPF.UI提供的样式，还是只在你指定的控件上生效？后者使你的项目可以同时使用其他控件库，避免样式冲突。  
  
> 无论使用哪种方式，都不会影响你使用 Panuon.WPF.UI 中提供的自定义控件（如 WindowX 、 SearchBox 等）。即使不执行以下步骤，也能在你的项目中使用它们。

### 选项1：替换所有原生控件的样式
打开项目的 `App.xaml` 文件，修改代码使其看起来如下：
```xml
<Application x:Class="WpfApp1.App"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:local="clr-namespace:WpfApp1"
             xmlns:pu="https://opensource.panuon.com/wpf-ui"
             StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <pu:StyleDictionary Includes="All" />
                <ResourceDictionary>
                    <pu:GlobalSettings x:Key="globalSettings"
                                       FontFamily="Arial" 
                                       FontSize="14"/>
                </ResourceDictionary>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```
我们在 `App.xaml` 中添加了两个内容： _StyleDictionary 样式字典_ 和 _GlobalSettings 全局设置_ 。  
如你所见，我们在 _StyleDictionary 样式字典_ 元素上使用了 `Includes="All"` ，这意味着所有的控件样式都会被引入到项目中。如果你只希望使用部分控件，可以像这样使用：
```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
...

<!--只要Button和TextBox-->
<pu:StyleDictionary Includes="Button,TextBox" />
<!--除了Button和TextBox，其他都要-->
<pu:StyleDictionary Excludes="Button,TextBox" />
```

如果不希望在整个程序范围内都使用Panuon.WPF.UI的样式，你也可以在 _Grid_ 、 _WindowX 窗体_ 等容器的 `Resources` 属性中添加它。这是一个例子：
```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
...

<Grid>
    <Grid.Resources>
        <pu:StyleDictionary Includes="All" />
    </Grid.Resources>
</Grid>
```

至于 _GlobalSettings 全局设置_ ，它可以用于设置字体、字号、图标字体、图标字号等内容。有关更多的内容，可以在文档中查看。    
额外提醒，它的 `x:Key` 可以是任何名称（只要不与这里可能添加的其他内容重名）。  

现在，你可以在任意界面中放上 _Button 按钮_ 之类的控件，它们将使用Panuon.WPF.UI提供的默认样式。   
```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
...

<Button x:Name="BtnOK" pu:ButtonHelper.HoverBackground="Red" />
```
当然，你也可以在C#中这样调用：  
```cs
ButtonHelper.SetHoverBackground(BtnOK, Brushes.Red);
```

### 选项2：在指定控件上使用样式
在选项1的说明中，我们向 `App.xaml` 中添加了 _StyleDictionary 样式字典_ 。现在，其他内容不变，将它替换为 _KeyOnlyStyleDictionary 资源键样式字典_ 。
```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
...

<pu:KeyOnlyStyleDictionary Includes="All" />
```

界面中的控件现在不会使用Panuon.WPF.UI提供的默认样式。要为指定的控件使用样式，需要使用以下代码：   
```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
...

<Button Style="{StaticResource {x:Static pu:StyleKeys.ButtonStyle}}"
        pu:ButtonHelper.HoverBackground="Red" />
```

稍微有些麻烦，但可以有效避免样式库之间产生冲突。  
如果需要编写 _Style_ ，必须添加 `BasedOn` ：
```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
...

<Style x:Key="MyButtonStyle" TargetType="Button" BasedOn="{StaticResource {x:Static pu:StyleKeys.ButtonStyle}}">
    <Setter Property="pu:ButtonHelper.HoverBackground" Value="Red"/>
</Style>
...

<Button Style="{DynamicResource MyButtonStyle}" />
```

## 将窗体更换为WindowX

> 即使不更换为 WindowX ，也可以继续使用控件库。  
Panuon.WPF.UI没有提供对原生 _Window 窗体_ 控件的样式支持，而是使用了自定义控件 _WindowX 窗体X_ 。_WindowX 窗体X_ 提供了更多有趣的功能，例如遮罩层和 _Toast 浮动通知_ 。  
打开 `MainWindow.xaml`，将 `<Window>` 根节点更换为 `<pu:WindowX>`：
```xml
<pu:WindowX ...
            xmlns:pu="https://opensource.panuon.com/wpf-ui"
            ...>
    ...
</pu:WindowX>
```
不要忘了 `MainWindow.xaml.cs`，需要将继承类型修改为：
```CS
using Panuon.WPF.UI;
...

public partial class MainWindow : WindowX
...
```

## 完成！
一切准备工作都就绪了。  
现在，请移步至各个控件的文档，每种控件有各自的示例代码。  