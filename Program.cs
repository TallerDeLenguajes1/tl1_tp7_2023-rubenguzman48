using System;
using EspacioCalculadora;

namespace mainProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            bool continuar = true;

            Console.WriteLine("-----------CALCULADORA----------");

            do
            {
                Console.WriteLine("Ingrese el numero que desea operar: ");
                float num1 = Convert.ToInt32(Console.ReadLine());


                //Aqui agrego la calculadora
                Console.WriteLine("Seleccione una operacion a realizar: ");
                Console.WriteLine("1- Suma");
                Console.WriteLine("2- Resta");
                Console.WriteLine("3- Multiplicacion");
                Console.WriteLine("4- Division");
                Console.WriteLine("5- Salir");
                int operacion = Convert.ToInt32(Console.ReadLine());

                switch (operacion)
                {
                    case 1: 
                    calc.Sumar(num1);
                    Console.WriteLine($"El resultado de sumar {num1} por si mismo da como resultado: {calc.Resultado}");
                    break;

                    case 2:
                    calc.Restar(num1);
                    Console.WriteLine($"El resultado de restar {num1} por si mismo da como resultado: {calc.Resultado}");
                    break;

                    case 3:
                    calc.Multiplicar(num1);
                    Console.WriteLine($"El resultado de multiplicar {num1} por si mismo da como resultado: {calc.Resultado}");
                    break;

                    case 4:
                    calc.Dividir(num1);
                    Console.WriteLine($"El resultado de dividir {num1} por si mismo da como resultado: {calc.Resultado}");
                    break;

                    case 5:
                    continuar = false;
                    break;

                    default:
                    Console.WriteLine("Opcion incorrecta, vuelva a intentar!");
                    break;
                }

                calc.Limpiar();

            } while (continuar == true);


        }
    }
}