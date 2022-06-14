using System;

namespace BookstoreManagement.ViewModels;

public enum TimeUnit
{
    
    DAY, MONTH, WEEK, YEAR
    
}

public static class TimeUnitExtensions
{
    public static DateTime ToDateTime(this long miliseconds)
    {
        return new DateTime(1970, 1, 1).AddMilliseconds(miliseconds);
    }
    public static long Miliseconds(this DateTime dateTime)
    {
        return (long) dateTime.ToUniversalTime().Subtract(
            new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        ).TotalMilliseconds;
    }
    public static long Miliseconds(this TimeUnit unit)
    {
        switch (unit)
        {
            case TimeUnit.DAY:
                return 86400000;
            case TimeUnit.MONTH:
                return 2592000000;
            case TimeUnit.WEEK:
                return 604800000;
            case TimeUnit.YEAR:
                return 31556926000;
            default:
                throw new ArgumentOutOfRangeException(nameof(unit), unit, null);
        }
    }
    
    public static DateTime Add(this DateTime from, TimeUnit unit)
    {
        switch (unit)
        {
            case TimeUnit.DAY:
                return from.AddDays(1);
            case TimeUnit.MONTH:
                return from.AddMonths(1);
            case TimeUnit.WEEK:
                return from.AddDays(7);
            case TimeUnit.YEAR:
                return from.AddYears(1);
            default:
                throw new ArgumentOutOfRangeException(nameof(unit), unit, null);
        }
    }
    
    public static DateTime Subtract(this DateTime from, TimeUnit unit)
    {
        switch (unit)
        {
            case TimeUnit.DAY:
                return from.AddDays(-1);
            case TimeUnit.MONTH:
                return from.AddMonths(-1);
            case TimeUnit.WEEK:
                return from.AddDays(-7);
            case TimeUnit.YEAR:
                return from.AddYears(-1);
            default:
                throw new ArgumentOutOfRangeException(nameof(unit), unit, null);
        }
    }
}