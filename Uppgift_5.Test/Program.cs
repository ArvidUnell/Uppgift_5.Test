using System;
namespace Uppgift_5_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namnArr = new string[5];
            byte[] åldrar = new byte[namnArr.Length];

            for (int i = 0; i < namnArr.Length; i++)
            {
                Console.WriteLine("Skriv in ett namn på en klasskompis");
                namnArr[i] = Console.ReadLine();

                Console.WriteLine($"Skriv in {namnArr[i]}s ålder");
                while (true)
                {
                    try
                    {
                        åldrar[i] = byte.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Det är inte en giltig ålder. Försök igen");
                    }
                }
            }

            short ålderSumma = 0;

            foreach (byte ålder in åldrar)
            {
                ålderSumma += ålder;
            }

            byte maxÅlder = åldrar.Max();
            byte äldstIndex = (byte)Array.IndexOf(åldrar, maxÅlder);

            Console.WriteLine($"Medelvärdet för åldrarna är {ålderSumma/åldrar.Length}");
            Console.WriteLine($"Den äldsta personen är {namnArr[äldstIndex]} som är {maxÅlder} år gammal.");

            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}