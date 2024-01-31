using System;

namespace MediaArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Scrivere un algoritmo che prenda in input:
            //  a) La dimensione di un array
            //    b) In base alla dimensione dell'array, x numeri interi e restituisca:
            //a) La somma di tutti i numeri inseriti all'interno dell'array;
            //b) La media aritmetica di tutti i numeri inseriti all'interno dell'array

            int dimensione;
            int somma = 0;
            decimal media = 0;

            Console.WriteLine("Quanti numeri vuoi inserire?");

            while (!int.TryParse(Console.ReadLine(), out dimensione) || dimensione <= 0)
            {
                Console.WriteLine("ERRORE!\tInserisci quanti numeri vuoi inserie, deve essere maggiore di 0");
            }
            int[] array = new int[dimensione];

            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine($"inserisci valore numero: {i}");
                array[i] = Convert.ToInt32(Console.ReadLine());
                somma += array[i];
                media += array[i];
            }
            Console.WriteLine($"La somma finale dei {dimensione} numeri è {somma} \nLa media invece è: {media / dimensione}");
            Console.ReadKey();
        }
    }
}
