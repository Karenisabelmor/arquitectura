using System;

namespace abstractfactory;

class FabricaHelado : IFabrica{
        private IProductoLeche leche;
        private IProductoSaborizante sabor;
        public IProductoLeche ObtenerProductoLeche {
            get { return leche; }
        }

        public IProductoSaborizante ObtenerSabor {
            get { return sabor; }
        }

        public void crearProducto(){
            //Console.ForegroundColor = ConsoleColor.Green;
            string selection = "";
            Console.WriteLine("Extraemos el sabor");
            Console.WriteLine("1) Vainilla\n2)Chocolate\n");
            selection = Console.ReadLine();

            if (selection == "1"){
                sabor = new SaborVainilla();
            }
            else{
                sabor = new SaborChocolate();
            }
            sabor.obtener();
            Console.WriteLine("Estamos creando tu helado");
            leche = new LecheVaca();
        }
    }