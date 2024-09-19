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
            Console.WriteLine("Introdueix la nota " + (i+1) + ": ");
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
