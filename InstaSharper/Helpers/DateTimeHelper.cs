﻿using System;

namespace InstaSharper.Helpers
{
    internal static class DateTimeHelper
    {
        public static DateTime UnixTimestampToDateTime(double unixTime)
        {
            try
            {
                var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified);
                dateTime = dateTime.AddSeconds(unixTime).ToUniversalTime();
                return dateTime;
            }
            catch (Exception) {
                return DateTime.MinValue;
            }
        }

        public static DateTime UnixTimestampToDateTime(string unixTime)
        {
            var time = Convert.ToDouble(unixTime);
            return UnixTimestampToDateTime(time);
        }
    }
}