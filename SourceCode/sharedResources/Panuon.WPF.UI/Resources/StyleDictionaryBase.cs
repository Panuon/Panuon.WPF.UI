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
                if(_excludes != StyleDictionaryFlags.None)
                {
                    throw new InvalidOperationException("Cannot set Includes property when Excludes property is not None.");
                }
                _inclues = value;
                SetIncludeStyles();
            }
        }
        private StyleDictionaryFlags _inclues;

        public StyleDictionaryFlags Excludes
        {
            get => _excludes;
            set
            {
                if(_inclues != StyleDictionaryFlags.None)
                {
                    throw new InvalidOperationException("Cannot set Excludes property when Includes property is not None.");
                }
                _excludes = value;
                SetExcludeStyles();
            }
        }
        private StyleDictionaryFlags _excludes;
        #endregion

        #region Methods
        protected abstract void SetIncludeStyles();

        protected abstract void SetExcludeStyles();

        protected void AddToMergedDictionaries(ResourceDictionary dictionary)
        {
            if (!MergedDictionaries.Contains(dictionary))
            {
                MergedDictionaries.Add(dictionary);
            }
        }
        #endregion
    }
}