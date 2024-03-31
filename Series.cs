namespace practico{

    class Series{
    public static void ejercicio1()
    {
        Console.WriteLine("Ingrese el valor de 'n' para encontrar el término 'n' de la serie de Fibonacci:");
        byte n;
        while (!byte.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero no negativo:");
        }
        byte resultado = fibo(n);
        Console.WriteLine("El término " + n + " de la serie de Fibonacci es: " + resultado);
    }
    static byte fibo(byte n)
    {
        byte t;
        if (n < 3)
        {
            t = n < 2 ? (byte)0 : (byte)1;
        }
        else
        {
            t = (byte)(fibo((byte)(n - 1)) + fibo((byte)(n - 2)));
        }
        return t;
    }
    public static void ejercicio2()
    {
        Console.WriteLine("Ingrese el valor de 'n' para encontrar el término 'n' de la serie:");
        byte n;
        while (!byte.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero no negativo:");
        }
        int resultado = Serie1(n);
        Console.WriteLine("El término " + n + " de la serie es: " + resultado);
        }
    static int Serie1(byte n)
    {
        int t;
        if (n < 3)
        {
            t = n;
        }
        else
        {
            if (n % 2 == 1)
            {
                t = Serie1((byte)(n - 1)) + 1;
            }
            else
            {
                t = Serie1((byte)(n - 1)) * 2;
            }
        }
        return t;
    }
    public static void ejercicio3()
    {
        Console.WriteLine("Ingrese el valor de 'n' para calcular la suma de los primeros n términos de la serie:");
        byte n;
        while (!byte.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero no negativo:");
        }
        int resultado = SumaSerie(n);
        Console.WriteLine("La suma de los primeros " + n + " términos de la serie es: " + resultado);
    }
    static int SumaSerie(byte n)
    {
        int s;
        if (n < 2)
        {
            s = 0;
        }
        else
        {
            s = SumaSerie((byte)(n - 1)) + (n - 1) * 2;
        }
        return s;
    }
    public static void ejercicio4()
    {
        Console.WriteLine("Ingrese el valor de 'n' para encontrar el término 'n' de la serie:");
        byte n;
        while (!byte.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero no negativo:");
        }
        int resultado = Serie2(n);
        Console.WriteLine("El término " + n + " de la serie es: " + resultado);
    }

    static int Serie2(byte n)
    {
        int t;
        if (n < 2)
        {
            t = n;
        }
        else
        {
            t = Serie2((byte)(n - 1)) * 2 + 1;
        }
        return t;
    }
    public static void ejercicio5()
    {
        Console.WriteLine("Ingrese el valor de 'n' para calcular la suma de los términos pares de la serie:");
        byte n;
        while (!byte.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero no negativo:");
        }
        int s = 0;
        int resultado = SumaSerie2(n, ref s);
        Console.WriteLine("La suma de los términos pares de los primeros " + n + " términos de la serie es: " + s);
    }
    static int SumaSerie2(byte n, ref int s)
    {
        int t;
        if (n < 2)
        {
            t = n;
        }
        else
        {
            if (n % 3 == 0)
            {
                t = SumaSerie2((byte)(n - 1), ref s) + 2;
            }
            else if (n % 3 == 1)
            {
                t = SumaSerie2((byte)(n - 1), ref s) + 1;
            }
            else
            {
                t = SumaSerie2((byte)(n - 1), ref s) * 2;
            }
        }
        if (t % 2 == 0)
        {
            s += t;
        }
        return t;
    }
    
        
    }

}