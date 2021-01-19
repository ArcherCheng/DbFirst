using System;
using System.Collections.Generic;

namespace FoodPos.Domain
{
    public partial class AppComData
    {
        public int ComId { get; set; }
        public string ComName { get; set; }
        public string GroupName { get; set; }
        public string ComNo { get; set; }
        public string ComPresident { get; set; }
        public string ComMaster { get; set; }
        public string ComStaff { get; set; }
        public string ComTel { get; set; }
        public string ComFax { get; set; }
        public string ComMobile { get; set; }
        public string ComIp { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceCode { get; set; }
        public int InvoiceIdBegin { get; set; }
        public int InvoiceIdEnd { get; set; }
        public string InvoiceBigMonth { get; set; }
        public string InvoiceYm { get; set; }
        public int InvoiceTaxRate { get; set; }
        public int ServiceRate { get; set; }
        public int QuestionnaireDays { get; set; }
        public int DiscountMonths { get; set; }
        public string PrinterForInvoice { get; set; }
        public string PrinterForOrder { get; set; }
        public string PrinterForKetchen { get; set; }
        public string PrinterForOrther { get; set; }
        public bool NeedTableNo { get; set; }
        public int MaxTableNo { get; set; }
        public int MaxSeatNo { get; set; }
        public string Notes { get; set; }
    }
}
