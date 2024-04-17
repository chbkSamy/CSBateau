public class Inv
{
    public string Question { get; private set; }
    public bool isdone { get; set; }

    public Inv(string question)
    {
        Question = question;
        isdone = false;
    }
}
