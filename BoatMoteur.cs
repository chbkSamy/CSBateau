public class BoatMoteur : Boat
{
    public BoatMoteur(string modele, string marque, int place) : base(modele, marque, place) { }

    public override void Inventaire()
    {
        base.InvList.Enqueue(new Inv("pièce de rechange"));
        base.InvList.Enqueue(new Inv("essence"));
        base.InvList.Enqueue(new Inv("Boîte à outils"));
        base.InvList.Enqueue(new Inv(" extincteurs"));
        base.InvList.Enqueue(new Inv(" bouées de sauvetage"));
        base.InvList.Enqueue(new Inv(" gilets de sauvetage"));
    }
}
