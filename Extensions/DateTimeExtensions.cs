﻿//using System;

using System.Globalization;

//namespace ExtensionMethods217.Extensions
namespace System
{
    public static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if(duration.TotalHours < 24.0 )
            {

                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas";

            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " dias";

            }

            
        }

    }
}
