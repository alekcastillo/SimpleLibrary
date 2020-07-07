using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Infraction
    {
        Guid Id { get; set; }
        User User { get; set; }
        Book Book { get; set; }

        public Infraction(Guid id, User user, Book book)
        {
            Id = id;
            User = user;
            Book = book;
        }

        public void Pay() { }
    }
}
