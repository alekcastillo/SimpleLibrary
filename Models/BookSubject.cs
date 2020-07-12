using Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookSubject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Book> Books { get; set; }

        public BookSubject(
            string title,
            IEnumerable<Book> books)
        {
            Title = title;
            Books = books;
        }

        public static BookSubject Add(
            string title)
        {
            var dataService = DataService.GetInstance();

            var bookSubject = new BookSubject(
                title,
                new List<Book>());

            dataService.BookSubjects.Add(bookSubject);

            return bookSubject;
        }
    }
}
