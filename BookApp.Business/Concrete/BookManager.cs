using BookApp.Business.Abstract;
using BookApp.Business.Utilities;
using BookApp.Business.Validation.FluentValidation;
using BookApp.DataAcces.Abstract;
using BookpApp.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            ValidationTool.Validate(new BookValidator(), book);
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            try
            {
                _bookDal.Delete(book);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi");

            }
        }

        public Book Get(int id)
        {
            return _bookDal.Get(p => p.Id == id);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetBooksByBookName(string bookName)
        {
            return _bookDal.GetAll(p => p.BookName.ToLower().Contains(bookName.ToLower()));
        }

        public List<Book> GetBooksByCategory(int categoryId)
        {
            return _bookDal.GetAll(p => p.CategoryId == categoryId);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
