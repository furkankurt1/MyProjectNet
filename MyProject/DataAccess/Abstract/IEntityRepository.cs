using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Ientity den alıyor. sadece entity objeleri verilebilir.
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T product);
        void Update(T product);
        void Delete(T product);


    }

}
