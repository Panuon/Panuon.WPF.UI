# PendingBox 等待框

## 小提示
1. 当 `CreateOnNewThread` 属性为 `True` 时（它的默认值为 `True`）， 你无法在等待框的内部样式中使用 `Panuon.WPF.UI` 中提供的任何资源（例如 `Style`），因为它们无法跨越线程。因此，`PendingBox 等待框` 是基于自定义或原生控件样式制作的。除非将 `CreateOnNewThread` 属性显式设置为 `False` ，否则你也应当使用原生控件来完成样式设计。  
2. `PendingBox 等待框` 不会阻塞当前的进程。
默认情况下，等待框会在一个新的线程上启动。这意味着，即使你在打开等待框后执行一个UI线程上的耗时操作，等待框的UI线程也不会被干扰（即不会出现假死状态）。但如果你在调用 `Show` 方法后立即执行UI线程耗时操作，则可能会出现 `owner` 窗体遮罩层无法打开的情况（如果 owner 参数为 `Panuon.WPF.UI.WindowX` 类型），如果遇到这种情况，可以尝试在执行代码前，调用 `await Task.Delay(300)`;。  
3. 请注意，`Panuon.WPF.UI.Configurations.PendingBoxSetting` 和 `Panuon.WPF.UI.PendingBoxSettings` 是两个完全不同的类型（后者带s）。
4. 要统一修改所有 `PendingBox` 等待框 的样式，你可以在 `cs代码` 中直接修改 `PendingBoxSettings.Setting` 属性中的内容，或者也可以选择像 `示例3` 中那样，将属性定义放置在 `App.xaml` 中。在使用后一种方案时，你仍然可以在 `cs代码` 中使用前一种方案来覆盖属性的值。
5. 如果要单独为某个 `PendingBox 等待框` 指定样式，请使用带有 `setting` 参数的 `Show` 重载方法，并在 cs代码 中创建 `MessageBoxSetting` 对象（或资源字典中创建，并使用 `Application.Current.FindResource()` 等类似的方法找到对象并传入（见`示例2`））。

## 方法

### Show

1. 该方法带有多个重载，请根据实际需要，选择合适的重载方法。
2. 全部参数:    Window owner, string message, string caption, bool canCancel, MessageBoxXSetting setting。

| 属性 | 类型 | 描述 |
| --- | --- | ----------- |
| Owner | *Window* | 指定等待框的 Owner 窗体。如果此参数为空，等待框会显示在屏幕的中央。当此参数不为空时，等待框会显示在该参数窗体的中央。如果该参数窗体是[*WindowX 窗体X*]() 类型，等待框在打开和关闭时会自动控制该窗体的遮罩层。 | 
| message | *string* | 要显示的消息主体。 | 
| caption | *string* | 要显示的标题。 | 
| canCancel | *bool* | 是否显示取消按钮并允许用户取消等待。 |
| setting | *MessageBoxXSetting* | 等待框的属性设定。如果此参数不为空，将不再使用 `PendingBoxSettings.Setting` 属性中的值。 | 

## PendingBoxSetting中的属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| InteropOwnersMask | *bool* | *true* | 获取或设置是否控制 `owner` 方法参数窗体的遮罩层（当 owner 是 WindowX 窗体X 类型时）。 | 
| CreateOnNewThread | *bool* | *true* | 获取或设置是否在新线程上打开等待框。当此属性值为 `True` 时，Panuon.WPF.UI会创建一个新的线程来承载等待框。这在执行UI线程长时操作时非常有用。如果 `owner` 窗体的遮罩层无法及时打开，请尝试在执行代码前调用 `await Task.Delay(300);`。 |
| CancelButtonStyle | *Style* | *(见内部资源键)* | 获取或设置取消 `Button 按钮` 控件的样式。 |
| WindowStyle | *Style* | *(见内部资源键)* | 获取或设置 `Window 窗体` 控件的样式。 |
| SpinStyle | *Style* | *(见内部资源键)* | 获取或设置等待 `Spin 等待中` 控件的样式。 |
| ContentTemplate | *Style* | *(见内部资源键)* | 获取或设置等待框的内容模板。 |
| CancelButtonContent | *Style* | *(见内部资源键)* | 获取或设置“取消”按钮的内容。 |

## 示例

### 示例1
<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/pendingbox-1-_theme_.png"></img>

```xml
using Panuon.WPF.UI;
···

var handler = PendingBox.Show(this, "正在执行...", "提示");
```
### 示例2
<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/pendingbox-2-_theme_.png"></img>
> 将以下定义放置在 `App.xaml` 中的 `ResourceDictionary` 中（或其他资源字典文件中，但要确保在 `App.xaml` 中引用，或通过 `cs代码` 装填到 `Application.Current.Resources.MergedDictionaries` 中）。如果不清楚如何放置，请下载源代码并查看 `Samples `项目。

```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
xmlns:puconfig="clr-namespace:Panuon.WPF.UI.Configurations;assembly=Panuon.WPF.UI"
···

<puconfig:PendingBoxSetting x:Key="CustomPendingSetting"
                             CancelButtonContent="CANCEL" />
```
```xml
using Panuon.WPF.UI;
using Panuon.WPF.UI.Configurations;
···

var setting = Application.Current.FindResource("CustomPendingSetting") as PendingBoxSetting;
var handler = PendingBox.Show(this, "正在执行...", "提示", true, setting);
```
### 示例3
<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/pendingbox-3-_theme_.png"></img>
> 将以下定义放置在 `App.xaml` 中的 `ResourceDictionary` 中（或其他资源字典文件中，但要确保在 `App.xaml` 中引用，或通过 `cs代码` 装填到 `Application.Current.Resources.MergedDictionaries 中）`。如果不清楚如何放置，请下载源代码并查看 `Samples` 项目。

