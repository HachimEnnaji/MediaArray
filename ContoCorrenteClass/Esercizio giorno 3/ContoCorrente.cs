using System;

namespace Esercizio_giorno_3
{
    internal class ContoCorrente
    {

        public string _name;
        public string _surname;
        public decimal _saldo;
        public bool _openedAccount;


        public ContoCorrente(string name, string surname)
        {
            _name = name;
            _surname = surname;
            _saldo = 0;
            _openedAccount = false;
        }

        public void ApriConto(decimal versamentoIniziale)
        {
            if (!_openedAccount && versamentoIniziale >= 1000)
            {
                _openedAccount = true;
                _saldo += versamentoIniziale;
                Console.WriteLine($"Conto aperto con successo per {_name} {_surname}. Saldo iniziale: {_saldo} euro");
            }
            else
            {

                Console.WriteLine("Impossibile aprire il conto. Assicurati di non averlo già aperto, di versare almeno 1000 euro e che il conto non sia stato aperto per questo utente.");
            }
        }

        public void Prelevamento(decimal importo)
        {
            if (_openedAccount && _saldo > importo && importo > 0)
            {
                _saldo -= importo;
                Console.WriteLine($"Hai prelevato:\t ${importo}\n Ora il tuo saldo è di: {_saldo}");
            }
            else
            {
                Console.WriteLine("Mi dispiace ma il tuo saldo è inferiore al tuo prelievo richiesto");
            }
        }
        public void Versamento(decimal importo)
        {
            if (_openedAccount && importo > 0)
            {
                _saldo += importo;
                Console.WriteLine($"Hai versato:\t ${importo}\n Ora il tuo saldo è di: {_saldo}");
            }
            else
            {
                Console.WriteLine("Impossibile effettuare il versamento. Assicurati che il conto sia aperto e l'importo sia positivo.");
            }

        }
        public string Saldo()
        {
            return "Nome: " + _name + "\nCognome: " + _surname + "\nSaldo attuale: " + _saldo;
        }
    }
}

