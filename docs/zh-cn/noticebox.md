# NoticeBox 通知

## 小提示
1. 默认情况下，通知会在一个新的线程上启动。这意味着，即使你在打开通知后执行一个UI线程上的耗时操作，通知的UI线程也不会被干扰（即不会出现假死状态）。  
2. 请注意，`Panuon.WPF.UI.Configurations.NoticeBoxSetting` 和`Panuon.WPF.UI.NoticeBoxSettings` 是两个完全不同的类型（后者带s）。  
3. 要统一修改所有 NoticeBox 通知 的样式，你可以在 cs代码 中直接修改 `NoticeBoxSettings.Setting` 属性中的内容，或者也可以选择像示例3 中那样，将属性定义放置在 `App.xaml` 中。在使用后一种方案时，你仍然可以在 cs代码 中使用前一种方案来覆盖属性的值。
4. 如果要单独为某个 NoticeBox 通知 指定样式，请使用带有 setting 参数的 Show 重载方法，并在 cs代码 中创建 `MessageBoxSetting 对象`（或资源字典中创建，并使用 `Application.Current.FindResource()` 等类似的方法找到对象并传入（见示例2））。
5. 一旦 `Show` 方法被调用，之后该方法的 `setting` 参数中就只有 `NoticeBoxItemStyle` 属性会重新生效。要修改其他属性的值，请使用 `DestoryInstance()` 方法销毁实例，然后再次调用 `Show` 方法。
6. 当 `CreateOnNewThread` 属性为 `True` 时（它的默认值为 `True`）， 你无法在通知的内部样式中使用 `Panuon.WPF.UI` 中提供的任何资源（例如 `Style`），因为它们无法跨越线程。因此，`NoticeBox 通知` 是基于自定义或原生控件样式制作的。除非将 `CreateOnNewThread` 属性显式设置为 `False` ，否则你也应当使用原生控件来完成样式设计。 
7. 在Net Core(包括3.1,5,6)中会存在`NoticeBox`无法置顶的问题。这个问题是由于新开U!线程中的窗体，无法通过设置`Topmost`属性或调用`SetWindowPos`方法置顶导致的，暂时没有找到解决方案。如有必要，为了解决这个问题，请参照wiki文档中的方法将`CreateOnNewThread`属性设置为`False`。这可以解决无法置顶的问题，但`NoticeBox将`在当前UI线程中启动。如果程序退出时进程没有结束(比如App中`ShutdownMode`为`OnLastWindowClosed`)，则需要在程序准备退出时手动调用`NoticeBox.Destroylnstance()`方法来释放实例。  

## 方法

### Show

1. 该方法带有多个重载，请根据实际需要，选择合适的重载方法。
2. 全部参数:Window owner, string message, string caption, bool canCancel, MessageBoxXSetting setting。

| 属性 | 类型 | 描述 |
| --- | --- | ----------- |
| Owner | *Window* | 指定消息框的`Owner`窗体。如果此参数为空，消息框会显示在屏幕的中央。当此参数不为空时，消息框会显示在该参数窗体的中央。如果该参数窗体是[*WindowX 窗体X*]()类型，通知在打开和关闭时会自动控制该窗体的遮罩层。 | 
| message | *string* | 要显示的消息主体。 | 
| caption | *string* | 要显示的标题。 | 
| canCancel | *bool* | 是否显示取消通知项卡片并允许用户取消等待。 |  
| setting | *MessageBoxXSetting* | 框的属性设定。如果此参数不为空，将不再使用 `MessageBoxXSettings.Setting` 属性中的值。 |  

### DestroyInstance

> 销毁现有的 `NoticeBox 通知` 实例。这将关闭承载通知卡片的窗体，并终止已经创建的线程。
之后，你可以通过调用 `Show` 方法再次创建新的实例。

## NoticeBoxSetting中的属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CreateOnNewThread | *object* | *true* | 获取或设置是否在新线程上打开通知。当此属性值为 `True` 时，Panuon.WPF.UI会创建一个新的线程来承载通知。这在执行UI线程长时操作时非常有用。 |
| NoticeBoxItemStyle | *bool* | *(见内部资源键)* | 获取或设置 `NoticeBoxItem 通知项` 控件的样式。 | 
| AnimationEasing | *bool* | *None* | 获取或设置卡片弹出动画使用的缓动函数。有关WPF缓动函数的更多信息，请查阅 `EasingFunction` 相关的文档。 | 
| AnimationDuration | *bool* | *0:0:0.5* | 获取或设置卡片弹出动画的持续时间。 | 

