using System;
using System.Collections.Generic;
using System.Windows;

namespace Panuon.UI.Core
{
    public class SharedResourceDictionary : ResourceDictionary
    {
        #region Fields
        private static Dictionary<Uri, ResourceDictionary> _sharedDictionaries = new Dictionary<Uri, ResourceDictionary>();

        private Uri _sourceUri;
        #endregion

        #region Properties
        public new Uri Source { get => _sourceUri; set => SetSource(value); }
        #endregion

        #region Functions
        private void SetSource(Uri sourceUri)
        {
            _sourceUri = sourceUri;
            if (_sharedDictionaries.ContainsKey(sourceUri))
            {
                MergedDictionaries.Add(_sharedDictionaries[sourceUri]);
            }
            else
            {
                base.Source = sourceUri;
                _sharedDictionaries.Add(sourceUri, this);
            }
        }
        #endregion
    }
}
