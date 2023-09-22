using static System.Console;
using IMDb.Models;

namespace IMDb
{
    public class Program
    {

        static void Main(string[] args)
        {
            Clear();

            WriteLine("\n==*==*== Välj ett alternativ: ==*==*==");
            WriteLine("\n1.Lägg till film");
            WriteLine("2.Lägg till skådespelare");
            WriteLine("3.Lägg till skådespelare till film");
            WriteLine("4.Sök film");

            var val = ReadLine();

            if (string.IsNullOrEmpty(val))
            {
                WriteLine("Inget val angivet. Försök igen.");
                return;
            }


            switch (val)
            {
                case "1":
                    AddFilm();
                    break;

                case "2":
                    AddActor();
                    break;
                case "3":
                    AddActorToFilm();
                    break;
                case "4":
                    SearchFilm();
                    break;
            }

        }

        static void AddFilm()
        {
            Clear();

            WriteLine("\nAnge filmens titel : ");
            var titel = ReadLine();

            WriteLine("\nAnge filmens genre : ");
            var genre = ReadLine();

            WriteLine("\nAnge filmens handling : ");
            var handling = ReadLine();

            WriteLine("\nAnge filmens regissör : ");
            var regissör = ReadLine();

            WriteLine("\nAnge filmens premiärdatum (ÅÅÅÅ-MM-DD): ");
            DateTime prämier;
            while (!DateTime.TryParse(ReadLine(), out prämier))
            {
                WriteLine("Ogiltigt datum. Ange igen i formatet ÅÅÅ-MM-DD : ");
            }

            var film = new Film
            {
                Titel = titel,
                Genre = genre,
                Handling = handling,
                Regissör = regissör,
                Premiär = prämier

            };

            using var context = new IMDbContext();
            context.Filmer.Add(film);
            context.SaveChanges();

            WriteLine("Filmen har lagts till!");

        }

        static void AddActor()
        {
            Clear();

            WriteLine("\nAnge skådespelarens förnamn: ");
            var förnamn = ReadLine();

            WriteLine("\nAnge skådespelarens efternamn: ");
            var efternamn = ReadLine();

            WriteLine("\nAnge skådespelarens födelsedatum (ÅÅÅÅ-MM-DD): ");
            DateTime födelsedatumDate;
            while (!DateTime.TryParse(ReadLine(), out födelsedatumDate))
            {
                WriteLine("Ogiltigt datum. Ange igen i formatet ÅÅÅ-MM-DD : ");
            }


            var ActorActris = new ActorActris
            {
                Förnamn = förnamn,
                Efternamn = efternamn,
                Födelsedatum = födelsedatumDate

            };

            using var context = new IMDbContext();
            context.ActorActris.Add(ActorActris);
            context.SaveChanges();

            WriteLine("Skådespelaren har lagts till!");
        }


        static void AddActorToFilm()
        {

        }

        static void SearchFilm()
        {

        }

    }
}