using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*           //Diseña un método esPar() que reciba como parámetro un entero y devuelva si ese número es par o no. 
                       //Utilízalo en un programa que lea un número por teclado y determine si es par o no.

                       Console.WriteLine("Type a number");
                       int num = Convert.ToInt32(Console.ReadLine());
                       esPar(num);

                       Console.ReadLine();
                   }

                   //cause the method will not return anything only the answer - void. It´s also possibñe instead of void spreciy the type of data
                   // for ex, bool. Then the method will return the bool.  
                   public static void esPar(int numRecibido)
                   {
                       if(numRecibido % 2 == 0)
                       {
                           Console.WriteLine("The number is even");
                       } else
                       {
                           Console.WriteLine("The number is odd");
                       }

                       //It´s also possibñe instead of void spreciy the type of data. For ex, bool. Then the method will return the bool.  
                       {
                           Console.WriteLine("Escribe un número");
                           int num = Convert.ToInt32(Console.ReadLine());
                           bool parImpar = esPar(num);
                           if (parImpar)
                           {
                               Console.WriteLine("Es par");
                           }
                           else
                           {
                               Console.WriteLine("Es impar");
                           }
                           Console.ReadLine();
                       }
                       public static bool esPar(int numRecibido)
                       {
                           bool par;
                           if (numRecibido % 2 == 0)
                           {
                               par = true;
                           }
                           else
                           {
                               par = false;
                           }
                           return par;
                       }

            // Crea una aplicación que nos calcule el área de un circulo, cuadrado o triangulo. 
            //Pediremos que figura queremos calcular su área y según lo introducido pedirá los valores necesarios para calcular el área. 
            //Crea un método por cada figura para calcular cada área, este devolverá un número real. Muestra el resultado por pantalla

            //    Console.WriteLine("An area of which figure would you like to calculate?");
            //    string figure;
            //    figure = Console.ReadLine();
            //    //float num = Convert.ToInt32(Console.ReadLine());
            //    //esArea(num);

            //    Console.ReadLine();
            //}

            //public static void esArea(figureArea)
            //{
            //    if (numRecibido % 2 == 0)
            //    {
            //        Console.WriteLine("The number is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is odd");
            //    }

            //Escribe una función que escriba “Hola” 3 veces.Llámala desde el programa principal.

            string hola = "";
            writeHola(hola);

            Console.ReadLine();
        }
        public static void writeHola(string r)
        {
            for(int i=1; i<=3; i++)
            {
                Console.Write("Hola ");
            }

            //Escribe una función que escriba “Hola” tantas veces como el número que le pasamos de parámetro. 
*/            //Llámala desde el programa principal dos veces, primero con 5 y después con 3.

            string hola = "";
            int num;
            Console.WriteLine("Type a number");
            num = Convert.ToInt32(Console.ReadLine());

            writeHola(hola, num);

            Console.ReadLine();
        }
        public static void writeHola(string r, int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write("Hola ");
            }


        }

    }
}
