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
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public BookType Type { get; set; }
        public BookStatus Status { get; set; }

        // Ocupamos un constructor vacio para que
        // EntityFramework mapee los valores
        public Book() { }

        protected Book(BookType type, BookStatus status)
        {
            Type = type;
            Status = status;
        }

        public static Book Add(
            int typeId)
        {
            var context = LibraryContext.GetInstance();

            var type = context.BookTypes.FirstOrDefault(
                bookType => bookType.Id == typeId);

            var book = new Book(
                type,
                BookStatus.Disponible);

            context.Books.Add(book);
            context.SaveChanges();

            return book;
        }

        public void Lend(int userId) {
            
        }

        public void Lend(string userEmail) {
            
        }

        public void SetAsLost() {
            Status = BookStatus.Perdido;
        }

        public void Return() {
        
        }
    }
}
