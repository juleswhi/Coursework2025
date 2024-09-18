namespace SSD_Coursework;

internal class DAL
{
    static DAL()
    {
        // Check if file exists
        var app_data = Environment.SpecialFolder.ApplicationData;
        var coursework_data = Path.Combine(app_data.ToString(), "MoversAdmin");

        if (!Directory.Exists(coursework_data))
        {
            Directory.CreateDirectory(coursework_data);
            "Database Created".Debug();
        } else
        {
            "Database Exists Already".Debug();
        }

        var db = Path.Combine(coursework_data, "db.db");
    }
}
