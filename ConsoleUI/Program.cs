using Business.Concrete;
using DataAccess.EntityFramework.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var productdto in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(productdto.ProductName + "/" + productdto.CategoryName+" " + productManager.GetProductDetails().Message);
            }
            Console.WriteLine(productManager.GetProductDetails().Message);
            Console.ReadLine();
           
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
            Console.ReadLine();
        }
    }
}
