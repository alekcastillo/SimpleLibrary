using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Infraction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }

        public Infraction(
            User user,
            Book book)
        {
            User = user;
            Book = book;
        }

        public void Pay() {
        
        }
    }
}
