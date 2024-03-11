using System;

namespace Panuon.WPF.UI
{
    [Flags]
    public enum StyleDictionaryFlags
        : uint
    {
        None = 0,
        All = 1,
        Button = 2,
        CheckBox = 4,
        ComboBox = 8,
        ContextMenu = 16,
        DataGrid = 32,
        DropDown = 64,
        Expander = 128,
        GroupBox = 256,
        Label = 512,
        ListBox = 1024,
        ListView = 2048,
        Menu = 4096,
        PasswordBox = 8192,
        ProgressBar = 16384,
        RadioButton = 32768,
        RepeatButton = 65536,
        ScrollBar = 131072,
        ScrollViewer = 262144,
        Slider = 524288,
        TabControl = 1048576,
        TextBox = 2097152,
        Thumb = 4194304,
        ToggleButton = 8388608,
        TreeView = 16777216,
    }
}
