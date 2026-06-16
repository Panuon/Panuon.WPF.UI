# Toast 弹出消息

## 小提示
1. 提供一系列属性和方法, 用于在 `WindowX 窗体X` 上显示弹出消息。`Toast 弹出消息` 不依赖任何 `Panuon.WPF.UI` 中的资源字典，即使不引用 `Control.xaml` ，也可使用 `Toast 弹出消息` 或自定义它的样式。  

## 方法

### Show

1. 该方法带有多个重载，请根据实际需要，选择合适的重载方法。
2. 全部参数:WindowX window, string message, ToastPosition position, double offset, int durationMs, ToastSetting setting, ToastWindow targetWindow。

| 属性 | 类型 | 描述 |
| --- | --- | ----------- |
| window | *WindowX* | 指定要弹出消息的 WindowX 窗体X 。如果此参数为空，弹出消息会使用 targetWindow 参数的值来寻找承载消息的窗体容器。但是，如果没有通过 targetWindow 参数找到对应的窗体，或目标窗体不是 WindowX 窗体X 类型，将会引发异常。 |
| message | *string* | 要显示的消息。 |
| position | *ToastPosition* | 要显示的消息位置，相对于窗体。 |
| offset | *double* | 消息的坐标位置偏移量，相对于窗体边缘。 |
| durationMs | *int* | 消息的持续时间，单位为毫秒。 |
| setting | *ToastSetting* | 弹出消息的属性设定。如果此参数不为空，将不再使用 `ToastSettings.Setting` 属性中的值。 |
| targetWindow | *ToastWindow* | 弹出消息自适应寻找窗体的逻辑。`MainWindow` 表示将在当前 `Application.Current.MainWindow` 窗体上弹出消息。`ActiveWindow` 表示将在当前 `Application.Current.Windows` 中寻找 `IsActive=True` 的窗体。注意，如果没有找到对应的窗体，或目标窗体不是 WindowX 窗体X 类型，将会引发异常。 | 

## ToastSetting中的属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| AnimationDuration | *Duration* | *0:0:0.5* | 获取或设置消息弹出动画的持续时间。 |
| AnimationEase | *AnimationEase* | *None* | 获取或设置消息弹出动画使用的缓动函数。有关WPF缓动函数的更多信息，请查阅 EasingFunction 相关的文档。 |
| DefaultPosition | *ToastPosition* | *Bottom* | 获取或设置默认弹出消息的位置。`Bottom`表示底部对齐， `Left`表示左侧对齐， `Top`表示顶部对齐，`Right`表示右侧对齐，`Center`表示中心对齐。 |
| LabelStyle | *Style* | *(见内部资源键)* | 获取或设置取消 Button 按钮 控件的样式。 | 
| Spacing | *double* | *20* | 获取或设置距离窗体边缘的默认间距。 | 

## 示例

### 示例1
<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/toast-1-_theme_.png"></img>

```xml
using Panuon.WPF.UI;
···

Toast.Show(window, "This is a toast message.");

//或者在WindowX中调用
Toast("This is a toast message.");
```
### 示例2
<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/toast-2-_theme_.png"></img>
> 将以下定义放置在 `App.xaml` 中的 `ResourceDictionary` 中（或其他资源字典文件中，但要确保在 `App.xaml` 中引用，或通过 `cs代码` 装填到 `Application.Current.Resources.MergedDictionaries` 中）。如果不清楚如何放置，请下载源代码并查看 `Samples` 项目。

```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
xmlns:puconfig="clr-namespace:Panuon.WPF.UI.Configurations;assembly=Panuon.WPF.UI"
···

<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                    xmlns:pu="https://opensource.panuon.com/wpf-ui">
    <!--注意，出于某种未知的原因，无论是否在App.xaml中直接定义，都需要在根资源字典中再嵌套一层资源字典。-->
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary>
            <!--x:Key的值是任意的，没有特殊要求-->
            <pu:ToastSettings x:Key="toastSetting" Spacing="25">
                <pu:ToastSettings.LabelStyle>
                    <Style TargetType="Label" BasedOn="{StaticResource {x:Static pu:Toast.LabelStyleKey}}">
                        <Setter Property="Background" Value="#80BEE8" />
                        <Setter Property="Foreground" Value="#FFFFFF" />
                        <Setter Property="pu:LabelHelper.CornerRadius" Value="15" />
                        <Setter Property="pu:LabelHelper.ShadowColor" Value="#80BEE8" />
                        <Setter Property="pu:ShadowHelper.Opacity" Value="0.5" />
                    </Style>
                </pu:ToastSettings.LabelStyle>
            </pu:ToastSettings>
        </ResourceDictionary>
    </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```
```xml
using Panuon.WPF.UI;
···
var setting = Application.Current.FindResource("toastSetting") as ToastSetting;

Toast.Show(window, "This is a toast message.");

//或者在WindowX中调用
Toast("This is a toast message.");
```
