using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class RequestFindProductProvider
    {
        public string Id { get; set; }
        public string FkRequestFindProduct { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string Description { get; set; }
        public int HeightX { get; set; }
        public int WidthY { get; set; }
        public int ThicknessZ { get; set; }
        public decimal Weight { get; set; }
        public string FkWeightUnit { get; set; }
        public string FkProvider { get; set; }
        public string TermOfPayment { get; set; }
        public string FkPort { get; set; }
        public string FkCcy { get; set; }
        public decimal ExchangeRate { get; set; }
        public string FkUnit { get; set; }
        public decimal QuantityOfPacking { get; set; }
        public string Packing { get; set; }
        public string FkUnitPacking { get; set; }
        public int DemoQuantity { get; set; }
        public decimal DemoExwPrice { get; set; }
        public decimal DemoFobPrice { get; set; }
        public decimal DemoCifPrice { get; set; }
        public int DemoSelected { get; set; }
        public int DemoApproverSelected { get; set; }
        public int MoqQuantity { get; set; }
        public decimal MoqExwPrice { get; set; }
        public decimal MoqFobPrice { get; set; }
        public decimal MoqCifPrice { get; set; }
        public int MoqSelected { get; set; }
        public int MoqApproverSelected { get; set; }
        public int Dc20quantity { get; set; }
        public decimal Dc20exwPrice { get; set; }
        public decimal Dc20fobPrice { get; set; }
        public decimal Dc20cifPrice { get; set; }
        public int Dc20selected { get; set; }
        public int Dc20approverSelected { get; set; }
        public int Dc40quantity { get; set; }
        public decimal Dc40exwPrice { get; set; }
        public decimal Dc40fobPrice { get; set; }
        public decimal Dc40cifPrice { get; set; }
        public int Dc40selected { get; set; }
        public int Dc40approverSelected { get; set; }
        public int Dc40hquantity { get; set; }
        public decimal Dc40hexwPrice { get; set; }
        public decimal Dc40hfobPrice { get; set; }
        public decimal Dc40hcifPrice { get; set; }
        public int Dc40hselected { get; set; }
        public int Dc40happroverSelected { get; set; }
        public int WarrantyMonth { get; set; }
        public DateTime CreateDate { get; set; }
        public string FkUserCreate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string FkUserUpdate { get; set; }
        public int IndexProvider { get; set; }
        public int MainProvider { get; set; }
        public int ApproverMainProvider { get; set; }
        public string Accessories { get; set; }

        public virtual RequestFindProduct FkRequestFindProductNavigation { get; set; }
    }
}
