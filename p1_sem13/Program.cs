using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_sem13
{
    internal class Program
    {
        static int[] surveyData = new int[100];
        static int count = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Encuestas de Calidad");
                Console.WriteLine("================================");
                Console.WriteLine("1: Realizar Encuesta");
                Console.WriteLine("2: Ver datos registrados");
                Console.WriteLine("3: Eliminar un dato");
                Console.WriteLine("4: Ordenar datos de menor a mayor");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        if (count < 100)
                        {
                            Console.Clear();
                            Console.WriteLine("===================================");
                            Console.WriteLine("Nivel de Satisfacción");
                            Console.WriteLine("===================================");
                            Console.WriteLine("¿Qué tan satisfecho está con la");
                            Console.WriteLine("atención de nuestra tienda?");
                            Console.WriteLine("1: Nada satisfecho");
                            Console.WriteLine("2: No muy satisfecho");
                            Console.WriteLine("3: Tolerable");
                            Console.WriteLine("4: Satisfecho");
                            Console.WriteLine("5: Muy satisfecho");
                            Console.WriteLine("===================================");
                            Console.Write("Ingrese una opción: ");
                            surveyData[count++] = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("===================================");
                            Console.WriteLine("Nivel de Satisfacción");
                            Console.WriteLine("===================================\n\n");
                            Console.WriteLine("¡Gracias por participar!\n\n");
                            Console.WriteLine("===================================");
                            Console.WriteLine("Presione una tecla para regresar al menú ...");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Ver datos registrados");
                        Console.WriteLine("===================================");
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("[" + surveyData[i] + "] ");
                            if ((i + 1) % 5 == 0)
                                Console.WriteLine();
                        }
                        Console.WriteLine("\nPresione una tecla para regresar al menú ...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Eliminar un dato");
                        Console.WriteLine("===================================");
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write(i.ToString("D3") + ":[" + surveyData[i] + "]  ");
                            if ((i + 1) % 5 == 0)
                                Console.WriteLine();
                        }
                        Console.WriteLine("\nIngrese la posición a eliminar: ");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        for (int i = pos; i < count - 1; i++)
                            surveyData[i] = surveyData[i + 1];
                        count--;
                        Console.WriteLine("\nPresione una tecla para regresar al menú ...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Array.Sort(surveyData, 0, count);
                        Console.WriteLine("\nPresione una tecla para regresar al menú ...");
                        Console.ReadKey();
                        break;
                    case 5:
                        return;
                }
            }
        }
    }

}

