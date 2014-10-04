using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, pro, sum;
            Console.WriteLine("calcular la suma y el promedio de 4 numeros :");
            Console.WriteLine("Dijite nota 1");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dijite nota2");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dijite nota 3");
            num3 = double.Parse(Console.ReadLine());
            sum = num1 + num2 + num3;
            Console.WriteLine("la suma es :" + sum);
            pro = sum / 3;
            Console.WriteLine("promedio es :" + pro);
            Console.WriteLine("");
            Console.WriteLine("la suma de las 3 notas es :" + sum + "    y el promedio es :" + pro);
            Console.ReadKey();
        }
    }
}
