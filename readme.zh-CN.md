<a href="https://www.nuget.org/packages/Panuon.WPF.UI" target='_blank'><img src="https://img.shields.io/badge/Nuget-Panuon.WPF.UI-green"></a>
![Nuget](https://img.shields.io/badge/.net%20framework-%E2%89%A54.5-blue)
![](https://img.shields.io/badge/.net-3.1-blue)
![](https://img.shields.io/badge/.net-5-blue)
![](https://img.shields.io/badge/.net-6-blue)
![](https://img.shields.io/nuget/dt/Panuon.UI.Silver)
![](https://img.shields.io/nuget/dt/Panuon.WPF.UI)
![](https://img.shields.io/badge/Visual%20Studio-2019+-813dbf)

[切换到简体中文](https://github.com/PanuonGroup/Panuon.WPF.UI)  
<br/>  

# Panuon.WPF.UI v2.2


一个专业的定制化UI引擎。  
`Panuon.WPF.UI` 能让你用最少的代码来实现期望的UI效果。  

`请勿从Panuon.UI.Silver 1.x 版本直接升级到 Panuon.UI.Silver 2.2 或 Panuon.WPF.UI 1.x 版本。这些个版本之间的使用方式有很大的差异。`  
  
# 升级

自 `Panuon.UI.Silver` `2.2.20` 开始, 本库已经重命名为 `Panuon.WPF.UI` 。 要升级到新库，请参阅这篇 [wiki文档](https://github.com/PanuonGroup/Panuon.WPF.UI/wiki/Release-zh-CN#100) 。  

# 文档  

现在仅提供了中文文档。  
[中文Wiki文档](https://github.com/PanuonGroup/Panuon.WPF.UI/wiki/Home-zh-CN)  

# 贡献
[<img width="40" height="40" src="https://avatars.githubusercontent.com/u/23360265?v=4"></img>](https://github.com/Mochengvia)
[<img width="40" height="40" src="https://avatars.githubusercontent.com/u/45651732?v=4"></img>](https://github.com/GodLeaveMe)
[<img width="40" height="40" src="https://avatars.githubusercontent.com/u/30036652?v=4"></img>](https://github.com/rdscfh)
  
# 如何使用
  
### 1. 将资源字典添加到 App.xaml 中

```
<ResourceDictionary Source="pack://application:,,,/Panuon.WPF.UI;component/Control.xaml" />
```

### 2. 像Material Design那样使用附加属性，尽管这两个库之间没有任何关系

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

### 3. 又或者，在不影响其他控件的情况下使用样式
```
<!--不要添加 Control.xaml-->

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
  
# 示例 
`这些界面已包含在"Samples"项目中。下载本仓库即可获得这些页面的源码。`  
  
## 报告
Samples/Views/Examples/ReportView.xaml  
使用Panuon.WPF.UI，你需要`261行代码`来实现该页面。  
  
![Report](https://raw.githubusercontent.com/Panuon/Panuon.Documents/master/Resources/Report.png)  

## Visual Studio 2019 (模拟)  
Samples/Views/Examples/VisualStudio2019View.xaml  
使用Panuon.WPF.UI，你需要`293行代码`来实现该页面。  
  
![Visual Studio 2019 (SIM)](https://raw.githubusercontent.com/Panuon/Panuon.Documents/master/Resources/VisualStudio2019.png)
  
  
## 网易云音乐 (模拟)
Samples/Views/Examples/NeteaseMusicView.xaml  
使用Panuon.WPF.UI，你需要`272行代码`来实现该页面。  

![](https://raw.githubusercontent.com/Panuon/Panuon.Documents/master/Resources/NeteaseMusic.png)
  
  
## 登录示例
Samples/Views/Examples/SignInView.xaml  
使用Panuon.WPF.UI，你需要`187行代码`来实现该页面。 

![](https://raw.githubusercontent.com/Panuon/Panuon.Documents/master/Resources/SignIn.png)
