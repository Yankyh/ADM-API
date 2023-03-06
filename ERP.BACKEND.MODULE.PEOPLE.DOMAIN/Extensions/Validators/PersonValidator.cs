using PeopleManagement.Common.Tools;
using PeopleManagement.Domain.Entities;
using PeopleManagement.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PeopleManagement.Domain.Extensions.Validators
{
    public static class PersonValidator
    {

        public static async Task ValidateGet(this Person person, IPersonRepository repository)
        {
            var personExistent = await GetPersonById(person, repository);

            if (personExistent == null)
            {
                throw new InvalidDataException($"Pessoa não encontrada.");
            }
        }

        public static async Task ValidateAdd(this Person person, IPersonRepository repository)
        {
            await ValidateInput(person, repository);

            if (await PersonAlreadyExists(person, repository))
            {
                throw new InvalidDataException($"Já existe uma pessoa com o nome {person.Name}.");
            }

            if (await CpfCnpjAlreadyExists(person, repository))
            {
                throw new InvalidDataException($"Já existe uma pessoa com o cpf/cnpj {person.CpfCnpj}.");
            }
        }

        public static async Task ValidateUpdate(this Person person, IPersonRepository repository)
        {
            var personExistent = await GetPersonById(person, repository);

            if (personExistent == null)
            {
                throw new InvalidDataException($"Pessoa não encontrada.");
            }

            await ValidateInput(person, repository);

            if(personExistent.Name != person.Name)
            {
                if (await PersonAlreadyExists(person, repository))
                {
                    throw new InvalidDataException($"Já existe uma pessoa com o nome {person.Name}.");
                }
            }

            if (personExistent.CpfCnpj != person.CpfCnpj)
            {
                if (await CpfCnpjAlreadyExists(person, repository))
                {
                    throw new InvalidDataException($"Já existe uma pessoa com o cpf/cnpj {person.CpfCnpj}.");
                }
            }
        }

        public static async Task ValidateDelete(this Person person, IPersonRepository repository)
        {
            var personExistent = await GetPersonById(person, repository);

            if (personExistent == null)
            {
                throw new InvalidDataException($"Pessoa não encontrada.");
            }
        }

        public static async Task ValidateInput(this Person person, IPersonRepository repository)
        {
            if (person.Name == null)
            {
                throw new InvalidDataException($"O campo nome é obrigatório.");
            }

            if (person.Name.Length < 4)
            {
                throw new InvalidDataException($"O nome deve ter no minímo 3 caracteres.");
            }

            if (person.CpfCnpj == null)
            {
                throw new InvalidDataException($"O campo cpf/cnpj é obrigatório.");
            }

            if (!ValidateCpf(person.CpfCnpj) && !ValidateCnpj(person.CpfCnpj))
            {
                throw new InvalidDataException($"Cpf/cnpj inválido.");
            }
        }

        public static bool ValidateCnpj(string cnpj)
        {
            return CommonValidations.ValidateCnpj(cnpj);
        }

        public static bool ValidateCpf(string cpf)
        {
            return CommonValidations.ValidateCpf(cpf);
        }
        public static async Task<bool> PersonAlreadyExists(this Person person, IPersonRepository repository)
        {
            return await repository.GetByName(person.Name) != null;
        }

        public static async Task<bool> CpfCnpjAlreadyExists(this Person person, IPersonRepository repository)
        {
            return await repository.GetByCpfCnpj(person.CpfCnpj) != null;
        }

        public static async Task<Person> GetPerson(this Person person, IPersonRepository repository)
        {
            return await repository.GetByCpfCnpj(person.CpfCnpj);
        }

        public static async Task<Person> GetPersonById(this Person person, IPersonRepository repository)
        {
            return await repository.GetById(person.Id);
        }

    }
}
