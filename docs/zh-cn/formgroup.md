# FormGroup 表单组

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  
2. 当为多个表单设置同一个`GroupName`时，会保留最大的`HeaderWidth`的值。
## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| ErrorMessageForeground | *Brush* | *null* | 错误消息的前景色。 |
| ExtendControl | *object* | *null* | 获取或设置扩展控件。 |
| GroupName | *string* | *null* | 组名。 |
| HeaderForeground | *Brush* | *null* | 标题的前景色。 |
| HeaderFontWeight | *FontWeight* | *null* | 标题的字体加粗。 |
| HeaderFontSize | *double* | *null* | 标题的字体大小。 |
| HeaderHeight | *GridLength* | *null* | 标题的高度。 |
| HeaderPadding | *Thickness* | *null* | 标题的内边距。 |
| HeaderWidth | *GridLength* | *null* | 标题的宽度。 |
| HorizontalHeaderAlignment | *HorizontalAlignment* | *null* | 水平对齐方式。`Center`表示居中对齐，`Left`表示左对齐， `Right`表示右对齐， `Stretch`表示拉伸对齐。 |
| InfoMessageForeground | *Brush* | *null* | 留言消息的前景色。 |
| IsPending | *bool* | *false* | 是否处于等待状态。等待状态下会在内容左侧显示一个Spin旋转 控件，但不会禁用按钮。Spin 旋转控件的样式可以通过`PendingSpinStyle`属性控制。 |
| MaxMessageHeight | *double* | *null* | 消息的最大高度。 |
| Message | *string* | *null* | 消息。 |
| MessageForeground | *Brush* | *null* | 消息的前景色。 |
| MessageHeight | *double* | *null* | 消息的高度。 |
| MessagePadding | *Thickness* | *null* | 消息的内边距。 |
| MessageTemplate | *DataTemplate* | *null* | 消息样式。 |
| MinMessageHeight | *double* | *null* | 消息的最小高度。 |
| Orientation | *Orientation* | *null* | 取向。 |
| PendingSpinStyle | *Style* | *(见内部资源键)* | 等待状态时显示的Spin 旋转控件样式。 |
| SuccessMessageForeground | *Brush* | *null* | 成功消息的前景色。 |
| ValidateResult | *ValidateResult* | *null* | 验证结果。 |
| VerticalHeaderAlignment | *VerticalAlignment* | *null* | 垂直对齐方式。`Bottom`表示底部对齐，`Center`表示居中显示，`Stretch`表示自动调整大小以填充，`Top`表示顶部对齐。 |
| WarningMessageForeground | *Brush* | *null* | 警告消息的前景色。 |

### 示例1
<img height="100" src="https://assets.panuon.com/images/samples/wpf-ui/formgroup-1-_theme_.gif"></img>

```xml
<pu:FormGroup
    x:Name="FrmPassword"
    Header="Password : "
    HeaderPadding="0,4,0,0"
    MinMessageHeight="22">
    <PasswordBox
        x:Name="PwdPassword"
        Height="35"
        Padding="10,0"
        pu:PasswordBoxHelper.ClearButtonVisibility="VisibleOnFocusedAndNonnull"
        pu:PasswordBoxHelper.CornerRadius="2"
        pu:PasswordBoxHelper.FocusedBorderBrush="#6CBCEA"
        pu:PasswordBoxHelper.FocusedWatermarkForeground="#AAAAAA"
        pu:PasswordBoxHelper.Watermark="Password"
        pu:PasswordBoxHelper.WatermarkForeground="#4A4A4A"
        PasswordChanged="PasswordBox_PasswordChanged" />
</pu:FormGroup>
```

```xml
private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
{
    ValidatePassword();
}
```

```xml
private bool ValidatePassword()
{
        if (PwdPassword.Password == null
            || PwdPassword.Password == "")
        {
            FrmPassword.ValidateResult = ValidateResult.Error;
            FrmPassword.Message = "Try to input password.";
            return false;
        }
        else if (PwdPassword.Password.Length < 6)
        {
            FrmPassword.ValidateResult = ValidateResult.Error;
            FrmPassword.Message = "At least 6 digits.";
            return false;
        }
        else if (PwdPassword.Password != "123456")
        {
            FrmPassword.ValidateResult = ValidateResult.Warning;
            FrmPassword.Message = "Password should be 123456.";
            return false;
        }
        else
        {
            FrmPassword.ValidateResult = ValidateResult.Success;
            FrmPassword.Message = "Password valid.";
            return true;
        }
}
```










  

