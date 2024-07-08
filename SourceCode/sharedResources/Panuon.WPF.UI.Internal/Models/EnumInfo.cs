using System;

namespace Panuon.WPF.UI.Internal.Models
{
    class EnumInfo
    {
        public EnumInfo(string displayName,
            Enum value)
        {
            DisplayName = displayName;
            Value = value;
        }

        public string DisplayName { get; }

        public Enum Value { get; }
    }
}
