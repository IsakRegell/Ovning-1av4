namespace Ovning_1av4
{
    public class Bok
    {
        public string titel;
        public string författare;
        public int årgång;


        public Bok(string titel, string författare, int årgång)
        {
            this.titel = titel;
            this.författare = författare;
            this.årgång = årgång;
        }

        public override string ToString()
        {
            return $"Titel: {titel}, Författare: {författare}, Årgång: {årgång}";
        }


        public static void AddNewBook(List<Bok> boklista)
        {
            Console.WriteLine("Skriv boktitlen : ");
            string boktitel = Console.ReadLine();

            Console.WriteLine("Skriv författarens namn : ");
            string bokförfattare = Console.ReadLine();

            Console.WriteLine("Skriv bokens årgång : ");
            int bokårgång = Convert.ToInt32(Console.ReadLine());

            Bok tillagdbok = new Bok(boktitel, bokförfattare, bokårgång);
            boklista.Add(tillagdbok);

            Console.WriteLine($"Du la till --{tillagdbok}-- i listan");

        }

        public static void HittaSpecifikBok(List<Bok> boklista, string sökUppBok)
        {
            bool bokHittad = false;
            foreach (Bok bok in boklista)
            {
                if (bok.författare.ToUpper() == sökUppBok)
                {
                    Console.WriteLine($"Här är {bok.författare} bok som du sökte efter");
                    Console.WriteLine($"Detta är titeln : {bok.titel} Detta är bokens årgång : {bok.årgång}");
                    Console.WriteLine($"Bokens omdöme är 4/5");
                    bokHittad = true;
                    break;
                }


            }
        }

    }

    

}
