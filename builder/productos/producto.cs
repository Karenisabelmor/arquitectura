using System;

namespace builder;

internal class Producto{
        private IMasa masa;
        private IMolde molde;
        private IFrosting frosting;

        internal void ColocarMasa(IMasa _masa){
            masa = _masa;
            Console.WriteLine("Se ha colocado la masa {0} ", masa);
        }

        internal void ColocarMolde(IMolde _molde)
        {
            molde = _molde;
            Console.WriteLine("Se ha colocado el molde {0} ", molde);
        }

        internal void ColocarFrosting(IFrosting _frosting)
        {
            frosting = _frosting;
            Console.WriteLine("Se han colocado el frosting {0} ", frosting);
        }

        internal void MostrarPastel(){
            Console.WriteLine("masa: {0}", masa);
            Console.WriteLine("frosting: {0}", frosting);
            Console.WriteLine("molde: {0}", molde);
        }
    }