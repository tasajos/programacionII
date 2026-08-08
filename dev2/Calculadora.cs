using System;
using System.Collections.Generic;
using System.Text;

namespace dev2
{
    public class Calculadora
    {

        public static void  Saludar()
        {
           Console.WriteLine("Buenos Dias");

        }

        public static double Suma( double a , double b)
        {
            return (a+b);

        }

        public static double Resta(double a, double b)
        {
            return (a - b);

        }

        public static double Multiplicacion(double a, double b)
        {
            return (a * b);

        }

        public static double Division(double a, double b)
        {
            return (a / b);

        }

    }
}
