using BookApp.DataAcces.Abstract;
using BookpApp.Entities.Concrete;
using BookpApp.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DataAcces.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, BookAppContext>, IBookDal
    {
        public List<BookDto> GetBooks(Expression<Func<BookDto,bool>> filter = null)
        {
            using (BookAppContext context = new BookAppContext())
            {
                var result = from book in context.Books
                             join category in context.Categories on book.CategoryId equals category.CategoryId
                             select new BookDto()
                             {
                                 Id = book.Id,
                                 AuthorName = book.AuthorName,
                                 BookName = book.BookName,
                                 CategoryName = category.CategoryName,
                                 NumberofPages = book.NumberofPages,
                                 Price = book.Price,
                                 Publisher = book.Publisher,
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }

        }
    }
}
