using System;

namespace Ejercicio4Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Conteo de num positivos, negativos, multiplos de 15 y suma de pares";
            Console.WriteLine("Ingrese 10 numeros.");
            Double cantidad = 0;
            int n;
            Double negativo = 0, positivo = 0, multiplo = 0, par = 0;
            Decimal var1, var2,var3, var4;
            for (n = 1; n <= 10; n = n + 1)
            {
                Console.WriteLine("Ingrese el valor número entero "+n+":");
                cantidad = int.Parse(Console.ReadLine());
                if (cantidad<0)
                {
                    negativo = negativo+1;
                }
                if (cantidad>0)
                {
                    positivo = positivo + 1;
                }
                var1 = Convert.ToDecimal(cantidad);
                var1 = var1 / 15;
                var2 = Math.Truncate(var1);
                if (var1==var2)
                {
                    multiplo = multiplo + 1;
                }
                var3 = Convert.ToDecimal(cantidad);
                var3 = var3 / 2;
                var4 = Math.Truncate(var3);
                if(var3==var4)
                {
                    par = par + 1;
                }
            }
            Console.WriteLine("\nLa cantidad de datos negativos ingresados es de: " + negativo);
            Console.WriteLine("\nLa cantidad de datos positivos ingresados es de: " + positivo);
            Console.WriteLine("\nLa cantidad de multiplos de 15 ingresados es de: "+multiplo);
            Console.WriteLine("\nLa cantidad de numeros par ingresados es de: "+par);
            Console.WriteLine("\n");
            Console.WriteLine("--->Fin del programa");
            Console.ReadKey();
        }
    }
}
