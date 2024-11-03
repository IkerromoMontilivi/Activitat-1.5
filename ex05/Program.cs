namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            double numero, sumaNumeros, cont, mitjana;

            //Introduccio de valors
            Console.Write("Introduiex un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            sumaNumeros = numero;
            cont = 0;

            //Algorisme / calcul
            while (numero != 0)
            {
                Console.Write("Introdueix un altre valor: ");
                numero = Convert.ToDouble(Console.ReadLine());
                sumaNumeros = sumaNumeros + numero;
                cont++;
            }

            mitjana = sumaNumeros / cont;

            //Mostrar resultats
            Console.WriteLine($"La mitjana es: {mitjana}");
        }
    }
}
