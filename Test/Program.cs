using PP_Escaner_AriasValentino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test {
    internal class Program {
        static void Main(string[] args) {
            Libro libro = new Libro("nana", "autor", 1249, "12313s", "46871234465", 456);
            Console.WriteLine(libro);
            Console.ReadKey();
        }
    }
}
