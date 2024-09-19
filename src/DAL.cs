using System.Diagnostics;

namespace SSD_Coursework;

internal class DAL
{
    static DAL()
    {
        // Check if file exists
        var userprofile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"AppData\\Local\\MoversAdmin");

        if (!Directory.Exists(userprofile))
        {
            Directory.CreateDirectory(userprofile);
            "Database Created".Debug();
        } else
        {
            "Database Exists Already".Debug();
        }

        var db = Path.Combine(userprofile, "db.db");

        File.Create(db);
    }
}
