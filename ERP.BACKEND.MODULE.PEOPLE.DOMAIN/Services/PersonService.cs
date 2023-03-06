namespace PeopleManagement.Domain.Services
{
    using PeopleManagement.Common.Tools;
    using PeopleManagement.Domain.Entities;
    using PeopleManagement.Domain.Extensions.Validators;
    using PeopleManagement.Domain.Interfaces.Repositories;
    using PeopleManagement.Domain.Interfaces.Services;

    public class PersonService : ServiceBase<Person>, IPersonService
    {
        IPersonRepository _repository;
        public PersonService(IPersonRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public override async Task<Person> GetById(Guid id)
        {
            Person person = new Person { Id = id };

            await person.ValidateGet(_repository);

            return await _repository.GetById(id);
        }

        public override async Task<bool> Delete(Guid id)
        {
            Person person = new Person { Id = id };

            await person.ValidateDelete(_repository);

            return await repository.Delete(id);
        }

        public override async Task<Person> Add(Person entity)
        {
            entity.CpfCnpj = RegexTool.NormalizeOnlyNumbers(entity.CpfCnpj);

            await entity.ValidateAdd(_repository);

            return await repository.Add(entity);
        }

        public virtual Task<IEnumerable<Person>> GetAll() => repository.GetAll();

        public override async Task<Person> Update(Person entity)
        {
            await entity.ValidateUpdate(_repository);

            var personExistent = await _repository.GetById(entity.Id);

            if (personExistent != null)
            {
                return await repository.Update(entity);
            }
            else
            {
                throw new InvalidDataException($"Usuário não encontrado.");
            }
        }
    }
}
