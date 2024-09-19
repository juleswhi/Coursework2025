global using LanguageExt;
global using System;

namespace SSD_Coursework;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Log.Location = Log.LogLocation.DebugFile;
        Log.Level = Log.LogLevel.DEBUG;
        new DAL();
        Application.Run(new MainMenu());
    }
}
