using FirstRestProject.Model;
using FirstRestProject.Repository;
using FirstRestProject.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FirstRestProject.Data.Converter.Implementations;
using FirstRestProject.Data.VO;

namespace FirstRestProject.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        // Returns all people
        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        //Returns one Book by id
        public BookVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        //Updates one Book
        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

        //Deletes a Book by its id
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
