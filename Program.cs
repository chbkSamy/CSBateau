internal class Program
{
    private static void Main(string[] args)
    {
        List<BoatVoile> bateauxVoile = new List<BoatVoile>();
        List<BoatMoteur> bateauxMoteur = new List<BoatMoteur>();

        BoatMoteur BM1 = new BoatMoteur("TMAX", "Yamaha", 17);
        BoatMoteur BM2 = new BoatMoteur("CZ2", "Scania", 10);
        BoatMoteur BM3 = new BoatMoteur("urus", "Lemborghni", 8);
        bateauxMoteur.Add(BM1);
        bateauxMoteur.Add(BM2);
        bateauxMoteur.Add(BM3);

        BoatVoile BV1 = new BoatVoile("45", "JSK", 19);
        BoatVoile BV2 = new BoatVoile("VM6", "56a", 12);
        BoatVoile BV3 = new BoatVoile("KCT", "USMA", 14);
        bateauxVoile.Add(BV1);
        bateauxVoile.Add(BV2);
        bateauxVoile.Add(BV3);

        ChoiceBoat(bateauxVoile, bateauxMoteur);
    }

    public static void ChoiceBoat(List<BoatVoile> bateauxVoile, List<BoatMoteur> bateauxMoteur)
    {
        Console.WriteLine("Choisissez votre bateau :");
        Console.WriteLine("1 - Bateau à moteur");
        Console.WriteLine("2 - Bateau à voile");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            ListMoteur(bateauxMoteur);
            StartboatM(bateauxMoteur);
        }
        else if (choice == 2)
        {
            ListVoile(bateauxVoile);
            StartboatV(bateauxVoile);
        }
    }

    public static void ListMoteur(List<BoatMoteur> bateauxMoteur)
    {
        int cpt = 0;
        Console.WriteLine("\nListe des bateaux à moteur :");
        foreach (var bateauMoteur in bateauxMoteur)
        {
            cpt++;
            Console.WriteLine($"{cpt} - Modèle : {bateauMoteur.Modele}, Marque : {bateauMoteur.Marque}, Places : {bateauMoteur.Place}");
        }
    }

    public static void ListVoile(List<BoatVoile> bateauxVoile)
    {
        int cpt = 0;
        Console.WriteLine("\nListe des bateaux à voile :");
        foreach (var bateauVoile in bateauxVoile)
        {
            cpt++;
            Console.WriteLine($"{cpt} - Modèle : {bateauVoile.Modele}, Marque : {bateauVoile.Marque}, Places : {bateauVoile.Place}");
        }
    }

    public static void StartboatV(List<BoatVoile> bateauxVoile)
    {
        Console.WriteLine("Quel bateau voulez-vous ?");
        int respone = Convert.ToInt32(Console.ReadLine());
        if (respone >= 1 && respone <= bateauxVoile.Count)
        {
            bateauxVoile[respone - 1].Embarquement();
        }
        else
        {
            Console.WriteLine("Ce bateau n'existe pas");
            ChoiceBoat(bateauxVoile, null);
        }
    }

    public static void StartboatM(List<BoatMoteur> bateauxMoteur)
    {
        Console.WriteLine("Quel bateau voulez-vous ?");
        int respone = Convert.ToInt32(Console.ReadLine());
        if (respone >= 1 && respone <= bateauxMoteur.Count)
        {
            bateauxMoteur[respone - 1].Embarquement();
        }
        else
        {
            Console.WriteLine("Ce bateau n'existe pas");
            ChoiceBoat(null, bateauxMoteur);
        }
    }
}
