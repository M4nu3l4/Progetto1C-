
using System.Globalization;

namespace ProgettoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome del contribuente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il cognome del contribuente:");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci la data di nascita (formato dd/MM/yyyy):");
            DateTime dataNascita;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascita))
            {
                Console.WriteLine("Formato data non valido. Riprova con il formato dd/MM/yyyy:");
            }


            Console.WriteLine("Inserisci il codice fiscale del contribuente:");
            string codiceFiscale = Console.ReadLine();

            Console.WriteLine("Inserisci il sesso del contribuente (M/F):");
            string sesso = Console.ReadLine();

            Console.WriteLine("Inserisci il comune di residenza:");
            string comuneResidenza = Console.ReadLine();

            Console.WriteLine("Inserisci il reddito annuo dichiarato:");
            double redditoAnnuale = double.Parse(Console.ReadLine());

            Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

            contribuente.StampaRiepilogo();
        }
    }
}
