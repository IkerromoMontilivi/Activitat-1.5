namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            double sumaNumeros, cont, mitjana;
            string numero;

            StreamReader sr = new StreamReader("C:\\Users\\Iker\\source\\repos\\Activitat 1.5\\ex06\\NUMEROS2.TXT");

            //Introduccio de valors
            numero = sr.ReadLine();
            sumaNumeros = Convert.ToDouble(numero);
            cont = 0;

            //Algorisme / calcul
            while (numero != null)
            {
                sumaNumeros = sumaNumeros + Convert.ToDouble(numero);
                cont++;
                numero = sr.ReadLine();
            }

            mitjana = sumaNumeros / cont;

            //Mostrar resultats
            Console.WriteLine($"La mitjana es: {mitjana}");
        }
    }
}
