using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstRestProject.Data.VO;
using FirstRestProject.Model;

namespace FirstRestProject.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);

    }
}
