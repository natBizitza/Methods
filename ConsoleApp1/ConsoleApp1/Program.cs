﻿using System;
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

*/      // Crea una aplicación que nos calcule el área de un circulo, cuadrado o triangulo. 
        //Pediremos que figura queremos calcular su área y según lo introducido pedirá los valores necesarios para calcular el área.
        //Crea un método por cada figura para calcular cada área, este devolverá un número real. Muestra el resultado por pantalla

            /*       Console.WriteLine("An area of which figure would you like to calculate?");
                   string figure;
                       double baseOf, height, radius, side;
                   figure = Console.ReadLine();
                   const double PI = 3.14;


                   if (figure.ToLower()=="triangle")
                       {
                           Console.WriteLine("Type a base in cm");
                           baseOf = Convert.ToDouble(Console.ReadLine());

                           Console.WriteLine("Type a height in cm");
                           height = Convert.ToDouble(Console.ReadLine());

                           TriangleArea(baseOf, height);
                       }
                       else if (figure.ToLower() == "circle")
                       {
                           Console.WriteLine("Type a radius in cm");
                           radius = Convert.ToDouble(Console.ReadLine());

                           CircleArea(radius, PI);
                       }
                       else
                       {
                           Console.WriteLine("Type a side in cm");
                           side = Convert.ToDouble(Console.ReadLine());

                           SquareArea(side);
                       }

                   Console.ReadLine();
                   }

                   public static double TriangleArea (double baseOf, double height)
                   {
                       double area1 = (baseOf*height)/ 2;
                       Console.WriteLine(area1);

                       return area1;
                   }

                   public static double SquareArea(double side)
                   {
                       double area2 = side * side;
                       Console.WriteLine(area2);
                       return area2;
                   }

                   public static double CircleArea(double radius, double PI)
                   {
                       double area3 = Math.Pow(radius , 2) * PI;
                       Console.WriteLine(area3);

                       return area3;
                   }


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
                //Llámala desde el programa principal dos veces, primero con 5 y después con 3.

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

            // Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos. 
            //Asigna el valor de llamar a la función en una variable en el programa principal y muestra el resultado en la pantalla.

                int num1, num2;
                Console.WriteLine("Type a number");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type one more number");
                num2  = Convert.ToInt32(Console.ReadLine());

                SumNumbers(num1, num2);

                Console.ReadLine();
            }
        public static void SumNumbers(int number1, int number2)
            {
                Console.WriteLine(number1 + number2);
            }

                //Usa esos 2 números como parámetros de la función y después asigna el valor que devuelve la función a una tercera variable 
                //en el programa. Finalmente, muestra el valor de la variable en la pantalla.

                int num1, num2;
                Console.WriteLine("Type a number");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type one more number");
                num2 = Convert.ToInt32(Console.ReadLine());

                int sum = SumNumbers(num1, num2);

                Console.WriteLine(sum);

                Console.ReadLine();
            }
            // it won´t work with void
            public static int SumNumbers(int number1, int number2)
            {
                return number1 + number2;
            }
 
            // Crea una aplicación que nos genere una cantidad de números enteros aleatorios que nosotros le pasaremos por teclado. 
            //Crea un método donde pasamos como parámetros entre que números queremos que los genere, 
            //podemos pedirlas por teclado antes de generar los números. Este método devolverá un número entero aleatorio. 
            //Muestra estos números por pantalla.

            int quantityOfNum, num1, num2;
            

            Console.WriteLine("How any numbers you would like to generate randomly?");
            quantityOfNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Between which numbers? Type the first...");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type the second...");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here are your numbers...");

            Randomizer(quantityOfNum, num1, num2);

            Console.ReadLine();
        }
            public static int Randomizer(int quantityOfNum, int num1, int num2)
            {
                Random r = new Random();
                int numbers=0;
                //to automatically generate numbers
                for (var i = 0; i < quantityOfNum; i++)
                {
                numbers = r.Next(num1, num2);
                Console.WriteLine(numbers);
                }
                return numbers;
            }

            // Crea una aplicación que nos calcule el factorial de un número pedido por 
            //teclado, lo realizara mediante un método al que le pasamos el número como parámetro. 
            //Para calcular el factorial, se multiplica los números anteriores hasta llegar a uno. Por ejemplo, 
            //si introducimos un 5, realizara esta operación 5*4*3*2*1=120.

            int num1;
            Console.WriteLine("Type a number to calculate it´s factorial.");
            num1 = Convert.ToInt32(Console.ReadLine());

            Factorial(num1);

            Console.ReadLine();
        }
            public static int Factorial(int num1)
            {
                int factor;
                factor = num1;

                //to  calculate a factorial. We dont do i > =1, cause i=num1-1 and in the case we doit it will show us the final answer twice.
                for (var i = num1 -1; i > 1; i--)
                {
                factor = factor *i;
                Console.WriteLine(factor);
                }
                return factor;
            }
     // Crea una aplicación que nos cuente el número de cifras de un número entero positivo (hay que controlarlo)
       //pedido por teclado. Crea un método que realice esta acción, pasando el número por parámetro, devolverá el 
       //número de cifras.

            string number;
            Console.WriteLine("Type a positive number");
            number = Console.ReadLine();

            ManyNum(number);
        }

        public static void FunctionName(int number)
        {
            Console.WriteLine("hello");
        }
        public static int ManyNum(string num1)
        {
            int nums;
            //string  num2 = num1.ToString();
            nums = num1.Length;

            Console.WriteLine(nums);
            Console.ReadLine();
 
            return nums;
            }
 */
            // Crea un aplicación que nos convierta una cantidad de euros introducida por teclado a otra moneda, estas pueden ser a dolares, 
            // yenes o libras. El método tendrá como parámetros, la cantidad de euros y la moneda a pasar que sera una cadena, este no devolverá 
            //ningún valor, mostrara un mensaje indicando el cambio (void). El cambio de divisas son: 0.86 libras es un 1 €, 1.28611 $ es un 1 €
            //129.852 yenes es un 1 €

        double euros;
        string currency = "";

        Console.WriteLine("How many euros do you have?");
        euros = Convert.ToDouble(Console.ReadLine());

            Converter(euros, currency);
        }
        public static void Converter(double euros, string currency)
        {
            double result = 0;

            Console.WriteLine("Convert to...");
            Console.WriteLine("1 - Dollar");
            Console.WriteLine("2 - Ruble");
            Console.WriteLine("3 - CHF");

            currency = Console.ReadLine();

            //Console.Write(" it´s ");

            switch (currency)
            {
                //currency is a string!!!! WE NEED "" ....
                case "1":
                    double dollar = 1.15;
                    result = dollar * euros;
                    Console.WriteLine(result + " dollars it´s " + euros + " euros");
                    break;
                case "2":
                    double ruble = 76.58;
                    result = ruble * euros;
                    Console.WriteLine(result + " rubles it´s " + euros + " euros");
                    break;
                case "3":
                    double chf = 1.14;
                    result = chf * euros;
                    Console.WriteLine(result + " CHF it´s " + euros + " euros");
                    break;
            }

            Console.ReadLine();
        }
    }
}
