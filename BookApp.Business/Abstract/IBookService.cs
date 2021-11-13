using BookpApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Business.Abstract
{
   public interface IBookService
    {
        List<Book>  GetAll();
        Book Get(int id);
        void Add(Book book);
        void Delete(Book book );
        void Update(Book book);
        List<Book> GetBooksByBookName(string bookName);
        List<Book> GetBooksByCategory(int categoryId);
    }
}
