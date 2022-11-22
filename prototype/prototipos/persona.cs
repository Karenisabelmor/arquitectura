using System;

namespace prototipo;

class CPersona : IPrototipo {

        private string nombre;
        private string mail;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Mail { get => mail; set => mail = value; }

        public CPersona(string pNombre, string pMail)
        {
            nombre = pNombre;
            mail = pMail;
        }

        public override string ToString(){
            return string.Format("{0}, {1}", nombre, mail);
        }
        public object Clonar(){
            CPersona clon = new CPersona(nombre, mail);

            return clon;
        }
    }