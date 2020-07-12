using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookAuthor : BookCatalog
    {
        public BookAuthor(
            Guid id,
            string ttitle,
            IEnumerable<Book> books
        ) : base(id, ttitle, books)
        {

        }

        public static void Add() {
        
        }
    }
}
