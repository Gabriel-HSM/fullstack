using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_22_Interfaces.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int installments)
        {
            return amount * MonthlyInterest * installments;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
        
    }
}