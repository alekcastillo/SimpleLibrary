using Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public class LibraryContext : DbContext
    {
        protected static LibraryContext instance { get; private set; }

        protected LibraryContext()
            : base("LibraryDatabase")
        { }

        public static LibraryContext GetInstance()
        {
            if (instance == null)
                instance = new LibraryContext();

            return instance;
        }

        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookPublisher> BookPublishers { get; set; }
        public DbSet<BookSubject> BookSubjects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Infraction> Infractions { get; set; }
    }
}
