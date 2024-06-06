using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            /*
            int numero;
            int factorial = 1;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            for (int i = 2 ; i <= numero; i++ )
            {
                factorial = factorial * i; 
            }
            Console.WriteLine(factorial);
            Console.ReadLine();
            */
            /*
             * 5. Contar vocales en una cadena 
             * Consigna: Escribe un programa que cuente el numero de vocales 
             * en una cadena de texto ingresada por el usuario. Utiliza un bucle
             * for para iterar a traves de los caracteres y una estructura if para
             * verificar si cada caracter es una vocal.
            */
            /*
            string texto;
            int longitudTexto;
            int cantVocales = 0;
            Console.WriteLine("Ingrese un texto");
            texto = Console.ReadLine();
            longitudTexto = texto.Length;
            for (int i = 0; i < longitudTexto; i++) 
            {
                if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u')
                {
                    cantVocales++;
                }
            }
            Console.WriteLine($"Cantidad de vocales en el texto: {cantVocales}");
            Console.ReadLine();
            */
            /*
             * 6. Numeros primos del 1 al 100 
             * Consigna: Escribe un programa que imprima todos los numeros primos del 
             * 1 al 100. Utiliza un bucle for para iterar a traves de los numeros y otro 
             * bucle for junto con una estructura if para verificar si cada numero es primo 
            */
            /*
            for (int i = 2; i <= 100; i++)
            {
                Boolean divisible = false;
                for (int j = 2 ;j < i; j++)
                {
                    if (i % j == 0) 
                    {
                        divisible = true;
                    }

                }
                if (divisible != true)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            */
            /*
             * 7. Numeros Fibonacci
             * Consigna: Escribe un programa que imprima los primeros 10 
             * numeros de la secuencia de fibonacci. Usa un bucle for para 
             * generar los numeros y muestra cada numero en la consola.
            */
            /*
            int fibonacci;
            int numPosterior = 1;
            int numAnterior = 1;
            Console.WriteLine(numAnterior);
            Console.WriteLine(numPosterior);
            for (int i = 3; i <= 10; i++) 
            {
                fibonacci = numAnterior + numPosterior;
                numAnterior = numPosterior;
                numPosterior = fibonacci;
                Console.WriteLine(fibonacci);
            }
            Console.ReadLine();
            */
            /*
             * 8. Determinar si un anio es bisiesto
             * Consigna: Escribe un programa que determine si un anio
             * dado es bisiesto. Utiliza una estructura if para aplicar 
             * las reglas de los anios bisiestos y muestra el resultado en 
             * la consola.
            */
            /*
            int anio;
            Console.WriteLine("Ingrese un anio");
            anio = int.Parse(Console.ReadLine());
            if (anio % 4 == 0 )
            {
                if (anio % 100 == 0 )
                {
                    if (anio % 400 == 0 ) 
                    {
                        Console.WriteLine("Es bisiesto");
                    }
                    else 
                    {
                        Console.WriteLine("No es bisiesto");
                    }
                }
                else 
                {
                    Console.WriteLine("Es bisiesto"); 
                }
            }
            else 
            {
                Console.WriteLine("No es bisiesto");
            }
            Console.ReadLine();
            */
            /*
             * 9. Invertir una cadena
             * Consigna: Escribe un programa que invierta una cadena de texto
             * ingresada por el usuario. Utiliza un bucle for para iterar a traves
             * de los caracteres de la cadena en orden inverso y luego imprime la 
             * cadena invertida.
            */
            /*
            string texto;
            int longitudTexto,j ;
            Console.WriteLine("Ingrese una palabra");
            texto = Console.ReadLine();
            longitudTexto = texto.Length;
            for (int i = longitudTexto - 1 ; i >= 0; i--)
            {
                Console.Write(texto[i]);
            }
            Console.ReadLine();
            */
            /*
             * 10. Calcular potencia de un numero 
             * Consigna: Escribe un programa que calcule la potencia de un numero (base)
             * elevado a un exponente dado. Usa un bucle for para multiplicar la base por 
             * si misma tantas veces como indique el exponente y muestra el resultado por 
             * consola.
            */
            /*
            int resultado;
            int numero, potencia;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese potencia");
            potencia = int.Parse(Console.ReadLine());
            resultado = numero;
            for (int i = 1; i < potencia; i++)
            {
                resultado = resultado * numero;   
            }
            Console.WriteLine(resultado);
            Console.ReadLine();
            */
        }
    }
}
