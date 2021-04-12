using Panuon.UI.Core;

namespace Samples.Models
{
    public class FontItem : NotifyPropertyChangedBase
    {
        #region Icon
        public char Icon { get => _icon; set => Set(ref _icon, value); }
        private char _icon;
        #endregion

        #region Code
        public string Code { get => _code; set => Set(ref _code, value); }
        private string _code;
        #endregion
    }
}
