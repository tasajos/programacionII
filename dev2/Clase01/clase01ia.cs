using System;
using System.Collections.Generic;
using System.Text;

namespace dev2.Clase01
{
    public class clase01ia
    {
         static void Main(string[] args)

        {

            Console.WriteLine("Bienvenido a Programacion II");
            Console.WriteLine("Por favor dime tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);
            Console.Write("Dime por favor cuantos años de experiencia tienes en c#");
            int experiencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime un aproximado de tiempo que le dedicas a la programacion");
            double tiempo = double.Parse(Console.ReadLine());
            Console.WriteLine("Muchas gracias " + nombre + " " + "Tu experiencia de " + experiencia + "años" + " "+" el tiempo que le dedicas  "+ " " + tiempo + "min "+ " " +
                                " sera un pilar fundamental para el desarrollo de la clase");


        }
    }
}
