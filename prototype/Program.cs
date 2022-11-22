using System;

namespace prototipo;

class Program {
        static void Main(string[] args){
            // invocamos el admin
            CAdminPrototipos admin = new CAdminPrototipos();

            //instanciamos dos obj
            CPersona uno = (CPersona)admin.ObtenPrototipo("Persona");
            CPersona dos = (CPersona)admin.ObtenPrototipo("Persona");

            //modificamos el estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("-----");

            //Modificamos el estado
            uno.Mail = "karen@hotmail.com";
            dos.Mail = "karen@gmail.com";


            // verificamos que cada quien tenga su estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("-----");

            //Creamos una instancia
            CLibro libro = new CLibro("The Final Empire", "Brandon Sanderson", 300);

            //Lo colocamos como prototipo
            admin.AdicionaPrototipo("Libro", libro);

            //Obtenemos un objeto del prototipo anterior
            CLibro libro2 = (CLibro)admin.ObtenPrototipo("Libro");

            //Cambiamos el estado
            libro2.Titulo= "The Well of Ascension";

            Console.WriteLine(libro);
            Console.WriteLine(libro2);
            Console.WriteLine("-----");

        }
    }