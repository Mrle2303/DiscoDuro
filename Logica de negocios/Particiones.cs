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
            set{
                tamanioTotal = value;
                tamanioDisponible = tamanioTotal;
            } get => tamanioDisponible;
        }
        public int Total
        {
            set => total = value; get=> total;
        }
       

        public bool agregarArchivo(Archivos archivo)
        {
            if (archivo.Tamanio < this.tamanioDisponible)
            {
                this.archivos.Add(archivo);
                this.tamanioDisponible -= archivo.Tamanio;
                return true;
            }
            return false;
        }

      
    }
}
