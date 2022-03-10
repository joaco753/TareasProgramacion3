using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion3eje1
{
    class Program
    {
        static void Main(string[] args)
        {
            ecucacions();
        }

        public static void ecucacions()
        {
            float num1;
            float num2;

            try
            {
                Console.WriteLine("ingrese el primer numero");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese el segundo numero");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"estos fueron los resultados para {num1} y {num2}");
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                if(num1 != 0 && num2 != 0)
                {
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("no se puede dividir por 0");
                }
                Console.ReadKey();
            }
            catch(FormatException)
            {
                Console.WriteLine("solo se permiten numeros, vuelva a intentarlo");
                Console.ReadKey();
                Console.Clear();
                ecucacions();
            }
        }
    }
}
