using System;

namespace builder;

interface IFrosting{
        string caracteristicas();
    }

    class FrostingBasico : IFrosting{
        public string caracteristicas(){
            return "frosting sencillo";
        }
    }
    class FrostingEspecial : IFrosting{
        public string caracteristicas(){
            return "frosting con diseño";
        }
    }