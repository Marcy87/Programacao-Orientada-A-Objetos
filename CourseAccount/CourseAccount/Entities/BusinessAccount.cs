namespace CourseAccount.Entities
{
    class BusinessAccount : Account  // O BusinessAccount herde, colocando os
                                     // dois pontos na frente da Classe Account,
                                     // todos os atributos e metodos da classe Account.
    {
        //Atributos
        public double loanLimit { get; set; }


        //Construtor
        public BusinessAccount()
        {

        }


        //Construtor com herança da classe Account
        public BusinessAccount(int number, string holder, double balance, double LoanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }


        //Metodo
        public void Loan(double amount)
        {
            if (amount <= loanLimit)
            {
                Balance += amount;
            }
        }
    }
}
