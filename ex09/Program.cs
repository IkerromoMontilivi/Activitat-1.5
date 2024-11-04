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
                cont++;
                divisor = Convert.ToInt32(Math.Pow(10, cont));
                rdivisio = numero / divisor;
            }

            Console.WriteLine($"El numero té {cont} xifres");
            //La condicio es que al fer una divisio entera del numero entre 10 elevat a n doni 0, n siguent el nombre de xifres que te el numero
        }
    }
}
