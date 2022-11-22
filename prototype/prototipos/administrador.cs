using System;

namespace prototipo;

class CAdminPrototipos{
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();
        public CAdminPrototipos(){
            //Adicionamos los obj prototipo con los valores iniciales
            CPersona persona = new CPersona("Karen", "hola@hotmail.com");
            prototipos.Add("Persona", persona);

            CLibro libro = new CLibro("Outlander", "Diana Gabaldon", 400);
            prototipos.Add("Libros", libro);
        }

        public void AdicionaPrototipo(string pLlave, IPrototipo pPrototipo){
            prototipos.Add(pLlave, pPrototipo);
        }
        public object ObtenPrototipo(string pLlave){
            return prototipos[pLlave].Clonar();
        }
    }