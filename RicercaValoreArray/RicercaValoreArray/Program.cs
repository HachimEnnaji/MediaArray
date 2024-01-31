using System;

namespace RicercaValoreArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2) Scrivere un algoritmo che prenda in input un valore di x nomi (decida il candidato la dimensione dell'array).
             * Dopo aver caricato l'array, specificare un nome da ricercare e
             * stampare se il nome è presente o meno nell'array caricato
             * precedentemente.*/

            //dichiarazione variabili
            int candidati;
            string ricerca;
            int count = 0;


            Console.WriteLine("Quanti candidati ci sono?");
            //controllo sul valore dimensione dell'array
            while (!int.TryParse(Console.ReadLine(), out candidati) || candidati <= 0)
            {
                Console.WriteLine("ERRORE!\tInserisci il numero di candidati, deve essere maggiore di 0");
            }
            string[] array = new string[candidati]; // inizializzo array con dimensione scelta dall'utente

            for (int i = 0; i < candidati; i++) // ciclo e inserisco nome candidati
            {
                Console.WriteLine("Inserisci valore candidato numero: " + i);
                array[i] = Console.ReadLine();
            }

            Console.WriteLine("Selezionare nome candidato che si vuole ricercare?");
            ricerca = Console.ReadLine();

            for (int i = 0; i < candidati; i++) // ciclo e cerco nome candidato
            {
                if (array[i] == ricerca)
                {
                    Console.WriteLine($"Il candidato {ricerca} esiste e si trova in posizione {i + 1}");
                    count++;
                }

            }
            if (count == 0)
            {
                Console.WriteLine($"Il candidato {ricerca} non è presente nella graduatoria");
            }


            Console.ReadKey();
        }
    }
}
