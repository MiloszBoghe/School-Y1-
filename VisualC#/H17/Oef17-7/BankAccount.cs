using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef17_7
{
    public class BankAccount
    {


        public BankAccount(double saldo, string naam, string rekeningNummer)
        {
            Saldo = saldo;
            Naam = naam;
            Rekeningnummer = rekeningNummer;
        }

        public double Saldo { get => Saldo; set => Saldo = value; }
        public string Naam { get; set; }
        public string Rekeningnummer { get; set; }

        public void Deposit(double amount)
        {
            if (amount > 2500)
            {
                throw new InvalidActionException("U mag niet meer dan 2500 euro storten.");
            }
            else if (amount < 0)
            {
                throw new InvalidActionException("");
            }
            else
            {
                Saldo += amount;
            }
        }

        public void Withdrawal(double amount)
        {
            if (amount > Saldo)
            {
                throw new InvalidActionException($"U heeft maar {Saldo} om op te nemen.");
            }
            else
            {
                Saldo -= amount;
            }
        }

    }
}
