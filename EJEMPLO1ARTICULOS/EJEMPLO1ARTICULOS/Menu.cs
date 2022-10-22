using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO1ARTICULOS
{
   static class Menu
    {
      private static int opcion = 0;

       
        public static void principal()
        {
            Articulos producto = new Articulos();

            do
            {
                Console.WriteLine("1- Agregar Articulos");
                Console.WriteLine("2- Consultar Articulos");
                Console.WriteLine("3- Imprimir");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: producto.AgregarArticulos(); break;
                    case 2: producto.ConsultarArticulos(); break;
                    case 3: producto.Imprimir(); break;
                    default:
                        break;
                }
            } while (opcion != 4);
        }



    }
}
