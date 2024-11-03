using static System.Net.Mime.MediaTypeNames;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int numero, contp, contn;

            //Introduccio de valors
            contp = 0;
            contn = 0;
            Console.Write("Introduiex un numero enter: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //Algorisme / calcul
            while (numero != 0)
            {
                if (numero > 0)
                {
                    contp++;
                    Console.Write("Introdueix un altre valor: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                else if (numero < 0)
                {
                    contn++;
                    Console.Write("Introdueix un altre valor: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Mostrar resultats
            Console.WriteLine($"Has introduit {contp} valors positius");
            Console.WriteLine($"Has introduit {contn} valors negatius");
        }
    }
}
