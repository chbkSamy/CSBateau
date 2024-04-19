public class BoatMoteur : Boat
{
   public override void Inventaire(){
    base.InvList.Enqueue(" piece de rechange");
    base.InvList.Enqueue("essence");
    base.InvList.Enqueue("Boite a outil")
   }
}
