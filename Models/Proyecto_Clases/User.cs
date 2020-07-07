using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clases
{
    public class User
    {
        Guid Id;
        string Email;
        string Password;
        string FirstName;
        string LastName;
        List<Book> BorrowedBooks;
        List<Infraction> Infractions;

        public static void Add() { }

        public bool HasActiveInfraction() { }

        public void AddInfraction(string transactionId) { }

    }
}
