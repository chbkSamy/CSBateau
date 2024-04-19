public class BoatVoile : Boat
{
   public override void Inventaire(){
    base.InvList.Enqueue("Voile de rechange");
    base.InvList.Enqueue("corde");
   }
}
