namespace Ovning_1av4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bok> boklista = new List<Bok>();
            Bok bok1 = new Bok("Isaks värld", "Isak Regell", 2004);
            Bok bok2 = new Bok("Amandas värld", "Amanda Frykmer", 2005);
            boklista.Add(bok1);
            boklista.Add(bok2);

            bool programIsRuning = true;

            while (programIsRuning)
            {
                Console.WriteLine("Tryck (1) för att lägga till bok");
                Console.WriteLine("Tryck (2) för att kolla boklistan");
                Console.WriteLine("Tryck (3) för att söka efter bok");
                Console.WriteLine("Tryck (4) för att stänga av programet");
                String menyval = Console.ReadLine();


                if (menyval == "1")
                {
                    Bok.AddNewBook(boklista);
                }


                else if (menyval == "2")
                {
                    foreach (Bok Boklista in boklista)
                    {
                        Console.WriteLine(Boklista);

                    }

                }
                else if (menyval == "3")
                {
                    Console.WriteLine("Skriv författarens namn på boken du söker efter : ");
                    String sökUppBok = Console.ReadLine().ToUpper();
                    Bok.HittaSpecifikBok(boklista, sökUppBok);

                }

                else if (menyval == "4")
                {
                    programIsRuning = false;
                }
            }


        }

        
    }

}

