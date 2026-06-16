# WindowX 窗体X

> 此类型是`Panuon.WPF.UI`中的自定义控件，不需要添加任何依赖。  

## 可以使用的附加类
#### WindowXCaption
在不影响原生窗体双击放大、拖拽效果的前提下，自定义标题栏的内容或按钮样式。  
#### WindowXModalDialog
为窗体X添加模态对话框按钮（是/否、确定、取消），并在按下按钮时设置`DialogResult` 属性。  


## 小提示
1. `InteropOwnersMask` 属性的默认值为`True`。如果*WindowX*（子窗体）在调用*ShowDialog()*方法前将`Owner`属性设为了另一个*WindowX*（主窗体），主窗体将在子窗体弹出时显示半透明的遮罩层，并在子窗体关闭时将其隐藏。但如果子窗体关闭时，主窗体仍然持有其他的*WindowX*类型子窗体，则主窗体将不会自动关闭遮罩层。在极少数特殊情况下，这可能会导致显示异常（例如将某个隐藏*WindowX*子窗体的`Owner`设为了主窗体）。可以通过在子窗体上添加`InteropOwnerMask=False`来阻止自动控制遮罩层，并在主窗体上通过`IsMaskVisible`属性来手动控制遮罩层的显隐。  
2. 通过`WindowXCaption.HeaderTemplate`属性自定义标题栏时，如果存在允许鼠标交互的控件（如输入框，按钮等），必须在控件上设置`WindowX.IsDragMoveArea=False`附加属性，这会从拖拽区域中将其排除，否则控件将无法响应鼠标事件。  
3. 当`CanClose=False`时，用户无法主动关闭窗体X（包括`Alt+F4`组合键），但调用*WindowX.Close()*重写方法能够正常关闭窗体。注意，此方法重写了*Window*中的*Close()*方法，如果调用时对象不是*WindowX*类型，请先将其转换为*WindowX*类型，然后再调用*Close()*方法。
4. `WindowX` 的显示一共有四层，从下到上依次为：`Content 内容`、`Backstage 后台`、`Mask 遮罩`和`Overlayer 悬浮`。一般情况下，开发者只会用到`Content 内容`和`Mask 遮罩`两层，而`Backstage 后台`通常用于与`Content 内容`做快速切换使用，`Overlayer 悬浮`则可以在显示遮罩层时为用户提供指引或提示。  
5. `WindowX` 内置了窗体特效（`Aero 毛玻璃`和`Acrylic 亚克力`，暂未支持`Mica 动态材质`）。在一些旧的系统版本上，它们可能不受支持。由于Windows更新频道众多，版本更新速度较快，`Panuon.WPF.UI`并没有内置判断逻辑。请根据运行时系统版本自行判断是否在窗体上启用样式。示例3中提供了如何使用特效的例子。  

## 属性

### WindowX上的自定义属性

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| Backstage | *object* | *0,0,0,0* | 显示在内容之上，遮罩层之下的后台层。显示和隐藏可以通过`IsBackstageVisible`属性控制。 |
| CanClose | *bool* | *true* | 是否允许关闭窗体。值为`false`时，用户无法主动关闭此窗体（包括`Alt+F4`组合键）。调用*WindowX.Close()*重写方法能正常关闭窗体。 |
| DisableDragMove | *bool* | *false* | 是否禁止用户拖拽窗体。 |
| Effect | *WindowXEffect* | *null* | 应用于`WindowX`的特殊效果，例如。 |
| InteropOwnersMask | *bool* | *true* | 是否自动与父窗体的遮罩层交互，仅当子窗体的`Owner`属性不为空，且目标父窗体为*WindowX*类型时生效。 |
| IsBackstageVisible | *bool* | *false* | 是否显示后台层。 |
| IsClosed | *bool* | *false* | 获取该窗体是否已经被关闭。 |
| IsBackstageVisible | *bool* | *false* | 是否显示后台查。 |
| IsEscEnabled | *bool* | *false* | 是否允许使用`Esc`键关闭窗体。 |
| IsF11Enabled | *bool* | *false* | 是否允许使用`F11`键最大化或还原窗体。 |
| IsFullScreen | *bool* | *false* | 是否为全屏模式。 |
| IsMaskVisible | *bool* | *false* | 是否显示遮罩层。遮罩层的颜色画刷可以通过`MaskBrush`属性控制。 |
| IsOverlayerVisible | *bool* | *false* | 是否显示覆盖层。 |
| MaskBrush | *Brush* | *#b3ffffff* | 遮罩层的颜色画刷。 |
| Overlayer | *object* | *null* | 能够显示在遮罩层之上的覆盖层。通常用于在打开遮罩层时显示一些额外的内容，例如示例或指引。显示和隐藏可以通过`IsOverlayerVisible`属性控制。 |

