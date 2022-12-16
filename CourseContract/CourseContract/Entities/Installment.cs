using System.Globalization;

namespace CourseContract.Entities
{
    class Installment

    {
        //Atributos
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        //Construtor
        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }


        //Metodo
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
