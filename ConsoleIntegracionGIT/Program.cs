using System;

namespace ConsoleIntegracionGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Suma de 5 y 10
            Console.WriteLine("La suma de "+ 5+" + "+10+" es igual a: "+ (5+10));
            //Suma de 5 y 10
            Console.WriteLine("La suma de " + 5 + " + " + 10 + " es igual a: " + (5 + 10));
            //Hola Mundo desde PUCESE
            Console.WriteLine("Hola mundo desde PUCESE");
            //Fin de clase
            Console.WriteLine("Se acabó la clase");

            Console.WriteLine("La suma de 10 + 20 es {0}", funcionSuma(10, 20));

            Console.WriteLine("La resta de 15 - 5 es {0}", funcionResta(15, 5));
            Console.ReadKey();
                
        }
        public static int funcionSuma(int a, int b)
        {
            return (a + b);
        }

        public static int funcionResta(int a, int b)
        {
            return (a - b);
        }
    }
}
