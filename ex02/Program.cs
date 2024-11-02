namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int cont;
            string numero;
            StreamReader sr = new StreamReader("C:\\Users\\Iker\\source\\repos\\Activitat 1.5\\ex02\\NUMEROS.TXT");

            //Introduccio de valors
            cont = 0;
            numero = sr.ReadLine();

            //Algorisme / calcul
            while (numero != null)
            {
                cont++;
                numero = sr.ReadLine();
            }
            //Mostrar resultats
            Console.WriteLine($"Hi havien {cont} valors al fitxer");
        }
    }
}

