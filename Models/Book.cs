using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public BookType Type { get; set; }
        public BookStatus Status { get; set; }

        public Book(BookType type, BookStatus status)
        {
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
            Status = BookStatus.Lost;
        }

        public void Return() {
        
        }
    }
}
