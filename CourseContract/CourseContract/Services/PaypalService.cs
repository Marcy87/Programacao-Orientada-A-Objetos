namespace CourseContract.Services
{
    class PaypalService : IOnlinePaymentService
    {
        //Atributos
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        //Metodos
        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;

        }

        public double PaymentFee(double amount)
        {
            return  amount * FeePercentage;
        }

        
    }
}
