namespace PeopleManagement.Domain.Extensions.Validators
{
    using PeopleManagement.Common.Tools;
    using PeopleManagement.Domain.Entities;
    using PeopleManagement.Domain.Interfaces.Repositories;
    using System.ComponentModel.DataAnnotations;

    public static class UserValidator
    {

        public static async Task ValidateGet(this User user, IUserRepository repository)
        {
            var userExistent = await GetUserById(user, repository);

            if (userExistent == null)
            {
                throw new InvalidDataException($"Usuário não encontrado.");
            }
        }

        public static async Task ValidateAdd(this User user, IUserRepository repository)
        {
            /*  if (new EmailAddressAttribute().IsValid(user.Email))
              {
                  throw new InvalidDataException($"O e-mail {user.Email} informado para o usuário {user.Name} é inválido.");
              }*/

            if (await UserAlreadyExists(user, repository))
            {
                throw new InvalidDataException($"O nome de usuário {user.Name} já existe.");
            }


            if (await EmailAlreadyExists(user, repository))
            {
                throw new InvalidDataException($"Um usuário com este e-mail {user.Email} já existe.");
            }
        }

        public static async Task ValidateUpdate(this User user, IUserRepository repository)
        {
            var userExistent = await GetUser(user, repository);

            if (userExistent == null)
            {
                throw new InvalidDataException($"Usuário não encontrado.");
            }

            if (userExistent.Email != user.Email)
            {
                if (await EmailAlreadyExists(user, repository))
                {
                    throw new InvalidDataException($"Um usuário com este e-mail {user.Email} já existe.");
                }
            }
        }

        public static async Task ValidateDelete(this User user, IUserRepository repository)
        {
            var userExistent = await GetUser(user, repository);

            if(userExistent == null || !SecurePasswordHasher.CompareHash(user.Password, userExistent.Password))
            {
                throw new InvalidDataException($"Usuário ou senha inválidos.");
            }
        }

        public static async Task<bool> UserAlreadyExists(this User user, IUserRepository repository)
        {
            return await repository.GetByName(user.Name) != null;
        }

        public static async Task<bool> EmailAlreadyExists(this User user, IUserRepository repository)
        {
            return await repository.GetByEmail(user.Email) != null;
        }

        public static async Task<User> GetUser(this User user, IUserRepository repository)
        {
            return await repository.GetByName(user.Name);
        }

        public static async Task<User> GetUserById(this User user, IUserRepository repository)
        {
            return await repository.GetById(user.Id);
        }

    }
}
