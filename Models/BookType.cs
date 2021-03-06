﻿using Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public BookSubject Subject { get; set; }
        public BookAuthor Author { get; set; }
        public BookPublisher Publisher { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        // Ocupamos un constructor vacio para que
        // EntityFramework mapee los valores
        public BookType() { }

        protected BookType(
            string title,
            BookSubject subject,
            BookAuthor author,
            BookPublisher publisher,
            int year,
            int pages)
        {
            Title = title;
            Subject = subject;
            Author = author;
            Publisher = publisher;
            Year = year;
            Pages = pages;
        }

        public static BookType Add(
            string title,
            int subjectId,
            int authorId,
            int publisherId,
            int year,
            int pages)
        {
            var context = LibraryContext.GetInstance();

            var subject = context.BookSubjects.FirstOrDefault(
                bookSubject => bookSubject.Id == subjectId);
            var author = context.BookAuthors.FirstOrDefault(
                bookAuthor => bookAuthor.Id == authorId);
            var publisher = context.BookPublishers.FirstOrDefault(
                bookPublisher => bookPublisher.Id == publisherId);

            var bookType = new BookType(
                title,
                subject,
                author,
                publisher,
                year,
                pages);

            context.BookTypes.Add(bookType);
            context.SaveChanges();

            return bookType;
        }
    }
}
