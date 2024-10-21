using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa la cantidad de operaciones que desea realizar: ");
        int cantidad = int.Parse(Console.ReadLine());
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingresa una opcion de la calculadora:\n1.Suma\n2.Resta\n3.Multiplicacion\n4.Division\n");
            int opcion = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el primer numero número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el primer numero número: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = 0;
            if (opcion == 1)
            {
                resultado = numero1+numero2;
                Console.WriteLine($"El resultado de la suma de {numero1} + {numero2} es {resultado}");
            }
            else if (opcion == 2)
            {
                resultado = numero1-numero2;
                Console.WriteLine($"El resultado de la resta de {numero1} - {numero2} es {resultado}");
            }
            else if (opcion == 3)
            {
                resultado = numero1*numero2;
                Console.WriteLine($"El resultado de la multiplicacion de {numero1} * {numero2} es {resultado}");
            }
            else if (opcion == 4)
            {
                if (numero2 != 0)
                {
                    resultado = numero1/numero2;
                    Console.WriteLine($"El resultado de la division de {numero1} / {numero2} es {resultado}");
                }
                else
                {
                    Console.WriteLine("El numero a dividir debe ser diferente de 0");   
                }
            }
            else
            {
                Console.WriteLine("Debe seleccionar un valor asociado a las opciones disponibles");
            }
        }
    }
}