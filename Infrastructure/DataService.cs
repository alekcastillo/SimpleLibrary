using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public class DataService
    {
        public List<BookAuthor> BookAuthors { get; private set; }
        public List<BookPublisher> BookPublishers { get; private set; }
        public List<BookSubject> BookSubjects { get; private set; }
        public List<BookType> BookTypes { get; private set; }
        public List<Book> Books { get; private set; }

        protected DataService()
        {
            BookAuthors = new List<BookAuthor>();
            BookPublishers = new List<BookPublisher>();
            BookSubjects = new List<BookSubject>();
            BookTypes = new List<BookType>();
            Books = new List<Book>();
        }

        protected static DataService instance { get; private set; }

        public static DataService GetInstance()
        {
            if (instance == null)
                instance = new DataService();

            return instance;
        }
    }
}