```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
···

<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                    xmlns:pu="https://opensource.panuon.com/wpf-ui">
    <!--注意，出于某种未知的原因，无论是否在App.xaml中直接定义，都需要在根资源字典中再嵌套一层资源字典。-->
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary>
            <!--x:Key的值是任意的，没有特殊要求-->
            <pu:PendingBoxSettings x:Key="CustomPendingSetting">
                <pu:PendingBoxSettings.SpinStyle>
                    <Style BasedOn="{StaticResource {x:Static pu:PendingBox.SpinStyleKey}}" TargetType="pu:Spin">
                        <Setter Property="SpinStyle" Value="Ring2" />
                        <Setter Property="GlyphBrush" Value="#6CBCEA" />
                    </Style>
                </pu:PendingBoxSettings.SpinStyle>
                <pu:PendingBoxSettings.CancelButtonStyle>
                    <!--注意：PendingBox.Settings.CreateOnNewThread为True时，不能使用Panuon.WPF.UI中提供的按钮样式-->
                    <Style BasedOn="{StaticResource {x:Static pu:PendingBox.CancelButtonStyleKey}}"
                           TargetType="Button">
                        <Setter Property="Background" Value="#6CBCEA" />
                        <Setter Property="Foreground" Value="White" />
                        <Style.Triggers>
                            <Trigger Property="IsPressed" Value="True">
                                <Setter Property="Background" Value="#6CABEA" />
                            </Trigger>
                        </Style.Triggers>
                    </Style>
                </pu:PendingBoxSettings.CancelButtonStyle>
            </pu:PendingBoxSettings>
        </ResourceDictionary>
    </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```
```xml
using Panuon.WPF.UI;
using Panuon.WPF.UI.Configurations;
···

var setting = Application.Current.FindResource("CustomPendingSetting") as PendingBoxSetting;
var handler = PendingBox.Show(this, "正在执行...", "提示", true, setting);
```
### 示例4
<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/pendingbox-4-_theme_.png"></img>
> 将以下定义放置在 `App.xaml` 中的 `ResourceDictionary` 中（或其他资源字典文件中，但要确保在 `App.xaml` 中引用，或通过 `cs代码` 装填到 `Application.Current.Resources.MergedDictionaries` 中）。如果不清楚如何放置，请下载源代码并查看 `Samples` 项目。

```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
···

<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                    xmlns:pu="https://opensource.panuon.com/wpf-ui">
    <!--注意，出于某种未知的原因，无论是否在App.xaml中直接定义，都需要在根资源字典中再嵌套一层资源字典。-->
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary>
            <!--x:Key的值是任意的，没有特殊要求-->
            <pu:PendingBoxSettings x:Key="CustomPendingSetting">
                <pu:PendingBoxSettings.WindowStyle>
                    <Style BasedOn="{StaticResource {x:Static pu:PendingBox.WindowStyleKey}}" TargetType="Window">
                        <Setter Property="Padding" Value="20,0,20,20" />
                        <Setter Property="MinWidth" Value="300" />
                        <Setter Property="MinHeight" Value="180" />
                        <Setter Property="MaxWidth" Value="300" />
                        <Setter Property="MaxHeight" Value="180" />
                        <Setter Property="SizeToContent" Value="Manual" />
                        <Setter Property="Foreground" Value="White" />
                        <Setter Property="pu:WindowXCaption.Background" Value="Transparent" />
                        <Setter Property="BorderBrush" Value="Gray" />
                        <Setter Property="BorderThickness" Value="1" />
                        <Setter Property="Background" Value="#1E1E1E" />
                    </Style>
                </pu:PendingBoxSettings.WindowStyle>
                <pu:PendingBoxSettings.SpinStyle>
                    <Style BasedOn="{StaticResource {x:Static pu:PendingBox.SpinStyleKey}}" TargetType="pu:Spin">
                        <Setter Property="SpinStyle" Value="Ring2" />
                        <Setter Property="Width" Value="50" />
                        <Setter Property="Height" Value="50" />
                        <Setter Property="Margin" Value="0,0,0,20" />
                        <Setter Property="GlyphSize" Value="2" />
                        <Setter Property="GlyphBrush" Value="#1ABBEA" />
                    </Style>
                </pu:PendingBoxSettings.SpinStyle>
                <pu:PendingBoxSettings.ContentTemplate>
                    <DataTemplate>
                        <Grid VerticalAlignment="Center">
                            <Grid.RowDefinitions>
                                <RowDefinition Height="Auto" />
                                <RowDefinition Height="Auto" />
                                <RowDefinition />
                                <RowDefinition Height="Auto" />
                            </Grid.RowDefinitions>
                            <pu:Spin x:Name="PART_Spin" />
                            <TextBlock
                                x:Name="PART_CaptionTextBlock"
                                Grid.Row="1"
                                Margin="5,5,0,0"
                                TextAlignment="Center" />
                            <TextBlock
                                x:Name="PART_MessageTextBlock"
                                Grid.Row="2"
                                TextAlignment="Center"
                                TextWrapping="Wrap" />
                            <Button
                                x:Name="PART_CancelButton"
                                Grid.Row="3"
                                HorizontalAlignment="Center"
                                Background="#36AAF7"
                                Foreground="#FFFFFF"
                                Style="{x:Null}"
                                Visibility="Collapsed" />
                        </Grid>
                    </DataTemplate>
                </pu:PendingBoxSettings.ContentTemplate>
            </pu:PendingBoxSettings>
        </ResourceDictionary>
    </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```
```xml
using Panuon.WPF.UI;
···

var setting = Application.Current.FindResource("CustomPendingSetting") as PendingBoxSetting;
var handler = PendingBox.Show(this, "正在执行...", "提示", true, setting);
```