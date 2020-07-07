using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class User
    {
        Guid Id { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        List<Book> BorrowedBooks { get; set; }
        List<Infraction> Infractions { get; set; }

        public User(Guid id, string email, string password, string firstName, string lastName, List<Book> borrowedBooks, List<Infraction> infractions)
        {
            Id = id;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            BorrowedBooks = borrowedBooks;
            Infractions = infractions;
        }

        public static void Add() { }

        public bool HasActiveInfraction() 
        {
            return true;
        }

        public void AddInfraction(string transactionId) { }
    }
}