## NoticeBoxItem中的属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| CaptionHeight | *Double* | *35* | 获取或设置标题的高度。 | 
| CornerRadius | *CornerRadius* | *0,0,0,0* | 获取或设置通知项卡片的圆角大小。 | 
| ShadowColor | *Color ?* | *Null* | 获取或设置通知项卡片的阴影颜色。此属性可以通过设置为 `Null (在Xaml中为 {x:Null})`来取消效果。若要更改阴影的模糊半径、深度等属性，请查看ShadowHelper 辅助类。 | 
| HoverBackground | *Brush* | *自动计算* | 获取或设置通知项卡片悬浮时的背景色彩画刷。此属性可以通过设置为 `Null (在Xaml中为 {x:Null})`来取消效果。 | 
| HoverForeground | *Brush* | *Null* | 获取或设置通知项卡片悬浮时的前景色彩画刷。此属性可以通过设置为 `Null (在Xaml中为 {x:Null})`来取消效果。 | 
| HoverBorderBrush | *Brush* | *Null* | 获取或设置通知项卡片悬浮时的边框色彩画刷。此属性可以通过设置为 `Null (在Xaml中为 {x:Null})`来取消效果。 | 
| HoverShadowColor | *Color?* | *Null* | 获取或设置通知项卡片悬浮时的阴影颜色。此属性可以通过设置为 `Null (在Xaml中为 {x:Null})`来取消效果。若要更改阴影的模糊半径、深度等属性，请查看ShadowHelper 辅助类。 | 
| ClickBackground | *Brush* | *自动计算* | 获取或设置通知项卡片点击时的背景色彩画刷。此属性可以通过设置为 `Null (在Xaml中为 {x:Null})`来取消效果。 | 
| ClickForeground | *Brush* | *Null* | 获取或设置通知项卡片点击时的前景色彩画刷。此属性可以通过设置为 `Null (在Xaml中为 {x:Null})`来取消效果。 | 
| ClickBorderBrush | *Brush* | *Null* | 获取或设置通知项卡片点击时的边框色彩画刷。此属性可以通过设置为 `Null (在Xaml中为 {x:Null})`来取消效果。 | 
| ClickBorderThickness | *Thickness?* | *Null* | 获取或设置通知项卡片点击时的边框色彩粗细。此属性可以通过设置为 `Null (在Xaml中为 {x:Null})`来取消效果。 | 
| ClickEffect | *ClickEffect* | *None* | 获取或设置通知项卡片的点击特效。`None` 表示没有点击特效，`Sink` 表示点击时下沉，`Shake` 表示点击时抖动。 | 

## 示例

### 示例1

<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/noticebox-1-_theme_.gif"></img>

```xml
using Panuon.WPF.UI;
···

var handler = NoticeBox.Show("正在执行...", "提示", MessageBoxIcon.Info);
```

### 示例2

<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/noticebox-2-_theme_.gif"></img>
> 将以下定义放置在 App.xaml 中的 ResourceDictionary 中（或其他资源字典文件中，但要确保在 App.xaml 中引用，或通过 cs代码 装填到 Application.Current.Resources.MergedDictionaries 中）。如果不清楚如何放置，请下载源代码并查看 Samples 项目。

```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
xmlns:puconfig="clr-namespace:Panuon.WPF.UI.Configurations;assembly=Panuon.WPF.UI"
···

<puconfig:NoticeBoxSetting x:Key="CustomNoticeSetting"  AnimationEasing="CircleOut" AnimationDuration="0:0:1.5" />
```
```xml
using Panuon.WPF.UI;
using Panuon.WPF.UI.Configurations;
···

var setting = Application.Current.FindResource("CustomNoticeSetting") as NoticeBoxSetting;
var handler = NoticeBox.Show("正在执行...", "提示", MessageBoxIcon.Info, true, setting);
```

### 示例3

<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/noticebox-3-_theme_.gif"></img>
> 将以下定义放置在 App.xaml 中的 ResourceDictionary 中（或其他资源字典文件中，但要确保在 App.xaml 中引用，或通过 cs代码 装填到 Application.Current.Resources.MergedDictionaries 中）。如果不清楚如何放置，请下载源代码并查看 Samples 项目。

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
            <pu:NoticeBoxSettings x:Key="noticeSetting" AnimationDuration="0:0:1" AnimationEasing="CubicInOut">
                <pu:NoticeBoxSettings.NoticeBoxItemStyle>
                    <Style TargetType="pu:NoticeBoxItem"
                           BasedOn="{StaticResource {x:Static pu:NoticeBox.NoticeBoxItemStyleKey}}">
                        <Setter Property="Background" Value="#1E1E1E" />
                        <Setter Property="BorderBrush" Value="#4E4E4E" />
                        <Setter Property="Foreground" Value="White" />
                        <Setter Property="ClickEffect" Value="None" />
                    </Style>
                </pu:NoticeBoxSettings.NoticeBoxItemStyle>
            </pu:NoticeBoxSettings>
        </ResourceDictionary>
    </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```
```xml
using Panuon.WPF.UI;
···

var setting = Application.Current.FindResource("noticeSetting") as NoticeBoxSetting;
var handler = NoticeBox.Show("正在执行...", "提示", MessageBoxIcon.Info, true, setting);
```