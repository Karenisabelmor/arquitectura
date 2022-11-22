using System;

namespace builder;

internal class Director
    {
        internal void Construye(IBuilder _constructor)
        {
            _constructor.ConstruyeMasa();
            _constructor.ConstruyeMolde();
            _constructor.ConstruyeFrosting();
        }
    }