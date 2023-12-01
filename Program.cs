using System.ComponentModel.Design;

namespace ExamenR3_DGGR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            int menu = 0;

            do
            {
                Console.WriteLine("1) Si desea ingresar nuevo carro");
                Console.WriteLine("2) Si desea ver la lista de carros");
                Console.WriteLine("3) si desea buscar un carro por sus datos");
                Console.WriteLine("4) si desea ver la lista de carros ordenada por año");
                Console.WriteLine();
                Console.WriteLine("Elija la opccion");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Incerte la marca");
                        string marca = Console.ReadLine();
                        Console.WriteLine("incerte el modelo");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("ingrece el año");
                        int año = Convert.ToInt32(Console.ReadLine());
                        Carro carro = new Carro { Modelo = modelo, Marca = marca, Año = año };
                        lista.incertar(carro);
                        break;
                    case 2:
                        lista.Mostrarcarros();
                        break;
                    case 3:
                        Console.WriteLine("Incerte la marca");
                        string marcaB = Console.ReadLine();
                        Carro carroB = new Carro {Marca = marcaB};
                        lista.BuscarCarro(marcaB);
                        break;
                }
            }
            while (menu != 4);
        }
    }
}