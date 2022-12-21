namespace Erp.Backend.Module.PERSON.DOMAIN.Services
{
    using Erp.Backend.Module.PERSON.COMMON.Tools;
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;
    using Erp.Backend.Module.PERSON.DOMAIN.Extensions.Validators;
    using Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Repositories;
    using Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Services;

    public class UserService : ServiceBase<User>, IUserService
    {
        IUserRepository _repository;
        public UserService(IUserRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public override async Task<User> Add(User entity)
        {
            entity.Validate();

            entity.Password = SecurePasswordHasher.Hash(entity.Password);
            return await repository.Add(entity);
        }

        public async Task<User> Authenticate(User entity) => await _repository.GetByName(entity.Name) ?? throw new Exception($"The user {entity.Name} is invalid!");

        public virtual Task<IEnumerable<User>> GetAll() => repository.GetAll();

    }
}
