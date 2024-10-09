namespace Ovning_1av4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bok> boklista = new List<Bok>();
            Bok bok1 = new Bok("Isaks värld", "Isak Regell", 2004);
            Bok bok2 = new Bok("Amandas värld", "Amanda Frykmer", 2005);
            Bok bok3 = new Bok("Jonte värld", "Jonte Frykmer", 1995);
            boklista.Add(bok1);
            boklista.Add(bok2);
            boklista.Add(bok3);



            Console.WriteLine("Tryck (1) för att lägga till bok");
            Console.WriteLine("Tryck (2) för att kolla boklistan");
            Console.WriteLine("Tryck (3) för att söka efter bok");
            String menyval = Console.ReadLine();
            
            if (menyval == "1")
            {
                Console.WriteLine("Skriv boktitlen : ");
                string boktitel = Console.ReadLine();

                Console.WriteLine("Skriv författarens namn : ");
                string bokförfattare = Console.ReadLine();

                Console.WriteLine("Skriv bokens årgång : ");
                int bokårgång = Convert.ToInt32(Console.ReadLine());

                Bok tillagdbok = new Bok(boktitel, bokförfattare, bokårgång);
                boklista.Add(tillagdbok);

                Console.WriteLine($"ny bok {tillagdbok}");
            }
            
            
            if (menyval == "2")
            {
                foreach (Bok Boklista in boklista)
                {
                    Console.WriteLine(Boklista);
                }

            }




        }
    }
}
