using System;

namespace factory;

    class Program
    {
        static void Main(string[] args){
            string dato;
            int dinero;
            IReloj reloj;

            Console.WriteLine("Cuánto dinero tiene para el reloj?");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);
            reloj = Creador.MetodoFabrica(dinero);

            reloj.Encender();
            reloj.Hora();
            reloj.FrecuenciaCardiaca();
            reloj.Carga();
            reloj.Apagar();
        }
    }