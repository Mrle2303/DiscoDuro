using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_negocios
{
    public class Archivos : Metodos
    {
        private string nombre;
        private int tamanio;

        public Archivos(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }
        public string Nombre
        {
            set
            {
                if (IsLetters(value))
                {
                    nombre = value;
                }
            }
            get => nombre;
        }
        public int Tamanio
        {
            set => tamanio = value; get => tamanio;
        }
    }
}
