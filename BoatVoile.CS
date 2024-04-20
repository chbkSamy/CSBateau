public class BoatVoile : Boat
{
    public BoatVoile(string modele, string marque, int place) : base(modele, marque, place) { }

    public override void Inventaire()
    {
        base.InvList.Enqueue(new Inv("Voile de rechange"));
        base.InvList.Enqueue(new Inv("corde"));
        base.InvList.Enqueue(new Inv(" extincteurs"));
        base.InvList.Enqueue(new Inv(" bouées de sauvetage"));
        base.InvList.Enqueue(new Inv(" gilets de sauvetage"));
    }
}
