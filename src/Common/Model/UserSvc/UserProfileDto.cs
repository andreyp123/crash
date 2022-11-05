namespace Common.Model.UserSvc;

public class UserProfileDto
{
    public string? UserId { get; set; }
    public string? Username { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? DriverLicense { get; set; }
    public bool Verified { get; set; }
    public string[]? Roles { get; set; }
}