using EntityLayer.Loans;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class ReducingBalance
    {
        public int Id { get; set; }
        public DateTime DisbursementDate { get; set; }
        public DateTime FirstRepaymentDate { get; set; }
        public decimal Payments { get; set; }
        public DateTime Days { get; set; }
        public DateTime Weeks { get; set; }
        public DateTime Month { get; set; }
        public DateTime Year { get; set; }

       
        public float Tenor { get; set; }

        public int NumberOfPayment { get; set; }
        public decimal InterestRate { get; set; }

        public string InterestType { get; set; }
        public DateTime RepaymentStartDate { get; set; }

        //Navigation properties

        public RepayLoan RepayLoan { get; set; }
        public PaymentRecord PaymentRecord { get; set; }
        //public LoanType LoanType { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        //public CustomerProfile CustomerProfile { get; set; }
        // public int CustomerProfileId { get; set; }

      
    }

}
   

