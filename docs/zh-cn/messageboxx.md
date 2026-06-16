# MessageBoxX 消息窗体

## 小提示
1. 如果消息框打开时闪烁过于明显，请考虑参考示例中的方法将`SizeToContent`属性设置为`False`，并手动指定窗体大小。  
2. 和原生的`MessageBox`不同，`MessageBoxX`是基于`WindowX窗体X`重新制作的。这意味着`MessageBoxX`不支持服务级别的消息弹框，一些表现行为也可能与`MessageBox`不一致。  
3. 请注意，`Panuon.WPF.UI.Configurations.MessageBoxXSetting`和`Panuon.WPF.UI.MessageBoxXSettings`是两个完全不同的类型（后者带s）。
4. 要统一修改所有`MessageBoxX`消息框X 的样式，你可以在`cs`代码中直接修改`MessageBoxXSettings.Setting`属性中的内容，或者也可以选择像`示例3`中那样，将属性定义放置在`App.xaml`中。在使用后一种方案时，你仍然可以在`cs代码`中使用前一种方案来覆盖属性的值。
5. 如果要单独为某个`MessageBoxX`消息框X指定样式，请使用带有`setting`参数的`Show`重载方法，并在`cs代码`中创建 `MessageBoxSetting`对象（或资源字典中创建，并使用`Application.Current.FindResource()`等类似的方法找到对象并传入（见`示例2`））。

## 方法

### Show

1. 该方法带有多个重载，请根据实际需要，选择合适的重载方法。
2. 全部参数:Window owner, string message, string caption, MessageBoxButton button, MessageBoxIcon icon, DefaultButton defaultButton, MessageBoxXSetting setting, int? countdown。

| 属性 | 类型 | 描述 |
| --- | --- | ----------- |
| Owner | *Window* | 指定消息框的`Owner`窗体。如果此参数为空，消息框会显示在屏幕的中央。当此参数不为空时，消息框会显示在该参数窗体的中央。如果该参数窗体是[*WindowX 窗体X*]()类型，消息框在打开和关闭时会自动控制该窗体的遮罩层。 | 
| message | *string* | 要显示的消息主体。 | 
| caption | *string* | 要显示的标题。 | 
| button | *MessageBoxButton* | 要显示的按钮。`OK`表示显示“确定”按钮。`OKCancel`表示显示“确定”和“取消”按钮。`YesNoCancel`表示显示“是”、“否”和“取消”按钮。`YesNo`表示显示“是”和“否”按钮。 | 
| icon | *MessageBoxIcon* | 要显示在消息主体左侧的图标。`None`表示不显示图标。`Info`表示显示消息图标。`Warning`表示显示警告图标。`Error`表示显示错误图标。`Success`表示显示成功图标。`Question`表示显示询问图标。 | 
| defaultButton | *DefaultButton* | 按下`Enter`键时默认触发的按钮。`Unset`表示不指定默认按钮。`YesOK`表示优先将`“是”`按钮设置为默认，否则再考虑`“确定”`按钮。`NoCancel`表示优先将`“否”`按钮设置为默认，否则再考虑`“取消”`按钮。`CancelNo`表示优先将`“取消”`按钮设置为默认，否则再考虑`“否”`按钮。 | 
| setting | *MessageBoxXSetting* | 消息框的属性设定。如果此参数不为空，将不再使用 `MessageBoxXSettings.Setting`属性中的值。 | 
| countdown | *int?* | 指定窗体倒计时（单位为秒）。倒计时结束时，会触发`defaultButton`参数中指定的默认按钮（如果使用了该参数且`defaultButton`参数的值为`Unset`， 将引发异常。）。 | 


## MessageBoxXSetting中的属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| InteropOwnersMask | *bool* | *true* | 打开时显示父窗体的遮罩。 | 
| InverseButtonsSequence | *bool* | *false* | 获取或设置是否反转按钮组的排列顺序。 |
| ButtonStyle | *Style* | *(见内部资源键)* | 获取或设置`Button`按钮控件的样式。 | 
| TextBoxStyle | *Style* | *(见内部资源键)* | 输入框的样式。 |
| WindowXStyle | *Style* | *(见内部资源键)* | 获取或设置[*WindowX窗体X*]()控件的样式。 | 
| ContentTemplate | *DataTemplate* | *(见内部资源键)* | 获取或设置消息框的内容模板。 |
| OKButtonContent | *object* | *null* | 获取或设置`“确定”`按钮的内容。 | 
| CancelButtonContent | *object* | *null* | 获取或设置`“取消”`按钮的内容。 |
| YesButtonContent | *object* | *null* | 获取或设置`“是”`按钮的内容。 | 
| NoButtonContent | *object* | *null* | 获取或设置`“否”`按钮的内容。 |

