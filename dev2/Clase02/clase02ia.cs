using System;
using System.Collections.Generic;
using System.Text;

namespace dev2.Clase02
{
    public class clase02ia
    {

        static void Main(string[] args)

        {

            //Console.WriteLine("Bienvenido a Programacion II - Clase02");
            saludar();
            //Introducir Datos
            datos();

            Console.WriteLine("Por favor introduce un valor para comprobar la calculadora en a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor introduce un valor para comprobar la calculadora en b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("La suma es" +" " + Sumar(a, b));
            Console.WriteLine("La resta es" + " " + Restar(a, b));
            Console.WriteLine("La multiplicacion es" + " " + Multiplicar(a, b));
            Console.WriteLine("La division es" + " " + Dividir(a, b));



        }


        /*Metodos
         * 
         * 
         */

        static void saludar()
        {
         Console.WriteLine("Bienvenido a la clase nro 2");
        }

        static void datos()
        {
            Console.WriteLine("Por favor dime tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);
            Console.Write("Dime por favor cuantos años de experiencia tienes en c#");
            int experiencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime un aproximado de tiempo que le dedicas a la programacion");
            double tiempo = double.Parse(Console.ReadLine());
            Console.WriteLine("Muchas gracias " + nombre + " " + "Tu experiencia de " + experiencia + "años" + " " + " el tiempo que le dedicas  " + " " + tiempo + "min " + " " +
                                " sera un pilar fundamental para el desarrollo de la clase");
        }


        /*
         * Funciones
         */
        static double Sumar(double a , double b)
        {
            return  a + b;

        }

        static double Restar(double a, double b)
        {
            return a - b;

        }

        static double Multiplicar(double a, double b)
        {
            return a * b;

        }

        static double Dividir(double a, double b)
        {
            return a / b;

        }



    }
}
