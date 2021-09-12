using System;
using System.Collections.Generic;
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

        public static string Yes => GetString(nameof(Yes));

        public static string No => GetString(nameof(No));

        public static string Cancel => GetString(nameof(Cancel));

        public static string Hour => GetString(nameof(Hour));

        public static string Minute => GetString(nameof(Minute));

        public static string Second => GetString(nameof(Second));
        #endregion


        private static string GetString(string key)
        {
            var ietf = System.Threading.Thread.CurrentThread.CurrentUICulture.IetfLanguageTag;
            return _dictionary[ietf][key];
        }
    }
}
