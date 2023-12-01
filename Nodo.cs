using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenR3_DGGR
{
    public class Nodo
    {
        private Nodo _siguiente;
        private Carro _datos;

        public Nodo(Carro carro)
        {
            _datos= carro;
            _siguiente = null;
        }
        /*public Nodo(Carro carro, Nodo siguiente) { 
            _datos= carro;
            _siguiente = siguiente; 
        }*/
        public Carro GetCarro()
        {
            return _datos;
        }
        public Nodo GetSiguiente()
        {
            return _siguiente;
        }
        public void SetSiguiente(Nodo siguiente)
        {
            _siguiente= siguiente;
        }
    }
}
