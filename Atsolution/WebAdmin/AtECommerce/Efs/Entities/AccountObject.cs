using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class AccountObject
    {
        public string AccountObjectId { get; set; }
        public string AccountObjectCode { get; set; }
        public string AccountObjectName { get; set; }
        public int? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public decimal? AgreementSalary { get; set; }
        public decimal? SalaryCoefficient { get; set; }
        public int? NumberOfDependent { get; set; }
        public decimal? InsuranceSalary { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string Address { get; set; }
        public string AccountObjectGroupList { get; set; }
        public string AccountObjectGroupListCode { get; set; }
        public string CompanyTaxCode { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string EmailAddress { get; set; }
        public string Website { get; set; }
        public string PaymentTermId { get; set; }
        public decimal? MaximizeDebtAmount { get; set; }
        public int? DueTime { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }
        public string Country { get; set; }
        public string ProvinceOrCity { get; set; }
        public string District { get; set; }
        public string WardOrCommune { get; set; }
        public string Prefix { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactMobile { get; set; }
        public string OtherContactMobile { get; set; }
        public string ContactFixedTel { get; set; }
        public string ContactEmail { get; set; }
        public string ContactAddress { get; set; }
        public int FkAccountObjectType { get; set; }
        public bool? Inactive { get; set; }
        public string OrganizationUnitId { get; set; }
        public string BranchId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public decimal? ReceiptableDebtAmount { get; set; }
        public string ShippingAddress { get; set; }
        public string AccountObjectGroupListName { get; set; }
        public string EmployeeId { get; set; }
        public string Description { get; set; }
        public string BankBranchName { get; set; }
        public string BankProvinceOrCity { get; set; }
        public string LegalRepresentative { get; set; }
        public string EinvoiceContactName { get; set; }
        public string EinvoiceContactEmail { get; set; }
        public string EinvoiceContactAddress { get; set; }
        public string EinvoiceContactMobile { get; set; }
        public string UserLogin { get; set; }
        public string PasswordLogin { get; set; }
        public bool IsVendorLc { get; set; }
        public bool IsVendorOf { get; set; }
        public bool IsVendorCustoms { get; set; }
        public bool IsVendorTrucking { get; set; }
        public bool IsVendorProduct { get; set; }
        public string FkAccountBusinessType { get; set; }
        public string ManageName { get; set; }
        public string ManagePhone { get; set; }
        public string ManageEmail { get; set; }
        public string ContactSkype { get; set; }
        public string DescriptionHtml { get; set; }
        public string ImageSlug { get; set; }
        public byte[] RowVersion { get; set; }
        public int? RowStatus { get; set; }

        public virtual AccountObjectType FkAccountObjectTypeNavigation { get; set; }
    }
}
