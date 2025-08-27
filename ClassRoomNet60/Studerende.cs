public class Studerende
{
    public string Navn {  get; set; }
    public int FødselsMåned { get; set; }
    public int Fødselsdag {  get; set; }

    public Studerende (string navn, int fødselsMåned, int fødselsdag)
    {
        Navn = navn;
        FødselsMåned = fødselsMåned;
        Fødselsdag = fødselsdag;
    }





}