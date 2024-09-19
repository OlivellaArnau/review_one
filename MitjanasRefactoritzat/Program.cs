using System;

public class Program
{
    public static void Main()
    {
        string ResultMsg = "La mitjana de les tres qualificacions és: ";
        string FirstMsg = "Quantes notes vols introduïr?";
        string ErrorMsg = "Error, introdueix una nota vàlida";
        string Aprovat = "Aprovat";
        string Suspes = "Suspès";
        int numScore;
        float promig;
        Console.WriteLine(FirstMsg);
        numScore = Convert.ToInt32(Console.ReadLine());
        int[] scores = new int[numScore];
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("Introdueix la nota " + (i + 1) + ": ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
            if (scores[i] < 0 || scores[i] > 10)
            {
                Console.WriteLine(ErrorMsg);
                i--;
            }
        }
        promig = Mitjana(scores);
        Console.WriteLine(ResultMsg + promig);

        if (promig >= 5)
        {
            Console.WriteLine(Aprovat);
        }
        else
        {
            Console.WriteLine(Suspes);
        }

        string MsgPostalCity = "Quantes ciutats vols introduïr?";
        int numCity;
        string CityMsg = "Introdueix la ciutat ";
        string PostalMsg = "Introdueix el codi postal de la ciutat ";
        Console.WriteLine(MsgPostalCity);
        numCity = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> ciutats = new Dictionary<string, int>();
        for (int i = 0; i < numCity; i++)
        {
            Console.WriteLine(CityMsg + (i + 1) + ": ");
            string city = Console.ReadLine();
            Console.WriteLine(PostalMsg + (i + 1) + ": ");
            int postal = Convert.ToInt32(Console.ReadLine());
            ciutats.Add(city, postal);
        }
        foreach (var ciutat in ciutats)
        {
            Console.WriteLine("La ciutat " + ciutat.Key + " té el codi postal " + ciutat.Value);
        }
    }
    public static float Mitjana(int[] scores)
    {
        int summ = 0, divider = 0;
        float promig;

        for (int i = 0; i < scores.Length; i++)
        {
            summ += scores[i];
            divider += 1;
        }
        promig = summ / divider;
        return promig;
    }
}
