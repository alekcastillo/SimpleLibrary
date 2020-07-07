using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clases
{
    public abstract class BookCatalog
    {
        Guid Id;
        string Ttitle;
        IEnumerable<Book> Books;

        public static void Add() { }
    }
}
