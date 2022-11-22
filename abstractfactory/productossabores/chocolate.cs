using System;

namespace abstractfactory;

class SaborChocolate : IProductoSaborizante {
    public string informacion(){
        return "Chocolate Cacao Rico";
    }

    public void obtener(){
        Console.WriteLine("Se produce Choco SD23");
    }

}