using ERP.BACKEND.MODULE.PERSON.COMMON.Tools;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Repositories;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.DOMAIN.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        IUserRepository _repository;
        public UserService(IUserRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public override async Task<User> Add(User entity)
        {
            entity.Password = SecurePasswordHasher.Hash(entity.Password);
            return await repository.Add(entity);
        }

        public async Task<User> Authenticate(User entity)
        {
            return await _repository.GetByName(entity.Name);
        }

    }
}
