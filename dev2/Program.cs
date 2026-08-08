namespace dev2
{

    public class Program
    {

        static void Main(string[] args)
        {

            string nombre = "Carlos";

            const int trabajo = 2;
            Calculadora.Saludar();
            string apellido = "Azcarraga";
            string cargo = "Coordinador de IA";
            Console.WriteLine(nombre + " tiene " + " " + trabajo + " " + "años en la empresa ");
            Console.WriteLine(nombre + " " + apellido + " El cargo actual es de  " + cargo);

            Console.WriteLine("Ingrese un valor para a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un valor para b");
            double b = double.Parse(Console.ReadLine());
                            
            Console.WriteLine("La suma es " + Calculadora.Suma(a, b));
            Console.WriteLine("La suma es " + Calculadora.Resta(a, b));
            Console.WriteLine("La suma es " + Calculadora.Multiplicacion(a, b)); 
            Console.WriteLine("La suma es " + Calculadora.Division(a, b));

        }
    }
}

/*
*---------   
ESTE ES UN METODO
*
static void Saludar ()
{
    Console.WriteLine("Buenos Dias");
    Console.WriteLine("Materia de Programacion II");
}


/*---------   
ESTA ES UNA FUNCION

static double Sumar( double a , double b)
{
    return a+ b;
}

///EJEMPLOS DE METODOS Y FUNCIONES
///

static double Restar ( double a , double b ) 

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
*/