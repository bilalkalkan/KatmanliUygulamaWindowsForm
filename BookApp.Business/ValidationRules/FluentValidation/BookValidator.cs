using BookpApp.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Business.Validation.FluentValidation
{
   public class BookValidator: AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(p => p.BookName).NotEmpty().WithMessage("Kitap ismi boş bırakılamaz");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.AuthorName).NotEmpty().WithMessage("Yazar ismi boş bırakılamaz");
            RuleFor(p => p.NumberofPages).NotEmpty().WithMessage("Sayfa sayısı boş bırakılamaz");
            RuleFor(p => p.Price).NotEmpty().WithMessage("Fiyat boş bırakılamaz");
            RuleFor(p => p.Publisher).NotEmpty().WithMessage("Yayınevi boş bırakılamaz");

            RuleFor(p => p.NumberofPages).GreaterThan(0);
            RuleFor(p => p.Price).GreaterThan(0);

           // RuleFor(p => p.BookName).Must(StartWithA).WithMessage("Ürün ismi A ile başlamalı.");
        }
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }

    }
}
