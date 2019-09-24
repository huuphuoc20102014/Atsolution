using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class OrganizationUnit
    {
        public string OrganizationUnitId { get; set; }
        public string BranchId { get; set; }
        public string OrganizationUnitCode { get; set; }
        public string OrganizationUnitName { get; set; }
        public bool IsSystem { get; set; }
        public string MisacodeId { get; set; }
        public int? Grade { get; set; }
        public string ParentId { get; set; }
        public bool IsParent { get; set; }
        public string Address { get; set; }
        public int OrganizationUnitTypeId { get; set; }
        public string BusinessRegistrationNumber { get; set; }
        public DateTime? BusinessRegistrationNumberIssuedDate { get; set; }
        public string BusinessRegistrationNumberIssuedPlace { get; set; }
        public bool? IsDependent { get; set; }
        public bool IsPrivateVatdeclaration { get; set; }
        public string CostAccount { get; set; }
        public bool Inactive { get; set; }
        public string CompanyTaxCode { get; set; }
        public string CompanyTel { get; set; }
        public string CompanyFax { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyBankAccountId { get; set; }
        public string CompanyOwnerName { get; set; }
        public string CompanyOwnerTaxCode { get; set; }
        public string DirectorTitle { get; set; }
        public string DirectorName { get; set; }
        public string ChiefOfAccountingTitle { get; set; }
        public string ChiefOfAccountingName { get; set; }
        public string StoreKeeperTitle { get; set; }
        public string StoreKeeperName { get; set; }
        public string CashierTitle { get; set; }
        public string CashierName { get; set; }
        public string ReporterTitle { get; set; }
        public string ReporterName { get; set; }
        public bool IsPrintSigner { get; set; }
        public bool IsGetReporterNameByUserLogIn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string SortMisacodeId { get; set; }
        public string CompanyDistrict { get; set; }
        public string CompanyCity { get; set; }
    }
}
