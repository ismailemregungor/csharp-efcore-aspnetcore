using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors.Constructors2
{
    internal class Book
    {
        //public Book() { }

        //public Book(int BookId) 
        //{
        //    this.BookId = BookId;
        //}

        //public Book(int BookId, string Name) 
        //{
        //    this.BookId = BookId;
        //    this.Name = Name;
        //}

        //public Book(int BookId, string Name, int Price) 
        //{ 
        //    this.BookId = BookId;
        //    this.Name = Name;
        //    this.Price = Price;
        //}

        //public Book(int BookId, string Name, decimal Price, string Description)
        //{
        //    this.BookId = BookId;
        //    this.Name = Name;
        //    this.Price = Price;
        //    this.Description = Description;
        //}

        public Book() { }

        public Book(int BookId) : this(BookId, null) { }

        public Book(int BookId, string Name) : this(BookId, Name, 0) { }

        public Book(int BookId, string Name, decimal Price) : this(BookId, Name, Price, null) { }

        public Book(int BookId, string Name, decimal Price, string Description)
        {
            this.BookId = BookId;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
        }

        public int BookId { get; set; }
        public string Name { get; set;}
        public decimal Price { get; set;}
        public string Description { get; set;}

        string Write(string value)
        {
            return "{BookId}";
        }
    }
}
