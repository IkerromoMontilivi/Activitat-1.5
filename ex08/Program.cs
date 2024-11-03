namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numMajor, numMenor, numero;
            string linea;

            StreamReader sr = new StreamReader("C:\\Users\\Iker\\source\\repos\\Activitat 1.5\\ex04\\NUMEROS.TXT");

            linea = sr.ReadLine();
            numero = Convert.ToInt32(linea);
            numMajor = numero;
            numMenor = numero;

            while (linea != null)
            {       
                if (numero > numMajor)
                    numMajor = numero;
                else if (numero < numMenor)
                    numMenor = numero;

                linea = sr.ReadLine();
                numero = Convert.ToInt32(linea);
            }

            Console.WriteLine($"El valor mes gran es {numMajor} i el mes petit es {numMenor}");
        }
    }
}
