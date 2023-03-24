using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Book
    {
        private string author; // автор
        private string title; // название
        private string publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания
   
        private static double price = 9;

        public void SetBook(String author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;

        }
        public static void SetPrice(double price)
        {
            Book.price = price;
        }
        public void Show()
        {
            Console.WriteLine("\nКнига:\nАвтор: {0}\nНазвание: {1}\nГод издания: {2}\nИздательство: {3}\n{4}стр.\nСтоимость аренды: {5}", author, title, year, publisher, pages, Book.price);
        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
    }
    
    
}
