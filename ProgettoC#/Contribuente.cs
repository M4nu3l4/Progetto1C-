using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoC_
{
    class Contribuente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public string Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public double RedditoAnnuale { get; set; }
        public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale,
            string sesso, string comuneResidenza, double redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }
        public double CalcolaImposta()
        {
            double imposta = 0;

            if (RedditoAnnuale <= 15000)
            {
                imposta = RedditoAnnuale * 0.23;
            }
            else if (RedditoAnnuale <= 28000)
            {
                imposta = 3450 + (RedditoAnnuale - 15000) * 0.27;
            }
            else if (RedditoAnnuale <= 55000)
            {
                imposta = 6960 + (RedditoAnnuale - 28000) * 0.38;
            }
            else if (RedditoAnnuale <= 75000)
            {
                imposta = 17220 + (RedditoAnnuale - 55000) * 0.41;
            }
            else
            {
                imposta = 25420 + (RedditoAnnuale - 75000) * 0.43;
            }

            return imposta;
        }
        public void StampaRiepilogo()
        {
            double impostaDaVersare = CalcolaImposta();
            string dataNascitaFormatta = DataNascita.ToString("dd/MM/yyyy");

            Console.WriteLine("==================================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
            Console.WriteLine($"Contribuente: {Nome} {Cognome},");
            Console.WriteLine($"nato il {dataNascitaFormatta} ({Sesso}),");
            Console.WriteLine($"residente in {ComuneResidenza},");
            Console.WriteLine($"codice fiscale: {CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: {RedditoAnnuale:N2}");
            Console.WriteLine($"IMPOSTA DA VERSARE: € {impostaDaVersare:N2}");
        }
    }
}

