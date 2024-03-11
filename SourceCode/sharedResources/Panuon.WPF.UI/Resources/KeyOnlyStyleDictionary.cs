using System;

namespace Panuon.WPF.UI.Resources
{
    public class KeyOnlyStyleDictionary
        : StyleDictionaryBase
    {
        protected override void SetIncludeStyles()
        {
            MergedDictionaries.Clear();
            MergedDictionaries.Add(DefaultResourceDictionary);

            foreach (var flag in Flags)
            {
                if (Includes.HasFlag(StyleDictionaryFlags.All) || Includes.HasFlag(flag))
                {
                    MergedDictionaries.Add(new SharedResourceDictionary() { Source = new Uri($"pack://application:,,,/Panuon.WPF.UI;component/Styles/{flag}Style.xaml") });
                }
            }
        }
    }
}
