namespace PeopleManagement.Domain.Services
{
    using PeopleManagement.Common.Tools;
    using PeopleManagement.Domain.Entities;
    using PeopleManagement.Domain.Extensions.Validators;
    using PeopleManagement.Domain.Interfaces.Repositories;
    using PeopleManagement.Domain.Interfaces.Services;

    public class UserService : ServiceBase<User>, IUserService
    {
        IUserRepository _repository;
        public UserService(IUserRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public override async Task<User> GetById(Guid id)
        {
            User user = new User { Id = id };

            await user.ValidateGet(_repository);

            return await _repository.GetById(id); 
        }

        public override async Task<bool> Delete(Guid id)
        {
            User user = new User { Id = id };

            await user.ValidateDelete(_repository);

            return await repository.Delete(id);
        }

        public override async Task<User> Add(User entity)
        {
            await entity.ValidateAdd(_repository);

            entity.Password = SecurePasswordHasher.Hash(entity.Password);

            entity.Name = RegexTool.NormalizeUserName(entity.Name);

            return await repository.Add(entity);
        }

        public async Task<User> Authentication(User entity)
        {
            await entity.ValidateAuthentication(_repository);

            return await _repository.GetByName(entity.Name);
        } 

        public virtual Task<IEnumerable<User>> GetAll() => repository.GetAll();

        public override async Task<User> Update(User entity)
        {
            await entity.ValidateUpdate(_repository);

            var userExistent = await _repository.GetById(entity.Id);

            if (userExistent != null)
            {
                if (userExistent.Password != entity.Password)
                {
                    entity.Password = SecurePasswordHasher.Hash(entity.Password);
                }

                entity.Name = RegexTool.NormalizeUserName(entity.Name);

                return await repository.Update(entity);
            }
            else
            {
                throw new InvalidDataException($"Usuário não encontrado.");
            }
        }



    }
}
