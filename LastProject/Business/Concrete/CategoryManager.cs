﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult <List<Category>> GetAll()
        {
            
            //iş kodları
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());

        }

        public IDataResult <Category> GeyById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }

        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            throw new System.NotImplementedException();
        }

        IDataResult<Category> ICategoryService.GeyById(int categoryId)
        {
            throw new System.NotImplementedException();
        }
    }
}