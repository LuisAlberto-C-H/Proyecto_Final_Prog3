namespace practico{

    class Numeros{
    public static void ejercicio1()
    {
        Console.WriteLine("Ingrese un número entero:");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero:");
        }
        int mayorDigito = 0;
        while (numero > 0)
        {
            int digito = numero % 10;
            if (digito > mayorDigito)
            {
                mayorDigito = digito;
            }
            numero /= 10;
        }
        Console.WriteLine("El mayor dígito del número ingresado es: " + mayorDigito);
    }
    public static void ejercicio2()
    {
        Console.WriteLine("Ingrese un número entero:");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero:");
        }
        int suma = 0;
        while (numero > 0)
        {
            int digito = numero % 10;
            if (digito % 2 == 0)
            {
                suma += digito;
            }
            numero /= 10;
        }
        Console.WriteLine("La suma de los dígitos pares del número ingresado es: " + suma);
    }
    public static void ejercicio3()
    {
        Console.WriteLine("Ingrese un número entero:");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero:");
        }
            int mayorDigito = 0;
            int resultado = 0;
            int multiplicador = 1;
        while (numero > 0)
        {
            int digito = numero % 10;
            if (digito > mayorDigito)
            {
                mayorDigito = digito;
            }
            numero /= 10;
        }
        numero = resultado;
        while (numero > 0)
        {
            int digito = numero % 10;
            if (digito != mayorDigito)
            {
                resultado += digito * multiplicador;
                multiplicador *= 10;
            }
            numero /= 10;
        }
        resultado += mayorDigito * multiplicador;
        Console.WriteLine("Número con el mayor dígito movido al final: " + resultado);
    }
    public static void ejercicio4()
    {
        Console.WriteLine("Ingrese un número entero:");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero:");
        }
            bool ordenado = EstaOrdenado(numero);
            Console.WriteLine("¿El número tiene sus dígitos ordenados?: " + ordenado);
    }
    private static bool EstaOrdenado(int numero)
    {
        int digitoAnterior = numero % 10;
        numero /= 10;
        while (numero > 0)
        {
            int digitoActual = numero % 10;
            if (digitoActual > digitoAnterior)
            {
                return false;
            }
            digitoAnterior = digitoActual;
            numero /= 10;
        }
        return true;
    }
    public static void ejercicio5()
    {
        Console.WriteLine("Ingrese un número entero:");
        string input = Console.ReadLine()!;
            
        int cantidadImparesAntesDePar = ContarImparesAntesDePar(input);
        Console.WriteLine("La cantidad de dígitos impares antes del primer dígito par es: " + cantidadImparesAntesDePar);
    }
    private static int ContarImparesAntesDePar(string numero)
    {
        bool encontradoPar = false;
        int cantidadImpares = 0;
        foreach (char digitoChar in numero)
        {
            int digito = int.Parse(digitoChar.ToString());
            if (digito % 2 != 0 && !encontradoPar)
            {
                cantidadImpares++;
            }
            else if (digito % 2 == 0)
            {
                encontradoPar = true;
            }
        }
        return cantidadImpares;
    }
    }
}