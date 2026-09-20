using System;
using System.Collections.Generic;
using System.Text;

namespace Event_Example
{
    public class BankAccount // amr kase akta class ase
    {
        public delegate void BalanceHandler(); // kon type ar methord nea amra kaj korbo?
        public event BalanceHandler? MoneyDeposited; // money deposite hola amr ae event use korbo, then je kaj kora lage seta korbo

        public void Deposit() // amr kase akta methord ase 
        {
            Console.WriteLine("Money deposited!"); //  methord  ter kaj korse (Money deposit korse)
            MoneyDeposited?.Invoke(); // money deposit hola amake bolio to, amr kisu koj ase money deposite hola seta korbo ame
        }

        public void Aajira() // amr kase methord ase
        {
            Console.WriteLine("Kola pauruti."); // methord ter kaj korse. 
        }

        public void Amni() // amr kase methord ase
        {
            Console.WriteLine("Aro koto kaj thake oigula."); // methord ter kaj korse. 
        }
    }
}
