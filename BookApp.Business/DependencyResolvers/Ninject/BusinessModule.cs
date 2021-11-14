using BookApp.Business.Abstract;
using BookApp.Business.Concrete;
using BookApp.DataAcces.Abstract;
using BookApp.DataAcces.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookService>().To<BookManager>().InSingletonScope();
            Bind<IBookDal>().To<EfBookDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
        }
    }
}
