using BookpApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DataAcces.Abstract
{
   public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