## WindowX上的附加属性

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| IsDragMoveArea | *bool?* | *null* | 是否将目标控件标记为可拖拽区域的一部分。如果在窗体内的控件上设置`WindowX.IsDragMoveArea=True`，鼠标在控件上按下时将触发拖拽窗体操作，而不会响应点击等交互。如果在标题栏的控件上设置`WindowX.IsDragMoveArea=False`，鼠标按下时控件会响应事件，而不会触发拖拽窗体。 |

## WindowXCaption上的附加属性
这些属性用于调整标题栏区域。

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| Background | *Brush* | *(跟随主控件)* | 标题栏的背景色。 |
| BackstageCloseButtonStyle | *Style* | *(见内部资源键)* | 显示后台层时，关闭按钮的样式。 |
| BackstageMaximizeButtonStyle | *Style* | *(见内部资源键)* | 显示后台层时，最大化按钮的样式 |
| BackstageMinimizeButtonStyle | *Style* | *(见内部资源键)* | 显示后台层时，最小化按钮的样式 |
| BorderBrush | *Brush* | *(跟随主控件)* | 标题栏的边框。 |
| BorderThickness | *Thickness* | *(跟随主控件)* | 标题栏的边框粗细。 |
| Buttons | *CaptionButtons[Flags]* | *Minimize,Maximize,Close* | 要显示的按钮组合。`None`表示不显示，`Minimize`表示显示最小化按钮，`Maximize`表示显示最大化按钮，`Close`表示显示关闭按钮。在C#中使用组合时，请使用竖线而不是逗号分隔。 |
| CloseButtonStyle | *Style* | *(见内部资源键)* | 关闭按钮的样式 |
| ExtendControl | *object* | *null* | 显示在最小化按钮左侧的扩展内容。 |
| Foreground | *Brush* | *(跟随主控件)* | 标题栏的前景色。 |
| HeaderAlignment | *WindowXHeaderAlignment* | *Stretch* | 标题在标题栏中的水平位置。`Left` 表示显示在标题栏的左侧，`Stretch` 表示显示铺满整个标题栏，`Center` 表示显示在标题栏的中间。 |
| HeaderTemplate | *DataTemplate* | *(见内部资源键)* | 标题栏的标题模板。 |
| Height | *double* | *35* | 标题栏的高度。 |
| MaximizeButtonStyle | *Style* | *(见内部资源键)* | 最大化按钮的样式 |
| MinimizeButtonStyle | *Style* | *(见内部资源键)* | 最小化按钮的样式 |
| Padding | *Thickness* | *0* | 标题栏的内边距。 |
| ShadowColor | *Color?* | *(跟随主控件)* | 标题栏的阴影颜色。 |

## WindowXModalDialog上的附加属性
这些属性用于将*WindowX*做为模态对话框使用。  
只有当窗体X通过`ShowDialog()`方法打开时，才能正常工作。

| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| Buttons | *MessageBoxButton?* | *null* | 要显示在页面底部的按钮组。`OK`表示显示确定按钮，`OKCancel`表示显示确定/取消按钮，`YesNoCancel`表示显示是/否/取消按钮，`YesNo`表示显示是/否按钮。 |
| ButtonStyle | *Style* | *(见内部资源键)* | 按钮的样式。按钮的类型被通过`Tag`属性区分。 |
| DefaultButton | *DefaultButton* | *Unset* | 按下`Enter`键时触发的默认按钮。`Unset`表示未指定（不触发），`YesOK`表示显示优先选择是按钮（如果`Buttons`中没有包括是按钮，则选择确定按钮），`NoCancel`表示优先选择否按钮（其次为取消按钮），`CancelNo`表示显示优先选择取消按钮（其次为否按钮）。 |
| InverseButtonsSequence | *bool* | *false* | 是否反转按钮的排列顺序。 |
| ButtonPanelMargin | *Thickness* | *0,0,0,0* | 按钮组面板外边距。 |
| ButtonPanelHorizontalAlignment | *HorizontalAlignment* | *Right* | 按钮组面板在水平方向的位置。 |
| OKButtonContent | *object* | *(en-us:OK/zh-cn:确定/ja-jp:確認)* | 确定按钮的内容。 |
| YesButtonContent | *object* | *(en-us:Yes/zh-cn:是/ja-jp:はい)* | 是按钮的内容。 |
| NoButtonContent | *object* | *(en-us:No/zh-cn:否/ja-jp:いいえ)* | 否按钮的内容。 |
| CancelButtonContent | *object* | *(en-us:Cancel/zh-cn:取消/ja-jp:キャンセル)* | 取消按钮的内容。 |
| DialogResult | *MessageBoxResult* | *-* | 获取用户选择的按钮。 |

## 内容补充中