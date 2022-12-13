using System.Globalization;

namespace CourseContribuintes.Entities
{
    class Company : TaxPayer  //Pessoa Juridica
    {
        //Atributos
        public int NumberOfEmployees { get; set; }

        //Construtor

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees) :base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        //Metodo para calcular o imposto
        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
