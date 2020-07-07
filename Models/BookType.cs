using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class BookType
    {
        Guid Id { get; set; }
        string Title { get; set; }
        BookSubject Subject { get; set; }
        BookAuthor Author { get; set; }
        BookPublisher Publisher { get; set; }
        int Year { get; set; }
        int Pages { get; set; }

        public BookType(Guid id, string title, BookSubject subject, BookAuthor author, BookPublisher publisher, int year, int pages)
        {
            Id = id;
            Title = title;
            Subject = subject;
            Author = author;
            Publisher = publisher;
            Year = year;
            Pages = pages;
        }

        public static void Add() { }
    }
}
