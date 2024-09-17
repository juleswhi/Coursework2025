namespace SSD_Coursework;

internal static class Log
{
    public enum LogLocation
    {
        Debug,
        File,
        DebugFile,
    }

    public enum LogLevel
    {
        DEBUG,
        INFO,
        WARNING,
        ERROR,
        FATAL,
    }

    public static LogLocation Location { get; set; } = LogLocation.Debug;
    public static LogLevel Level { get; set; } = LogLevel.WARNING;

    private static void LocationPrint(Func<string> print)
    {
        switch (Location)
        {
            case LogLocation.Debug: System.Diagnostics.Debug.Print(print()); break;
        };
    }

    public static void Debug(this string message)
    {
        LocationPrint(() => message);
    }
}
