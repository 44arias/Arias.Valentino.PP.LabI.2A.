using PP_Escaner_AriasValentino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PP_Escaner_AriasValentino {
    class Test {
        static void Main(string[] args) {
            Libro miLibro = new Libro("titulo", "autorx", 4444, "444-44-444-4444-4", "4444444444", 4444);

            Mapa miMapa = new Mapa("titulo mapa", "autorx mapa", 4444, "444-44-444-4444-4 mapa", "4444mapa", 44, 44);

            Console.WriteLine(miLibro);
            Console.WriteLine(miMapa);
            Console.ReadKey();
        }
    }
}

