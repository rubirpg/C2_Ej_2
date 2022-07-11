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
            Console.WriteLine("Introduzca el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); //leemos el primer numero
            Console.WriteLine("Introduzca el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine()); //leemos el segundo numero

            Console.WriteLine(); //Mostramos los numeros seleccionados y su suma
            Console.WriteLine("La suma de los numeros {0} y {1} es: {2}", num1, num2, num1 + num2);

            Console.WriteLine();//Mostramos los numeros seleccionados y su resta
            Console.WriteLine("La resta de los numeros {0} y {1} es: {2}", num1, num2, num1 - num2);

            Console.WriteLine();//Mostramos los numeros seleccionados y su multiplicacion
            Console.WriteLine("La multiplicación de los numeros {0} y {1} es: {2}", num1, num2, num1 * num2);

            Console.WriteLine();//Mostramos los numeros seleccionados y su division
            Console.WriteLine("La division de los numeros {0} y {1} es: {2}", num1, num2, num1 / num2);

            Console.WriteLine();//Mostramos los numeros seleccionados y su modulo
            Console.WriteLine("El modulo (resto resultante de dividir ambos números) de los numeros {0} y {1} es: {2}", num1, num2, num1 % num2);
        }
    }
}