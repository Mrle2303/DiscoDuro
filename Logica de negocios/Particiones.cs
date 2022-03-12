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
        public bool EliminarArchivo(string nombreArchivo)//-- Es metodo lo ejecutaras cuando quieras elimanar un archivo dentro de la particion
        {
            for (int i = 0; i < listaArchivos.Count; i++)//-- Recorre toda la lista de archivos
            {
                if (listaArchivos[i].Nombre == nombreArchivo)//-- verifica si el nombre coincide con alguno de la lista
                {
                    tamanioDisponible += listaArchivos[i].Tamanio;//-- aumenta el tamaño disponible
                    listaArchivos.RemoveAt(i);//-- quita el archivo de la lista
                    return true;//-- indica que si se realizo la operacion
                }   
            }
            return false;
        }
        public bool VerificaNombreArchivo(string nombreArchivo)// Verifica si ese nombre ya existe
        {
            for(int i = 0; i < listaArchivos.Count; i++)//-- recorre toda la lista
            {
                if(listaArchivos[i].Nombre == nombreArchivo)//-- verifica si algun elemento coincide con la lista
                {
                    return true;// regresa true porque si hay un archivo que se llama igual
                }
            }
            return false;//-- regresa falso porque no hay un archivo que se llame asi
        }
        public List<Archivos> ObtenerListaDeArchivos()//-- Este metodo regresa la lista de archivos que tiene esta particion
        {
            return listaArchivos;
        }

      
    }
}
