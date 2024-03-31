namespace practico{
    
    class Matrices{

        public static void ejercicio1()
        {
            Console.Write("M.1. Ingrese la cantidad de filas de la matriz: ");
            int filas;
            if (!int.TryParse(Console.ReadLine(), out filas) || filas <= 0)
            {
                Console.WriteLine("La cantidad de filas debe ser un número entero positivo.");
                return;
            }

            Console.Write("M.1. Ingrese la cantidad de columnas de la matriz: ");
            int columnas;
            if (!int.TryParse(Console.ReadLine(), out columnas) || columnas <= 0)
            {
                Console.WriteLine("La cantidad de columnas debe ser un número entero positivo.");
                return;
            }

            int[,] matriz = new int[filas, columnas];
            int contador = filas * (filas + 1) / 2;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas && j <= i; j++)
                {
                    matriz[i, j] = contador--;
                }
            }

            Console.WriteLine();
            Console.WriteLine("El resultado de la matriz triangular inferior es:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        // -----------------------------------------------

        public static void ejercicio2()
        {
            Console.Write("M.2. Ingrese el número de filas de la matriz: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("M.2. Ingrese el número de columnas de la matriz: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            int contador = 1;
            for (int j = 0; j < columnas; j++)
            {
                for (int i = j; i < filas; i++)
                {
                    matriz[i, j] = contador;
                    contador++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("El resultado de la matriz triangular inferior es:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        // -----------------------------------------------

        public static void ejercicio3()
        {
            Console.Write("M.3. Ingrese el número de filas de la matriz: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("M.3. Ingrese el número de columnas de la matriz: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            int contador = 1;
            for (int j = 0; j < columnas; j++)
            {
                // Si la columna es par, llenar de arriba hacia abajo
                if (j % 2 == 0)
                {
                    for (int i = 0; i < filas; i++)
                    {
                        matriz[i, j] = contador;
                        contador++;
                    }
                }
                // Si la columna es impar, llenar de abajo hacia arriba
                else
                {
                    for (int i = filas - 1; i >= 0; i--)
                    {
                        matriz[i, j] = contador;
                        contador++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("El resultado de la matriz serpiente es:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        // ---------------------------------------------------------------

        public static void ejercicio4()
        {
            Console.Write("M.4. Ingrese el número de filas de la matriz: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("M.4. Ingrese el número de columnas de la matriz: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            int fila = filas - 1;
            int columna = columnas / 2;

            // Llenmos la matriz con algoritmo Siames
            for (int i = 1; i <= filas * columnas; i++)
            {
                matriz[fila, columna] = i;

                fila = (fila + 1) % filas;
                columna = (columna + 1) % columnas;

                if (i % columnas == 0)
                {
                    fila = (fila + filas - 2) % filas;
                    columna = (columna + 1) % columnas;
                }
            }

            Console.WriteLine();
            Console.WriteLine("El resultado de la matriz de cuadrado mágico es:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        // ----------------------------------------------------------
        public static void ejercicio5()
        {
            Console.WriteLine("M.5. Ingrese el número de filas de la matriz: ");
            int filas = int.Parse(Console.ReadLine());

            Console.WriteLine("M.5. Ingrese el número de columnas de la matriz: ");
            int columnas = int.Parse(Console.ReadLine());

            // Creamos la matriz
            int[,] matriz = new int[filas, columnas];

            // Llenamos la matriz con los valores decrementales en la intersección
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    matriz[fila, columna] = Math.Max(fila, columna) == 0 ? Math.Max(filas, columnas) : Math.Max(filas, columnas) - Math.Max(fila, columna);
                }
            }
            Console.WriteLine();
            Console.WriteLine("El resultado de la matriz decremental en intersección es:");
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}