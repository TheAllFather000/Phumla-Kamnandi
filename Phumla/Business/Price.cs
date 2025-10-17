using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla.Business
{
    internal static class Price
    {
        public enum Seasons
        {
            LOW = 550,
            MID = 750,
            HIGH = 995
        }

        private static double bill = 0.9;

        private static double amount;
        private static double deposit;

        static Price()
        {
            amount = 0;
        }

        /*
         * Returns the value of that particular day in terms of price.
         */
        public static double dayValue(DateTime date)
        {
            int dayOfMonth = date.Day;

            if (dayOfMonth >= 1 && dayOfMonth <= 7)
            {
                return (double)Seasons.LOW;
            }
            else if (8 <= dayOfMonth && dayOfMonth <= 16)
            {
                return (double)Seasons.MID;
            }
            else
            {
                return (double)Seasons.HIGH;
            }

        }

        // Calculates the deposit needed to be paid.
        public static double calculateDeposit(DateTime startDate, DateTime endDate)
        {
            calculateDays(startDate, endDate);
            deposit = amount * 0.1;
            return deposit;
        }


        public static double calculateActual(DateTime startDate, DateTime endDate)
        {
            calculateDeposit(startDate, endDate);
            return amount - deposit;
        }

        /*
         * Calculates the money required between 2 days.
         */
        public static double calculateDays(DateTime startDate, DateTime endDate)
        {
            double amount = 0;
            DateTime tempDate = startDate;
            while (tempDate < endDate)
            {
                amount += dayValue(tempDate);
                tempDate = tempDate.AddDays(1);
            }
            return amount; // Assume a deposit is made every single time a booking is made.

        }
    }
}
