using Library.Infrastructure;
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
        public Student Student { get; set; }
        public Book Book { get; set; }

        // Ocupamos un constructor vacio para que
        // EntityFramework mapee los valores
        public Infraction() {}
        

        protected Infraction(
            Student student,
            Book book)
        {
            Student = student;
            Book = book;
        }

        public static Infraction Add(
            int studentId,
            int bookId)
        {
            var context = LibraryContext.GetInstance();

            var student = context.Students.FirstOrDefault(
                infractionStudent => infractionStudent.Id == studentId);

            var book = context.Books.FirstOrDefault(
                infractionBook => infractionBook.Id == bookId);

            var infraction = new Infraction(
                student,
                book);

            context.Infractions.Add(infraction);
            context.SaveChanges();

            return infraction;
        }

        public void Pay() {
        
        }
    }
}
