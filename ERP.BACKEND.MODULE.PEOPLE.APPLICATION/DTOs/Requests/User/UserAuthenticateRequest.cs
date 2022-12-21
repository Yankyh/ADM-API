namespace PeopleManagement.Application.DTOs.Requests.User
{
    public class UserAuthenticateRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
