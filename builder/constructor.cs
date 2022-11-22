using System;

namespace builder;

internal class BuilderNormal : IBuilder{
        private Producto pastel = new Producto();
        public void ConstruyeMasa()
        {
            pastel.ColocarMasa(new MasaEspecial());
        }

        public void ConstruyeMolde()
        {
            pastel.ColocarMolde(new Molde1());
        }

        public void ConstruyeFrosting()
        {
            pastel.ColocarFrosting(new FrostingBasico());
        }

        internal Producto ObtenProducto()
        {
            return pastel;
        }
    }