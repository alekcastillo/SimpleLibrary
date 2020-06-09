using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public abstract class BookCatalog
    {
        public Guid Id { get; private set; }
        public String Title { get; private set; }
        public List<BookType> BookTypes { get; private set; }

        protected BookCatalog(
            Guid id
            ,string title
            ,List<BookType> bookTypes)
        {
            Id = id;
            Title = title;
            BookTypes = bookTypes;
        }

        public virtual void AddBookType(BookType bookType)
        {
            BookTypes.Add(bookType);
        }
    }
}
