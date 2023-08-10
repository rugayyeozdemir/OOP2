using DataAccess.Concrete.EntityFreamwork;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    //SOLID 
    //Open Closed Principle
      public class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //IoC 
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

            //CategoyTest();
        }

        private static void CategoyTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if(result.Success)

            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }



            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName +"/" + product.CategoryName );
            }
        }
    }
}