namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, numMajor, numMenor;

            Console.Write("Escriu un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            numMajor = numero;
            numMenor = numero;

            while(numero != 0)
            {
                if (numero > numMajor)
                    numMajor = numero;
                else if (numero < numMenor)
                    numMenor = numero;

                Console.Write("Escriu un altre numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"El valor mes gran es {numMajor} i el mes petit es {numMenor}");

        }
    }
}
