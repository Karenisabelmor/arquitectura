using System;

namespace abstractfactory;

class FabricaGelato : IFabrica {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;
        public IProductoLeche ObtenerProductoLeche {
            get { return leche; }
        }

        public IProductoSaborizante ObtenerSabor {
            get { return sabor; }
        }

        public void crearProducto() {
            Console.WriteLine("Estamos produciendo tu gelato");
            leche = new LecheVaca();
            sabor = new SaborChocolate();
        }
    }