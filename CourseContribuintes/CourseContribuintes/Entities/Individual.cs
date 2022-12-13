using System.Globalization;

namespace CourseContribuintes.Entities
{
    class Individual : TaxPayer  //Pessoa Fisica
    {
        //Atributo
        public double HealthExpenditures { get; set; }

        //Construtor

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) :base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;  //despesa com saude
        }

        //Metodo para calcular o imposto
        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
