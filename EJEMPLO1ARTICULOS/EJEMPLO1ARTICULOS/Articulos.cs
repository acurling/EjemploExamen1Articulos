using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO1ARTICULOS
{
    internal class Articulos
    {


        private int[] Codigo = new int[3];   // atributos de codigo

        private string[] nombre = new string[3]; // atributos de nombre

        private float[] precio = new float[3];

        public byte indice;

        public Articulos()  // constructor
        {
            indice = 0;
            for (int i = 0; i < Codigo.Length; i++)
            {
                Codigo[i] = 0;
                nombre[i] = "";
                precio[i] = 0;

            }
        }


        public void ConsultarArticulos()
        {
            Boolean SiExiste = false;
            Console.WriteLine("Ingrese un codigo de Articulo: ");
            int cod = int.Parse(Console.ReadLine());
            for (int i = 0; i < Codigo.Length; i++)
            {
                if (Codigo[i]==(cod))
                {
                    Console.WriteLine($"El nombre del articulo es: {nombre[i]} y el precio es {precio[i]}");
                    SiExiste = true;
                    break;
                }
            }

            if (!SiExiste) Console.WriteLine("Articulo no existe");
        }

        public void Imprimir()
        {
            for (int i = 0; i < Codigo.Length; i++)
            {
                Console.WriteLine($"Codigo: {Codigo[i]} Nombre: {nombre[i]} Precio: {precio[i]}");
                
            }
        }
        public void AgregarArticulos()
        {
            char respuesta = 'n';
            Console.Clear();
            if (indice < 2)
            {
                do
                {
                    Console.WriteLine("Digite un codigo: ");
                    Codigo[indice] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el nombre: ");
                    nombre[indice] = Console.ReadLine();
                    Console.WriteLine("Digite un Precio: ");
                    precio[indice] = int.Parse(Console.ReadLine());
                    indice++;
                    Console.Clear();
                    Console.WriteLine("****Articulo has sido agregado*****");
                   
                    if (indice == 3)
                    {
                        Console.WriteLine("Arreglo esta lleno");
                        respuesta = 'n';
                    }
                    else
                    {
                        Console.WriteLine("Desea ingresar otro:");
                        respuesta = char.Parse(Console.ReadLine());
                    }
                    switch (respuesta)
                    {
                        case 's':
                            
                            break;
                        case 'n':  break;
                    }

                } while (respuesta != 'n');


            }
            else
            {
                Console.WriteLine("El arreglo esta lleno");

            }
        }
    }

}
