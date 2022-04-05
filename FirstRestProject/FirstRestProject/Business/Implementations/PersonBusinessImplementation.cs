using FirstRestProject.Data.Converter.Implementations;
using FirstRestProject.Data.VO;
using FirstRestProject.Model;
using FirstRestProject.Repository;
using System.Collections.Generic;

namespace FirstRestProject.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        // Returns all people
        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        //Returns one person b id
        public PersonVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }
        /* Quando o objeto entra vem como VO e não dá para persistir na base de dados então é preciso fazer a conversão para entidade
           Como entidade dá para persistir (Create) e o resultado é devolvido para personEntity
           Depois converte-se a entidade para VO e devolve-se a resposta*/
        public PersonVO Create(PersonVO person)
        {
            //O repositório trabalha com entidades por isso temos que converter
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        //Updates one person
        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        //Deletes a peron by its id
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
