using Panuon.UI.Core;
using System;

namespace Samples
{
    public class ExampleItem : NotifyPropertyChangedBase
    {
        public string DisplayName { get => _displayName; set => Set(ref _displayName, value); }
        private string _displayName;

        public Type ViewType { get => _viewType; set => Set(ref _viewType, value); }
        private Type _viewType;

        public string Screenshot { get => _screenshot; set => Set(ref _screenshot, value); }
        private string _screenshot;

        public string ViewPath { get => _viewPath; set => Set(ref _viewPath, value); }
        private string _viewPath;
    }
}
