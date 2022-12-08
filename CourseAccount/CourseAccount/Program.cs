using System;
using CourseAccount.Entities;

namespace CourseAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Browm", 100.0, 500.0);

            Console.WriteLine(account.Balance);
        }
    }
}