namespace PeopleManagement.Application.DTOs.Requests.User
{
    public class UserAuthenticationRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
