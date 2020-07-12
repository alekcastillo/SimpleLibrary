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
        public IEnumerable<BookAuthor> BookAuthors { get; private set; }
        public IEnumerable<BookPublisher> BookPublishers { get; private set; }
        public IEnumerable<BookSubject> BookSubjects { get; private set; }
        public IEnumerable<BookType> BookTypes { get; private set; }
        public IEnumerable<Book> Books { get; private set; }

        protected static DataService instance { get; private set; }

        public static DataService GetInstance()
        {
            if (instance == null)
                instance = new DataService();

            return instance;
        }
    }
}
