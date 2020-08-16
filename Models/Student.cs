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
    public class Student
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
        public Student()
        {
            BorrowedBooks = new List<Book>();
            Infractions = new List<Infraction>();
        }

        protected Student(
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

        public static Student Add(
            string email,
            string firstName,
            string lastName)
        {
            var context = LibraryContext.GetInstance();
            var student = new Student(
                email,
                firstName,
                lastName,
                new List<Book>(),
                new List<Infraction>());

            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

        public bool HasActiveInfraction() 
        {
            return this.Infractions.Count > 0;
        }
    }
}
