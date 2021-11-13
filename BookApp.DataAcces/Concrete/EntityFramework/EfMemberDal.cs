using BookApp.DataAcces.Abstract;
using BookpApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DataAcces.Concrete.EntityFramework
{
    public class EfMemberDal:EfEntityRepositoryBase<Member,BookAppContext>,IMemberDal
    {
    }
}
