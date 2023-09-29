using System;
namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Har du gått ut gymnasiet? (Svara j för ja eller n för nej): ");
            string svar = Console.ReadLine().ToLower();

            switch (svar)
            {
                case "j":
                    Console.Write("Hur gammal är du? ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    if (age < 22)
                    {
                        Console.WriteLine("Vi vill gärna anställa dig.");
                    }
                    else
                    {
                        Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
                    }
                    break;

                case "n":
                    Console.WriteLine("Du uppfyller inte våra kriterier.");
                    break;

                default:
                    Console.WriteLine("Ogiltigt svar. Vänligen svara j för ja eller n för nej.");
                    break;
            }
        }
    }
}