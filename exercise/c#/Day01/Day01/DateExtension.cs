namespace Day01;

public static class DateExtension
{
    public static bool IsGreaterThan(this DateOnly date1, DateOnly date2) => date1.CompareTo(date2) > 0;
}