using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.LoansBaseClass
{
    class LoanAmmortization
    {
        /********DISBURSE LOAN************/
       // public int AccountId { get; set; }
        public DateTime DisbursementDate { get; set; }
        public DateTime FirstRepaymentDate { get; set; }
        public decimal Payments { get; set; }

        //********** LOAN *********//
       // public int Id { get; set; }
        //public int CustomerId { get; set; }
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

        //******REPAY LOAN******************//
    }
}
