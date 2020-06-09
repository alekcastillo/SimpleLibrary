using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class BookPublisher : BookCatalog
    {
        public BookPublisher(
            Guid id
            , string title
            , List<BookType> bookTypes
        ) : base(
            id
            ,title
            ,bookTypes)
        {
        }

        public override void AddBookType(BookType bookType)
        {
            BookTypes.Add(bookType);
            bookType.Publisher = this;
        }
    }
}
