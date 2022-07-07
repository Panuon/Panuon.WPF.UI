using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Panuon.UI.Silver.Internal.Utils
{
    public static class LocalizationUtil
    {
        #region Fields
        private static Dictionary<string, Dictionary<string, string>> _dictionary = new Dictionary<string, Dictionary<string, string>>()
        {
            {
                "en-US", new Dictionary<string, string>()
                {
                    { nameof(Yes), "Yes" },
                    { nameof(No), "No" },
                    { nameof(Cancel), "Cancel" },
                    { nameof(OK), "OK" },
                    { nameof(Hour), "Hour" },
                    { nameof(Minute), "Minute" },
                    { nameof(Second), "Second" },
                }
            },
            {
                "zh-CN", new Dictionary<string, string>()
                {
                    { nameof(Yes), "是" },
                    { nameof(No), "否" },
                    { nameof(Cancel), "取 消" },
                    { nameof(OK), "确 定" },
                    { nameof(Hour), "时" },
                    { nameof(Minute), "分" },
                    { nameof(Second), "秒" },
                }
            },
            {
                "ja-JP", new Dictionary<string, string>()
                {
                    { nameof(Yes), "はい" },
                    { nameof(No), "いいえ" },
                    { nameof(Cancel), "キャンセル" },
                    { nameof(OK), "確 認" },
                    { nameof(Hour), "時" },
                    { nameof(Minute), "分" },
                    { nameof(Second), "秒" },
                }
            },
        };
        #endregion

        #region Properties
        public static string OK => GetString(nameof(OK));

        public static string GetOK(CultureInfo culture) => GetString(nameof(OK), culture);

        public static string Yes => GetString(nameof(Yes));

        public static string GetYes(CultureInfo culture) => GetString(nameof(Yes), culture);

        public static string No => GetString(nameof(No));

        public static string GetNo(CultureInfo culture) => GetString(nameof(No), culture);

        public static string Cancel => GetString(nameof(Cancel));

        public static string GetCancel(CultureInfo culture) => GetString(nameof(Cancel), culture);

        public static string Hour => GetString(nameof(Hour));

        public static string GetHour(CultureInfo culture) => GetString(nameof(Hour), culture);

        public static string Minute => GetString(nameof(Minute));
        
        public static string GetMinute(CultureInfo culture) => GetString(nameof(Minute), culture);

        public static string Second => GetString(nameof(Second));

        public static string GetSecond(CultureInfo culture) => GetString(nameof(Second), culture);
        #endregion


        private static string GetString(string key, CultureInfo culture = null)
        {
            var ietf = (culture ?? System.Threading.Thread.CurrentThread.CurrentUICulture).IetfLanguageTag;
            if (_dictionary.ContainsKey(ietf))
            {
                return _dictionary[ietf][key];
            }
            return _dictionary.ElementAt(0).Value[key];
        }
    }
}
