using System;

namespace factory;

internal class Inteligente : IReloj{
        public void Encender(){
            Console.WriteLine("Los relojes inteligentes encienden");
        }
        public void Hora(){
            Console.WriteLine("Te da la hora");
        }
        public void FrecuenciaCardiaca(){
            Console.WriteLine("Te da tu frecuencia cardiaca en el día");
        }
        public void Carga(){
            Console.WriteLine("Necesita que lo cargues cada cierto tiempo");
        }
        public void Apagar(){
            Console.WriteLine("Los relojes inteligentes se apagan");
        }

}

internal class Analogico : IReloj{
        public void Encender(){
            Console.WriteLine("Los analógicos siempre están encendidos");
        }
        public void Hora(){
            Console.WriteLine("Te da la hora");
        }
        public void FrecuenciaCardiaca(){
            Console.WriteLine("No toma tu frecuencia cardiaca");
        }
        public void Carga(){
            Console.WriteLine("Necesita de pilas para funcionar");
        }
        public void Apagar(){
            Console.WriteLine("Se apaga si le quitas la pila");
        }
    }