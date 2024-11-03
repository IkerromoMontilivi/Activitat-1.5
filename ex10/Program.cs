namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultatDau, c1, c6, cont;
            Random random = new Random();
            c1 = 0;
            c6 = 0;
            cont = 0;

            while(c1 != c6 || c1 == 0 || c6 == 0)
            {
                resultatDau = random.Next(1, 7);
                if (resultatDau == 1)
                {
                    c1++;
                }
                    
                else if (resultatDau == 6)
                {
                    c6++;
                }
                cont++;
            }

            Console.WriteLine($"S'ha llençat el dau {cont} vegades");
            Console.WriteLine($"El 6 ha aparegut {c6} vegades");
        }
    }
}
