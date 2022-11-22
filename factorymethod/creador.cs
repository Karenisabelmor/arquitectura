using System;

namespace factory;

internal class Creador{
        internal static IReloj MetodoFabrica(int dinero){
            IReloj _reloj = null;
            if (dinero > 1000){
                _reloj = new Inteligente();
            }
            if (dinero < 500){
                _reloj = new Analogico();
            }
            return _reloj;
        }
    }