double temperatura;
string respuesta;

while (true)
{
    // Solicitar al usuario la temperatura
    Console.Write("Introduce la temperatura actual en grados Celsius: ");
    string input = Console.ReadLine();

    // Convierte el input a número
    if (!double.TryParse(input, out temperatura))
    {
        Console.WriteLine("Por favor, introduce una temperatura válida.");
        continue; // Vuelve a empezar el bucle
    }

    // Mostrar el mensaje relacionado a la temperatura
    if (temperatura < 0)
    {
        Console.WriteLine("Hace mucho frío afuera, asegúrate de abrigarte bien.");
    }
    else if (temperatura >= 0 && temperatura <= 20)
    {
        Console.WriteLine("El clima está fresco, una chaqueta ligera sería perfecta.");
    }
    else
    {
        Console.WriteLine("Hace calor afuera, no necesitas una chaqueta.");
    }

    // Preguntar si quiere conocer el pronóstico para los próximos cinco días
    Console.Write("¿Queres saber la temperatura de los siguientes dias?? (sí/no): ");
    respuesta = Console.ReadLine().Trim().ToLower();

    if (respuesta == "si")
    {
        // Generar y mostrar un pronóstico simple
        Console.WriteLine("El pronostico para los siguientes dias es:");
        for (int i = 1; i <= 5; i++)
        {// Generar una temperatura simple entre -10 y 10 grados Celsius
            int forecastTemp = (i * 5) - 10; 
            Console.WriteLine($"Día {i}: {forecastTemp}°C");
        }
    }

    // Preguntar si quiere consultar nuevamente
    Console.Write("¿Queres consultar nuevamente? (sí/no): ");
    respuesta = Console.ReadLine().Trim().ToLower();

    if (respuesta == "no")
    {
        Console.WriteLine("¡Espero haberte servido, hasta luego!");
        break; // Salir
    }
}
    }
}