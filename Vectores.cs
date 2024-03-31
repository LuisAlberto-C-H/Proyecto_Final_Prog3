namespace practico{

    public class Vectores{

        // ----------------------------------
        public static void ejercicio2()
        {
            Console.WriteLine("V.2. Ingrese los elementos del vector separados por comas:");
            string input = Console.ReadLine();

            string[] values = input.Split(',');

            int[] vector = new int[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                vector[i] = Convert.ToInt32(values[i]);
            }

            MergeSort(vector, 0, vector.Length - 1);

            Console.WriteLine("El vector ordenado es:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }

        static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; ++i)
            {
                L[i] = arr[left + i];
            }
            for (int j = 0; j < n2; ++j)
            {
                R[j] = arr[middle + 1 + j];
            }

            int i1 = 0, i2 = 0;
            int k = left;
            while (i1 < n1 && i2 < n2)
            {
                if (L[i1] <= R[i2])
                {
                    arr[k] = L[i1];
                    i1++;
                }
                else
                {
                    arr[k] = R[i2];
                    i2++;
                }
                k++;
            }

            while (i1 < n1)
            {
                arr[k] = L[i1];
                i1++;
                k++;
            }

            while (i2 < n2)
            {
                arr[k] = R[i2];
                i2++;
                k++;
            }
        }
        // -----------------------------
        public static void ejercicio3()
        {
            Console.WriteLine("V.3. Ingrese los elementos del vector separados por comas:");
            string input = Console.ReadLine();
            string[] elements = input.Split(',');

            int[] vector = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                if (!int.TryParse(elements[i], out vector[i]))
                {
                    Console.WriteLine("Error: Ingrese solo números enteros separados por comas.");
                    return;
                }
            }

            InsertionSort(vector);
            Console.WriteLine("El vector ordenado es:");

            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

        }
        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        // -------------------------------------
        public static void ejercicio4()
        {
            Console.WriteLine("V.4. Ingrese los elementos del vector separados por comas:");
            string input = Console.ReadLine();

            string[] elements = input.Split(',');

            int[] vector = new int[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                if (!int.TryParse(elements[i], out vector[i]))
                {
                    Console.WriteLine("Error: Ingrese solo números enteros separados por comas.");
                    return;
                }
            }

            Console.WriteLine("Ingrese el número a eliminar:");
            int numeroEliminar;
            if (!int.TryParse(Console.ReadLine(), out numeroEliminar))
            {
                Console.WriteLine("Error: Ingrese un número entero válido.");
                return;
            }

            vector = EliminarNumero(vector, numeroEliminar);

            Console.WriteLine("El vector resultante es:");
            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static int[] EliminarNumero(int[] arr, int numero)
        {
            // Contar cuántos numeros repetidos hay del número en el vector
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == numero)
                {
                    count++;
                }
            }

            // Crear un nuevo vector con el tamaño adecuado
            int newSize = arr.Length - count;
            int[] newArray = new int[newSize];

            // Copiar los elementos del vector original al nuevo vector, omitiendo las ocurrencias del número
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != numero)
                {
                    newArray[index++] = arr[i];
                }
            }
            return newArray;
        }

        // ----------------------------------------------------
        public static void ejercicio5()
        {
            Console.WriteLine("V.5. Ingrese los elementos del vector separados por comas:");
            string input = Console.ReadLine();

            string[] elements = input.Split(',');

            int[] vector = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                if (!int.TryParse(elements[i], out vector[i]))
                {
                    Console.WriteLine("Error: Ingrese solo números enteros separados por comas.");
                    return;
                }
            }

            Console.WriteLine("Ingrese la posición inicial (a) del elemento del vector, del rango a invertir:");
            int a;
            if (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a >= vector.Length)
            {
                Console.WriteLine("Error: Ingrese una posición inicial válida.");
                return;
            }

            Console.WriteLine("Ingrese la posición final (b) del elemento del vector, del rango a invertir: ");
            int b;
            if (!int.TryParse(Console.ReadLine(), out b) || b < 0 || b >= vector.Length || b <= a)
            {
                Console.WriteLine("Error: Ingrese una posición final válida y mayor que la posición inicial.");
                return;
            }

            InvertirRango(vector, a, b);
            Console.WriteLine("El vector resultante es:");

            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void InvertirRango(int[] arr, int a, int b)
        {
            while (a < b)
            {
                int temp = arr[a];
                arr[a] = arr[b];
                arr[b] = temp;
                a++;
                b--;
            }
        }
        // ---------------------------------------------
    }
}


