using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4Parte3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Numeros pares de 1 al 50
             * Objetivo: Escribe un programa que imprima todos los numeros
             * pares del 1 al 50. Utiliza un bucle for para iterar a traves 
             * de los numeros y una estructura if para verificar si el numero 
             * es par.
            */
            /*
                for (int i = 1; i <= 50; i++ )
                {
                    if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                }
                Console.ReadLine();
            */
            /*
             * 2. Suma de los numeros del 1 al 100
             * Consigna: Escribe un programa que calcule la suma de los numeros
             * de los numeros del 1 al 100. Usa un bucle for para sumar los numeros 
             * y luego imprime el resultado en la consola.
            */
            /*
            int sumaNumeros = 0;
            for (int i = 1; i <=100; i++)
                {
                    sumaNumeros = sumaNumeros + i;
                }
            Console.WriteLine(sumaNumeros);
            Console.ReadLine();
            */
            /*
             * 3. Tabla de multiplicar de un numero
             * Consigna: Escribe un programa que imprima la tabla de multiplicar 
             * de un numero especifico(Por ejemplo: 7). Usa un bucle for para generar
             * los valores y muestra el resultado en la consola.
            */
            /*
            int numero, tablaMultiplicar;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++ )
            {
                tablaMultiplicar = numero * i;
                Console.WriteLine(tablaMultiplicar);
            }
            Console.ReadLine();
            */
            /*
             * 4. Factorial de un numero 
             * Consigna: Escribe un programa que calcule el factorial de un
             * numero dado. Use el bucle for para multiplicar los numeros y una
             * estructura if para manejar entradas no validas (como numeros negativos)
            */
            int numero;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            for (int i = numero ; i > 0; i-- )
            {
                factorial = 
            }
        }
    }
}
