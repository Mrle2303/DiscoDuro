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
        private int total;
        private int sumatoria;
        private int tamanios;
        
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
        public int Total
        {
            set => total = value; get=> total;
        }
        public int Sumatoria
        {
            set => sumatoria = value; get => sumatoria;
        }
        public int Tamanios
        {
            set => tamanios = value; get => tamanios;
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

        public void Espacios()
        {
            Sumatoria = Sumatoria + tamanio;
            
        }
    }
}
