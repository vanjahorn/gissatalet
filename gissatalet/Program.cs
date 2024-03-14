using System.ComponentModel.Design;

namespace gissatalet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Random rand = new Random();
            Console.WriteLine("Gissa vilket nummer jag tänker på!");
            int tal = rand.Next(1, 21);
            string gissning = Console.ReadLine();
            int guessint = int.Parse(gissning);

            for (int i = 0; i < 2 && guessint != tal; i++)
            {
                {

                    if (guessint > tal)
                    {
                        Console.WriteLine("Lägre");
                    }
                    else if (guessint < tal)
                    {
                        Console.WriteLine("Högre!");
                    }
                    else if (guessint == tal)
                    {
                        Console.WriteLine("Du gissade rätt!");
                    }
                    gissning = Console.ReadLine();
                    guessint = int.Parse(gissning);
                }

            }
            if (guessint != tal)
            {
                Console.WriteLine("Du gissade fel! Talet var: " + tal);
            }
            if (guessint == tal)
            {
                Console.WriteLine("Du gissade rätt!");
            }











        }

    }
}
