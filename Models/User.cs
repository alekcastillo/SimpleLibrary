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
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public List<Infraction> Infractions { get; set; }

        protected User(
            string email,
            string password,
            string firstName,
            string lastName,
            List<Book> borrowedBooks,
            List<Infraction> infractions)
        {
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            BorrowedBooks = borrowedBooks;
            Infractions = infractions;
        }

        public static User Add(
            string email,
            string password,
            string firstName,
            string lastName)
        {
            var user = new User(
                email,
                password,
                firstName,
                lastName,
                new List<Book>(),
                new List<Infraction>());

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
