﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null){
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter){
            throw new NotImplementedException();
        }

        public void Add(Category product){
            throw new NotImplementedException();
        }

        public void Update(Category product){
            throw new NotImplementedException();
        }

        public void Delete(Category product){
            throw new NotImplementedException();
        }

    }
}
