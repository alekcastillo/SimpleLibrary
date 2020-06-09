using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Book
    {
        public Guid Id { get; private set; }
        public BookType Type { get; private set; }

        public Book(Guid id, BookType type)
        {
            Id = id;
            Type = type;
        }
    }
}
