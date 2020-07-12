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
    public class BookAuthor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Book> Books { get; set; }

        protected BookAuthor(
            string title,
            IEnumerable<Book> books)
        {
            Title = title;
            Books = books;
        }

        public static BookAuthor Add(
            string title)
        {
            var dataService = DataService.GetInstance();

            var bookAuthor = new BookAuthor(
                title,
                new List<Book>());

            bookAuthor.Id = dataService.BookAuthors.Count;
            dataService.BookAuthors.Add(bookAuthor);

            return bookAuthor;
        }
    }
}
