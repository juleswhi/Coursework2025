namespace SSD_Coursework.User;

internal enum UserLevel
{
    Guest,
    Base,
    Admin
}

internal class User
{
    public string Username { get; set; } = string.Empty;
    public Option<(string First, string Last)> Name { get; set; } 
    public UserLevel Level { get; set; }
}
