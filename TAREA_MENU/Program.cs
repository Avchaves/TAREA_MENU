using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_MENU
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            Console.WriteLine("Deseas ingresar al Menú? ");
            string respuesta = Console.ReadLine();
            while (respuesta != "no")
            {
                double num1, num2;
                Console.WriteLine("Ingrese 2 numeros cualquiera para realizar operaciones Matematicas");
                Console.WriteLine("Ingrese el NUM 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el NUM 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("*******Menú de Operaciones Matematicas*******");
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Dividir");
                Console.WriteLine("4. Multiplicar");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Opción: ");

                opcion=int.Parse(Console.ReadLine());
                if (opcion == 1)
                {  
                    Console.WriteLine("La suma de los numeros: " +( num1 + num2));   
                }
                if (opcion == 2)
                {
                    Console.WriteLine("La Resta de los numeros: " + (num1 - num2));
                }
                if (opcion == 3)
                {
                    Console.WriteLine("La Division  de los numeros: " + num1 / num2);
                }
                if (opcion == 4)
                {
                    Console.WriteLine("La Division  de los numeros: " + num1 * num2);
                }
                if (opcion == 5)
                {
                    Console.WriteLine("Te has salido del sistema");
                }
                else Console.WriteLine("Presione enter para volver al Menú");


                Console.ReadLine();
            }       
        }
    }

}
