using System;
using System.Collection.Generic;
using System.Runtime.CompilerServices;

public class Temperatura
{
    private static int[,] temperaturas = new[5,7];
    private static List<double> promedioSemanal = new List<double>();
    private static List<int> temperaturasAltas = new List<int>();

    public static void Main()
    {
        CargarTemperaturas();
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Ver temperatura del dia:");
            Console.WriteLine("2.Calcular promedio de las temperaturas semanales");
            Console.WriteLine("3.Encontrar y ver temperaturas por encima de los 20°c");
            Console.WriteLine("4.Ver temperatura promedio mensual");
            Console.WriteLine("5.Ver temperatura mas baja");
            Console.WriteLine("6.Ver temperatura mas alta");
            Console.WriteLine("7.Ver pronostico de los siguientes 5 dias al mes");
            Console.WriteLine("8.Salir");
            Console.WriteLine("Seleccione una opcion:");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    VerTemperaturaDelDia();
                    break;
                case "2":
                    CalcularPromedioSemanal();
                    break;
                case "3":
                    BuscarTemperaturasAltas();
                    break;
                case "4":
                    VerPromedioMensual();
                    break;
                case "5":
                    VerTemperaturaMasBaja();
                    break;
                case "6":
                    VerTemperaturaMasAlta();
                    break;
                case "7":
                    VerPronosticoPosteriorAlMes();
                    break;
                case "8":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opcion no valida, introduzca una correcta.");
                    break;

            }
        }
    }
    private static void CargarTemperaturas()
    {
        Console.WriteLine("ingrese las temperaturas del mes:");
        int contador = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (contador < 31)
                {
                    Console.WriteLine($"Dia{contador + 1}:");
                    temperaturas[i, j] = Convert.ToInt32(Console.ReadLine());
                    contador++;
                }
            }
        }
    }
    private static void VerTemperaturaDelDia()
    {
        Console.WriteLine("ingrese el dia(1-31)");
        int dia = Convert.ToInt32(Console.ReadLine()) - 1;

        if (dia >= 0 && dia < 31)
        {
            int semana = dia / 7;
            int diaDeLaSemana = dia % 7;
            int temp = temperaturas[semana, diaDeLaSemana];

            Console.WriteLine($"Temperatura del dia {dia + 1} : {temp}");

            if (temp < 0)
                Console.WriteLine("hace frio loco");
            else if (temp >= 0 && temp <= 20)
                Console.WriteLine("el tiempo estuvo fresco");
            else
                Console.WriteLine("hizo calor");
        }
        else
        {
            Console.WriteLine("dia no valido");

        }
    }
    private static void CalcularPromedioSemanal()
    {
           promedioSemanal.Clear();
        for (int i = 0; i < 5; i++)
        {
            int suma = 0;
            int diasEnSemana = 0;

            for int j = 0; j < 7; j++)
            {
                if (i * 7 + j < 31)
                {
                    suma += temperaturas[i, j];
                    diasEnSemana++;
                }
            }
            double promedio = diasEnSemana > 0 ? (double)suma / diasEnSemana : 0;
            promedioSemanal.Add(promedio);
            Console.WriteLine($"Promedio de la semana {i+1}:{promedio:F2}"
        }
    }
    private static void BuscarTemperaturasAltas()
    {
        temperaturasAltas.Clear();
        for(int i = 0;i < 5;i++)
        {
            for (int j = 0;j < 7; j++)
            {
                if(i * 7 + i < 31 && temperaturas[i,j]>20)
                {
                temperaturasAltas.Add(temperaturas[i, j]);
                }
            }
        }
        Console.WriteLine("temperatura mayor a 20°c");
        foreach(var temp in temperaturasAltas)
        {
            Console.WriteLine(temp + " ");
        }
        Console.WriteLine();
    }
    private static void VerPromedioMensual()
    {
        double suma = 0;
        int totalDias = 0;
        for(int i = 0; i < 5;i++)
        {
            for(int j = 0; j < 7; j++)
            {
                if (i * 7 + i < 31)
                {
                    suma += temperaturas[i, j];
                    totalDias++;
                }
            }
        }
        double promedio = totalDias > 0 ? suma / totalDias : 0;
        Console.WriteLine($"la temperatura mensual es {promedio:F2}");
    }

}