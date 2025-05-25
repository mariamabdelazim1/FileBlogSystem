namespace FileBlogSystem.Config;

public class JwtSettings
{
    public string Issuer { get; set; } = "FileBlogSystem";
    public string Audience { get; set; } = "FileBlogSystemAudience";
    public string SecretKey { get; set; } = "9xZ$gY!5Lp#Q2m@7Vt*rWb&E^uJzNfT1";
    public int ExpiryMinutes { get; set; } = 60;
}
