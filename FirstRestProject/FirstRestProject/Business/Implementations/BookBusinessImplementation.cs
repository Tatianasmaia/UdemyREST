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
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
        }

        // Returns all people
        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        //Returns one Book by id
        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        //Updates one Book
        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

        //Deletes a Book by its id
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
