using System;
using libServices;

namespace appCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float operando1 = 0, operando2 = 0;
            int Option = 0;

            do
            {
                Option = clsMath.menuCalculadora();

                switch (Option)
                {
                    case 1:

                        clsConsola.Escribir("Escriba el sumando 1: ");
                        operando1 = clsConsola.leerFloat();
                        clsConsola.Escribir("Escriba el sumando 2: ");
                        operando2 = clsConsola.leerFloat();
                        clsConsola.Escribir("El resultado es: " + clsMath.Sumar(operando1, operando2) + "\n");
                        clsConsola.WaitKey();
                        Console.Clear();

                        break;

                    case 2:

                        clsConsola.Escribir("Escriba el operando 1: ");
                        operando1 = clsConsola.leerFloat();
                        clsConsola.Escribir("Escriba el operando 2: ");
                        operando2 = clsConsola.leerFloat();
                        clsMath.Restar(operando1, operando2);
                        clsConsola.Escribir("El resultado es: " + clsMath.Restar(operando1, operando2) + "\n");
                        clsConsola.WaitKey();
                        Console.Clear();

                        break;

                    case 3:

                        clsConsola.Escribir("Escriba el factor 1: ");
                        operando1 = clsConsola.leerFloat();
                        clsConsola.Escribir("Escriba el factor 2: ");
                        operando2 = clsConsola.leerFloat();
                        clsConsola.Escribir("El resultado es: " + clsMath.Multiplicar(operando1, operando2) + "\n");
                        clsConsola.WaitKey();
                        Console.Clear();

                        break;

                    case 4:

                        clsConsola.Escribir("Escriba el numerador 1: ");
                        operando1 = clsConsola.leerFloat();
                        clsConsola.Escribir("Escriba el denominador 2: ");
                        operando2 = clsConsola.leerFloat();
                        clsConsola.Escribir("El resultado es: " + clsMath.Dividir(operando1, operando2) + "\n");
                        clsConsola.WaitKey();
                        Console.Clear();

                        break;

                    case 5:

                        clsConsola.Escribir("Saliendo de appCalculadora!");
                        clsConsola.WaitKey();

                        break;

                    default:

                        clsConsola.Escribir("Opcion no valida!");
                        clsConsola.WaitKey();
                        Console.Clear();

                        break;
                }

            } while (Option != 5) ;
        }
    }
}