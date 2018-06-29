using System;

namespace OpenSocio.Common.Extensions
{
    public static class DateTimeExtensions
    {
        public static long ToTimestamp(this DateTime dt)
        {
            return (long)dt.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
        }
    }
}