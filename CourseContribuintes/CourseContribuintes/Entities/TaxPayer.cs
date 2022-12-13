namespace CourseContribuintes.Entities
{
    abstract class TaxPayer
    {
        //Atributos
        public string Name { get; set; }
        public double AnualIncome { get; set; }


        //Construtor
        public TaxPayer()  //Contribuente
        {
        }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }


        //metodo abstrato para calcular o Imposto
        public abstract double Tax(); //imposto
    }
}
