using System;
using Course_Interfaces.Entities;

namespace Course_Interfaces.Services
{
    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPaymant = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPaymant = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPaymant = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPaymant);

            carRental.Invoice = new Invoice(basicPaymant, tax);
        }
    }
}