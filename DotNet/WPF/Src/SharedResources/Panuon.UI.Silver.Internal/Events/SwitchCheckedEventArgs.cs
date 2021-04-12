using System;

namespace Panuon.UI.Silver.Internal
{
    class SwitchCheckedEventArgs : EventArgs
    {
        public SwitchCheckedEventArgs(string groupName)
        {
            GroupName = groupName;
        }

        public string GroupName { get; set; }
    }
}
