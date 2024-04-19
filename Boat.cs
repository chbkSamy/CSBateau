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
            Embarquement();
        }
        else if (passenger <= Place && passenger > 0)
        {
            Console.WriteLine("Nous allons procéder à l'enregistrement des passagers.");
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            PrezInventaire();
        }
        else
        {
            Console.WriteLine("Désolé, nous n'avons pas assez de place !");
        }
    }

    public void StartEngine()
    {
        Embarquement();
        Console.WriteLine("C'est bon ! Allons-y !");
        Console.WriteLine("TCHHH TCHHH TCHHH !!!");
        Console.WriteLine("TCHHH TCHHH TCHHH !!!");
        Console.WriteLine("TCHHH TCHHH TCHHH !!!");
        Console.WriteLine("J'éspere que votre balade fut agréable, avant de débarquer, nous allons tout d'abord vérifier l'inventaire");
        VerifInventaire();
    }

    public void VerifInventaire()
    {
        foreach (var tache in InvList)
        {
            Console.WriteLine($"Est-ce que l'objet  suivante est présent : {tache.Question} ? (o : OUI | n : NON)");
            var respone = Console.ReadLine();
            if (respone == "o" || respone == "O")
            {
                tache.isdone = true;
            }
            else
            {
                break;
            }
        }
    }

    public void PrezInventaire()
    {
        Console.WriteLine("Avant de demarer, voici l'inventaire des objets se trouvant dans le bateau, ils doivent être présents au retour :");

        foreach (var tache in InvList)
        {
            Console.WriteLine($" {tache.Question}");
        }
    }

    public virtual void Inventaire()
    {
        InvList.Enqueue(new Inv(" extincteurs"));
        InvList.Enqueue(new Inv(" bouées de sauvetage"));
        InvList.Enqueue(new Inv(" gilets de sauvetage"));
    }
}
