public class BoatMoteur : Boat
{
   public override void Inventaire(){
    base.InvList.Enqueue(new Inv(" piece de rechange"));
    base.InvList.Enqueue(new Inv(" essence"));
    base.InvList.Enqueue(new Inv(" Boite a outil"));

   }
}
