using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_Estructuras_iterativas
{
    internal class Program
    {

        static void ejercicio1()
        {
            Console.WriteLine("Esta aplicación pide dos números y muestra cual es mayor.");
            int num1 = ParseInt("Introduce el primer número: ");
            int num2 = ParseInt("Introduce el segundo número: ");

            int mayor = num1 > num2 ? num1 : num2;
            Console.WriteLine($"El número mayor es {mayor}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }


        static void ejercicio2()
        {
            Console.WriteLine("Este programa calcula el coste de la factura de la luz.");
            int kw = ParseInt("Introduce la cantidad de kilowatios: ");
            float precioKw = kw < 1000 ? 0.14f : kw < 1800 ? 0.12f : 0.8f;
            
            Console.WriteLine($"El precio del Kw es: {precioKw}");
            Console.WriteLine($"El total a pagar es: {kw * precioKw} euros");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static void ejercicio3()
        {
            Console.WriteLine("Este programa indica el estado civil.");
            Console.Write("Introduce la inicial de tu estado civil (C, S, V o D): ");
            string input = Console.ReadLine();
            string estado;

            switch(input)
            {
                case "C":
                case "c":
                    estado = "CASAD@";
                    break;
                case "S":
                case "s":
                    estado = "SOLTER@";
                    break;
                case "V":
                case "v":
                    estado = "VIUD@";
                    break;
                case "D":
                case "d":
                    estado = "DIVORCIAD@";
                    break;
                default:
                    estado = "ENTRADA INCORRECTA";
                    break;
            }

            Console.WriteLine($"Tu estado civil es {estado}");
            
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static void ejercicio4()
        {
            Console.WriteLine("Este programa muestra la tabla de multiplicar de un número.");
            int num = ParseInt("Introduce un número de 1 al 9: ");
            bool isValid = (num > 0 && num < 10);

            if (isValid)
            {
                for(int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num} x {i} = {num * i}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static void ejercicio5()
        {
            Console.WriteLine("Este programa realiza acciones sobre un string");
            
            Console.Write("Introduce una cadena de texto: ");
            string cadena = Console.ReadLine();
            Console.WriteLine($"La longitud del string es: {cadena.Length}");
            Console.WriteLine();

            Console.Write("Introduce una cadena para comprobar si la anterior la contiene: ");
            string subcadena = Console.ReadLine();
            Console.WriteLine($"¿{subcadena} se encuentra dentro de {cadena}?: {cadena.Contains(subcadena)}");
            Console.WriteLine();


            string letra;
            bool isValid;
            do
            {
                Console.Write("¿Qué letra quieres reemplazar?: ");
                letra = Console.ReadLine();
                isValid = cadena.Contains(letra);
                if (!isValid)
                {
                    Console.WriteLine("El string no contiene la letra introducida");
                }
            } while (!isValid);

            Console.Write("¿Por qué letra quieres reemplazarla?: ");
            string nuevaLetra = Console.ReadLine();
            Console.WriteLine(cadena.Replace(letra, nuevaLetra));

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static void ejercicio6()
        {
            Console.WriteLine("Este programa muestra el factorial de un número");

            int number = ParseInt("Introduce un número entero: ");
            int factorial = number;
            for (int i = number - 1; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {number} es {factorial}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static void ejercicio7()
        {
            Console.WriteLine("Este programa crea el abecedario en mayúsculas");
            int caracter = 90;
            while (caracter >= 65)
            {
                Console.Write($"{Convert.ToString((char)caracter)} ");
                caracter--;
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static void ejercicio8()
        {
            Console.WriteLine("Este programa genera un número aleatorio entre 10 y 30");
            Random random = new Random();
            Console.WriteLine($"{random.Next(10, 31)}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static void ejercicio9()
        {
            Console.WriteLine("Este programa crea un array de enteros");
            int cant = ParseInt("Introduce la longitud del array: ");
            int[] array = new int[cant];

            for (int i = 0; i < cant; i++)
            {
                array[i] = ParseInt("Introduce un número: ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                string resul = array[i] % 2 == 0 ? "par" : "impar";
                Console.WriteLine($"{array[i]} es {resul}");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static void ejercicio10()
        {
            Console.WriteLine("Este programa define un array de 10 enteros y los ordena");
            int[] desordenados = new int[10];
            Random random = new Random();

            for (int i = 0; i < desordenados.Length; i++)
            {
                desordenados[i] = random.Next(1, 100);
            }

            Console.Write("Array desordenado: ");
            foreach (int number in desordenados)
            {
                Console.Write($"{number} ");
            }

            Array.Sort(desordenados);
            Console.WriteLine("Array ordenado: ");
            foreach (int number in desordenados)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static void ejercicio11()
        {
            Console.WriteLine("Este programa crea una pila e introduce varios valores enteros por teclado");
            Stack pila = new Stack();

            int valores = ParseInt("¿Cuántos valores quieres introducir?: ");
            for (int i = 0; i < valores; i++)
            {
                pila.Push(ParseInt("Introduce un número entero: "));
            }
            Console.WriteLine();

            Console.WriteLine("Resultado de la pila: ");
            foreach (int elem in pila) {
                Console.WriteLine($"{elem} ");
            }
            Console.WriteLine();

            Console.WriteLine("Extraemos 2 elementos: ");
            for (int i = 0; i < 2; i++)
            {
                int extraido = (int)pila.Pop();
                Console.WriteLine($"{extraido}");
            }
            Console.WriteLine();

            Console.WriteLine("Restantes en la pila: ");
            foreach (int elem in pila)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static int ParseInt(string message)
        {
            int number;
            bool isValid;

            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out number);

                if (!isValid)
                {
                    Console.Write("Entrada no válida. Por favor, introduce un número válido.");
                }
            } while (!isValid);

            return number;
        }

        static float ParseFloat(string message)
        {
            float number;
            bool isValid;

            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                isValid = float.TryParse(input, out number);

                if (!isValid)
                {
                    Console.Write("Entrada no válida. Por favor, introduce un número válido.");
                }
            } while (!isValid);

            return number;
        }

        static void Main(string[] args)
        {
            ejercicio1();
            ejercicio2();
            ejercicio3();
            ejercicio4();
            ejercicio5();
            ejercicio6();
            ejercicio7();
            ejercicio8();
            ejercicio9();
            ejercicio10();
            ejercicio11();

            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
