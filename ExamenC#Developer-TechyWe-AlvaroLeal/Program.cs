class Program
{
    //EJERCICIO 1


    static void Main(string[] args)
    {

        Console.WriteLine("Ingresa el primer lado del triangulo:");
        int lado1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo lado del triangulo:");
        int lado2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el tercer lado del triangulo:");
        int lado3 = Convert.ToInt32(Console.ReadLine());

        bool esTriangulo = EsTriangulo(lado1, lado2, lado3);

        if (esTriangulo)
        {
            string tipoTriangulo = DeterminarTipo(lado1, lado2, lado3);
            Console.WriteLine($"Es triángulo y es {tipoTriangulo}");
        }
        else
        {
            Console.WriteLine("No es trinángulo");
        }
    }

    static bool EsTriangulo(int lado1, int lado2, int lado3)
    {
        if (lado1 + lado2 > lado3 &&
            lado1 + lado3 > lado2 &&
            lado2 + lado3 > lado1)
        {
            if (lado1 > 0 && lado2 > 0 && lado3 > 0)
                return true;
        }
        return false;
    }
    static string DeterminarTipo(int lado1, int lado2, int lado3)
    {
        if (lado1 == lado2 && lado2 == lado3)
            //Lados iguales
            return "Equilátero";
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            //Dos lados iguales
            return "Isóceles";
        else
            //Todos los lados son diferentes
            return "Escaleno";
    }






    //// EJERCICIO 2



    //static void Main(string[] args)
    //{


    //    string[] var = { "abcd", "efghij", "klmnop", "qrst", "cuenta", "uvwxyz" };
    //    int R = 2;

    //    string cadenaMasLarga = EncontrarCadenaMasLarga(var, R);
    //    Console.WriteLine("La cadena mas larga es: " + cadenaMasLarga);
    //}
    //static string EncontrarCadenaMasLarga(string[] var, int R)
    //{
    //    string cadenaMasLarga = "";

    //    //AQUI ITERO A TRAVES DE LAS CADENAS EN EL ARRAY VAR

    //    for (int i = 0; i <= var.Length - R; i++)
    //    {
    //        string concatenacion = "";
    //        for (int j = i; j < i + R; j++)
    //        {
    //            concatenacion += var[j];
    //        }
    //        if (concatenacion.Length > cadenaMasLarga.Length)
    //            cadenaMasLarga = concatenacion;
    //    }
    //    return cadenaMasLarga;
    //}





    //EJERCICIO 3





    //static void Main(string[] args)
    //{
    //    int[] arrayInicial = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //    int k = 4;

    //    List<int> permJosephus = GetPermJosephus(arrayInicial, k);

    //    Console.WriteLine("Permutacion Josephus: ");
    //    foreach (int elemento in permJosephus)
    //    {
    //        Console.Write(elemento + " ");
    //    }
    //}
    //static List<int> GetPermJosephus(int[] arrayInicial, int k)
    //{
    //    List<int> perm = new List<int>(arrayInicial);
    //    List<int> resultado = new List<int>();

    //    int indiceEliminar = 0;
    //    while (perm.Count > 0)
    //    {
    //        indiceEliminar = (indiceEliminar + k - 1) % perm.Count;
    //        resultado.Add(perm[indiceEliminar]);
    //        perm.RemoveAt(indiceEliminar);
    //    }
    //    return resultado;
    //}



}
