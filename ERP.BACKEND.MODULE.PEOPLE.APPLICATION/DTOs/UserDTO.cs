namespace PeopleManagement.Application.DTOs
{
    public class UserDTO : BaseDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
