using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Exercicio_22_Interfaces.Entities;

namespace Exercicio_22_Interfaces.Services
{
    public class PaymentService
    {
        private IOnlinePaymentService _ionlinePaymentService;

        public PaymentService(IOnlinePaymentService onlinePaymentService)
        {
            _ionlinePaymentService = onlinePaymentService;
        }

        public void ProcessPayment(Contracts contract,int contractInstallments)
        {
            double basicQuota = contract.TotalValue / contractInstallments;

            for (int i = 1; i <= contractInstallments; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                 double updatedQuota = basicQuota + _ionlinePaymentService.Interest(basicQuota, i);
                double fullQuota =  updatedQuota + _ionlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
            
        }
    }
}