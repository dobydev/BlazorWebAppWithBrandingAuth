namespace BlazorWebAppWithBrandingAuth.Client
{
    public class UserInfo
    {
        public required string UserId { get; set; }
        public required string Email { get; set; }
        public required string FirstName { get; set; } // Newly added
        public required string LastName { get; set; }  // Newly added
    }
}
