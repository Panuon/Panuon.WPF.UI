using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Panuon.WPF.UI.Internal
{
    internal class ClassNameInfo
    {
        public IEnumerable<string> Abbrs { get; set; }

        public Action<FrameworkElement, Dictionary<string, string>> ClassNameChangedCallback { get; set; }


    }
}