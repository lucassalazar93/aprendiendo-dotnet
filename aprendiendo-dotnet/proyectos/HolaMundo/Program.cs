using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("¿Como te llamas?");
        string nombre = Console.ReadLine()!;

        Console.WriteLine("¿En que año naciste?");
        int anioNacimiento = Convert.ToInt32(Console.ReadLine()!);
        int edad = DateTime.Now.Year - anioNacimiento;

        int opcion = 0;
        while (opcion != 3)
        {
            Console.WriteLine("\n --- MENÚ PRINCIPAL ---");
            Console.WriteLine("1. Ver tu edad");
            Console.WriteLine("2. Saber cuantos años te faltan para llegar a 100");
            Console.WriteLine("3. salir");

            Console.Write("Elige una opcion (1-3):");
            opcion = Convert.ToInt32(Console.ReadLine()!);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"\n{nombre}, tienes {edad} años.");
                    break;

                case 2:
                    int faltan = 100 - edad;
                    Console.WriteLine($"\n {nombre}, te faltan {faltan} años para cumplir 100");
                    break;

                case 3:
                    Console.WriteLine("\n¡Gracias por usar nuestra app! Hasta luego.");
                    break;

                default:
                    Console.WriteLine("\n❌ opcion no valida. intente de nuevo.");
                    break;
                    
                }               
            }

        }
        

}