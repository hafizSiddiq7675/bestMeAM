using System;
namespace bestMeAM
{
    class ledger
    {
        public int voucherNo { get; set; }
        public System.DateTime voucherDate { get; set; }
        public string Description { get; set; }
        public decimal debit { get; set; }
        public decimal credit { get; set; }
        public decimal balance { get; set; }
    }
}
