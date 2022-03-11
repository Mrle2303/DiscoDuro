using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_negocios
{
    public class Particiones : Metodos
    {
        //------------------- ATRIBUTOS -------------------------------------------------
        private string nombre;//-- guardara el nombre de la particion
        private int tamanioDisponible, tamanioTotal;//-- guardara tamaño disponible y total sobre la particion
        private List<Archivos> listaArchivos = new List<Archivos>();//-- Se crea una lista donde se guardaran los archivos que estaran en la particion
        //-------------------- CONSTRUCTOR --------------------------------------------
        public Particiones(int tamanio, string nombre)//-- Al crearse una particion en el form se ejecutara esto primero - solo pide los valores con los que iniciara la particion
        {
            this.Nombre = nombre;//-- se usa la propiedad de aqui abajo para añadir el valor al atributo
            this.Tamanio = tamanio;//-- se usa la propiedad de aqui abajo para añadir el valor al atributo
        }
        //---------------------- PROPIEDADES -------------------------------------------------------
        public string Nombre//-- Propiedad que asigna o devuelve un valor al nombre de la particion
        {
            set//-- para asignar
            {
                if (IsLetters(value))//-- verifica que sean puras letras
                {
                    nombre = value;//-- asignamos en valor mandado(sera el nombre de la particion que manda el form)
                }
            }
            get => nombre;//-- para devolver nomas devuelve el nombre
        }
        public int Tamanio//-- Propiedad que asigna o devuelve un valor al tamaño de la particion
        {
            set
            {//-- para asignar
                tamanioTotal = value;//-- asigna el valor que mandaran del form del tamaño de la particion
                tamanioDisponible = tamanioTotal;//-- al crearse la particion tendra el total disponible
            } get => tamanioTotal;//-- para devolver nomas devuelve el tamaño disponible en la particion
        }

        public int TamanioDisponible { get => tamanioDisponible;}

        //------------------------ METODOS --------------------------------------------------------------
        public bool AgregarArchivo(Archivos archivo)//-- Metodo que ejecutaremos cuando queramos añadir archivo(es booleano regresa un valor para saber si se pudo completar)
        {
            if (archivo.Tamanio <= this.TamanioDisponible)//-- Verifica que el tamaño del archivo no supere al disponible
            {
                this.listaArchivos.Add(archivo);//--Añadimos el archivo que mandaron a la lista donde los pondremos
                this.tamanioDisponible -= archivo.Tamanio;//-- Disminuye el tamaño disponible respecto al del archivo
                return true;//-- si se pudo añadir regresa verdadero
            }
            return false;//-- si no se pudo regresa falso
        }
        public bool EliminarArchivo(Archivos archivo)//-- Es metodo lo ejecutaras cuando quieras elimanar un archivo dentro de la particion
        {
            if (this.listaArchivos.Contains(archivo))//-- Revisa si el valor esta en la lista
            {
                this.tamanioDisponible += archivo.Tamanio;
                return this.listaArchivos.Remove(archivo);//-- si estaba solo lo quita
                //-- resgresa verdadero indicando que se elimino con exito
            }
            return false;//-- regreso falso en caso de que no se elimino
        }
        public List<Archivos> ObtenerListaDeArchivos()//-- Este metodo regresa la lista de archivos que tiene esta particion
        {
            return listaArchivos;
        }

      
    }
}
