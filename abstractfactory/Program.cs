using System;

namespace abstractfactory;

class Program {
    static void Main(string[] args) {
        // Fabrica 1
        IFabrica mifabrica = new FabricaGelato();
        mifabrica.crearProducto();

        IProductoLeche _leche_ = mifabrica.ObtenerProductoLeche;
        IProductoSaborizante _sabor_ = mifabrica.ObtenerSabor;

        _leche_.producir();
        _leche_.obtenerDatos();

        Console.WriteLine("- Mi gelato es de {0} y {1}", _leche_.obtenerDatos(), _sabor_.informacion());
        Console.WriteLine("---");
            
        // Fabrica 2
        IFabrica mifabrica2 = new FabricaHelado();
        mifabrica2.crearProducto();

        IProductoLeche _leche2_ = mifabrica2.ObtenerProductoLeche;
        IProductoSaborizante _sabor2_ = mifabrica2.ObtenerSabor;

        _leche2_.producir();
        _leche2_.obtenerDatos();

        Console.WriteLine("- Mi helado es de {0} y {1}", _leche2_.obtenerDatos(), _sabor2_.informacion());
    }
}
