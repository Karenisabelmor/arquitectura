using System;

namespace builder;

interface IMasa{
        string caracteristicas();
    }

    class MasaBasica : IMasa{
        public string caracteristicas(){
            return "masa pastel vainilla";
        }
    }
    class MasaEspecial : IMasa{
        public string caracteristicas(){
            return "masa pastel red velvet";
        }
    }