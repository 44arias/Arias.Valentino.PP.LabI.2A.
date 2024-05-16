using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test {
    internal class Program {
        static void Main(string[] args) {

            Documento doc = new Documento("titulo dou", "hitler", 1212, "asdas", "asd123");
            Console.WriteLine(doc);
            Console.ReadKey();
        }
    }
}
