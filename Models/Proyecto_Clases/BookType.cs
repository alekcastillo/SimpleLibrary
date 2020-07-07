using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clases
{
    public class BookType
    {
        Guid Id;
        string Title;
        BookSubject Subject;
        BookAuthor Author;
        BookPublisher Publisher;
        int Year;
        int Pages;

        public static void Add() { }
    }
}
