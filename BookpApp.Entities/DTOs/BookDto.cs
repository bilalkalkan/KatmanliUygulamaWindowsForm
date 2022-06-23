using BookpApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookpApp.Entities.DTOs
{
    public class BookDto:IDto
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int NumberofPages { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public string Publisher { get; set; }
    }
}
