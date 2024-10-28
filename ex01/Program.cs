namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int numero, cont;

            //Introduccio de valors
            Console.Write("Introduiex un numero enter: ");
            numero = Convert.ToInt32(Console.ReadLine());
            cont = 1;

            //Algorisme / calcul
            while (numero != 0)
            {
                Console.Write("Introdueix un altre valor: ");
                numero = Convert.ToInt32(Console.ReadLine());
                cont++;
            }
            //Mostrar resultats
            Console.WriteLine($"Has introduit {cont} valors");
        }
    }
}
