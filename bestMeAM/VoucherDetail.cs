//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bestMeAM
{
    using System;
    using System.Collections.Generic;
    
    public partial class VoucherDetail
    {
        public int code { get; set; }
        public int voucherNo { get; set; }
        public int accountNo { get; set; }
        public string accountName { get; set; }
        public string Description { get; set; }
        public decimal debit { get; set; }
        public decimal credit { get; set; }
    
        public virtual Voucher Voucher { get; set; }
    }
}
