using System;

namespace builder;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join('-', args));
            Director miDirector = new Director();
            BuilderNormal normal = new BuilderNormal();
            miDirector.Construye(normal);
            Producto pastel1 = normal.ObtenProducto();
            pastel1.MostrarPastel();            
        }
    }
