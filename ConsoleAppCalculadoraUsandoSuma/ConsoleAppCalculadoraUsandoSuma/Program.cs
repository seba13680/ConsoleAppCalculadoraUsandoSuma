using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculadoraUsandoSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            String opcion = "";
            do
            {
                Console.WriteLine("Seleccione una operación :\n1 - Sumar\n2 - Restar\n3 - Multiplicar\n4 - Dividir");

                opcion= Console.ReadLine();

                if (opcion.Equals("1") || opcion.Equals("2") || opcion.Equals("3") || opcion.Equals("4"))
                {
                    Operacion operacion = new Operacion();

                    Console.Write("Ingrese el número 1: ");
                    operacion.Numero1 = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el número 2: ");
                    operacion.Numero2 = int.Parse(Console.ReadLine());

                    if (opcion.Equals("1"))
                    {
                        Console.WriteLine("El resultado es : " + operacion.Sumar());
                    }
                    if (opcion.Equals("2"))
                    {
                        Console.WriteLine("El resultado es : " + operacion.Restar());
                    }
                    if (opcion.Equals("3"))
                    {
                        Console.WriteLine("El resultado es : " + operacion.Multiplicar());
                    }
                    if (opcion.Equals("4"))
                    {
                        Console.WriteLine("El resultado es : " + operacion.Dividir());
                    }
                }
                Console.ReadKey();
            } while (!opcion.Equals("5"));
        }
    }
}