## 示例

### 示例1
<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/messageboxx-1-_theme_.png"></img>

```xml
using Panuon.WPF.UI;
···

MessageBoxX.Show(this, "你有一条新消息。", "提示", MessageBoxButton.OK, MessageBoxIcon.Info, DefaultButton.YesOK, 5);
```
### 示例2
<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/messageboxx-2-_theme_.png"></img>
> 将以下定义放置在 `App.xaml` 中的 `ResourceDictionary` 中（或其他资源字典文件中，但要确保在 `App.xaml` 中引用，或通过 `cs代码` 装填到 `Application.Current.Resources.MergedDictionaries` 中）。如果不清楚如何放置，请下载源代码并查看 `Samples` 项目。

```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
xmlns:puconfig="clr-namespace:Panuon.WPF.UI.Configurations;assembly=Panuon.WPF.UI"
···

<puconfig:MessageBoxXSetting x:Key="CustomSetting"
                             OKButtonContent="OK"
                             YesButtonContent="YES"
                             NoButtonContent="NO"
                             CancelButtonContent="CANCEL" />
```
```xml
using Panuon.WPF.UI;
using Panuon.WPF.UI.Configurations;
···

var setting = Application.Current.FindResource("CustomSetting") as MessageBoxXSetting;
MessageBoxX.Show(this, "你有一条新消息。", "提示", MessageBoxButton.OK, MessageBoxIcon.Info, DefaultButton.YesOK, setting, 5);
```
### 示例3
<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/messageboxx-3-_theme_.png"></img>
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
            <pu:MessageBoxXSettings x:Key="messageSetting">
                <pu:MessageBoxXSettings.WindowXStyle>
                    <Style TargetType="pu:WindowX" BasedOn="{StaticResource {x:Static pu:MessageBoxX.WindowXStyleKey}}">
                        <Setter Property="SizeToContent"
                                Value="Manual" />
                        <Setter Property="Width"
                                Value="400" />
                        <Setter Property="Height"
                                Value="200" />
                    </Style>
                </pu:MessageBoxXSettings.WindowXStyle>
                <pu:MessageBoxXSettings.ButtonStyle>
                    <Style TargetType="Button" BasedOn="{StaticResource {x:Static pu:MessageBoxX.ButtonStyleKey}}">
                        <Setter Property="pu:ButtonHelper.CornerRadius"
                                Value="4" />
                        <Style.Triggers>
                            <Trigger Property="IsDefault"
                                     Value="True">
                                <Setter Property="Foreground"
                                        Value="#FFFFFF" />
                                <Setter Property="Background"
                                        Value="#80BEE8" />
                            </Trigger>
                        </Style.Triggers>
                    </Style>
                </pu:MessageBoxXSettings.ButtonStyle>
            </pu:MessageBoxXSettings>
        </ResourceDictionary>
    </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```
```xml
using Panuon.WPF.UI;
using Panuon.WPF.UI.Configurations;
···

var setting = Application.Current.FindResource("messageSetting") as MessageBoxXSetting;
MessageBoxX.Show(this, "你有一条新消息。", "提示", MessageBoxButton.OK, MessageBoxIcon.Info, DefaultButton.YesOK, setting, 5);
```
### 示例4
<img height="400" src="https://assets.panuon.com/images/samples/wpf-ui/messageboxx-4-_theme_.png"></img>
> 将以下定义放置在 `App.xaml` 中的 `ResourceDictionary` 中（或其他资源字典文件中，但要确保在 `App.xaml` 中引用，或通过 `cs代码` 装填到 `Application.Current.Resources.MergedDictionaries` 中）。如果不清楚如何放置，请下载源代码并查看 `Samples` 项目。

```xml
xmlns:pu="https://opensource.panuon.com/wpf-ui"
···
xmlns:pu="https://opensource.panuon.com/wpf-ui"
···

<ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                    xmlns:pu="https://opensource.panuon.com/wpf-ui">
    <!--注意，出于某种未知的原因，无论是否在App.xaml中直接定义，都需要在根资源字典中再嵌套一层资源字典。-->
    <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary>
            <!--x:Key的值是任意的，没有特殊要求-->
            <pu:MessageBoxXSettings x:Key="messageSetting" OKButtonContent="OK" YesButtonContent="YES" NoButtonContent="NO" CancelButtonContent="CANCEL">
                <pu:MessageBoxXSettings.WindowXStyle>
                    <Style TargetType="pu:WindowX" BasedOn="{StaticResource {x:Static pu:MessageBoxX.WindowXStyleKey}}">
                        <Setter Property="SizeToContent" Value="Manual" />
                        <Setter Property="Width" Value="400" />
                        <Setter Property="Height" Value="250" />
                        <Setter Property="Background" Value="#1E1E1E" />
                        <Setter Property="Foreground" Value="#FFFFFF" />
                        <Setter Property="pu:WindowXModalDialog.ButtonPanelHorizontalAlignment" Value="Center" />
                    </Style>
                </pu:MessageBoxXSettings.WindowXStyle>
                <pu:MessageBoxXSettings.ButtonStyle>
                    <Style TargetType="Button" BasedOn="{StaticResource {x:Static pu:MessageBoxX.ButtonStyleKey}}">
                        <Setter Property="pu:ButtonHelper.CornerRadius" Value="4" />
                        <Style.Triggers>
                            <Trigger Property="IsDefault" Value="True">
                                <Setter Property="Foreground" Value="#FFFFFF" />
                                <Setter Property="Background" Value="#80BEE8" />
                            </Trigger>
                        </Style.Triggers>
                    </Style>
                </pu:MessageBoxXSettings.ButtonStyle>
                <pu:MessageBoxXSettings.ContentTemplate>
                    <DataTemplate>
                        <Grid>
                            <Grid.RowDefinitions>
                                <RowDefinition Height="Auto" />
                                <RowDefinition />
                            </Grid.RowDefinitions>
                            <pu:StateControl CurrentState="{Binding MessageBoxIcon}" HorizontalAlignment="Center" Margin="0,10,0,10" FontSize="80"
                                             FontFamily="/Panuon.WPF.UI;component/Resources/Fonts/#PanuonIcon">
                                <pu:StateItem State="Info">
                                    <TextBlock Foreground="#80BEE8" Text="&#xe92f;" />
                                </pu:StateItem>
                                <pu:StateItem State="Question">
                                    <TextBlock Foreground="#80BEE8" Text="&#xe937;" />
                                </pu:StateItem>
                                <pu:StateItem State="Warning">
                                    <TextBlock Foreground="#F9D01A" Text="&#xe931;" />
                                </pu:StateItem>
                                <pu:StateItem State="Error">
                                    <TextBlock Foreground="#FF5656" Text="&#xe933;" />
                                </pu:StateItem>
                                <pu:StateItem State="Success">
                                    <TextBlock Foreground="#75CD43" Text="&#xe935;" />
                                </pu:StateItem>
                            </pu:StateControl>
                            <TextBox Grid.Row="1" Text="{Binding Message}" Foreground="{Binding Foreground, RelativeSource={RelativeSource AncestorType=pu:WindowX}, Mode=OneWay}"
                                     TextWrapping="Wrap" Background="Transparent" BorderThickness="0" HorizontalContentAlignment="Center" />
                        </Grid>
                    </DataTemplate>
                </pu:MessageBoxXSettings.ContentTemplate>
            </pu:MessageBoxXSettings>
        </ResourceDictionary>
    </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```
```xml
using Panuon.WPF.UI;
using Panuon.WPF.UI.Configurations;
···

var setting = Application.Current.FindResource("messageSetting") as MessageBoxXSetting;
MessageBoxX.Show(this, "你有一条新消息。", "提示", MessageBoxButton.OK, MessageBoxIcon.Info, DefaultButton.YesOK, setting, 5);
```