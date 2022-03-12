using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_negocios
{
    public class DiscoDuro
    { //----------------------- ATRIBUTOS ----------------------------

        private int tamanioDiscoTotal;//--Variable que guardara el tamaño total del DD
        private int tamanioDiscoDisponible;//--Guardara el disponible que hay del DD
        private List<Particiones> listaParticiones;//-- guardara cuantas y cuales particiones vamos creando
        //-------------------- CONSTRUCTOR -------------------------------
        public DiscoDuro(int tamanio)
        {
            listaParticiones = new List<Particiones>();//-- Se instancia el objeto de la lista donde estara las particiones
            this.TamanioDiscoTotal = tamanio;//-- Asignamos el tamaño del disco duro
            this.tamanioDiscoDisponible = TamanioDiscoTotal;//-- Al inicio el tamaño disponible sera igual al tamaño total
        }
        //------------------- PROPIEDADES ---------------------------------------------------
        public int TamanioDiscoTotal { get => tamanioDiscoTotal;
            set
            {
                if (value > 0)//-- Para asignarse tiene que ser mayor a 0
                {
                    this.tamanioDiscoTotal = value;
                }
            }
        }
        public int TamanioDiscoDisponible { get => tamanioDiscoDisponible; }
        //----------------------------- METODOS ----------------------------------------
        public void AsignarParticion(Particiones particion)//-- Metodo que asigna 
        {
            this.listaParticiones.Add(particion);//-- Añade la lista 
            tamanioDiscoDisponible -= particion.Tamanio;//-- Disminuye el tamaño disponible respecto ala particion agregada
        }
        public Particiones ObtenerParticion(string nombre)//-- Metodo que me dira que aparticion es depediendo su nombre
        {
            for (int i = 0; i < listaParticiones.Count; i++)//-- da vueltas hasta que se acabe la lista
            {
                if (listaParticiones[i].Nombre == nombre)//-- revisa si el nombre esta en la lista
                {
                    return listaParticiones[i];//-- devuelve la particion escogida
                }
            }
            return null;//--- EN caso de que no devuelva un nulo
        }
        public bool VerificarNombreParticion(string nombreParticion)//--- vreifica si hay alguna particion con ese nombre
        {
            for(int i = 0; i < listaParticiones.Count; i++)//--Recorre toda la lista 
            {
                if (listaParticiones[i].Nombre == nombreParticion)//-- Verifica si el nombre mandado existe en la lista
                {
                    return true;// regresa verdadero si es que existe
                }
            }
            return false;//-- si no regresa falso
        }
        public bool BorrarParticiones(string nombre)//-- Metodo para  borrar las particiones
        {
            for (int i = 0; i < listaParticiones.Count; i++)//-- da vueltas hasta que se acabe la lista
            {
                if (listaParticiones[i].Nombre == nombre)//-- revisa si el nombre esta en la lista
                {
                    tamanioDiscoDisponible += listaParticiones[i].Tamanio;//-- Aumenta el valor disponible ya que no estara esa particion
                    listaParticiones.RemoveAt(i);//-- quita la particion de la lista
                    return true;//-- regresa un verdadero debido a que si se pudo completar la operacion
                }
            }
            return false;
        }
    }
}
