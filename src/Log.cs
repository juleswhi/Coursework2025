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
    static Log()
    {
        var userprofile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var path = Path.Combine(userprofile, @"AppData\\Local\\MoversAdmin\\logs");

        Directory.CreateDirectory(path);

        "Log File Found".Debug();
    }

    public static LogLocation Location { get; set; } = LogLocation.Debug;
    public static LogLevel Level { get; set; } = LogLevel.WARNING;

    private static void LocationPrint(Func<string> print)
    {
        switch (Location)
        {
            case LogLocation.Debug: System.Diagnostics.Debug.Print(print()); break;
            case LogLocation.DebugFile: System.Diagnostics.Debug.Print(print()); WriteErrFile(print());  break;
            case LogLocation.File: WriteErrFile(print()); break;
        };
    }

    public static void ClearLogFile()
    {
        var userprofile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var path = Path.Combine(userprofile, @"AppData\\Local\\MoversAdmin\\logs");
    }

    private static void WriteErrFile(string s)
    {
        var userprofile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var path = Path.Combine(userprofile, @"AppData\\Local\\MoversAdmin\\logs");

        File.AppendAllText(Path.Combine(path, "log.txt"), s+"\n");
    }

    public static void Debug(this string message)
    {
        LocationPrint(() => message);
    }
}
