using Business.Abstract;
using Core.Utilities.ErrorResult;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.ComponentModel.Design;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //business codes

            if (product.ProductName.Length<2)
            {
                return new ErrorResult("Ürün ismi enn az 2 karakter olmalıdır");
            }
            _productDal.Add(product);

            return new SuccesResult("Ürün eklendi");
        }

        public List<Product> GetAll()

        {
            //iş kodları 
            //yetkisi var mı 

            return  new _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryID(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public IEnumerable<object> GetAllByCategoryId(int v)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);      
        } 

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();

        }

        IResult IProductService.Add(Product product)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

