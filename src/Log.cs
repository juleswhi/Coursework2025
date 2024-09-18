namespace SSD_Coursework;

//Should write to AppData/MoversAdmin/Logs/Date.log

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
            case LogLocation.File: System.Diagnostics.Debug.Print(print());  break;
            case LogLocation.DebugFile: System.Diagnostics.Debug.Print(print()); break;
        };
    }

    private static void WriteErrFile(string s)
    {
        File.AppendAllText(Path.Combine(Directory.SpecialFolder.ApplicationData.ToString(), "logs", $"now.log"), s);
    }

    public static void Debug(this string message)
    {
        LocationPrint(() => message);
    }
}
