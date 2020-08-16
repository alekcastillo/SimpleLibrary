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
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public List<Infraction> Infractions { get; set; }

        //Constructor Vacio
        public User() { }

        protected User(
            string email,
            string firstName,
            string lastName,
            List<Book> borrowedBooks,
            List<Infraction> infractions)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            BorrowedBooks = borrowedBooks;
            Infractions = infractions;
        }

        public static User Add(
            string email,
            string firstName,
            string lastName)
        {
            var context = LibraryContext.GetInstance();
            var user = new User(
                email,
                firstName,
                lastName,
                new List<Book>(),
                new List<Infraction>());

            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public bool HasActiveInfraction() 
        {
            return true;
        }

        public void AddInfraction(string transactionId) {
            
        }
    }
}
