namespace Ovning_1av4
{
    public class Bok
    {
        public string title;
        public string författare;
        public int årgång;


        public Bok(string titel, string författare, int årgång)
        {
            this.title = titel;
            this.författare = författare;
            this.årgång = årgång;
        }

        public override string ToString()
        {
            return $"Titel: {title}, Författare: {författare}, Årgång: {årgång}";
        }


    }

    

}
