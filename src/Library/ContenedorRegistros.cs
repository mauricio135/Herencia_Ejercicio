using System.Collections.Generic;

namespace Herencia_Ejercicio.Library
{
    /*
    Se Crea Contenedor para utilizar el Concepto de Tipos Genericos y reutilizar el codigo
    */

    public class ContenedorRegistros<T>
    {
        private IList<T> items = new List<T> ();

        public void Add (T item)
        {
            this.items.Add (item);
        }

        public IEnumerator<T> GetEnumerator ()
        {
            return this.items.GetEnumerator ();
        }
    }
}