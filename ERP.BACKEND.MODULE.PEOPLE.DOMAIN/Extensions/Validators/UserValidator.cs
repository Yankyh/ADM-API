namespace PeopleManagement.Domain.Extensions.Validators
{
    using PeopleManagement.Common.Tools;
    using PeopleManagement.Domain.Entities;
    using PeopleManagement.Domain.Interfaces.Repositories;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

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
            await ValidateInput(user, repository);

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
            var userExistent = await GetUserById(user, repository);

            if (userExistent == null)
            {
                throw new InvalidDataException($"Usuário não encontrado.");
            }

            await ValidateInput(user, repository);

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
            var userExistent = await GetUserById(user, repository);

            if (userExistent == null)
            {
                throw new InvalidDataException($"Usuário não encontrado.");
            }
        }

        public static async Task ValidateAuthentication(this User user, IUserRepository repository)
        {
            var userExistent = await GetUser(user, repository);

            if(userExistent == null || !SecurePasswordHasher.CompareHash(user.Password, userExistent.Password))
            {
                throw new InvalidDataException($"Usuário ou senha inválidos.");
            }
        }

        public static async Task ValidateInput(this User user, IUserRepository repository)
        {
            if (user.Name == null)
            {
                throw new InvalidDataException($"O campo usuário é obrigatório.");
            }

            if (user.Name.Length < 4)
            {
                throw new InvalidDataException($"O nome de usuário deve ter no minímo 3 caracteres.");
            }

            if (user.Password == null)
            {
                throw new InvalidDataException($"O campo senha é obrigatório.");
            }

            if (user.Password.Length < 6)
            {
                throw new InvalidDataException($"A senha deve ter no minímo 6 caracteres.");
            }

            if (user.Email == null)
            {
                throw new InvalidDataException($"O campo e-mail é obrigatório.");
            }

            if (!Regex.IsMatch(user.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                throw new InvalidDataException($"O e-mail informado é inválido.");
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
