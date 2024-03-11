using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Panuon.WPF.UI.Resources
{
    public abstract class StyleDictionaryBase
        : ResourceDictionary
    {
        #region Fields
        protected static ResourceDictionary DefaultResourceDictionary { get; } = new ResourceDictionary
        {
            {
                "PanuonIconFont",
                Fonts.GetFontFamilies(new Uri("pack://application:,,,/Panuon.WPF.UI;component/Resources/Fonts/#PanuonIcon")).First()
            }
        };

        protected static StyleDictionaryFlags[] Flags { get; } = Enum.GetValues(typeof(StyleDictionaryFlags))
                .Cast<StyleDictionaryFlags>()
                .Where(x => x != StyleDictionaryFlags.None && x != StyleDictionaryFlags.All)
                .ToArray();
        #endregion

        #region Ctor
        public StyleDictionaryBase()
        {
            MergedDictionaries.Add(DefaultResourceDictionary);
        }
        #endregion

        #region Properties
        public StyleDictionaryFlags Includes
        {
            get => _inclues;
            set
            {
                _inclues = value;
                SetIncludeStyles();
            }
        }
        private StyleDictionaryFlags _inclues;
        #endregion

        #region Methods
        protected abstract void SetIncludeStyles();
        #endregion
    }
}
