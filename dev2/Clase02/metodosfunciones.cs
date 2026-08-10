using System;
using System.Collections.Generic;
using System.Text;

namespace dev2.Clase02
{
    public class metodosfunciones
    {

        public static void Saludar()
        {

            Console.WriteLine("Bienvenido a la clase nro 2 - Nueva Clase Metodos y Funciones");

        }

        public static void Datos()

        {

            Console.WriteLine("Por favor dime tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido a Clase 02 - Metodos y Funciones " + nombre);
            Console.WriteLine("Dime por favor cuantos años de experiencia tienes en c#");
            int experiencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime un aproximado de tiempo que le dedicas a la programacion");
            double tiempo = double.Parse(Console.ReadLine());
            Console.WriteLine("Muchas gracias " + nombre + " " + "Tu experiencia de " + experiencia + "años" + " " + " el tiempo que le dedicas  " + " " + tiempo + "min " + " " +
                                " sera un pilar fundamental para el desarrollo de la clase");
        }

        public static double Sumar (double a , double b)

        {
            return a + b;

        }

        public static double Resta(double a, double b)

        {
            return a - b;

        }

        public static double Multiplicacion(double a, double b)

        {
            return a * b;

        }

        public static double Dividir(double a, double b)

        {
            return a / b;

        }

    }
}
