using System;
using System.Collections.Generic;

namespace CourseContract.Entities
{
    class Contract
    {
        //Atributos
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; }


        //Construtor
        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }


        //Metodo para adicionar elementos na lista
        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
