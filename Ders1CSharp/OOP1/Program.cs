using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.Name = "Kabak";
            product1.UnitPrice = 50;
            product1.UnitsInStock = 100;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 6,
                Name = "Laptop",
                UnitPrice = 3000,
                UnitsInStock = 20
            };

            ProductManagerDal productManager = new ProductManagerDal();
            productManager.Add(product1);
            

            
        }

    }
}
