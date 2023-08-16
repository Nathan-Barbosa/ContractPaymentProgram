using System;
using System.Collections.Generic;

namespace ContractPaymentProgram.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; }
        public Contract() { }

        public Contract(int number, DateTime date, double totalPayment)
        {
            Number = number;
            Date = date;
            TotalValue = totalPayment;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
