using FirstRestProject.Model;
using FirstRestProject.Repository;
using FirstRestProject.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FirstRestProject.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
        }

        // Returns all people
        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }

        //Returns one person b id
        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        //Updates one person
        public Person Update(Person person)
        {
            return _repository.Update(person);
        }

        //Deletes a peron by its id
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
