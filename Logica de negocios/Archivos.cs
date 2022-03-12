using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_negocios
{
    public class Archivos : Metodos
    {
        //---------------------------- ATRIBUTOS -----------------------------------
        private string nombre;
        private int tamanio;
        //---------------------------- CONSTRUCTOR ----------------------------------
        public Archivos(string nombre, int tamanio)//--------------- Cuando se cree va a pedir los datos iniciales del archivo
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }
        //--------------------------- PROPIEDADES -----------------------------------
        public string Nombre
        {
            set
            {
                if (IsLetters(value))//---- Verifica que sean solo letras
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
