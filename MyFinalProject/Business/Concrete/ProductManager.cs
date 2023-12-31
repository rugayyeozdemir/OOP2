﻿using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FulentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        private readonly ILogger _logger;
        ILogger logger; 
        public ProductManager(IProductDal productDal, ILogger logger )
        {
            _productDal = productDal;
            _logger = logger;
        }



         //[ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            _logger.Log();
            try
            {
                //business codes 

                _productDal.Add(product);

                return new SuccessResult(Messages.ProductAdded);
            }

            catch (Exception exeption)
            {
                _logger.Log(); 
            }
            return new ErrorResult();

            //business codes
            _productDal.Add(product);

            return new SuccessResult("Messages.ProductAdded");
        }

        public IDataResult<List<Product>> GetAll()

        {
            if (DateTime.Now.Hour == 15)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(Messages.ProductsListed,_productDal.GetAll());
        }

        public List<Product> GetAllByCategoryID(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public IDataResult <List<Product>>  GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Product> GetById(int productId)

        {
            return new SuccessDataResult<Product>(_productDal.Get(p =>p.ProductId == productId));

        } 

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());

        }

       
    }
}

