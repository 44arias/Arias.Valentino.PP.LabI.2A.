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

            //Escaner escanerLibros = new Escaner("Marca1", Escaner.TipoDoc.libro);
            //Escaner escanerMapas = new Escaner("Marca2", Escaner.TipoDoc.mapa);

            //escanerLibros += miLibro;
            //escanerMapas += miMapa;

            //int extension, cantidad;
            //string resumen;

            //Informes.MostrarDistribuidos(escanerLibros, out extension, out cantidad, out resumen);
            //Console.WriteLine("Informe de libros distribuidos:");
            //Console.WriteLine($"Extensión total: {extension} páginas");
            //Console.WriteLine($"Cantidad de libros: {cantidad}");
            //Console.WriteLine("Resumen:");
            //Console.WriteLine(resumen);

            //Informes.MostrarDistribuidos(escanerMapas, out extension, out cantidad, out resumen);
            //Console.WriteLine("\nInforme de mapas distribuidos:");
            //Console.WriteLine($"Extensión total: {extension} cm2");
            //Console.WriteLine($"Cantidad de mapas: {cantidad}");
            //Console.WriteLine("Resumen:");
            //Console.WriteLine(resumen);
            //Console.ReadKey();

            Console.WriteLine(miLibro);
            Console.WriteLine(miMapa);
            Console.ReadKey();
        }
    }
}

