namespace PeopleManagement.Domain.Extensions.Validators
{
    using PeopleManagement.Domain.Entities;
    using System.ComponentModel.DataAnnotations;

    public static class UserValidator
    {
        public static void Validate(this User user)
        {
            if (new EmailAddressAttribute().IsValid(user.Email))
            {
               // throw new InvalidDataException($"O e-mail {user.Email} informado para o usuário {user.Name} é inválido.");
            }
        }
    }
}
