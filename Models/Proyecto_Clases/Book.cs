using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clases
{
    public class Book
    {
        Guid Id;
        BookType Type;
        BookStatus Status;

        public static void Add() { }

        public void Lend(Guid userId) { }

        public void Lend(string userEmail) { }

        public void SetAsLost() { }

        public void Return() { }
    }
}
