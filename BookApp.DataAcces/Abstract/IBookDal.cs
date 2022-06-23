using BookpApp.Entities.Concrete;
using BookpApp.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DataAcces.Abstract
{
   public interface IBookDal:IEntityRepository<Book>
    {

        List<BookDto> GetBooks(Expression<Func< BookDto,bool>> filter = null);
    }
}
