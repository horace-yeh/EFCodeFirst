using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Repository.Interface
{
    //Reference: https://kevintsengtw.blogspot.com/2012/10/aspnet-mvc-part2-repository.html

    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Create(TEntity instance);

        void Update(TEntity instance);

        void Delete(TEntity instance);

        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetAll();

        void SaveChanges();

    }
}
