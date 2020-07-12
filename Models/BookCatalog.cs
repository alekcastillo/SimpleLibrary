using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public abstract class BookCatalog
    {
        Guid Id { get; set; }
        string Ttitle { get; set; }
        IEnumerable<Book> Books { get; set; }

        public BookCatalog(
            Guid id,
            string ttitle,
            IEnumerable<Book> books)
        {
            Id = id;
            Ttitle = ttitle;
            Books = books;
        }

        public static void Add() {
        
        }
    }
}
