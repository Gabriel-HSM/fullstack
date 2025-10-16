using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_22_Interfaces.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthInterest * months;
        }
    }
}