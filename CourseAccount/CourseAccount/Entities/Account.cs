using System;
using CourseAccount.Entities.Exceptions;

namespace CourseAccount.Entities
{
    class Account
    {
        //Atributos

        public int Number { get; set; }           
        public string Holder { get; set; }          
        public double Balance { get; set; }         
        public double WithdrawLimit { get; set; }   


        //Construtor

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }


        //Metodos

        public void Deposit(double amount)
        {
            Balance += amount;
        }


        public void Withdraw(double amount)    
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");    
            }
            else if (amount > Balance)
            {
                throw new DomainException("Not enough balance");    
            }

            Balance -= amount;
        }
    }
}
