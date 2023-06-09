using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        class products
        {
            public string ID;
            public string Name;
            public int price;
            public string category;
            public string BrandName;
            public string country;
        }
        static void Main(string[] args)
        {

            products[] v = new products[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                    v[count] = add_products();
                    count = count + 1;

                }
                else if (option == '2')
                {
                    View_Products(v, count);
                }
                else if (option == '3')
                {
                    int result = Total_Worth_Products(v, count);
                    Console.WriteLine("Result is :" + result);
                    Console.ReadKey();
                }
                else if (option == '4')
                {
                    break;
                }
            }
            while (option != '4');
            Console.WriteLine("Press enter to exit");
            Console.Read();
        }
        static char menu()
        {
            Console.Clear();
            char option;
            Console.WriteLine("Press 1 to Add Product");
            Console.WriteLine("Press 2 to Show Product");
            Console.WriteLine("Press 3 for Total worth of store");

            Console.WriteLine("Press 4 to exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        static products add_products()
        {
            products v1 = new products();
            Console.WriteLine("ENTER YOUR ID");
            v1.ID = Console.ReadLine();
            Console.WriteLine("ENTER NAME");
            v1.Name = Console.ReadLine();
            Console.WriteLine("ENTER PRICE");
            v1.price = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER PRODUCT's CATEGORY");
            v1.category = Console.ReadLine();
            Console.WriteLine("ENTER BRANDNAME");
            v1.BrandName = Console.ReadLine();
            Console.WriteLine("ENTER YOUR COUNTRY NAME");
            v1.country = Console.ReadLine();
            return v1;

        }
        static void View_Products(products[] v, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("ID:  " + v[i].ID + "  NAME:  " + v[i].Name + "  PRICE:  " + v[i].price + "  CATEGORY:  " + v[i].category + "  BRAND NAME  " + v[i].BrandName + "  COUNTRY NAME  " + v[i].country);
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadKey();
        }
        static int Total_Worth_Products(products[] v, int count)

        {
            int price = 0;
            for (int x = 0; x < count; x++)
            {
                price = price + v[x].price;
            }
            return price;
          
        }
    }
}
