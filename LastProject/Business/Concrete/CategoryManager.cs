using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal x)
        {
            _categoryDal = x;
        }

        public List<Category> GetAll()
        {
            //iş kodları
            return _categoryDal.GetAll();

        }

        public Category GeyById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}