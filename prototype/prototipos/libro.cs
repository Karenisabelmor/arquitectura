using System;

namespace prototipo;

class CLibro : IPrototipo{
        private string titulo;
        private string autor;
        private int costo;

        public string Titulo { get => titulo; set => titulo = value;}
        public string Autor { get => autor; set => autor = value;}

        public CLibro(string pTitulo, string pAutor, int pCosto){
            titulo = pTitulo;
            costo = pCosto;
            autor = pAutor;
        }

        public override string ToString(){
            return string.Format("{0}, {1}, {2}", titulo, autor, costo);
        }
        public object Clonar(){
            CLibro clon = new CLibro(titulo, autor, costo);

            return clon;
        }
    }