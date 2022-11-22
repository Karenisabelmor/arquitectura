using System;

namespace builder;

interface IMolde{
        string caracteristicas();
    }

    class Molde1 : IMolde{
        public string caracteristicas(){
            return "molde circulo";
        }
    }
    class Molde2 : IMolde{
        public string caracteristicas(){
            return "molde cuadrado";
        }
    }