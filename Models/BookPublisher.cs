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
    public class BookPublisher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Book> Books { get; set; }

        public BookPublisher(
            string title,
            IEnumerable<Book> books)
        {
            Title = title;
            Books = books;
        }

        public static BookPublisher Add(
            string title)
        {
            var dataService = DataService.GetInstance();

            var bookPublisher = new BookPublisher(
                title,
                new List<Book>());

            dataService.BookPublishers.Add(bookPublisher);

            return bookPublisher;
        }
    }
}
