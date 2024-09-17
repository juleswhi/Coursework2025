namespace SSD_Coursework;

internal class DAL
{
    static DAL()
    {
        // Check if file exists
        var app_data = Environment.SpecialFolder.ApplicationData;
        var coursework_data = Path.Combine(app_data.ToString(), "MoversAdmin");
    }
}
