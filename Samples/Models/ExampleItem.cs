using Panuon.WPF;
using System;
using System.Windows;

namespace Samples
{
    public class ExampleItem : NotifyPropertyChangedBase
    {
        #region DisplayName
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        public string DisplayName { get => _displayName; set => Set(ref _displayName, value); }
        private string _displayName;
        #endregion

        #region ViewType
        public Type ViewType { get => _viewType; set => Set(ref _viewType, value); }
        private Type _viewType;
        #endregion

        #region PreviewView
        public UIElement PreviewView { get => _previewView; set => Set(ref _previewView, value); }
        private UIElement _previewView;
        #endregion

        #region ViewPath
        public string ViewPath { get => _viewPath; set => Set(ref _viewPath, value); }
        private string _viewPath;
        #endregion
    }
}
