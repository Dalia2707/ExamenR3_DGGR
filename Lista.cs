using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenR3_DGGR
{
    public class Lista
    {
        public Nodo primero;

        public Lista()
        {
            primero = null;
        }

        public void incertar(Carro carro)
        {
            Nodo nodo = new Nodo(carro);
            if (primero == null)
            {
                primero = nodo;
 
            }
            else if(primero != null)
            {

                Nodo actual = primero;
                while (actual != null) {
                    if(actual.GetSiguiente() != null) {
                        actual = actual.GetSiguiente();
                    }
                    else
                    {

                    actual.SetSiguiente(nodo);
                        break;
                    }

                }

                /*Nodo act = primero;
                while (act != null)
                {
                    act = act.GetSiguiente();
                }
                act = nodo;*/
            }
        }

        public bool listavacia()
        {
            if (primero!=null)
            {
                return false;
            }
            return true;
        }

        public void Mostrarcarros()
        {
            Nodo actual = primero;
            if (listavacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                while (actual != null)
                {
                    Console.WriteLine(actual.GetCarro().Marca);

                    if (actual.GetSiguiente() != null)
                    {
                        Console.WriteLine($"La marca del carro es {actual.GetCarro().Marca}, el modelo {actual.GetCarro().Modelo} y su año es {actual.GetCarro().Año}");
                        actual = actual.GetSiguiente();
                        
                    }
                    else
                    {
                        Console.WriteLine($"La marca del carro es {actual.GetCarro().Marca}, el modelo {actual.GetCarro().Modelo} y su año es {actual.GetCarro().Año}");
                        break;

                    }


                }
            }
        }

        public void BuscarCarro(string marca)
        {
            Nodo actual = primero;
            int contador = 0;
            if(listavacia() )
            {
                Console.WriteLine("La lista esta vacia");
            }
            if else
            {
                while( actual != null )
                {
                    if (actual.GetCarro().Marca==marca)
                    {

                        Console.WriteLine($"El carro de la marca {actual.GetCarro().Marca}, modelo {actual.GetCarro().Modelo} y son año {actual.GetCarro().Año} esta en la pocicion {contador + 1}");
                    }
                    contador++;
                    actual= actual.GetSiguiente();
                }
            }
        }
    }
}
