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
    
    public partial class invoiceMaster
    {
        public invoiceMaster()
        {
            this.invoiceDetails = new HashSet<invoiceDetail>();
        }
    
        public int invoiceNo { get; set; }
        public System.DateTime invoiceDate { get; set; }
        public int companyCode { get; set; }
        public string companyName { get; set; }
        public int saleVoucherNo { get; set; }
        public string containers { get; set; }
    
        public virtual ICollection<invoiceDetail> invoiceDetails { get; set; }
    }
}
