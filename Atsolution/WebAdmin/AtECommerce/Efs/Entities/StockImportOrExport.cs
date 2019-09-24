using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class StockImportOrExport
    {
        public StockImportOrExport()
        {
            StockImportOrExportDetail = new HashSet<StockImportOrExportDetail>();
        }

        public string Id { get; set; }
        public bool IsImport { get; set; }
        public string FkProviderOrCustomer { get; set; }
        public string FkStockId { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public string FkCreateUser { get; set; }
        public decimal TotalAmountWithOutTax { get; set; }
        public decimal TotalAmountWithTax { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public string FkChiefUser { get; set; }
        public string FkCcy { get; set; }
        public decimal ExchangeRate { get; set; }
        public string Note { get; set; }
        public string DebitAccount { get; set; }
        public string CreditAccount { get; set; }
        public bool IsDelete { get; set; }
        public string FkRequestBuyProduct { get; set; }

        public virtual Stock FkStock { get; set; }
        public virtual ICollection<StockImportOrExportDetail> StockImportOrExportDetail { get; set; }
    }
}
