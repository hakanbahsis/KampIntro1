using Metotlar;
using System;

namespace Metotlae
{
    class Program
    {
        static void Main(string[] args)
        {
            SepetManager sepetManager = new SepetManager();
            

            Product product1 = new Product();
            product1.ProductName = "Elma";
            product1.UnitPrice = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.UnitPrice = 80;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine("Ürün Adı : "+product.ProductName);
                Console.WriteLine("Ürün Fiyatı : "+product.UnitPrice);
                Console.WriteLine("Ürün Açıklaması : "+product.Description);
                Console.WriteLine("----------------");
            }

            sepetManager.Ekle(product1);
            
            Console.ReadKey();
        }
    }
}
