using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un número: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); //leemos y asignamos a num1 el número
            Console.WriteLine("Introduzca un número con decimales largo: ");
            double num2 = Convert.ToDouble(Console.ReadLine()); //leemos y asignamos un número con decimales largo a num2
            Console.WriteLine("Introduzca un caracter: ");
            char caracter = Convert.ToChar(Console.ReadLine()); //leemos un caracter


            //mostramos por pantalla los valores contenidos en las variables
            Console.WriteLine(); 
            Console.WriteLine("El valor del número es: " + num1);
            Console.WriteLine("El valor del número con decimales largo es: " + num2);
            Console.WriteLine("El valor del caracter es: " + caracter);

            //mostramos por pantalla el resultado de sumar num1 y num2
            Console.WriteLine("Las suma del número {0} y el numero {1 } es: {2}.", num1, num2, num1 + num2);

            //mostramos por pantalla el resultado de restar a num2 el valor de num1
            Console.WriteLine("Las resta del número {0} y el número {1} es: {2}.", num2, num1, num2 - num1);

            //mostramos por pantalla el valor de convertir el caractar a un número
            Console.WriteLine("El valor numerico del caracter ({0}) es: {1}.", caracter, Convert.ToInt32(caracter));
        }
    }
}