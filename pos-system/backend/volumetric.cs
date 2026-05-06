using System;
using System.Diagnostics.CodeAnalysis;
using System.Net; // Namespace import

namespace HelloWorldApp 
{
    class Program 
    {
        static void Main(string[] args) // Program entry point
        {
                        Console.WriteLine(" Welcome to calculator");
            bool keep = true;
            while (keep)
            {

            Console.WriteLine("Por favor ingrese una operacion a realizar"+" \n"+"#1 Sumas"+"\n"+"#2 Multiplicaciones"
            +"\n"+"#3 Divisiones"+"\n"+"#4 Salir");
            int options = int.Parse(Console.ReadLine());
            switch (options)
            {
                case 1:
                Sumary(); 
                break;

                case 2:
                Multp();
                break;
                
                case 3:
                Div();
                break;
                //Stop program manually
                case 4:
                keep = false;
                break;
            }

            static void Sumary()
            {
                Console.WriteLine("ingrese el primer numero");
                int num1 =int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el segundo numero");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("El resultado es: "+(num1+num2)+"\n");
            }
            static void Multp()
            {
                Console.WriteLine("ingrese el primer numero");
                int num1 =int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el segundo numero");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("El resultado es: "+(num1*num2)+"\n");
            }
            static void Div(){
            Console.WriteLine("ingrese el primer numero");
                float num1 =int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el segundo numero");
                float num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("El resultado es: "+(num1/num2)+"\n");
            }
        }
    }
}
}