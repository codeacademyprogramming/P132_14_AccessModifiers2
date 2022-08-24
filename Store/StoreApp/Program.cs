using System;
using StoreClasses;

namespace StoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Store arazMarket = new Store();
            arazMarket.Name = "Araz";
            arazMarket.ProductLimit = 20;
          

            Console.WriteLine("1. Mehsul elave et");
            Console.WriteLine("2. Mehsullara bax");
            Console.WriteLine("3. Kateqoriaya eases mehsullara bax");
            Console.WriteLine("0. Cix");


            string opt;
            do
            {
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Adi daxil edin");
                        string name = Console.ReadLine();

                        Console.WriteLine("Kateqoriyani daxil edin");
                        string category = Console.ReadLine();


                        double price;

                        do
                        {

                            Console.WriteLine("Qiymeti daxil edin");
                            string priceStr = Console.ReadLine();
                            price = Convert.ToDouble(priceStr);

                        } while (price<0);


                        Product product = new Product
                        {
                            Name = name,
                            Category = category,
                            Price = price
                        };

                        arazMarket.AddProduct(product);
                        break;
                    case "2":
                        for (int i = 0; i < arazMarket.Products.Length; i++)
                        {
                            Console.WriteLine($"{arazMarket.Products[i].Name} - {arazMarket.Products[i].Price}");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Kateqoriyani daxil edin");
                        string wantedCategory = Console.ReadLine();

                        Product[] filteredProducts = arazMarket.GetProductsByCategory(wantedCategory);

                        for (int i = 0; i < filteredProducts.Length; i++)
                        {
                            Console.WriteLine(filteredProducts[i].Name);
                        }

                        break;
                    case "0":
                        Console.WriteLine("Program bitdi");
                        break;
                    default:
                        Console.WriteLine("Dogru secim edin!");
                        break;
                }
            } while (opt!="0");

        }


    }
}
