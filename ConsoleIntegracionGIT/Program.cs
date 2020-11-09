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

            Console.WriteLine("Probando la función");
            int suma = funcionSuma(10, 20);
            Console.WriteLine("Resultado funcion = "+suma);

            Console.ReadKey();
        }

        //Funcion suma
        public static int funcionSuma(int a,int b)
        {
            return (a * 10 + b * 100);
        }
    }
}
