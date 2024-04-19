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
        BoatMoteur BV2 = new BoatVoile("VM6", "56a", 12);
        BoatMoteur BV3 = new BoatVoile("KCT", "USMA", 14);
        bateauxVoile.Add(BV1);
        bateauxVoile.Add(BV2);
        bateauxVoile.Add(BV3);

        // Console.WriteLine("Liste des bateaux à voile :");
        // foreach (var bateauVoile in bateauxVoile)
        // {
        //     Console.WriteLine($"Modèle : {bateauVoile.Modele}, Marque : {bateauVoile.Marque}, Places : {bateauVoile.Place}");
        // }

        // Affichage de la liste des bateaux à moteur
        Console.WriteLine("\nListe des bateaux à moteur :");
        foreach (var bateauMoteur in bateauxMoteur)
        {
            Console.WriteLine($"Modèle : {bateauMoteur.Modele}, Marque : {bateauMoteur.Marque}, Places : {bateauMoteur.Place}");
        }




        //  boat.Embarquement();
        // boat.AfficherInventaire();
        // boat.PrezInventaire();
        // boat.StartEngine();
    }
}


