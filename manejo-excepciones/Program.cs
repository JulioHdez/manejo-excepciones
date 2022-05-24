using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejo_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            int num;

            try
            {
                //Solicitud de variable
                Console.Write("Ingresa un numero: ");
                num = int.Parse(Console.ReadLine());

                //Impresión en pantalla 
                Console.WriteLine("El resultado de {0} al cuadrado es: {1}" , num , Math.Pow(num,2)); 
            }
            catch (FormatException a)
            {
                Console.WriteLine(a.Message);
                //Console.WriteLine("El formato de datos no corresponde a lo solicitado {0}" , a);
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número ingresado es demasiado grande.");
            }
        }
    }
}
