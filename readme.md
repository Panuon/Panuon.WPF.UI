<a href="https://www.nuget.org/packages/Panuon.WPF.UI" target='_blank'><img src="https://img.shields.io/badge/Nuget-Panuon.WPF.UI-green"></a>
![Nuget](https://img.shields.io/badge/.net%20framework-%E2%89%A54.5-blue)
![](https://img.shields.io/badge/.net-3.1-blue)
![](https://img.shields.io/badge/.net-5-blue)
![](https://img.shields.io/badge/.net-6-blue)
![](https://img.shields.io/nuget/dt/Panuon.UI.Silver)
![](https://img.shields.io/nuget/dt/Panuon.WPF.UI)
![](https://img.shields.io/badge/Visual%20Studio-2019+-813dbf)

[切换到简体中文](https://github.com/PanuonGroup/Panuon.WPF.UI/blob/master/readme.zh-CN.md)  
<br/>  

# Panuon.WPF.UI

A professional UI engine for customization.  
`Panuon.WPF.UI` allows you to achieve the desired UI effect with minimal code.  


`Do not directly upgrade from Panuon.UI.Silver 1.x version to Panuon.UI.Silver 2.2 or Panuon.WPF.UI 1.x version. There are significant differences in how these versions are used. `  

# Upgrade

Since `Panuon.UI.Silver` `2.2.20`, this library has been renamed `Panuon.WPF.UI`. For the specific upgrade method, please refer to this [wiki document](https://github.com/PanuonGroup/Panuon.WPF.UI/wiki/Release-zh-CN#100) (currently only supports Chinese).  

# Documents  

Only Chinese documentation is now available.  
[Chinese Wiki Document](https://github.com/PanuonGroup/Panuon.WPF.UI/wiki/Home-zh-CN)  

# Contributors
[<img width="40" height="40" src="https://avatars.githubusercontent.com/u/23360265?v=4"></img>](https://github.com/Mochengvia)
[<img width="40" height="40" src="https://avatars.githubusercontent.com/u/45651732?v=4"></img>](https://github.com/GodLeaveMe)  
  
# How to use
  
### 1. Add resource dictionary to your App.xaml

```
<ResourceDictionary Source="pack://application:,,,/Panuon.WPF.UI;component/Control.xaml" />
```

### 2. Use attached properties like Material Design does, although there is no relationship between the two libraries

```
xmlns:pu="clr-namespace:Panuon.WPF.UI;assembly=Panuon.WPF.UI"
...

<Button Width="150"
        Height="35"
        Background="#6CBCEA"
        pu:ButtonHelper.CornerRadius="5"
        pu:ButtonHelper.HoverBackground="#6CA3EA"
        pu:ButtonHelper.ClickBackground="#83A6D4" />
```

### 3. Or, use styles without affecting other controls
```
<!--Don't add Control.xaml-->

<ResourceDictionary Source="pack://application:,,,/Panuon.WPF.UI;component/ButtonStyle.xaml" />

<ResourceDictionary Source="pack://application:,,,/Panuon.WPF.UI;component/TextBoxStyle.xaml" />
...
```

```
xmlns:pu="clr-namespace:Panuon.WPF.UI;assembly=Panuon.WPF.UI"
xmlns:purs="clr-namespace:Panuon.WPF.UI.Resources;assembly=Panuon.WPF.UI"
...

<Button Width="150"
        Height="35"
        Style="{StaticResource {x:Static purs:StyleKeys.ButtonStyle}}"
        Background="#6CBCEA"
        pu:ButtonHelper.CornerRadius="5"
        pu:ButtonHelper.HoverBackground="#6CA3EA"
        pu:ButtonHelper.ClickBackground="#83A6D4" />
```
  
# Samples  
`These pages were included in the Samples project. Download this repository to get the source code.`  
  
## Report
Samples/Views/Examples/ReportView.xaml  
`261 code lines` to implement this page in Panuon.WPF.UI.  
  
![Report](https://raw.githubusercontent.com/Panuon/Panuon.Documents/master/Resources/Report.png)  
  
## Visual Studio 2019 (SIM)  
Samples/Views/Examples/VisualStudio2019View.xaml  
`293 code lines` to implement this page in Panuon.WPF.UI.  
  
![Visual Studio 2019 (SIM)](https://raw.githubusercontent.com/Panuon/Panuon.Documents/master/Resources/VisualStudio2019.png)
  
## Netease Music (SIM)
Samples/Views/Examples/NeteaseMusicView.xaml  
`272 code lines` to implement this page in Panuon.WPF.UI.  
  
![](https://raw.githubusercontent.com/Panuon/Panuon.Documents/master/Resources/NeteaseMusic.png)
  
## Sign In Example
Samples/Views/Examples/SignInView.xaml  
`187 code lines` to implement this page in Panuon.WPF.UI.  
  
![](https://raw.githubusercontent.com/Panuon/Panuon.Documents/master/Resources/SignIn.png)