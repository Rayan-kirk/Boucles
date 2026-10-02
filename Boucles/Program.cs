using System;
using System.Globalization;

class Program
{
    const double TauxTVA = 0.20;

    static void Main()
    {
        double prixHT;

        do
        {
            prixHT = LirePrix();

            if (prixHT != 0)
            {
                double tva = prixHT * TauxTVA;
                Console.WriteLine($"TVA : {tva:F2} €  |  TTC : {prixHT + tva:F2} €\n");
            }
        } while (prixHT != 0);
    }

    static double LirePrix()
    {
        double valeur;
        Console.Write("Prix HT (0 pour quitter) : ");

        while (!double.TryParse(Console.ReadLine().Replace('.', ','),
                                NumberStyles.Any, new CultureInfo("fr-FR"), out valeur))
            Console.Write("Saisie invalide, entrez un nombre : ");

        return valeur;
    }
}