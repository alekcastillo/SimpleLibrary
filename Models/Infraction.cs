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
    public class Infraction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }

        // Ocupamos un constructor vacio para que
        // EntityFramework mapee los valores
        public Infraction() {}
        

        protected Infraction(
            User user,
            Book book)
        {
            User = user;
            Book = book;
        }

        public static Infraction Add(
            int userId,
            int bookId)
        {
            var context = LibraryContext.GetInstance();

            var user = context.Users.FirstOrDefault(
                infractionUser => infractionUser.Id == userId);

            var book = context.Books.FirstOrDefault(
                infractionBook => infractionBook.Id == bookId);

            var infraction = new Infraction(
                user,
                book);

            context.Infractions.Add(infraction);
            context.SaveChanges();

            return infraction;
        }

        public void Pay() {
        
        }
    }
}
