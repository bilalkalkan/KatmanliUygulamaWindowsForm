using BookpApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DataAcces.Concrete
{
   public class BookAppContext:DbContext
    {
        public DbSet<Book> books { get; set; }
        public DbSet<Member> members { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
