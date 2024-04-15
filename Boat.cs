

public class Boat
{
    public string Modele { get; private set; }
    public string Marque { get; private set; }
    public int Place { get; private set; }

    public void Embarquement()
{
    Console.WriteLine("Combien de personnes voulez-vous embarquer ?");
    int passenger = int.Parse(Console.ReadLine());

    if (passenger == 0)
    {
        Console.WriteLine("Le bateau ne peut pas partir vide !");
    }
    else if (passenger <= Place && passenger > 0)
    {
        Console.WriteLine("Allons-y !");
    }
    else
    {
        Console.WriteLine("Désolé, nous n'avons pas assez de place !");
    }
}


    // Constructeur
    public Boat(string modele, string marque, int place)
    {
        Modele = modele;
        Marque = marque;
        Place = place;
    }
}
