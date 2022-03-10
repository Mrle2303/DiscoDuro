using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_negocios
{
     public class Particiones : Metodos
    {
        private string nombre;
        private int tamanio;
        private List<Archivos> archivos = new List<Archivos>();
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
        public bool agregarArchivo(Archivos archivo)
        {
            if (archivo.Tamanio < this.tamanio)
            {
                this.archivos.Add(archivo);
                this.tamanio -= archivo.Tamanio;
                return true;
            }
            return false;
        }
    }
}
