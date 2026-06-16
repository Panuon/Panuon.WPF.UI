# 首页

<a href="https://github.com/Panuon/Panuon.WPF.UI" alt="Github"><img src="https://img.shields.io/github/stars/Panuon/Panuon.WPF.UI" /></a>
<br/>
<a href="https://www.nuget.org/packages/Panuon.WPF.UI/" alt="Nuget Package"><img src="https://img.shields.io/nuget/dt/Panuon.WPF.UI" /></a>
<a href="https://github.com/Panuon/Panuon.WPF.UI" alt="Github"><img src="https://img.shields.io/github/license/Panuon/Panuon.WPF.UI" /></a><br/>
<img src="https://img.shields.io/badge/Framework-4.5.2-512BD4?logo=.net" />
<img src="https://img.shields.io/badge/Framework-4.6.2-512BD4?logo=.net" />
<img src="https://img.shields.io/badge/Framework-4.7.2-512BD4?logo=.net" />
<img src="https://img.shields.io/badge/Framework-4.8-512BD4?logo=.net" />
<img src="https://img.shields.io/badge/-5-512BD4?logo=.net" />
<img src="https://img.shields.io/badge/-6-512BD4?logo=.net" />
<img src="https://img.shields.io/badge/-7-512BD4?logo=.net" />
<img src="https://img.shields.io/badge/-8-512BD4?logo=.net" />
<br/>
<br/>
<a href="https://qm.qq.com/q/1aG1XRHw74">
    <img src="https://img.shields.io/badge/QQ群-Panon开发者社区-white?logo=tencentQQ" alt="QQ群">
</a>

> 本文档正在持续热更新中。由于文档欠缺较多，将以每周更新几篇的速度稳定前进。

## 它能做什么
你喜欢使用 AntDesign 、Material Design 这类现有的设计规范和样式进行开发，还是喜欢根据UI设计图或自己的喜好自定义界面？  
如果你喜欢自定义样式，那么Panuon.WPF.UI很可能是你的不二之选。  
Panuon.WPF.UI项目本身没有提供任何设计规范（包括配色），你可以根据自己的喜好调整UI控件的绝大多数细节。  
原生WPF提供的属性很少，甚至没有在控件中提供 `CornerRadius 圆角` 这类非常常见的属性。为了实现一些效果，开发者不得不重新编写 _ControlTemplate_ 或 _Style_ ，极大的降低了开发效率。  
Panuon.WPF.UI通过提供附加属性和自定义控件解决了这些问题，它为每一种原生控件都提供了不下于10个扩展属性，覆盖了90%以上常见的UI效果。例如 `HoverBackground 悬浮背景色` 、 `ClickBackground 点击背景色` 、 `ShadowColor 阴影颜色` 等等。  
相比于直接使用原生WPF，通过Panuon.WPF.UI编写样式可以为你`节省50%以上的前端开发时间`（未经验证的小道消息）。大多数情况下，只要添加几条属性就能解决UI问题。  

## 示例图片
这些内容包含在[github](https://github.com/Panuon/Panuon.WPF.UI)的仓库中。下载编译即可运行。

![](https://assets.panuon.com/images/samples/wpf-ui/samples-1.jpg)
![](https://assets.panuon.com/images/samples/wpf-ui/samples-2.jpg)
![](https://assets.panuon.com/images/samples/wpf-ui/samples-3.jpg)

## 为什么选择它
Panuon.WPF.UI是一个长期项目，它的前身是2018年首次发布的Panuon.UI，以及2021年首次发布的Panuon.UI.Silver。  
历经两百多个小版本，四个大版本的不断迭代，在6年的时间里，Panuon始终自成一派。  
为了不让软件看上去 “长得差不多” ，Panuon.WPF.UI一直在为了能以更简单、更符合开发规范的方式来自定义UI样式和效果。  
截至目前，Panuon所有的控件都兼容 `MVVM` 开发方式，无论是绑定还是直接调用，都可以完美使用。另外，考虑到部分项目可能使用多个控件库，Panuon.WPF.UI中还提供了[兼容模式](/tutorial)。  
严重错误通常能在当天完成修复和发版。  
如果在使用过程中遇到任何阻碍，可以通过[Github issue](https://github.com/Panuon/Panuon.WPF.UI/issues)或我们的[QQ频道（更快响应）](https://pd.qq.com/s/8zi1tjeq8)反馈。  

## 许可信息摘要
Panuon的所有开源项目无偿向任何个人或机构提供。无论是个人还是商业项目，都无需为Panuon.WPF.UI付费。  
Panuon.WPF.UI遵循 `Apache-2.0` 开源协议（早期版本及更早期的Panuon.UI.Silver库则遵循 `MIT` 开源协议）。  

`另请注意，Panuon 是上海坂悦计算网络有限公司持有的注册商标。当您为软件产品申请著作权或专利时，请勿包含Panuon的开源代码。`  
      
您不得将Panuon提供的开源代码用于出售。  
控件库的内容可以被任意修改，您可以将其应用在您自己的项目中，或进行二次发行。根据Apache-2.0开源协议的要求，二次发行时应当包含对Panuon.WPF.UI的修改说明（尽管Panuon并不强制要求这一点）。如果您从代码中移除了Panuon名称，您必须遵循上述约定。  
  
完整的Apache-2.0协议内容可以前往 [Apache组织官方网站](https://apache.org/licenses/LICENSE-2.0) 上查看。

## 免责声明
Panuon不会在代码中主动制造破坏或预埋彩蛋，但也不对其安全性和稳定性保有任何承诺。开发过程中，应当对内容进行充分的测试。如果遇到问题或BUG，可以通过github等渠道提交反馈。  
基于开源项目开发的所有程序或内容都必须遵守当地的法律法规。  
包括但不限于BUG、法律问题等一切原因导致的后果，由开发者自行承担。