using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class BookType
    {
        public Guid Id { get; private set; }
        public String Title { get; private set; }
        public BookSubject Subject { get; set; }
        public BookAuthor Author { get; set; }
        public BookPublisher Publisher { get; set; }
        public int Year { get; private set; }
        public int Pages { get; private set; }

        public BookType(
            Guid id
            ,string title
            ,BookSubject subject
            ,BookAuthor author
            ,BookPublisher publisher
            ,int year
            ,int pages)
        {
            Id = id;
            Title = title;
            Subject = subject;
            Author = author;
            Publisher = publisher;
            Year = year;
            Pages = pages;
        }
    }
}
