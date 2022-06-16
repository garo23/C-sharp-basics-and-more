public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int hours = seconds / 3600;
        int minutes = (seconds / 60) % 60;
        int s = seconds % 60;

        return (hours.ToString("00") + ":" + minutes.ToString("00") + ":" + s.ToString("00"));
    }
}
