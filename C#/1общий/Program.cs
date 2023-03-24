using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Program
    {
        static void Main()
        {
            Book b1 = new Book();
            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
            Book.SetPrice(12);
            b1.Show();
            Console.WriteLine("\n Итоговая стоимость аренды: {0} p.",b1.PriceBook(3));

        }
    }
}
