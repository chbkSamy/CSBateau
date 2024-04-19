public class BoatVoile : Boat
{
   public override void Inventaire(){
    base.InvList.Enqueue(new Inv(" Voile de rechange"));
    base.InvList.Enqueue(new Inv(" corde"));

   }
}
