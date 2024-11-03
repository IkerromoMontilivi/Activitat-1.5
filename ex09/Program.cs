namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, cont, divisor, rdivisio;

            Console.Write("Escriu un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            cont = 0;
            divisor = 10;
            rdivisio = -1;

            while (rdivisio != 0)
            {
                rdivisio = numero / divisor;
                cont++;
                divisor = divisor * 10;
            }

            Console.WriteLine($"El numero té {cont} xifres");
            //La condicio es que al fer una divisio entera del numero entre 10 elevat a la n doni 0
        }
    }
}
