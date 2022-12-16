﻿using System;
using CourseContract.Entities;

namespace CourseContract.Services
{
    class ContractService
    {
        //Atributo
        private IOnlinePaymentService _onlinePaymentService;

        //Construtor
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        //Metodo
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);

                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
