using System;
using ContractPaymentProgram.Entities;
using ContractPaymentProgram.Services;

namespace ContractPaymentProgram
{
    class Program
    {
        public static void Main(string[] args) {

            Console.WriteLine("Enter contract date");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract (contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PayPalService());

            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments: ");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}