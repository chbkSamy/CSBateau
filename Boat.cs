public class Boat
{
    public string Modele { get; private set; }
    public string Marque { get; private set; }
    public int Place { get; private set; }
    public Queue<Inv> InvList { get; private set; }

    public Boat(string modele, string marque, int place)
    {
        Modele = modele;
        Marque = marque;
        Place = place;
        InvList = new Queue<Inv>();
        Inventaire();
    }

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

    public void AfficherInventaire()
    {
        foreach (var tache in InvList)
        {
           Console.WriteLine($"Est-ce que tu as réaliser la tache suivante : {tache.Question} ? (o : OUI | n : NON)");
            var respone = Console.ReadLine();
            if (respone == "o" || respone == "O")
            {
                tache.isdone = true;
            }
            else {
                break;
            }
        }
    }

    public virtual void Inventaire()
    {
        InvList.Enqueue(new Inv("les extincteurs"));
        InvList.Enqueue(new Inv("les boués de sauvetage"));
        InvList.Enqueue(new Inv("les gilets de sauvetage"));
    }
}
