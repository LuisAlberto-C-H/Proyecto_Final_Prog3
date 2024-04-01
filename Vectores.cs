namespace practico{

    public class Vectores{

        // --------------------------------------------
        public static void ejercicio1()
        {
            Console.WriteLine("V.1.  Ingrese los elementos del vector separados por coma:");
            string input = Console.ReadLine()!;
            string[] strNumbers = input.Split(',');
            int[] vector = new int[strNumbers.Length];

            for (int i = 0; i < strNumbers.Length; i++)
            {
                vector[i] = int.Parse(strNumbers[i]);
            }

            int count = 0;

            foreach (int num in vector)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Resultado, la cantidad de números pares en el vector es  : " + count);
            Console.WriteLine();
        }
        // ---------------------------------------------
    }
}


