using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStringApp02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int cantidadNombres = 0;
            StringBuilder namesAndChars = new StringBuilder();
            do
            {
                do
                {
                    Console.Write("Ingrese un nombre:");
                    nombre = Console.ReadLine();
                    if (!ValidarNombre(nombre))
                    {
                        Console.WriteLine("El nombre debe tener al menos 5 caracteres y comenzar con una A");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                PrintNameWithSpaces(nombre);
                
                Console.WriteLine(ContainsChar(nombre) ? "Contiene al menos una letra e" : "No tiene e");
                if (ContainsChar(nombre))
                {
                    PrintWithSpecialCaracter(nombre);
                }

                InvertName(nombre);
                NameAndCharsCont(nombre, ref namesAndChars);
                cantidadNombres++;
            } while (cantidadNombres<5);

            Console.WriteLine(namesAndChars.ToString());
            Console.ReadLine();

        }

        private static bool ValidarNombre(string nombre)
        {
           return nombre.Length>=5 && nombre.StartsWith("A");//que tenga al menos 5 caracteres y comience con A
        }

        private static void NameAndCharsCont(string nombre, ref StringBuilder namesAndChars)
        {
            namesAndChars.AppendLine($"{nombre} - {nombre.Length}");
        }

        private static void InvertName(string nombre)
        {
            StringBuilder nombreInvertido = new StringBuilder();
            for (int i = nombre.Length-1; i >=0; i--)
            {
                nombreInvertido.Append(nombre[i]);
            }
            Console.WriteLine(nombreInvertido);
        }

        private static void PrintWithSpecialCaracter(string nombre)
        {
            Console.WriteLine(nombre.Replace('e', '%'));
        }

        private static bool ContainsChar(string nombre)
        {
            //bool tieneE = false;
            //foreach (var c in nombre)
            //{
            //    if (c=='e')
            //    {
            //        tieneE = true;
            //        break;
            //    }
            //}
            //return tieneE;
            return nombre.Any(c => c == 'e');
        }

        private static void PrintNameWithSpaces(string nombre)
        {
            int cantidadCaracteres = nombre.Length;
            StringBuilder nombreConEspacios = new StringBuilder();
            for (int i = 0; i < cantidadCaracteres-1; i++)
            {
                nombreConEspacios.Append($"{nombre[i]} ");// "A n a l í "
            }
            nombreConEspacios.Append(Char.ToUpper(nombre[cantidadCaracteres-1])); // "A";
            Console.WriteLine(nombreConEspacios.ToString());
        }
    }
}
