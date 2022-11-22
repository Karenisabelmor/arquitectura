using System;

namespace abstractfactory;

interface IFabrica{
        void crearProducto();
        IProductoLeche ObtenerProductoLeche { get; }
        IProductoSaborizante ObtenerSabor { get; }

    }