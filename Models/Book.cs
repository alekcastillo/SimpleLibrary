using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        Guid Id { get; set; }
        BookType Type { get; set; }
        BookStatus Status { get; set; }

        public Book(Guid id, BookType type, BookStatus status)
        {
            Id = id;
            Type = type;
            Status = status;
        }

        public static void Add() {

        }

        public void Lend(Guid userId) {
        
        }

        public void Lend(string userEmail) {
        
        }

        public void SetAsLost() {
        
        }

        public void Return() {
        
        }
    }
}
