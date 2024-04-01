namespace practico{

    class Cadenas{

        public static void ejercicio1()        
        {
            Console.WriteLine("C.1. Ingrese una cadena para contar las palabras:");
            string cadena = Console.ReadLine()!;
            int cantidad = ContarPalabras(cadena);
            Console.WriteLine("La cantidad de palabras en la cadena es: " + cantidad);
            Console.WriteLine();
        }
        static int ContarPalabras(string cadena)
        {
            string[] palabras = cadena.Split(' ');
            return palabras.Length;
        }

        // -------------------------------------------------
        public static void ejercicio2()  
        {
            Console.WriteLine("C.2. Ingrese una cadena para eliminar las vocales:");
            string cadena = Console.ReadLine()!;
            string resultado = EliminarVocales(cadena);
            Console.WriteLine("La cadena sin vocales es: " + resultado);
            Console.WriteLine();
        }
        static string EliminarVocales(string cadena)
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach (char vocal in vocales)
            {
                cadena = cadena.Replace(vocal.ToString(), "");
            }
            return cadena;
        }

        // -------------------------------------------------------
        public static void ejercicio3()
        {
            Console.WriteLine("C.3. Ingrese una cadena para encontrar la palabra más larga:");
            string cadena = Console.ReadLine()!;
            string palabraMasLarga = EncontrarPalabraMasLarga(cadena);
            Console.WriteLine("La palabra más larga en la cadena es: " + palabraMasLarga);
            Console.WriteLine();
        }
        static string EncontrarPalabraMasLarga(string cadena)
        {
            string[] palabras = cadena.Split(' ');
            string palabraMasLarga = "";
            foreach (string palabra in palabras)
            {
                if (palabra.Length > palabraMasLarga.Length)
                {
                    palabraMasLarga = palabra;
                }
            }
            return palabraMasLarga;
        }

        // --------------------------------------------------
        public static void ejercicio4()
        {
            Console.WriteLine("C.4. Ingrese una oración para eliminar las primeras letras de cada palabra:");
            string input = Console.ReadLine()!;
            string[] palabras = input.Split(' ');

            Console.WriteLine("Resultado:");

            foreach (string palabra in palabras)
            {
                if (palabra.Length > 1)
                {
                    Console.Write(palabra.Substring(1) + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        // ------------------------------------------------------------
        public static void ejercicio5()
        {
            Console.WriteLine("C.5. Ingrese una oración para invertir las palabras:");
            string input = Console.ReadLine()!;
            string[] palabras = input.Split(' ');

            Console.WriteLine("Resultado:");

            for (int i = 0; i < palabras.Length; i++)
            {
                char[] palabraArray = palabras[i].ToCharArray();
                Array.Reverse(palabraArray);
                Console.Write(new string(palabraArray) + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        // -----------------------------------------------------------------
    }

}