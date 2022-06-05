using MX_Target_Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MX_Target_Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetPersons();

        Task<Person> GetById(int? id);

        Task<Person> Create(Person person);

        Task<Person> Update(Person person);

        Task<Person> Remove(Person person);
    }
}
