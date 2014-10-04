using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumeroCastellanoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ingresar un numero entre 1 y5 en castellano
             * luego mostrar en formato numerico,  si se ingresa 
             * un valor fuera de dicho rango mostrar un mensaje 
             * indicando tal sitacion*/

            string numero, num;
            Console.WriteLine("programa que pasa de caracter a numerico");
            Console.WriteLine("escriba el numero entre uno y cinco");
            numero = Console.ReadLine();
            num = numero;
            switch (num)
            {
                case "uno":
                    Console.WriteLine("1");
                    break;

                case "dos":
                    Console.WriteLine("2");
                    break;

                case "tres":
                    Console.WriteLine("3");
                    break;

                case "cuatro":
                    Console.WriteLine("4");
                    break;

                case "cinco":
                    Console.WriteLine("5");
                    break;

                default:
                    Console.WriteLine("numero fuera de rango");
                    break;

            }
            Console.ReadKey();
        }
    }
}
