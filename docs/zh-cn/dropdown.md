# DropDown 下拉列表

## 小提示
1. 当按钮被禁用时，`Opacity`的属性值将与*GlobalSettings.Setting.DisabledOpacity*属性的值绑定（默认为`0.4`）。有关全局设置的更多内容, 请查看[*GlobalSettings 全局设置*]()。  

## 属性 
| 属性 | 类型 | 默认值 | 描述 |
| --- | --- | --- | ----------- |
| IsOpen | *bool* | *false* | 是否展开抽屉。 | 
| StaysOpen | *bool* | *true* | 是否保持展开。 | 
| Child | *object* | *null* | 颜色编辑器面板外边距。 | 
| InitBeforeOpen | *bool* | *null* | 打开之前是否初始化。 | 

## 示例

### 示例1
<img height="150" src="https://assets.panuon.com/images/samples/wpf-ui/dropdown-1-_theme_.gif"></img>

```xml
<pu:DropDown
    x:Name="DrpMenu"
    Width="150"
    Height="30"
    pu:DropDownHelper.Background="#ffffff"
    pu:DropDownHelper.BorderBrush="#b3b3b3"
    pu:DropDownHelper.BorderThickness="1"
    pu:DropDownHelper.ClipDockSideShadow="False"
    pu:DropDownHelper.CornerRadius="15"
    pu:DropDownHelper.MinHeight="150"
    pu:DropDownHelper.Padding="7,5"
    pu:DropDownHelper.ShadowColor="#36AAF7"
    pu:DropDownHelper.VerticalOffset="3"
    pu:DropDownHelper.Width="150"
    pu:ShadowHelper.BlurRadius="25"
    pu:ShadowHelper.Opacity="0.25"
    IsOpen="True">
    <pu:DropDown.Content>
        <ToggleButton
            pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}"
            pu:ToggleButtonHelper.CheckedBorderBrush="#b3b3b3"
            pu:ToggleButtonHelper.CheckedBorderThickness="1"
            pu:ToggleButtonHelper.ClickBorderBrush="#b3b3b3"
            pu:ToggleButtonHelper.ClickBorderThickness="1"
            pu:ToggleButtonHelper.CornerRadius="10"
            pu:ToggleButtonHelper.HoverBorderBrush="#b3b3b3"
            pu:ToggleButtonHelper.HoverBorderThickness="1"
            pu:ToggleButtonHelper.Icon="&#xe903;"
            Background="#ffffff"
            Content="Open"
            FontFamily="{StaticResource PanuonIconFont}"
            FontSize="16"
            IsChecked="{Binding IsOpen, RelativeSource={RelativeSource AncestorType=pu:DropDown}, Mode=TwoWay}" />
    </pu:DropDown.Content>
    <pu:DropDown.Child>
        <StackPanel>
            <Button
                Height="35"
                Margin="0,5,0,5"
                HorizontalContentAlignment="Stretch"
                pu:ButtonHelper.HoverBackground="#36AAF7"
                pu:ButtonHelper.HoverForeground="#ffffff"
                pu:ButtonHelper.Icon="&#xe941;"
                pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}"
                Background="Transparent"
                Content="Home"
                FontSize="12"
                FontWeight="Regular"
                Foreground="#000000" />
            <Button
                Height="35"
                HorizontalContentAlignment="Stretch"
                pu:ButtonHelper.HoverBackground="#36AAF7"
                pu:ButtonHelper.HoverForeground="#ffffff"
                pu:ButtonHelper.Icon="&#xe939;"
                pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}"
                Background="Transparent"
                Content="User"
                FontSize="12"
                FontWeight="Regular"
                Foreground="#000000" />
            <Button
                Height="35"
                HorizontalContentAlignment="Stretch"
                pu:ButtonHelper.HoverBackground="#36AAF7"
                pu:ButtonHelper.HoverForeground="#ffffff"
                pu:ButtonHelper.Icon="&#xe9e5;"
                pu:IconHelper.FontFamily="{StaticResource PanuonIconFont}"
                Background="Transparent"
                Content="Settings"
                FontSize="12"
                FontWeight="Regular"
                Foreground="#000000" />
        </StackPanel>
    </pu:DropDown.Child>
</pu:DropDown>
```





