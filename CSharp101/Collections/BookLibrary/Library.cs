using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.BookLibrary
{
    public class Library
    {
        ArrayList bookList = new ArrayList();
        public void KitapEkle(Book books)
        {
            bookList.Add(bookList);
        }

        public void KitapListele()
        {
            foreach (var book in bookList)
            {
                Console.WriteLine(book);
            }
        }
    }
}
