using System;

namespace Esercizio_giorno_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome");
            string cognome = Console.ReadLine();
            Console.WriteLine("Vuoi aprire un conto? y/n");
            string account = Console.ReadLine();

            int opzione; // opzione per selezionare la scelta
            decimal versa;
            decimal preleva;
            string selezione;

            while (account != "y" && account != "n") //controllo la scelta dell'utente
            {
                Console.WriteLine("Selezione errata, riprova\n");
                Console.WriteLine("Vuoi aprire un conto? y/n");
                account = Console.ReadLine();
            }
            if (account == "y") // una volta qui il valore della scelta è certamente o y oppure n quindi condiziono la scelta
            {

                // qui ha scelto di aprire il conto
                ContoCorrente conto = new ContoCorrente(nome, cognome);
                Console.WriteLine("La ringraziamo per la fiducia abbiamo aperto il suo nuovo conto\n");
                Console.WriteLine("Per poterlo attivare bisogna versare almeno 1000 Euro, gradisce procedere? y/n \n");
                account = Console.ReadLine();

                while (account != "y" && account != "n")
                {
                    Console.WriteLine("ci dispiace la sua scelta non è valida\n Prego riprovare: y/n\n");
                    account = Console.ReadLine();
                }
                if (account == "y")
                { // ramo in cui accetta di versare
                    Console.WriteLine("Quanto gradisce versare?\t ATTENZIONE: valore minimo 1000Euro");
                    decimal versamento = Convert.ToDecimal(Console.ReadLine());
                    while (versamento < 1000 || !(versamento is decimal))
                    {
                        Console.WriteLine("Valore Errato controllare nuovamente selezione, prego reinserire valore");
                        versamento = Convert.ToDecimal(Console.ReadLine());
                    }
                    conto.ApriConto(versamento);
                    Console.WriteLine(conto.Saldo());


                    do
                    {
                        Console.WriteLine("Selezionare un'opzione dal Menù numerato:\n");
                        Console.WriteLine("1. Versamento");
                        Console.WriteLine("2. Prelievo");
                        Console.WriteLine("3. Saldo");
                        Console.WriteLine("4. Esci");
                        opzione = Convert.ToInt32(Console.ReadLine());
                        while (opzione != 1 && opzione != 2 && opzione != 3 && opzione != 4)
                        {
                            Console.WriteLine("Valore non valido, prego reinserire:\n");
                            opzione = Convert.ToInt32(Console.ReadLine());

                        }
                        switch (opzione)
                        {
                            case 1:
                                Console.WriteLine("Quanto gradisci versare?\n");
                                versa = Convert.ToDecimal(Console.ReadLine());
                                conto.Versamento(versa);
                                Console.WriteLine(conto.Saldo());
                                break;

                            case 2:
                                Console.WriteLine("Quanto gradisci prelevare?\n");
                                preleva = Convert.ToDecimal(Console.ReadLine());
                                conto.Prelevamento(preleva);
                                Console.WriteLine(conto.Saldo());
                                break;

                            case 3:
                                Console.WriteLine("Saldo contabile ad Oggi\n");
                                Console.WriteLine(conto.Saldo());
                                break;

                            default:
                                Environment.Exit(0);
                                break;
                        }
                        Console.WriteLine("Gradisci fare un'altra operazione? y/n");
                        selezione = Console.ReadLine();
                    } while (selezione == "y");

                }
                else
                { // non vuole attivare quindi versare almeno 1000 euro
                    Console.WriteLine("Ci dispiace per la scelta, ma non potrà usufruire del suo conto se non lo attiva previo Versamento\n");
                    Console.WriteLine("Le auguriamo una buona giornata");
                    Console.ReadKey();

                    Environment.Exit(0);
                }

            }
            else
            {

                //qui ha declinato 
                Console.WriteLine("Le auguriamo una buona giornata");
                Console.ReadKey();

                Environment.Exit(0);
            }



            Console.ReadKey();
        }
    }
}
