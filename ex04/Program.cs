namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int contp, contn;
            string numero;

            StreamReader sr = new StreamReader("C:\\Users\\Iker\\source\\repos\\Activitat 1.5\\ex04\\NUMEROS.TXT");

            //Introduccio de valors
            contp = 0;
            contn = 0;
            numero = sr.ReadLine();

            //Algorisme / calcul
            while (numero != null)
            {
                if (Convert.ToInt32(numero) > 0)
                {
                    contp++;
                    numero = sr.ReadLine();

                }
                else if (Convert.ToInt32(numero) < 0)
                {
                    contn++;
                    numero = sr.ReadLine();
                }
            }
            //Mostrar resultats
            Console.WriteLine($"Hi han {contp} valors positius al fitxer");
            Console.WriteLine($"Hi han {contn} valors negatius al fitxer");
        }
    }
}