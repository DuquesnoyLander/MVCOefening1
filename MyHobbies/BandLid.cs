namespace MyHobbies
{
    public enum Geslacht
    {
        Man,
        Vrouw
    }

    public class BandLid
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Geslacht Geslacht { get; set; }
        public bool Levend { get; set; }
    }
}