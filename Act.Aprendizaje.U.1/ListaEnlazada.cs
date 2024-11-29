using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act.Aprendizaje.U._1
{
    internal class ListaEnlazada
    {
        private Nodo cabeza;

        public ListaEnlazada()
        {
            cabeza = null!;
        }

        public void Agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            nuevo.Siguiente = cabeza;
            cabeza = nuevo;
        }

        public System.Collections.Generic.List<int> ObtenerElementos()
        {
            var elementos = new System.Collections.Generic.List<int>();
            Nodo actual = cabeza;
            while (actual != null)
            {
                elementos.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            return elementos;
        }
    }
}
