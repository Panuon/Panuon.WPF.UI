using System;

namespace Panuon.UI.Core
{
    public static class DateTimeExtension
    {
        public static DateTime GetTime(this DateTime dateTime)
        {
            return new DateTime(1, 1, 1, dateTime.Hour, dateTime.Minute, dateTime.Second);
        }
    }
}
