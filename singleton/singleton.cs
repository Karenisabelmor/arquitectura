using System;

namespace singleton;

class Singleton {
    private static Singleton instancia;
    private string nombre;
    private int cuenta;

    private Singleton(){
        nombre = "nada";
        cuenta = 100;
    }

    public void CuentaNueva (string Nombre, int Cuenta){
        nombre = Nombre;
        cuenta = Cuenta;
    }

    public static Singleton ObtenerInstancia(){
        if (instancia == null){
            instancia = new Singleton();
            Console.WriteLine("Cuenta registrada");
        } else {
            Console.WriteLine("Por el momento no puedes realizar el registro. {0}", instancia);
        }
        return instancia;
    }

    public override string ToString(){
        return string.Format("La cuenta {0} a nombre de {1} ya está procesando una solicitud.", cuenta, nombre);
    }

    public void Proceso(){
        Console.WriteLine("Se está procesando su solicitud, {0} ", nombre);
    }

    static void Main(string[] args){
            Console.WriteLine("Bienvenido");

            Singleton cuenta1 = Singleton.ObtenerInstancia();
            cuenta1.CuentaNueva("Karen", 102);
            cuenta1.Proceso();
            
            Singleton dos = Singleton.ObtenerInstancia();
            dos.CuentaNueva("Greta", 402);
        }
}
