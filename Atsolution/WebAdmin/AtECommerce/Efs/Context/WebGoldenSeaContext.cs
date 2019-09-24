using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GenEf.Efs.Entities
{
    public partial class WebGoldenSeaContext : DbContext
    {

        public WebGoldenSeaContext(DbContextOptions<WebGoldenSeaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutCustomer> AboutCustomer { get; set; }
        public virtual DbSet<AboutUs> AboutUs { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountBusinessType> AccountBusinessType { get; set; }
        public virtual DbSet<AccountFeeBelong> AccountFeeBelong { get; set; }
        public virtual DbSet<AccountObject> AccountObject { get; set; }
        public virtual DbSet<AccountObjectBankAccount> AccountObjectBankAccount { get; set; }
        public virtual DbSet<AccountObjectGroup> AccountObjectGroup { get; set; }
        public virtual DbSet<AccountObjectLedger> AccountObjectLedger { get; set; }
        public virtual DbSet<AccountObjectShippingAddress> AccountObjectShippingAddress { get; set; }
        public virtual DbSet<AccountObjectType> AccountObjectType { get; set; }
        public virtual DbSet<AccountTransfer> AccountTransfer { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AutoBusiness> AutoBusiness { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankAccount> BankAccount { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<CabareasonType> CabareasonType { get; set; }
        public virtual DbSet<Capayment> Capayment { get; set; }
        public virtual DbSet<CapaymentDetail> CapaymentDetail { get; set; }
        public virtual DbSet<Careceipt> Careceipt { get; set; }
        public virtual DbSet<CareceiptDetail> CareceiptDetail { get; set; }
        public virtual DbSet<CareceiptPaymentList> CareceiptPaymentList { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Ccy> Ccy { get; set; }
        public virtual DbSet<ConfigListTable> ConfigListTable { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<ContractAttachment> ContractAttachment { get; set; }
        public virtual DbSet<ContractStatus> ContractStatus { get; set; }
        public virtual DbSet<CustomFieldLedger> CustomFieldLedger { get; set; }
        public virtual DbSet<Faq> Faq { get; set; }
        public virtual DbSet<FixedAssetCategory> FixedAssetCategory { get; set; }
        public virtual DbSet<GeneralLedger> GeneralLedger { get; set; }
        public virtual DbSet<GlvoucherCrossEntryDetail> GlvoucherCrossEntryDetail { get; set; }
        public virtual DbSet<ImageSlide> ImageSlide { get; set; }
        public virtual DbSet<IninwardOutwardList> IninwardOutwardList { get; set; }
        public virtual DbSet<InventoryItem> InventoryItem { get; set; }
        public virtual DbSet<InventoryItemCategory> InventoryItemCategory { get; set; }
        public virtual DbSet<InventoryItemCategoryAccount> InventoryItemCategoryAccount { get; set; }
        public virtual DbSet<InventoryItemCategoryParrent> InventoryItemCategoryParrent { get; set; }
        public virtual DbSet<InventoryItemDetail> InventoryItemDetail { get; set; }
        public virtual DbSet<InventoryItemGeneral> InventoryItemGeneral { get; set; }
        public virtual DbSet<InventoryItemMaterialProperty> InventoryItemMaterialProperty { get; set; }
        public virtual DbSet<InventoryItemType> InventoryItemType { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MscAccountObjectJoinRole> MscAccountObjectJoinRole { get; set; }
        public virtual DbSet<MscAudittingLog> MscAudittingLog { get; set; }
        public virtual DbSet<MscOption> MscOption { get; set; }
        public virtual DbSet<MscPermission> MscPermission { get; set; }
        public virtual DbSet<MscRegisPermisionForSubSystem> MscRegisPermisionForSubSystem { get; set; }
        public virtual DbSet<MscRole> MscRole { get; set; }
        public virtual DbSet<MscRolePermissionMaping> MscRolePermissionMaping { get; set; }
        public virtual DbSet<MscSubSystem> MscSubSystem { get; set; }
        public virtual DbSet<MscTableCode> MscTableCode { get; set; }
        public virtual DbSet<MscUser> MscUser { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsType> NewsType { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<OrganizationUnit> OrganizationUnit { get; set; }
        public virtual DbSet<PaymentTerm> PaymentTerm { get; set; }
        public virtual DbSet<Port> Port { get; set; }
        public virtual DbSet<PortAccountObject> PortAccountObject { get; set; }
        public virtual DbSet<PostApimethod> PostApimethod { get; set; }
        public virtual DbSet<PostShippingProvider> PostShippingProvider { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductComment> ProductComment { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<ProductVersion> ProductVersion { get; set; }
        public virtual DbSet<Provine> Provine { get; set; }
        public virtual DbSet<RequestBuyProduct> RequestBuyProduct { get; set; }
        public virtual DbSet<RequestBuyProductBuyType> RequestBuyProductBuyType { get; set; }
        public virtual DbSet<RequestBuyProductCustoms> RequestBuyProductCustoms { get; set; }
        public virtual DbSet<RequestBuyProductOf> RequestBuyProductOf { get; set; }
        public virtual DbSet<RequestBuyProductPayOrder> RequestBuyProductPayOrder { get; set; }
        public virtual DbSet<RequestBuyProductPayOrderPrioty> RequestBuyProductPayOrderPrioty { get; set; }
        public virtual DbSet<RequestBuyProductPayOrderStatus> RequestBuyProductPayOrderStatus { get; set; }
        public virtual DbSet<RequestBuyProductPayOrderType> RequestBuyProductPayOrderType { get; set; }
        public virtual DbSet<RequestBuyProductProvider> RequestBuyProductProvider { get; set; }
        public virtual DbSet<RequestBuyProductProviderMaterial> RequestBuyProductProviderMaterial { get; set; }
        public virtual DbSet<RequestBuyProductProviderType> RequestBuyProductProviderType { get; set; }
        public virtual DbSet<RequestBuyProductStatus> RequestBuyProductStatus { get; set; }
        public virtual DbSet<RequestBuyProductStockImport> RequestBuyProductStockImport { get; set; }
        public virtual DbSet<RequestBuyProductTrucking> RequestBuyProductTrucking { get; set; }
        public virtual DbSet<RequestFindProduct> RequestFindProduct { get; set; }
        public virtual DbSet<RequestFindProductCustoms> RequestFindProductCustoms { get; set; }
        public virtual DbSet<RequestFindProductLc> RequestFindProductLc { get; set; }
        public virtual DbSet<RequestFindProductOf> RequestFindProductOf { get; set; }
        public virtual DbSet<RequestFindProductProvider> RequestFindProductProvider { get; set; }
        public virtual DbSet<RequestFindProductProviderType> RequestFindProductProviderType { get; set; }
        public virtual DbSet<RequestFindProductStatus> RequestFindProductStatus { get; set; }
        public virtual DbSet<RequestFindProductTrucking> RequestFindProductTrucking { get; set; }
        public virtual DbSet<RequestFindProductType> RequestFindProductType { get; set; }
        public virtual DbSet<RequestProductPrioty> RequestProductPrioty { get; set; }
        public virtual DbSet<Sample> Sample { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<StockImportOrExport> StockImportOrExport { get; set; }
        public virtual DbSet<StockImportOrExportDetail> StockImportOrExportDetail { get; set; }
        public virtual DbSet<StockInventoryItemDetail> StockInventoryItemDetail { get; set; }
        public virtual DbSet<SysrefType> SysrefType { get; set; }
        public virtual DbSet<SysrefTypeCategory> SysrefTypeCategory { get; set; }
        public virtual DbSet<TableVersion> TableVersion { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<VoucherReference> VoucherReference { get; set; }
        public virtual DbSet<VoucherType> VoucherType { get; set; }
        public virtual DbSet<VoucherTypeCategory> VoucherTypeCategory { get; set; }
        public virtual DbSet<VoucherTypeCategoryRefType> VoucherTypeCategoryRefType { get; set; }
        public virtual DbSet<WBlog> WBlog { get; set; }
        public virtual DbSet<WBlogCaterogy> WBlogCaterogy { get; set; }
        public virtual DbSet<WCategory> WCategory { get; set; }
        public virtual DbSet<WColorOfProduct> WColorOfProduct { get; set; }
        public virtual DbSet<WCommerceWebsite> WCommerceWebsite { get; set; }
        public virtual DbSet<WContact> WContact { get; set; }
        public virtual DbSet<WCustomer> WCustomer { get; set; }
        public virtual DbSet<WEmail> WEmail { get; set; }
        public virtual DbSet<WFaq> WFaq { get; set; }
        public virtual DbSet<WOrder> WOrder { get; set; }
        public virtual DbSet<WPostService> WPostService { get; set; }
        public virtual DbSet<WProduct> WProduct { get; set; }
        public virtual DbSet<WProductAndTag> WProductAndTag { get; set; }
        public virtual DbSet<WProductHotSale> WProductHotSale { get; set; }
        public virtual DbSet<WProductImage> WProductImage { get; set; }
        public virtual DbSet<WProductOption> WProductOption { get; set; }
        public virtual DbSet<WProductOptionAndProduct> WProductOptionAndProduct { get; set; }
        public virtual DbSet<WReviewOfProduct> WReviewOfProduct { get; set; }
        public virtual DbSet<WSetting> WSetting { get; set; }
        public virtual DbSet<WSlideShow> WSlideShow { get; set; }
        public virtual DbSet<WSlideShowGroup> WSlideShowGroup { get; set; }
        public virtual DbSet<WSubMenu> WSubMenu { get; set; }
        public virtual DbSet<WSubMenuGroup> WSubMenuGroup { get; set; }
        public virtual DbSet<WUser> WUser { get; set; }
        public virtual DbSet<WUserGroup> WUserGroup { get; set; }
        public virtual DbSet<WeightUnit> WeightUnit { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=115.78.100.42,8899;Database=GOLDEN_SEA_DEV;User Id=sa;Password=1@qweQAZ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AboutCustomer>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImageSlug)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWord).HasMaxLength(1000);

                entity.Property(e => e.LongDescriptionHtml)
                    .HasColumnName("LongDescription_Html")
                    .HasColumnType("ntext");

                entity.Property(e => e.MetaData).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.ShortDescriptionHtml)
                    .HasColumnName("ShortDescription_Html")
                    .HasMaxLength(1000);

                entity.Property(e => e.SlugName)
                    .IsRequired()
                    .HasColumnName("Slug_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tags).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AboutUs>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImageSlug)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWord).HasMaxLength(1000);

                entity.Property(e => e.LongDescriptionHtml)
                    .HasColumnName("LongDescription_Html")
                    .HasColumnType("ntext");

                entity.Property(e => e.MetaData).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.ShortDescriptionHtml)
                    .HasColumnName("ShortDescription_Html")
                    .HasMaxLength(1000);

                entity.Property(e => e.SlugTitle)
                    .IsRequired()
                    .HasColumnName("Slug_Title")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tags).HasMaxLength(1000);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.AccountNameEnglish).HasMaxLength(128);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountObjectType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DetailByContractKind).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailByDepartmentKind).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailByExpenseItemKind).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailByJobKind).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailByListItemKind).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailByOrderKind).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailByProjectWorkKind).HasDefaultValueSql("((0))");

                entity.Property(e => e.DetailByPucontract).HasColumnName("DetailByPUContract");

                entity.Property(e => e.DetailByPucontractKind)
                    .HasColumnName("DetailByPUContractKind")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Grade).HasDefaultValueSql("((1))");

                entity.Property(e => e.MisacodeId)
                    .HasColumnName("MISACodeID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(50);

                entity.Property(e => e.SortMisacodeId)
                    .HasColumnName("SortMISACodeID")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AccountBusinessType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountBusinessTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AccountFeeBelong>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.FeeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FeeName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UnsignName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<AccountObject>(entity =>
            {
                entity.Property(e => e.AccountObjectId)
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountObjectCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.AccountObjectName).HasMaxLength(128);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AgreementSalary).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.BankBranchName).HasMaxLength(128);

                entity.Property(e => e.BankName).HasMaxLength(128);

                entity.Property(e => e.BankProvinceOrCity).HasMaxLength(100);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BirthPlace).HasMaxLength(255);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyTaxCode).HasMaxLength(50);

                entity.Property(e => e.ContactAddress).HasMaxLength(255);

                entity.Property(e => e.ContactEmail).HasMaxLength(100);

                entity.Property(e => e.ContactFixedTel).HasMaxLength(50);

                entity.Property(e => e.ContactMobile).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(128);

                entity.Property(e => e.ContactSkype).HasMaxLength(100);

                entity.Property(e => e.ContactTitle).HasMaxLength(128);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DescriptionHtml)
                    .HasColumnName("Description_html")
                    .HasColumnType("ntext");

                entity.Property(e => e.District).HasMaxLength(100);

                entity.Property(e => e.EinvoiceContactAddress)
                    .HasColumnName("EInvoiceContactAddress")
                    .HasMaxLength(255);

                entity.Property(e => e.EinvoiceContactEmail)
                    .HasColumnName("EInvoiceContactEmail")
                    .HasMaxLength(255);

                entity.Property(e => e.EinvoiceContactMobile)
                    .HasColumnName("EInvoiceContactMobile")
                    .HasMaxLength(50);

                entity.Property(e => e.EinvoiceContactName)
                    .HasColumnName("EInvoiceContactName")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FkAccountBusinessType)
                    .HasColumnName("FK_AccountBusinessType")
                    .HasMaxLength(50);

                entity.Property(e => e.FkAccountObjectType).HasColumnName("Fk_AccountObjectType");

                entity.Property(e => e.IdentificationNumber).HasMaxLength(20);

                entity.Property(e => e.ImageSlug)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InsuranceSalary)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVendorLc).HasColumnName("IsVendorLC");

                entity.Property(e => e.IsVendorOf).HasColumnName("IsVendorOF");

                entity.Property(e => e.IssueBy).HasMaxLength(120);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.LegalRepresentative).HasMaxLength(128);

                entity.Property(e => e.ManageEmail).HasMaxLength(50);

                entity.Property(e => e.ManageName).HasMaxLength(50);

                entity.Property(e => e.ManagePhone).HasMaxLength(50);

                entity.Property(e => e.MaximizeDebtAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizationUnitId)
                    .HasColumnName("OrganizationUnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherContactMobile).HasMaxLength(50);

                entity.Property(e => e.PasswordLogin)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(50);

                entity.Property(e => e.Prefix).HasMaxLength(60);

                entity.Property(e => e.ProvinceOrCity).HasMaxLength(100);

                entity.Property(e => e.ReceiptableDebtAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.SalaryCoefficient).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ShippingAddress).HasMaxLength(255);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WardOrCommune).HasMaxLength(100);

                entity.Property(e => e.Website).HasMaxLength(100);

                entity.HasOne(d => d.FkAccountObjectTypeNavigation)
                    .WithMany(p => p.AccountObject)
                    .HasForeignKey(d => d.FkAccountObjectType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AccountOb__Fk_Ac__151102AD");
            });

            modelBuilder.Entity<AccountObjectBankAccount>(entity =>
            {
                entity.Property(e => e.AccountObjectBankAccountId)
                    .HasColumnName("AccountObjectBankAccountID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountHolder)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BankAccount)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankBranchName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FkAccountObjectId)
                    .IsRequired()
                    .HasColumnName("FK_AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.FkBankId)
                    .IsRequired()
                    .HasColumnName("FK_BankId")
                    .HasMaxLength(50);

                entity.Property(e => e.ProvinceOrCity)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SwiftCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AccountObjectGroup>(entity =>
            {
                entity.Property(e => e.AccountObjectGroupId)
                    .HasColumnName("AccountObjectGroupID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountObjectGroupCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountObjectGroupName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Grade).HasDefaultValueSql("((1))");

                entity.Property(e => e.MisacodeId)
                    .HasColumnName("MISACodeID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(50);

                entity.Property(e => e.SortMisacodeId)
                    .HasColumnName("SortMISACodeID")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AccountObjectLedger>(entity =>
            {
                entity.Property(e => e.AccountObjectLedgerId).HasColumnName("AccountObjectLedgerID");

                entity.Property(e => e.AccountName).HasMaxLength(128);

                entity.Property(e => e.AccountNumber).HasMaxLength(20);

                entity.Property(e => e.AccountObjectAddress).HasMaxLength(255);

                entity.Property(e => e.AccountObjectAddressDi)
                    .HasColumnName("AccountObjectAddressDI")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountObjectCode).HasMaxLength(25);

                entity.Property(e => e.AccountObjectId)
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountObjectName).HasMaxLength(128);

                entity.Property(e => e.AccountObjectNameDi)
                    .HasColumnName("AccountObjectNameDI")
                    .HasMaxLength(128);

                entity.Property(e => e.AccountObjectTaxCode).HasMaxLength(50);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.BudgetItemId)
                    .HasColumnName("BudgetItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.CashOutExchangeRateLedger).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ContractCode).HasMaxLength(50);

                entity.Property(e => e.ContractId)
                    .HasColumnName("ContractID")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractName).HasMaxLength(255);

                entity.Property(e => e.ContractSignDate).HasColumnType("datetime");

                entity.Property(e => e.CorrespondingAccountNumber).HasMaxLength(20);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditAmountOc)
                    .HasColumnName("CreditAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasMaxLength(3);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DebitAmountOc)
                    .HasColumnName("DebitAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DocumentIncluded).HasMaxLength(255);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeCode).HasMaxLength(25);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(128);

                entity.Property(e => e.EntryType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ExchangeRateOperator)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'*')");

                entity.Property(e => e.InvDate).HasColumnType("datetime");

                entity.Property(e => e.InvNo).HasMaxLength(500);

                entity.Property(e => e.InvRefId)
                    .HasColumnName("InvRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.InvSeries).HasMaxLength(20);

                entity.Property(e => e.InventoryItemCode).HasMaxLength(25);

                entity.Property(e => e.InventoryItemId)
                    .HasColumnName("InventoryItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryItemName).HasMaxLength(255);

                entity.Property(e => e.IsUpdateRedundant)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .HasMaxLength(50);

                entity.Property(e => e.JournalMemo).HasMaxLength(255);

                entity.Property(e => e.ListItemId)
                    .HasColumnName("ListItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.MainConvertRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MainQuantity).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.MainUnitId)
                    .HasColumnName("MainUnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.MainUnitPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MainUnitPriceOc)
                    .HasColumnName("MainUnitPriceOC")
                    .HasColumnType("decimal(20, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrganizationUnitId)
                    .HasColumnName("OrganizationUnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(50);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectWorkId)
                    .HasColumnName("ProjectWorkID")
                    .HasMaxLength(50);

                entity.Property(e => e.PucontractCode)
                    .HasColumnName("PUContractCode")
                    .HasMaxLength(50);

                entity.Property(e => e.PucontractId)
                    .HasColumnName("PUContractID")
                    .HasMaxLength(50);

                entity.Property(e => e.PucontractName)
                    .HasColumnName("PUContractName")
                    .HasMaxLength(255);

                entity.Property(e => e.PuorderRefId)
                    .HasColumnName("PUOrderRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.PusignDate)
                    .HasColumnName("PUSignDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.RefDate).HasColumnType("datetime");

                entity.Property(e => e.RefDetailId)
                    .HasColumnName("RefDetailID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefId)
                    .HasColumnName("RefID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.RefOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefTypeName).HasMaxLength(100);

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.UnitPriceOc)
                    .HasColumnName("UnitPriceOC")
                    .HasColumnType("decimal(20, 6)");
            });

            modelBuilder.Entity<AccountObjectShippingAddress>(entity =>
            {
                entity.HasKey(e => e.ShippingAddressId);

                entity.Property(e => e.ShippingAddressId)
                    .HasColumnName("ShippingAddressID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountObjectId)
                    .IsRequired()
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.ShippingAddress).HasMaxLength(255);
            });

            modelBuilder.Entity<AccountObjectType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountObjectTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AccountTransfer>(entity =>
            {
                entity.Property(e => e.AccountTransferId)
                    .HasColumnName("AccountTransferID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountTransferCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FromAccount).HasMaxLength(20);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SetupType).HasDefaultValueSql("((1))");

                entity.Property(e => e.ToAccount).HasMaxLength(20);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AutoBusiness>(entity =>
            {
                entity.Property(e => e.AutoBusinessId)
                    .HasColumnName("AutoBusinessID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoBusinessName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditAccount).HasMaxLength(20);

                entity.Property(e => e.DebitAccount).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.Property(e => e.BankId)
                    .HasColumnName("BankID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.BankCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BankName).HasMaxLength(128);

                entity.Property(e => e.BankNameEnglish).HasMaxLength(128);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EbankCode)
                    .HasColumnName("EBankCode")
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SwiftCode).HasMaxLength(50);
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.Property(e => e.BankAccountId)
                    .HasColumnName("BankAccountID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountHolder).HasMaxLength(128);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.BankAccountNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankId)
                    .HasColumnName("BankID")
                    .HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProvinceOrCity).HasMaxLength(100);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.BranchCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FkUserCreatedBy)
                    .IsRequired()
                    .HasColumnName("Fk_UserCreatedBy")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserModifiedBy)
                    .HasColumnName("Fk_UserModifiedBy")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.President)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TaxCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CabareasonType>(entity =>
            {
                entity.HasKey(e => e.ReasonTypeId);

                entity.ToTable("CABAReasonType");

                entity.Property(e => e.ReasonTypeId)
                    .HasColumnName("ReasonTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ReasonTypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<Capayment>(entity =>
            {
                entity.HasKey(e => e.RefId);

                entity.ToTable("CAPayment");

                entity.Property(e => e.RefId)
                    .HasColumnName("RefID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountObjectAddress).HasMaxLength(255);

                entity.Property(e => e.AccountObjectContactName).HasMaxLength(128);

                entity.Property(e => e.AccountObjectId)
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountObjectName).HasMaxLength(128);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.CashBookPostedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasMaxLength(3);

                entity.Property(e => e.CustomField1).HasMaxLength(255);

                entity.Property(e => e.CustomField10).HasMaxLength(255);

                entity.Property(e => e.CustomField2).HasMaxLength(255);

                entity.Property(e => e.CustomField3).HasMaxLength(255);

                entity.Property(e => e.CustomField4).HasMaxLength(255);

                entity.Property(e => e.CustomField5).HasMaxLength(255);

                entity.Property(e => e.CustomField6).HasMaxLength(255);

                entity.Property(e => e.CustomField7).HasMaxLength(255);

                entity.Property(e => e.CustomField8).HasMaxLength(255);

                entity.Property(e => e.CustomField9).HasMaxLength(255);

                entity.Property(e => e.DocumentIncluded).HasMaxLength(255);

                entity.Property(e => e.EditVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlvoucherRefId)
                    .HasColumnName("GLVoucherRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.IsEnvironmentVat).HasColumnName("IsEnvironmentVAT");

                entity.Property(e => e.IsImportVat).HasColumnName("IsImportVAT");

                entity.Property(e => e.IsSpecialVat).HasColumnName("IsSpecialVAT");

                entity.Property(e => e.IsVat).HasColumnName("IsVAT");

                entity.Property(e => e.JournalMemo).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonTypeId).HasColumnName("ReasonTypeID");

                entity.Property(e => e.RefDate).HasColumnType("datetime");

                entity.Property(e => e.RefNoFinance).HasMaxLength(20);

                entity.Property(e => e.RefNoManagement).HasMaxLength(20);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmountOc)
                    .HasColumnName("TotalAmountOC")
                    .HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<CapaymentDetail>(entity =>
            {
                entity.HasKey(e => e.RefDetailId);

                entity.ToTable("CAPaymentDetail");

                entity.Property(e => e.RefDetailId)
                    .HasColumnName("RefDetailID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountObjectId)
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AmountOc)
                    .HasColumnName("AmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BankAccountId)
                    .HasColumnName("BankAccountID")
                    .HasMaxLength(50);

                entity.Property(e => e.BudgetItemId)
                    .HasColumnName("BudgetItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.CashOutAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CashOutAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CashOutDiffAccountNumberFinance).HasMaxLength(20);

                entity.Property(e => e.CashOutDiffAccountNumberManagement).HasMaxLength(20);

                entity.Property(e => e.CashOutDiffAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CashOutDiffAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CashOutExchangeRateFinance).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.CashOutExchangeRateManagement).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ContractId)
                    .HasColumnName("ContractID")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditAccount).HasMaxLength(20);

                entity.Property(e => e.CustomField1).HasMaxLength(255);

                entity.Property(e => e.CustomField10).HasMaxLength(255);

                entity.Property(e => e.CustomField2).HasMaxLength(255);

                entity.Property(e => e.CustomField3).HasMaxLength(255);

                entity.Property(e => e.CustomField4).HasMaxLength(255);

                entity.Property(e => e.CustomField5).HasMaxLength(255);

                entity.Property(e => e.CustomField6).HasMaxLength(255);

                entity.Property(e => e.CustomField7).HasMaxLength(255);

                entity.Property(e => e.CustomField8).HasMaxLength(255);

                entity.Property(e => e.CustomField9).HasMaxLength(255);

                entity.Property(e => e.DebitAccount).HasMaxLength(20);

                entity.Property(e => e.DebtAgreementId)
                    .HasColumnName("DebtAgreementID")
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ExpenseItemId)
                    .HasColumnName("ExpenseItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.FkAccountFeeBelong)
                    .HasColumnName("FK_AccountFeeBelong")
                    .HasMaxLength(50);

                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .HasMaxLength(50);

                entity.Property(e => e.ListItemId)
                    .HasColumnName("ListItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrganizationUnitId)
                    .HasColumnName("OrganizationUnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectWorkId)
                    .HasColumnName("ProjectWorkID")
                    .HasMaxLength(50);

                entity.Property(e => e.PucontractId)
                    .HasColumnName("PUContractID")
                    .HasMaxLength(50);

                entity.Property(e => e.PuorderRefId)
                    .HasColumnName("PUOrderRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefId)
                    .IsRequired()
                    .HasColumnName("RefID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Careceipt>(entity =>
            {
                entity.HasKey(e => e.RefId);

                entity.ToTable("CAReceipt");

                entity.Property(e => e.RefId)
                    .HasColumnName("RefID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountObjectAddress).HasMaxLength(255);

                entity.Property(e => e.AccountObjectContactName).HasMaxLength(128);

                entity.Property(e => e.AccountObjectId)
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountObjectName).HasMaxLength(128);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.CashBookPostedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasMaxLength(3);

                entity.Property(e => e.CustomField1).HasMaxLength(255);

                entity.Property(e => e.CustomField10).HasMaxLength(255);

                entity.Property(e => e.CustomField2).HasMaxLength(255);

                entity.Property(e => e.CustomField3).HasMaxLength(255);

                entity.Property(e => e.CustomField4).HasMaxLength(255);

                entity.Property(e => e.CustomField5).HasMaxLength(255);

                entity.Property(e => e.CustomField6).HasMaxLength(255);

                entity.Property(e => e.CustomField7).HasMaxLength(255);

                entity.Property(e => e.CustomField8).HasMaxLength(255);

                entity.Property(e => e.CustomField9).HasMaxLength(255);

                entity.Property(e => e.DocumentIncluded).HasMaxLength(255);

                entity.Property(e => e.EditVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlvoucherRefId)
                    .HasColumnName("GLVoucherRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.JournalMemo).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonTypeId).HasColumnName("ReasonTypeID");

                entity.Property(e => e.RefDate).HasColumnType("datetime");

                entity.Property(e => e.RefNoFinance).HasMaxLength(20);

                entity.Property(e => e.RefNoManagement).HasMaxLength(20);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmountOc)
                    .HasColumnName("TotalAmountOC")
                    .HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<CareceiptDetail>(entity =>
            {
                entity.HasKey(e => e.RefDetailId);

                entity.ToTable("CAReceiptDetail");

                entity.Property(e => e.RefDetailId)
                    .HasColumnName("RefDetailID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountObjectId)
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AmountOc)
                    .HasColumnName("AmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BankAccountId)
                    .HasColumnName("BankAccountID")
                    .HasMaxLength(50);

                entity.Property(e => e.BudgetItemId)
                    .HasColumnName("BudgetItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.CashOutAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CashOutAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CashOutDiffAccountNumberFinance).HasMaxLength(20);

                entity.Property(e => e.CashOutDiffAccountNumberManagement).HasMaxLength(20);

                entity.Property(e => e.CashOutDiffAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CashOutDiffAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CashOutExchangeRateFinance).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.CashOutExchangeRateManagement).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ContractId)
                    .HasColumnName("ContractID")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditAccount).HasMaxLength(20);

                entity.Property(e => e.CustomField1).HasMaxLength(255);

                entity.Property(e => e.CustomField10).HasMaxLength(255);

                entity.Property(e => e.CustomField2).HasMaxLength(255);

                entity.Property(e => e.CustomField3).HasMaxLength(255);

                entity.Property(e => e.CustomField4).HasMaxLength(255);

                entity.Property(e => e.CustomField5).HasMaxLength(255);

                entity.Property(e => e.CustomField6).HasMaxLength(255);

                entity.Property(e => e.CustomField7).HasMaxLength(255);

                entity.Property(e => e.CustomField8).HasMaxLength(255);

                entity.Property(e => e.CustomField9).HasMaxLength(255);

                entity.Property(e => e.DebitAccount).HasMaxLength(20);

                entity.Property(e => e.DebtAgreementId)
                    .HasColumnName("DebtAgreementID")
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ExpenseItemId)
                    .HasColumnName("ExpenseItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.FkAccountFeeBelong)
                    .HasColumnName("FK_AccountFeeBelong")
                    .HasMaxLength(50);

                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .HasMaxLength(50);

                entity.Property(e => e.ListItemId)
                    .HasColumnName("ListItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrganizationUnitId)
                    .HasColumnName("OrganizationUnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.ProjectWorkId)
                    .HasColumnName("ProjectWorkID")
                    .HasMaxLength(50);

                entity.Property(e => e.PucontractId)
                    .HasColumnName("PUContractID")
                    .HasMaxLength(50);

                entity.Property(e => e.PuorderRefId)
                    .HasColumnName("PUOrderRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefId)
                    .IsRequired()
                    .HasColumnName("RefID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CareceiptPaymentList>(entity =>
            {
                entity.HasKey(e => e.RefId)
                    .HasName("PK_CAReceiptPaymentList_RefID");

                entity.ToTable("CAReceiptPaymentList");

                entity.Property(e => e.RefId)
                    .HasColumnName("RefID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountObjectAddress).HasMaxLength(255);

                entity.Property(e => e.AccountObjectBankAccount).HasMaxLength(50);

                entity.Property(e => e.AccountObjectBankName).HasMaxLength(255);

                entity.Property(e => e.AccountObjectContactName).HasMaxLength(128);

                entity.Property(e => e.AccountObjectId)
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountObjectName).HasMaxLength(128);

                entity.Property(e => e.BankAccountId)
                    .HasColumnName("BankAccountID")
                    .HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.Cabaamount)
                    .HasColumnName("CABAAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CabaamountOc)
                    .HasColumnName("CABAAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CabadocumentIncluded)
                    .HasColumnName("CABADocumentIncluded")
                    .HasMaxLength(255);

                entity.Property(e => e.CabajournalMemo)
                    .HasColumnName("CABAJournalMemo")
                    .HasMaxLength(255);

                entity.Property(e => e.CabapostedDate)
                    .HasColumnName("CABAPostedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CabarefDate)
                    .HasColumnName("CABARefDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CabarefNoFinance)
                    .HasColumnName("CABARefNoFinance")
                    .HasMaxLength(20);

                entity.Property(e => e.CabarefNoManagement)
                    .HasColumnName("CABARefNoManagement")
                    .HasMaxLength(20);

                entity.Property(e => e.CadocumentIncluded)
                    .HasColumnName("CADocumentIncluded")
                    .HasMaxLength(255);

                entity.Property(e => e.CajournalMemo)
                    .HasColumnName("CAJournalMemo")
                    .HasMaxLength(255);

                entity.Property(e => e.CapostedDate)
                    .HasColumnName("CAPostedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarefDate)
                    .HasColumnName("CARefDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarefNoFinance)
                    .HasColumnName("CARefNoFinance")
                    .HasMaxLength(20);

                entity.Property(e => e.CarefNoManagement)
                    .HasColumnName("CARefNoManagement")
                    .HasMaxLength(20);

                entity.Property(e => e.CashBookPostedDate).HasColumnType("datetime");

                entity.Property(e => e.Catype).HasColumnName("CAType");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasMaxLength(3);

                entity.Property(e => e.CustomField1).HasMaxLength(255);

                entity.Property(e => e.CustomField10).HasMaxLength(255);

                entity.Property(e => e.CustomField2).HasMaxLength(255);

                entity.Property(e => e.CustomField3).HasMaxLength(255);

                entity.Property(e => e.CustomField4).HasMaxLength(255);

                entity.Property(e => e.CustomField5).HasMaxLength(255);

                entity.Property(e => e.CustomField6).HasMaxLength(255);

                entity.Property(e => e.CustomField7).HasMaxLength(255);

                entity.Property(e => e.CustomField8).HasMaxLength(255);

                entity.Property(e => e.CustomField9).HasMaxLength(255);

                entity.Property(e => e.DocumentIncluded).HasMaxLength(255);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IdentificationNumber).HasMaxLength(20);

                entity.Property(e => e.InrefOrder)
                    .HasColumnName("INRefOrder")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvDate).HasColumnType("datetime");

                entity.Property(e => e.InvNo).HasMaxLength(500);

                entity.Property(e => e.InvSeries).HasMaxLength(20);

                entity.Property(e => e.InventoryPostedDate).HasColumnType("datetime");

                entity.Property(e => e.IssueBy).HasMaxLength(120);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.JournalMemo).HasMaxLength(255);

                entity.Property(e => e.ListTableName).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OutDocumentIncluded).HasMaxLength(255);

                entity.Property(e => e.PayReason).HasMaxLength(255);

                entity.Property(e => e.Payer).HasMaxLength(128);

                entity.Property(e => e.PayerAddress).HasMaxLength(255);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(50);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.PuinvoiceRefId)
                    .HasColumnName("PUInvoiceRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReasonTypeId).HasColumnName("ReasonTypeID");

                entity.Property(e => e.Receiver).HasMaxLength(128);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(255);

                entity.Property(e => e.RefDate).HasColumnType("datetime");

                entity.Property(e => e.RefNoFinance).HasMaxLength(20);

                entity.Property(e => e.RefNoManagement).HasMaxLength(20);

                entity.Property(e => e.RefTypeName).HasMaxLength(100);

                entity.Property(e => e.SainvoiceRefId)
                    .HasColumnName("SAInvoiceRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasMaxLength(50);

                entity.Property(e => e.SupplierName).HasMaxLength(128);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmountOc)
                    .HasColumnName("TotalAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalCustomBeforeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDiscountAmountOc)
                    .HasColumnName("TotalDiscountAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalExportTaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalExportTaxAmountOc)
                    .HasColumnName("TotalExportTaxAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalFreightAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalImportTaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalImportTaxAmountOc)
                    .HasColumnName("TotalImportTaxAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalInwardAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalSaleAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalSaleAmountOc)
                    .HasColumnName("TotalSaleAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalSpecialConsumeTaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalSpecialConsumeTaxAmountOc)
                    .HasColumnName("TotalSpecialConsumeTaxAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalVatamount)
                    .HasColumnName("TotalVATAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalVatamountOc)
                    .HasColumnName("TotalVATAmountOC")
                    .HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FkCategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon).HasMaxLength(500);

                entity.Property(e => e.KeyWord).HasMaxLength(1000);

                entity.Property(e => e.MetaData).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.SlugName)
                    .IsRequired()
                    .HasColumnName("Slug_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tags).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkCategory)
                    .WithMany(p => p.InverseFkCategory)
                    .HasForeignKey(d => d.FkCategoryId)
                    .HasConstraintName("FK_Category_Category");
            });

            modelBuilder.Entity<Ccy>(entity =>
            {
                entity.HasKey(e => e.CurrencyId);

                entity.ToTable("CCY");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterDecimal).HasMaxLength(20);

                entity.Property(e => e.AfterDecimalDefault).HasMaxLength(20);

                entity.Property(e => e.AfterDecimalDefaultEng)
                    .HasColumnName("AfterDecimalDefaultENG")
                    .HasMaxLength(20);

                entity.Property(e => e.AfterDecimalEng)
                    .HasColumnName("AfterDecimalENG")
                    .HasMaxLength(20);

                entity.Property(e => e.Baaccount)
                    .HasColumnName("BAAccount")
                    .HasMaxLength(20);

                entity.Property(e => e.Caaccount)
                    .HasColumnName("CAAccount")
                    .HasMaxLength(20);

                entity.Property(e => e.Ccyname)
                    .HasColumnName("CCYName")
                    .HasMaxLength(20);

                entity.Property(e => e.CcynameDefault)
                    .HasColumnName("CCYNameDefault")
                    .HasMaxLength(20);

                entity.Property(e => e.CcynameDefaultEng)
                    .HasColumnName("CCYNameDefaultENG")
                    .HasMaxLength(20);

                entity.Property(e => e.CcynameEng)
                    .HasColumnName("CCYNameENG")
                    .HasMaxLength(20);

                entity.Property(e => e.ConvertRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConvertRateDefault)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConvertRateDefaultEng)
                    .HasColumnName("ConvertRateDefaultENG")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConvertRateEng)
                    .HasColumnName("ConvertRateENG")
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DecimalSeperate).HasMaxLength(20);

                entity.Property(e => e.DecimalSeperateDefault).HasMaxLength(20);

                entity.Property(e => e.DecimalSeperateDefaultEng)
                    .HasColumnName("DecimalSeperateDefaultENG")
                    .HasMaxLength(20);

                entity.Property(e => e.DecimalSeperateEng)
                    .HasColumnName("DecimalSeperateENG")
                    .HasMaxLength(20);

                entity.Property(e => e.ExampleAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Prefix).HasMaxLength(20);

                entity.Property(e => e.PrefixDefault).HasMaxLength(20);

                entity.Property(e => e.PrefixDefaultEng)
                    .HasColumnName("PrefixDefaultENG")
                    .HasMaxLength(20);

                entity.Property(e => e.PrefixEng)
                    .HasColumnName("PrefixENG")
                    .HasMaxLength(20);

                entity.Property(e => e.Subfix).HasMaxLength(20);

                entity.Property(e => e.SubfixDefault).HasMaxLength(20);

                entity.Property(e => e.SubfixDefaultEng)
                    .HasColumnName("SubfixDefaultENG")
                    .HasMaxLength(20);

                entity.Property(e => e.SubfixEng)
                    .HasColumnName("SubfixENG")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ConfigListTable>(entity =>
            {
                entity.Property(e => e.ConfigListTableId)
                    .HasColumnName("ConfigListTableID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.GeneralTableName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ListCode)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ListTableName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkProductCommentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Map)
                    .HasColumnName("map")
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.Property(e => e.ContractId)
                    .HasColumnName("ContractID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountObjectAddress).HasMaxLength(255);

                entity.Property(e => e.AccountObjectContactName).HasMaxLength(128);

                entity.Property(e => e.AccountObjectId)
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountObjectName).HasMaxLength(128);

                entity.Property(e => e.AccumCostAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AccumCostAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AccumOtherAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AccumOtherAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AccumSaleAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AccumSaleAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BalanceExpenseAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BalanceExpenseAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BalanceReceiptAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BalanceReceiptAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.CloseAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CloseAmountOc)
                    .HasColumnName("CloseAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.CloseReason).HasMaxLength(255);

                entity.Property(e => e.ContractAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ContractAmountOc)
                    .HasColumnName("ContractAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ContractCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContractStatusId).HasColumnName("ContractStatusID");

                entity.Property(e => e.ContractSubject).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasMaxLength(3);

                entity.Property(e => e.CustomField1).HasMaxLength(255);

                entity.Property(e => e.CustomField10).HasMaxLength(255);

                entity.Property(e => e.CustomField2).HasMaxLength(255);

                entity.Property(e => e.CustomField3).HasMaxLength(255);

                entity.Property(e => e.CustomField4).HasMaxLength(255);

                entity.Property(e => e.CustomField5).HasMaxLength(255);

                entity.Property(e => e.CustomField6).HasMaxLength(255);

                entity.Property(e => e.CustomField7).HasMaxLength(255);

                entity.Property(e => e.CustomField8).HasMaxLength(255);

                entity.Property(e => e.CustomField9).HasMaxLength(255);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ExpenseAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ExpenseAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InvoiceAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InvoiceAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InvoiceAmountOcfinance)
                    .HasColumnName("InvoiceAmountOCFinance")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InvoiceAmountOcmanagement)
                    .HasColumnName("InvoiceAmountOCManagement")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizationUnitId)
                    .HasColumnName("OrganizationUnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherTerms).HasMaxLength(255);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.ProfitAndLossExpectAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProfitAndLossExpectAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProjectId)
                    .HasColumnName("ProjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiptAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReceiptAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReceiptAmountOcfinance)
                    .HasColumnName("ReceiptAmountOCFinance")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReceiptAmountOcmanagement)
                    .HasColumnName("ReceiptAmountOCManagement")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RevenueDate).HasColumnType("datetime");

                entity.Property(e => e.SaorderId)
                    .HasColumnName("SAOrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.TotalExpenseExpectAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalExpensedAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalInvoiceAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalInvoiceAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalInvoiceAmountOcfinance)
                    .HasColumnName("TotalInvoiceAmountOCFinance")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalInvoiceAmountOcmanagement)
                    .HasColumnName("TotalInvoiceAmountOCManagement")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalReceiptedAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ContractAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId);

                entity.Property(e => e.AttachmentId)
                    .HasColumnName("AttachmentID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ContractId)
                    .IsRequired()
                    .HasColumnName("ContractID")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FileExtension).HasMaxLength(25);

                entity.Property(e => e.FileMimetype)
                    .HasColumnName("FileMIMEType")
                    .HasMaxLength(100);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ContractStatus>(entity =>
            {
                entity.Property(e => e.ContractStatusId)
                    .HasColumnName("ContractStatusID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContractStatusName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);
            });

            modelBuilder.Entity<CustomFieldLedger>(entity =>
            {
                entity.HasKey(e => e.CustomFieldLegerId);

                entity.Property(e => e.CustomFieldLegerId)
                    .HasColumnName("CustomFieldLegerID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomField1).HasMaxLength(255);

                entity.Property(e => e.CustomField10).HasMaxLength(255);

                entity.Property(e => e.CustomField2).HasMaxLength(255);

                entity.Property(e => e.CustomField3).HasMaxLength(255);

                entity.Property(e => e.CustomField4).HasMaxLength(255);

                entity.Property(e => e.CustomField5).HasMaxLength(255);

                entity.Property(e => e.CustomField6).HasMaxLength(255);

                entity.Property(e => e.CustomField7).HasMaxLength(255);

                entity.Property(e => e.CustomField8).HasMaxLength(255);

                entity.Property(e => e.CustomField9).HasMaxLength(255);

                entity.Property(e => e.MasterCustomField1).HasMaxLength(255);

                entity.Property(e => e.MasterCustomField10).HasMaxLength(255);

                entity.Property(e => e.MasterCustomField2).HasMaxLength(255);

                entity.Property(e => e.MasterCustomField3).HasMaxLength(255);

                entity.Property(e => e.MasterCustomField4).HasMaxLength(255);

                entity.Property(e => e.MasterCustomField5).HasMaxLength(255);

                entity.Property(e => e.MasterCustomField6).HasMaxLength(255);

                entity.Property(e => e.MasterCustomField7).HasMaxLength(255);

                entity.Property(e => e.MasterCustomField8).HasMaxLength(255);

                entity.Property(e => e.MasterCustomField9).HasMaxLength(255);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.RefDetailId)
                    .IsRequired()
                    .HasColumnName("RefDetailID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefId)
                    .IsRequired()
                    .HasColumnName("RefID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("FAQ");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Faqquestion)
                    .IsRequired()
                    .HasColumnName("FAQQuestion")
                    .HasMaxLength(1000);

                entity.Property(e => e.Faqreply)
                    .IsRequired()
                    .HasColumnName("FAQReply")
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<FixedAssetCategory>(entity =>
            {
                entity.Property(e => e.FixedAssetCategoryId)
                    .HasColumnName("FixedAssetCategoryID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepreciationAccount).HasMaxLength(20);

                entity.Property(e => e.FixedAssetCategoryCode).HasMaxLength(20);

                entity.Property(e => e.FixedAssetCategoryName).HasMaxLength(128);

                entity.Property(e => e.Grade).HasDefaultValueSql("((1))");

                entity.Property(e => e.Inactive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MisacodeId)
                    .HasColumnName("MISACodeID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrgPriceAccount).HasMaxLength(20);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(50);

                entity.Property(e => e.SortMisacodeId)
                    .HasColumnName("SortMISACodeID")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GeneralLedger>(entity =>
            {
                entity.Property(e => e.GeneralLedgerId).HasColumnName("GeneralLedgerID");

                entity.Property(e => e.AccountName).HasMaxLength(128);

                entity.Property(e => e.AccountNumber).HasMaxLength(20);

                entity.Property(e => e.AccountObjectAddress).HasMaxLength(255);

                entity.Property(e => e.AccountObjectBankAccount).HasMaxLength(50);

                entity.Property(e => e.AccountObjectBankName).HasMaxLength(128);

                entity.Property(e => e.AccountObjectCode).HasMaxLength(25);

                entity.Property(e => e.AccountObjectId)
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountObjectName).HasMaxLength(128);

                entity.Property(e => e.AccountObjectNameDi)
                    .HasColumnName("AccountObjectNameDI")
                    .HasMaxLength(128);

                entity.Property(e => e.AccountObjectTaxCode).HasMaxLength(50);

                entity.Property(e => e.BankAccountId)
                    .HasColumnName("BankAccountID")
                    .HasMaxLength(50);

                entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.BudgetItemId)
                    .HasColumnName("BudgetItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.CashOutExchangeRateLedger).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ContactName).HasMaxLength(128);

                entity.Property(e => e.ContractCode).HasMaxLength(50);

                entity.Property(e => e.ContractId)
                    .HasColumnName("ContractID")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractName).HasMaxLength(255);

                entity.Property(e => e.ContractSignDate).HasColumnType("datetime");

                entity.Property(e => e.CorrespondingAccountNumber).HasMaxLength(20);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreditAmountOc)
                    .HasColumnName("CreditAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasMaxLength(3);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DebitAmountOc)
                    .HasColumnName("DebitAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DocumentIncluded).HasMaxLength(255);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeCode).HasMaxLength(25);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(128);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ExchangeRateOperator)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.ExpenseItemId)
                    .HasColumnName("ExpenseItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.InvDate).HasColumnType("datetime");

                entity.Property(e => e.InvNo).HasMaxLength(500);

                entity.Property(e => e.InvRefId)
                    .HasColumnName("InvRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.InvSeries).HasMaxLength(20);

                entity.Property(e => e.InventoryItemCode).HasMaxLength(25);

                entity.Property(e => e.InventoryItemId)
                    .HasColumnName("InventoryItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryItemName).HasMaxLength(255);

                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .HasMaxLength(50);

                entity.Property(e => e.JournalMemo).HasMaxLength(255);

                entity.Property(e => e.ListItemId)
                    .HasColumnName("ListItemID")
                    .HasMaxLength(50);

                entity.Property(e => e.MainConvertRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MainQuantity).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.MainUnitId)
                    .HasColumnName("MainUnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.MainUnitPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MainUnitPriceOc)
                    .HasColumnName("MainUnitPriceOC")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.OrganizationUnitId)
                    .HasColumnName("OrganizationUnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTermCode).HasMaxLength(20);

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentTermName).HasMaxLength(128);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectWorkId)
                    .HasColumnName("ProjectWorkID")
                    .HasMaxLength(50);

                entity.Property(e => e.PucontractCode)
                    .HasColumnName("PUContractCode")
                    .HasMaxLength(50);

                entity.Property(e => e.PucontractId)
                    .HasColumnName("PUContractID")
                    .HasMaxLength(50);

                entity.Property(e => e.PucontractName)
                    .HasColumnName("PUContractName")
                    .HasMaxLength(255);

                entity.Property(e => e.PuorderRefId)
                    .HasColumnName("PUOrderRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.PusignDate)
                    .HasColumnName("PUSignDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.RefDate).HasColumnType("datetime");

                entity.Property(e => e.RefDate1).HasColumnType("datetime");

                entity.Property(e => e.RefDetailId)
                    .HasColumnName("RefDetailID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefId)
                    .IsRequired()
                    .HasColumnName("RefID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.RefNo1).HasMaxLength(20);

                entity.Property(e => e.RefNo2).HasMaxLength(20);

                entity.Property(e => e.RefTypeName).HasMaxLength(100);

                entity.Property(e => e.StockCode).HasMaxLength(20);

                entity.Property(e => e.StockId)
                    .HasColumnName("StockID")
                    .HasMaxLength(50);

                entity.Property(e => e.StockName).HasMaxLength(128);

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.UnitPriceOc)
                    .HasColumnName("UnitPriceOC")
                    .HasColumnType("decimal(20, 6)");
            });

            modelBuilder.Entity<GlvoucherCrossEntryDetail>(entity =>
            {
                entity.HasKey(e => e.RefDetailId);

                entity.ToTable("GLVoucherCrossEntryDetail");

                entity.Property(e => e.RefDetailId)
                    .HasColumnName("RefDetailID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountObjectId)
                    .IsRequired()
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasMaxLength(3);

                entity.Property(e => e.DebtAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DebtAmountOc)
                    .HasColumnName("DebtAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DebtDescription).HasMaxLength(255);

                entity.Property(e => e.DebtDueDate).HasColumnType("datetime");

                entity.Property(e => e.DebtEmployeeId)
                    .HasColumnName("DebtEmployeeID")
                    .HasMaxLength(50);

                entity.Property(e => e.DebtExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DebtInvDate).HasColumnType("datetime");

                entity.Property(e => e.DebtPostedDate).HasColumnType("datetime");

                entity.Property(e => e.DebtRefDate).HasColumnType("datetime");

                entity.Property(e => e.DebtRefId)
                    .IsRequired()
                    .HasColumnName("DebtRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.DebtRefNo).HasMaxLength(25);

                entity.Property(e => e.DebtableAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DebtableAmountOc)
                    .HasColumnName("DebtableAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountAccount).HasMaxLength(20);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountAmountOc)
                    .HasColumnName("DiscountAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.ExchangeDiffAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GlvoucherRefId)
                    .HasColumnName("GLVoucherRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.LastExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.MappingCrossId)
                    .HasColumnName("MappingCrossID")
                    .HasMaxLength(50);

                entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PayAmountOc)
                    .HasColumnName("PayAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PayDescription).HasMaxLength(255);

                entity.Property(e => e.PayPostedDate).HasColumnType("datetime");

                entity.Property(e => e.PayRefDate).HasColumnType("datetime");

                entity.Property(e => e.PayRefId)
                    .IsRequired()
                    .HasColumnName("PayRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.PayRefNo).HasMaxLength(25);

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PayableAmountOc)
                    .HasColumnName("PayableAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(50);

                entity.Property(e => e.SortOrder).ValueGeneratedOnAdd();

                entity.Property(e => e.TotalDebtableAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDebtableAmountOc)
                    .HasColumnName("TotalDebtableAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalPayableAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalPayableAmountOc)
                    .HasColumnName("TotalPayableAmountOC")
                    .HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ImageSlide>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWord).HasMaxLength(1000);

                entity.Property(e => e.MetaData).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.SlugName)
                    .IsRequired()
                    .HasColumnName("Slug_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tags).HasMaxLength(1000);

                entity.Property(e => e.Thumbnail).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.YoutubeLink).HasMaxLength(500);
            });

            modelBuilder.Entity<IninwardOutwardList>(entity =>
            {
                entity.HasKey(e => e.RefId)
                    .HasName("PK_INInwardOutwardList_RefID");

                entity.ToTable("INInwardOutwardList");

                entity.Property(e => e.RefId)
                    .HasColumnName("RefID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountObjectAddress).HasMaxLength(255);

                entity.Property(e => e.AccountObjectBankAccount).HasMaxLength(50);

                entity.Property(e => e.AccountObjectBankName).HasMaxLength(255);

                entity.Property(e => e.AccountObjectContactName).HasMaxLength(128);

                entity.Property(e => e.AccountObjectId)
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountObjectName).HasMaxLength(128);

                entity.Property(e => e.AssemblyRefId)
                    .HasColumnName("AssemblyRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.BankAccountId)
                    .HasColumnName("BankAccountID")
                    .HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.Cabaamount)
                    .HasColumnName("CABAAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CabaamountOc)
                    .HasColumnName("CABAAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CabadocumentIncluded)
                    .HasColumnName("CABADocumentIncluded")
                    .HasMaxLength(255);

                entity.Property(e => e.CabajournalMemo)
                    .HasColumnName("CABAJournalMemo")
                    .HasMaxLength(255);

                entity.Property(e => e.CabapostedDate)
                    .HasColumnName("CABAPostedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CabarefDate)
                    .HasColumnName("CABARefDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CabarefNoFinance)
                    .HasColumnName("CABARefNoFinance")
                    .HasMaxLength(20);

                entity.Property(e => e.CabarefNoManagement)
                    .HasColumnName("CABARefNoManagement")
                    .HasMaxLength(20);

                entity.Property(e => e.CadocumentIncluded)
                    .HasColumnName("CADocumentIncluded")
                    .HasMaxLength(255);

                entity.Property(e => e.CajournalMemo)
                    .HasColumnName("CAJournalMemo")
                    .HasMaxLength(255);

                entity.Property(e => e.CapostedDate)
                    .HasColumnName("CAPostedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarefDate)
                    .HasColumnName("CARefDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CarefNoFinance)
                    .HasColumnName("CARefNoFinance")
                    .HasMaxLength(20);

                entity.Property(e => e.CarefNoManagement)
                    .HasColumnName("CARefNoManagement")
                    .HasMaxLength(20);

                entity.Property(e => e.CashBookPostedDate).HasColumnType("datetime");

                entity.Property(e => e.ContactName).HasMaxLength(128);

                entity.Property(e => e.ContractCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("CurrencyID")
                    .HasMaxLength(3);

                entity.Property(e => e.CustomField1).HasMaxLength(255);

                entity.Property(e => e.CustomField10).HasMaxLength(255);

                entity.Property(e => e.CustomField2).HasMaxLength(255);

                entity.Property(e => e.CustomField3).HasMaxLength(255);

                entity.Property(e => e.CustomField4).HasMaxLength(255);

                entity.Property(e => e.CustomField5).HasMaxLength(255);

                entity.Property(e => e.CustomField6).HasMaxLength(255);

                entity.Property(e => e.CustomField7).HasMaxLength(255);

                entity.Property(e => e.CustomField8).HasMaxLength(255);

                entity.Property(e => e.CustomField9).HasMaxLength(255);

                entity.Property(e => e.DocumentIncluded).HasMaxLength(255);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(50);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FromStockId)
                    .HasColumnName("FromStockID")
                    .HasMaxLength(50);

                entity.Property(e => e.IdentificationNumber).HasMaxLength(20);

                entity.Property(e => e.InrefOrder)
                    .HasColumnName("INRefOrder")
                    .HasColumnType("datetime");

                entity.Property(e => e.Intype).HasColumnName("INType");

                entity.Property(e => e.InvNo).HasMaxLength(50);

                entity.Property(e => e.InvSeries).HasMaxLength(20);

                entity.Property(e => e.InvTemplateNo).HasMaxLength(50);

                entity.Property(e => e.InventoryPostedDate).HasColumnType("datetime");

                entity.Property(e => e.IsCreatedSareturnLastYear).HasColumnName("IsCreatedSAReturnLastYear");

                entity.Property(e => e.IssueBy).HasMaxLength(120);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.JournalMemo).HasMaxLength(255);

                entity.Property(e => e.ListTableName).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNo).HasMaxLength(20);

                entity.Property(e => e.OutDocumentIncluded).HasMaxLength(255);

                entity.Property(e => e.OutwardDependentRefId)
                    .HasColumnName("OutwardDependentRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.PayReason).HasMaxLength(255);

                entity.Property(e => e.Payer).HasMaxLength(128);

                entity.Property(e => e.PayerAddress).HasMaxLength(255);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(50);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.PuinvoiceRefId)
                    .HasColumnName("PUInvoiceRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.Receiver).HasMaxLength(128);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(255);

                entity.Property(e => e.RefDate).HasColumnType("datetime");

                entity.Property(e => e.RefNoFinance).HasMaxLength(20);

                entity.Property(e => e.RefNoManagement).HasMaxLength(20);

                entity.Property(e => e.RefTypeName).HasMaxLength(100);

                entity.Property(e => e.RevenueStatusName).HasMaxLength(100);

                entity.Property(e => e.SainvoiceRefId)
                    .HasColumnName("SAInvoiceRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.SareturnRefId)
                    .HasColumnName("SAReturnRefID")
                    .HasMaxLength(50);

                entity.Property(e => e.ToStockId)
                    .HasColumnName("ToStockID")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmountFinance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmountManagement).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmountOc)
                    .HasColumnName("TotalAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalCustomBeforeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDiscountAmountOc)
                    .HasColumnName("TotalDiscountAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalFreightAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalImportTaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalImportTaxAmountOc)
                    .HasColumnName("TotalImportTaxAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalInwardAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalSpecialConsumeTaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalSpecialConsumeTaxAmountOc)
                    .HasColumnName("TotalSpecialConsumeTaxAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalVatamount)
                    .HasColumnName("TotalVATAmount")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalVatamountOc)
                    .HasColumnName("TotalVATAmountOC")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Transport).HasMaxLength(50);

                entity.Property(e => e.TransporterId)
                    .HasColumnName("TransporterID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransporterName).HasMaxLength(128);
            });

            modelBuilder.Entity<InventoryItem>(entity =>
            {
                entity.Property(e => e.InventoryItemId)
                    .HasColumnName("InventoryItemID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BarCode).HasMaxLength(20);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.Cogsaccount)
                    .HasColumnName("COGSAccount")
                    .HasMaxLength(20);

                entity.Property(e => e.CostMethod).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultStockId)
                    .HasColumnName("DefaultStockID")
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DiscountAccount).HasMaxLength(20);

                entity.Property(e => e.DiscountType).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportTaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedSalePrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.FixedUnitPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.GuarantyPeriod).HasMaxLength(100);

                entity.Property(e => e.ImportTaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InventoryAccount).HasMaxLength(20);

                entity.Property(e => e.InventoryCategorySpecialTaxId)
                    .HasColumnName("InventoryCategorySpecialTaxID")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryItemCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InventoryItemName).HasMaxLength(255);

                entity.Property(e => e.InventoryItemSource).HasMaxLength(255);

                entity.Property(e => e.InventoryItemType).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFollowSerialNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSaleDiscount).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinimumStock).HasColumnType("decimal(22, 8)");

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentInventoryItem).HasMaxLength(50);

                entity.Property(e => e.PurchaseDescription).HasMaxLength(255);

                entity.Property(e => e.PurchaseDiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReturnAccount).HasMaxLength(20);

                entity.Property(e => e.SaleAccount).HasMaxLength(20);

                entity.Property(e => e.SaleDescription).HasMaxLength(255);

                entity.Property(e => e.SaleOffAccount).HasMaxLength(20);

                entity.Property(e => e.SalePrice1).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.SalePrice2).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.SalePrice3).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(100);

                entity.Property(e => e.TacareerGroupId).HasColumnName("TACareerGroupID");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(20, 6)");
            });

            modelBuilder.Entity<InventoryItemCategory>(entity =>
            {
                entity.HasKey(e => e.InventoryCategoryId);

                entity.Property(e => e.InventoryCategoryId)
                    .HasColumnName("InventoryCategoryID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CodeCategory)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FkInventoryCategory)
                    .HasColumnName("Fk_InventoryCategory")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryCategoryCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InventoryCategoryName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InventoryItemCategoryAccount>(entity =>
            {
                entity.HasKey(e => e.InventoryCategoryAccountId);

                entity.Property(e => e.InventoryCategoryAccountId)
                    .HasColumnName("InventoryCategoryAccountID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Grade).HasDefaultValueSql("((1))");

                entity.Property(e => e.InventoryCategoryCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InventoryCategoryName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.MisacodeId)
                    .HasColumnName("MISACodeID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(50);

                entity.Property(e => e.SortMisacodeId)
                    .IsRequired()
                    .HasColumnName("SortMISACodeID")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<InventoryItemCategoryParrent>(entity =>
            {
                entity.HasKey(e => e.InventoryCategoryId);

                entity.Property(e => e.InventoryCategoryId)
                    .HasColumnName("InventoryCategoryID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CodeCategory)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.InventoryCategoryCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InventoryCategoryName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InventoryItemDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FkInventoryItemId)
                    .IsRequired()
                    .HasColumnName("FK_InventoryItemId")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryDetailCode).HasMaxLength(50);

                entity.Property(e => e.Material)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ParentInventoryItem).HasMaxLength(50);

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(50);

                entity.Property(e => e.Style)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InventoryItemGeneral>(entity =>
            {
                entity.ToTable("InventoryItem_General");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FkInventoryItem)
                    .IsRequired()
                    .HasColumnName("Fk_InventoryItem")
                    .HasMaxLength(50);

                entity.Property(e => e.FkInventotyDetail)
                    .HasColumnName("Fk_InventotyDetail")
                    .HasMaxLength(50);

                entity.Property(e => e.Lot)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlanQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Serial).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<InventoryItemMaterialProperty>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InventoryItemType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ten)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AnotherLink)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ControlerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CssClass).HasMaxLength(200);

                entity.Property(e => e.FkMenuId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IconSlug).HasMaxLength(200);

                entity.Property(e => e.ImageSlug).HasMaxLength(200);

                entity.Property(e => e.KeyWord).HasMaxLength(1000);

                entity.Property(e => e.MetaData).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.SlugName)
                    .IsRequired()
                    .HasColumnName("Slug_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tags).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MscAccountObjectJoinRole>(entity =>
            {
                entity.HasKey(e => e.UserJoinRoleId)
                    .HasName("PK_MSC_UserJoinRole");

                entity.ToTable("MSC_AccountObjectJoinRole");

                entity.Property(e => e.UserJoinRoleId)
                    .HasColumnName("UserJoinRoleID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MscAudittingLog>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("MSC_AudittingLog");

                entity.Property(e => e.EventId)
                    .HasColumnName("EventID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationPartAlias)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ApplicationPartCode).HasMaxLength(100);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.ComputerIp)
                    .HasColumnName("ComputerIP")
                    .HasMaxLength(100);

                entity.Property(e => e.ComputerName).HasMaxLength(100);

                entity.Property(e => e.IsWorkingWithManagementBook).HasMaxLength(255);

                entity.Property(e => e.LoginName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Parameter).HasMaxLength(100);

                entity.Property(e => e.PermissionTypeAlias)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefId)
                    .HasColumnName("RefID")
                    .HasMaxLength(50);

                entity.Property(e => e.Reference).HasDefaultValueSql("('')");

                entity.Property(e => e.ReferenceManagement).HasDefaultValueSql("('')");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MscOption>(entity =>
            {
                entity.HasKey(e => e.SettingKey);

                entity.ToTable("MSC_Option");

                entity.Property(e => e.SettingKey)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.SettingNote).HasMaxLength(500);

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<MscPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.ToTable("MSC_Permission");

                entity.Property(e => e.PermissionId)
                    .HasColumnName("PermissionID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.PermissionAlias).HasMaxLength(50);

                entity.Property(e => e.PermissionName).HasMaxLength(50);
            });

            modelBuilder.Entity<MscRegisPermisionForSubSystem>(entity =>
            {
                entity.ToTable("MSC_RegisPermisionForSubSystem");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.PermissionId)
                    .HasColumnName("PermissionID")
                    .HasMaxLength(50);

                entity.Property(e => e.SubSystemCode).HasMaxLength(255);
            });

            modelBuilder.Entity<MscRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_Role");

                entity.ToTable("MSC_Role");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.RoleCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RoleName).HasMaxLength(128);
            });

            modelBuilder.Entity<MscRolePermissionMaping>(entity =>
            {
                entity.ToTable("MSC_RolePermissionMaping");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.PermissionId)
                    .IsRequired()
                    .HasColumnName("PermissionID")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasColumnName("RoleID")
                    .HasMaxLength(50);

                entity.Property(e => e.SubSystemCode)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MscSubSystem>(entity =>
            {
                entity.HasKey(e => e.SubSystemCode)
                    .HasName("PK_MSC_SubSystem_1");

                entity.ToTable("MSC_SubSystem");

                entity.Property(e => e.SubSystemCode)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ParentSubSystemCode).HasMaxLength(255);

                entity.Property(e => e.SubSystemName).HasMaxLength(255);

                entity.Property(e => e.SubSystemSerial).HasMaxLength(500);
            });

            modelBuilder.Entity<MscTableCode>(entity =>
            {
                entity.HasKey(e => e.TableId);

                entity.ToTable("MSC_TableCode");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentValue).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Prefix).HasMaxLength(50);

                entity.Property(e => e.TableCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(500);

                entity.Property(e => e.UnsignName).HasMaxLength(500);
            });

            modelBuilder.Entity<MscUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("MSC_User");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(128);

                entity.Property(e => e.HomeAddress).HasMaxLength(255);

                entity.Property(e => e.JobTitle).HasMaxLength(128);

                entity.Property(e => e.MobilePhone).HasMaxLength(50);

                entity.Property(e => e.OrganizationUnitId)
                    .HasColumnName("OrganizationUnitID")
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PasswordEncryption).HasMaxLength(10);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WorkAddress).HasMaxLength(255);

                entity.Property(e => e.WorkPhone).HasMaxLength(50);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FkNewsTypeId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageSlug).HasMaxLength(100);

                entity.Property(e => e.KeyWord).HasMaxLength(1000);

                entity.Property(e => e.LongDescriptionHtml)
                    .HasColumnName("LongDescription_Html")
                    .HasColumnType("ntext");

                entity.Property(e => e.MetaData).HasMaxLength(1000);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.ShortDescriptionHtml)
                    .HasColumnName("ShortDescription_Html")
                    .HasMaxLength(1000);

                entity.Property(e => e.SlugTitle)
                    .IsRequired()
                    .HasColumnName("Slug_Title")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tags).HasMaxLength(1000);

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkNewsType)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.FkNewsTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_NewsType");
            });

            modelBuilder.Entity<NewsType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.KeyWord).HasMaxLength(1000);

                entity.Property(e => e.MetaData).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.SlugName)
                    .IsRequired()
                    .HasColumnName("Slug_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tags).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.NotificationId)
                    .HasColumnName("NotificationID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.NotificationIsmacId)
                    .HasColumnName("NotificationIsmacID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefDate).HasColumnType("datetime");

                entity.Property(e => e.RefId)
                    .HasColumnName("RefID")
                    .HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(50);

                entity.Property(e => e.SubContent).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(25);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FkAspNetUser)
                    .IsRequired()
                    .HasColumnName("FK_AspNetUser")
                    .HasMaxLength(50);

                entity.Property(e => e.FkCustomer)
                    .IsRequired()
                    .HasColumnName("FK_Customer")
                    .HasMaxLength(50);

                entity.Property(e => e.FkShippingProvider)
                    .IsRequired()
                    .HasColumnName("FK_ShippingProvider")
                    .HasMaxLength(50);

                entity.Property(e => e.OrderCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentNumber).HasMaxLength(100);

                entity.Property(e => e.PaymentRef).HasMaxLength(100);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverDistrict)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReceiverPhone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverProvine)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverWard)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShippingAddress)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ShippingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.FkShippingProviderNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.FkShippingProvider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_PostShippingProvider");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.FkOrder)
                    .IsRequired()
                    .HasColumnName("Fk_Order")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProductDetail)
                    .IsRequired()
                    .HasColumnName("Fk_ProductDetail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductVerion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FkOrderNavigation)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.FkOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.FkProductDetailNavigation)
                    .WithMany(p => p.OrderDetail)
                    .HasForeignKey(d => d.FkProductDetail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetail_ProductVersion");
            });

            modelBuilder.Entity<OrganizationUnit>(entity =>
            {
                entity.Property(e => e.OrganizationUnitId)
                    .HasColumnName("OrganizationUnitID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessRegistrationNumber).HasMaxLength(50);

                entity.Property(e => e.BusinessRegistrationNumberIssuedDate).HasColumnType("datetime");

                entity.Property(e => e.BusinessRegistrationNumberIssuedPlace).HasMaxLength(255);

                entity.Property(e => e.CashierName).HasMaxLength(50);

                entity.Property(e => e.CashierTitle).HasMaxLength(50);

                entity.Property(e => e.ChiefOfAccountingName).HasMaxLength(50);

                entity.Property(e => e.ChiefOfAccountingTitle).HasMaxLength(50);

                entity.Property(e => e.CompanyBankAccountId)
                    .HasColumnName("CompanyBankAccountID")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyCity).HasMaxLength(100);

                entity.Property(e => e.CompanyDistrict).HasMaxLength(100);

                entity.Property(e => e.CompanyEmail).HasMaxLength(100);

                entity.Property(e => e.CompanyFax).HasMaxLength(50);

                entity.Property(e => e.CompanyOwnerName).HasMaxLength(128);

                entity.Property(e => e.CompanyOwnerTaxCode).HasMaxLength(50);

                entity.Property(e => e.CompanyTaxCode).HasMaxLength(50);

                entity.Property(e => e.CompanyTel).HasMaxLength(50);

                entity.Property(e => e.CompanyWebsite).HasMaxLength(100);

                entity.Property(e => e.CostAccount).HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DirectorName).HasMaxLength(50);

                entity.Property(e => e.DirectorTitle).HasMaxLength(50);

                entity.Property(e => e.Grade).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDependent).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsPrivateVatdeclaration).HasColumnName("IsPrivateVATDeclaration");

                entity.Property(e => e.MisacodeId)
                    .HasColumnName("MISACodeID")
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizationUnitCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OrganizationUnitName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.OrganizationUnitTypeId)
                    .HasColumnName("OrganizationUnitTypeID")
                    .HasDefaultValueSql("((6))");

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReporterName).HasMaxLength(50);

                entity.Property(e => e.ReporterTitle).HasMaxLength(50);

                entity.Property(e => e.SortMisacodeId)
                    .HasColumnName("SortMISACodeID")
                    .HasMaxLength(100);

                entity.Property(e => e.StoreKeeperName).HasMaxLength(50);

                entity.Property(e => e.StoreKeeperTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentTerm>(entity =>
            {
                entity.Property(e => e.PaymentTermId)
                    .HasColumnName("PaymentTermID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTermCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PaymentTermName)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Port>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.PortAddress).IsRequired();

                entity.Property(e => e.PortName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PortNameUnsign)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<PortAccountObject>(entity =>
            {
                entity.HasKey(e => new { e.FkAccountObjectId, e.FkPortId });

                entity.Property(e => e.FkAccountObjectId)
                    .HasColumnName("Fk_AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.FkPortId)
                    .HasColumnName("FK_PortID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PostApimethod>(entity =>
            {
                entity.ToTable("PostAPIMethod");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Apiline)
                    .IsRequired()
                    .HasColumnName("APILine")
                    .HasMaxLength(500);

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<PostShippingProvider>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountObjectId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Api)
                    .IsRequired()
                    .HasColumnName("API")
                    .HasMaxLength(500);

                entity.Property(e => e.PassApi).HasMaxLength(50);

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserApi).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ccy)
                    .HasColumnName("CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FkInventoryItem)
                    .HasColumnName("Fk_InventoryItem")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageSlug)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWord).HasMaxLength(1000);

                entity.Property(e => e.LongDescriptionHtml)
                    .HasColumnName("LongDescription_Html")
                    .HasColumnType("ntext");

                entity.Property(e => e.Material).HasMaxLength(50);

                entity.Property(e => e.MetaData).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.Producer).HasMaxLength(500);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.ShortDescriptionHtml)
                    .HasColumnName("ShortDescription_Html")
                    .HasMaxLength(1000);

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.Sku)
                    .HasColumnName("SKU")
                    .HasMaxLength(50);

                entity.Property(e => e.SlugName)
                    .IsRequired()
                    .HasColumnName("Slug_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificationHtml)
                    .HasColumnName("Specification_Html")
                    .HasMaxLength(1000);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Style).HasMaxLength(50);

                entity.Property(e => e.Tags).HasMaxLength(1000);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkInventoryItemNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.FkInventoryItem)
                    .HasConstraintName("FK_Product_InventoryItem");

                entity.HasOne(d => d.FkProduct)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.FkProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Category");
            });

            modelBuilder.Entity<ProductComment>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkProductCommentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkProductComment)
                    .WithMany(p => p.InverseFkProductComment)
                    .HasForeignKey(d => d.FkProductCommentId)
                    .HasConstraintName("FK_ProductComment_ProductComment");

                entity.HasOne(d => d.FkProduct)
                    .WithMany(p => p.ProductComment)
                    .HasForeignKey(d => d.FkProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductComment_Product");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FkProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KeyWord).HasMaxLength(1000);

                entity.Property(e => e.MetaData).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();

                entity.Property(e => e.SlugName)
                    .IsRequired()
                    .HasColumnName("Slug_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tags).HasMaxLength(1000);

                entity.Property(e => e.Thumbnail).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.YoutubeLink).HasMaxLength(500);

                entity.HasOne(d => d.FkProduct)
                    .WithMany(p => p.ProductImage)
                    .HasForeignKey(d => d.FkProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductImage_Product");
            });

            modelBuilder.Entity<ProductVersion>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FkInventoryItemDetail)
                    .IsRequired()
                    .HasColumnName("Fk_InventoryItemDetail")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProductId)
                    .IsRequired()
                    .HasColumnName("FK_ProductId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Material)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasColumnName("SKU")
                    .HasMaxLength(50);

                entity.Property(e => e.Style)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FkProduct)
                    .WithMany(p => p.ProductVersion)
                    .HasForeignKey(d => d.FkProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductVersion_Product");
            });

            modelBuilder.Entity<Provine>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ProvineName).HasMaxLength(500);
            });

            modelBuilder.Entity<RequestBuyProduct>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CashAccDate).HasColumnType("datetime");

                entity.Property(e => e.CashAccNote).HasMaxLength(500);

                entity.Property(e => e.CashAccPayPlan).HasColumnType("datetime");

                entity.Property(e => e.ChiefAccDate).HasColumnType("datetime");

                entity.Property(e => e.ChiefAccNote).HasMaxLength(500);

                entity.Property(e => e.ChiefCashDate).HasColumnType("datetime");

                entity.Property(e => e.ChiefCashNote).HasMaxLength(500);

                entity.Property(e => e.ChiefWareHouseAccDate).HasColumnType("datetime");

                entity.Property(e => e.CustomsProcessDate).HasColumnType("datetime");

                entity.Property(e => e.DateNeedGood).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DesignTradeMarkFile).HasMaxLength(500);

                entity.Property(e => e.FactoryFinishDate).HasColumnType("datetime");

                entity.Property(e => e.FkCustomer)
                    .IsRequired()
                    .HasColumnName("FK_Customer")
                    .HasMaxLength(50);

                entity.Property(e => e.FkInventoryItem)
                    .HasColumnName("FK_InventoryItem")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvine)
                    .IsRequired()
                    .HasColumnName("FK_Provine")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestFindProduct)
                    .IsRequired()
                    .HasColumnName("FK_RequestFindProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkStatus).HasColumnName("FK_Status");

                entity.Property(e => e.FkTypeOfBuy).HasColumnName("FK_TypeOfBuy");

                entity.Property(e => e.FkUserCashAcc)
                    .HasColumnName("FK_UserCashAcc")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserChiefAcc)
                    .HasColumnName("FK_UserChiefAcc")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserChiefCashAcc)
                    .HasColumnName("FK_UserChiefCashAcc")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserChiefWareHouseAcc)
                    .HasColumnName("FK_UserChiefWareHouseAcc")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCustomsProcess)
                    .HasColumnName("FK_UserCustomsProcess")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserFlorder)
                    .HasColumnName("FK_UserFLOrder")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserOfprocess)
                    .HasColumnName("FK_UserOFProcess")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserPurchaseAcc)
                    .HasColumnName("FK_UserPurchaseAcc")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserSale)
                    .IsRequired()
                    .HasColumnName("FK_UserSale")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserSaleLeader)
                    .HasColumnName("FK_UserSaleLeader")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserSourceApprover)
                    .HasColumnName("FK_UserSourceApprover")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserSourceProcess)
                    .HasColumnName("FK_UserSourceProcess")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserTruckingProcess)
                    .HasColumnName("FK_UserTruckingProcess")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserWareHouseAcc)
                    .HasColumnName("FK_UserWareHouseAcc")
                    .HasMaxLength(50);

                entity.Property(e => e.FlorderDate)
                    .HasColumnName("FLOrderDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OfprocessDate)
                    .HasColumnName("OFProcessDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PurchaseAccDate).HasColumnType("datetime");

                entity.Property(e => e.PurchaseAccNote).HasMaxLength(500);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.QuantityContainer).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.RequestCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.SaleLeadApproverDate).HasColumnType("datetime");

                entity.Property(e => e.SaleLeadapproverNote).HasMaxLength(500);

                entity.Property(e => e.SaleLeadeApprover).HasMaxLength(50);

                entity.Property(e => e.SalePlan).IsRequired();

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SourApproverNote).HasMaxLength(500);

                entity.Property(e => e.SourceApproverDate).HasColumnType("datetime");

                entity.Property(e => e.SourceProcessDate).HasColumnType("datetime");

                entity.Property(e => e.TradeMark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TruckingProcessDate).HasColumnType("datetime");

                entity.Property(e => e.WareHouseAccDate).HasColumnType("datetime");

                entity.Property(e => e.WareHouseAccNote).HasMaxLength(500);
            });

            modelBuilder.Entity<RequestBuyProductBuyType>(entity =>
            {
                entity.HasKey(e => e.BuyTypeId);

                entity.Property(e => e.BuyTypeId).ValueGeneratedNever();

                entity.Property(e => e.NameBuyType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RequestBuyProductCustoms>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AnotherCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Cost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.FkCcy)
                    .IsRequired()
                    .HasColumnName("FK_CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvider)
                    .IsRequired()
                    .HasColumnName("FK_Provider")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestBuyProduct)
                    .IsRequired()
                    .HasColumnName("FK_RequestBuyProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCreate)
                    .IsRequired()
                    .HasColumnName("Fk_UserCreate")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserUpdate)
                    .HasColumnName("Fk_UserUpdate")
                    .HasMaxLength(50);

                entity.Property(e => e.ImportTax).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.InspectionCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.PublicationCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.VatTax).HasColumnType("decimal(20, 6)");

                entity.HasOne(d => d.FkRequestBuyProductNavigation)
                    .WithMany(p => p.RequestBuyProductCustoms)
                    .HasForeignKey(d => d.FkRequestBuyProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestBuyProductCustoms_RequestBuyProduct");
            });

            modelBuilder.Entity<RequestBuyProductOf>(entity =>
            {
                entity.ToTable("RequestBuyProductOF");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.BorderShippingPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Exwprice)
                    .HasColumnName("EXWPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.FkCcy)
                    .IsRequired()
                    .HasColumnName("FK_CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.FkDestinationPort)
                    .IsRequired()
                    .HasColumnName("FK_DestinationPort")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvider)
                    .IsRequired()
                    .HasColumnName("FK_Provider")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProviderLc)
                    .IsRequired()
                    .HasColumnName("FK_ProviderLC")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestBuyProduct)
                    .IsRequired()
                    .HasColumnName("FK_RequestBuyProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkSourcePort)
                    .IsRequired()
                    .HasColumnName("FK_SourcePort")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCreate)
                    .IsRequired()
                    .HasColumnName("Fk_UserCreate")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserUpdate)
                    .HasColumnName("Fk_UserUpdate")
                    .HasMaxLength(50);

                entity.Property(e => e.Lcprice)
                    .HasColumnName("LCPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Ofprice)
                    .HasColumnName("OFPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkRequestBuyProductNavigation)
                    .WithMany(p => p.RequestBuyProductOf)
                    .HasForeignKey(d => d.FkRequestBuyProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestBuyProductOF_RequestBuyProduct");
            });

            modelBuilder.Entity<RequestBuyProductPayOrder>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Accompanying).HasMaxLength(500);

                entity.Property(e => e.AccountHolder).HasMaxLength(100);

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BankAddress).HasMaxLength(500);

                entity.Property(e => e.BankName).HasMaxLength(500);

                entity.Property(e => e.BranhBank).HasMaxLength(500);

                entity.Property(e => e.Explain).HasMaxLength(500);

                entity.Property(e => e.FkBankAccount)
                    .IsRequired()
                    .HasColumnName("FK_BankAccount")
                    .HasMaxLength(50);

                entity.Property(e => e.FkBankAccountApproved)
                    .IsRequired()
                    .HasColumnName("FK_BankAccountApproved")
                    .HasMaxLength(50);

                entity.Property(e => e.FkPayFor)
                    .IsRequired()
                    .HasColumnName("FK_PayFor")
                    .HasMaxLength(50);

                entity.Property(e => e.FkPrioty).HasColumnName("FK_Prioty");

                entity.Property(e => e.FkRequestBuyProduct)
                    .IsRequired()
                    .HasColumnName("FK_RequestBuyProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkType).HasColumnName("FK_Type");

                entity.Property(e => e.FkUserApprover)
                    .HasColumnName("FK_UserApprover")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserProcess)
                    .HasColumnName("FK_UserProcess")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserRequestPay)
                    .IsRequired()
                    .HasColumnName("FK_UserRequestPay")
                    .HasMaxLength(50);

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PayOrderCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PayPlan).HasColumnType("datetime");

                entity.Property(e => e.RequestPayDate).HasColumnType("datetime");

                entity.Property(e => e.SwiftCode).HasMaxLength(50);

                entity.Property(e => e.UserApproverDate).HasColumnType("datetime");

                entity.Property(e => e.UserApproverNote).HasMaxLength(500);

                entity.Property(e => e.UserProcessDate).HasColumnType("datetime");

                entity.Property(e => e.UserProcessNote).HasMaxLength(500);

                entity.HasOne(d => d.FkRequestBuyProductNavigation)
                    .WithMany(p => p.RequestBuyProductPayOrder)
                    .HasForeignKey(d => d.FkRequestBuyProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestBuyProductPayOrder_RequestBuyProduct");
            });

            modelBuilder.Entity<RequestBuyProductPayOrderPrioty>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PriotyName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RequestBuyProductPayOrderStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RequestBuyProductPayOrderType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RequestBuyProductProvider>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Accessories).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.FkCcy)
                    .IsRequired()
                    .HasColumnName("FK_CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.FkPort)
                    .IsRequired()
                    .HasColumnName("FK_Port")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvider)
                    .IsRequired()
                    .HasColumnName("FK_Provider")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestBuyProduct)
                    .IsRequired()
                    .HasColumnName("FK_RequestBuyProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUnit)
                    .IsRequired()
                    .HasColumnName("FK_Unit")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUnitPacking)
                    .HasColumnName("FK_UnitPacking")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCreate)
                    .IsRequired()
                    .HasColumnName("Fk_UserCreate")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserUpdate)
                    .HasColumnName("Fk_UserUpdate")
                    .HasMaxLength(50);

                entity.Property(e => e.FkWeightUnit)
                    .IsRequired()
                    .HasColumnName("Fk_WeightUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.Packing).HasMaxLength(500);

                entity.Property(e => e.Price).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ProductImage)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.QuantityOfPacking).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TermOfPayment).IsRequired();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.FkRequestBuyProductNavigation)
                    .WithMany(p => p.RequestBuyProductProvider)
                    .HasForeignKey(d => d.FkRequestBuyProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestBuyProductProvider_RequestBuyProduct");
            });

            modelBuilder.Entity<RequestBuyProductProviderMaterial>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FkCcy)
                    .IsRequired()
                    .HasColumnName("FK_CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestBuyProductProvider)
                    .IsRequired()
                    .HasColumnName("FK_RequestBuyProductProvider")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCreate)
                    .IsRequired()
                    .HasColumnName("FK_UserCreate")
                    .HasMaxLength(50);

                entity.Property(e => e.MaterialCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaterialName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Price).HasColumnType("decimal(20, 6)");

                entity.HasOne(d => d.FkRequestBuyProductProviderNavigation)
                    .WithMany(p => p.RequestBuyProductProviderMaterial)
                    .HasForeignKey(d => d.FkRequestBuyProductProvider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestBuyProductProviderMaterial_RequestBuyProductProvider");
            });

            modelBuilder.Entity<RequestBuyProductProviderType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NameProvider)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RequestBuyProductStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RequestBuyProductStockImport>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FkInventoryItemDetail)
                    .IsRequired()
                    .HasColumnName("FK_InventoryItemDetail")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestBuyProduct)
                    .IsRequired()
                    .HasColumnName("FK_RequestBuyProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.Lot)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlanQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<RequestBuyProductTrucking>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLoadGood)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.AnotherCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.FkCcy)
                    .IsRequired()
                    .HasColumnName("FK_CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.FkDestinationPort)
                    .IsRequired()
                    .HasColumnName("FK_DestinationPort")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvider)
                    .IsRequired()
                    .HasColumnName("FK_Provider")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestBuyProduct)
                    .IsRequired()
                    .HasColumnName("FK_RequestBuyProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCreate)
                    .IsRequired()
                    .HasColumnName("Fk_UserCreate")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserUpdate)
                    .HasColumnName("Fk_UserUpdate")
                    .HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Price).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkRequestBuyProductNavigation)
                    .WithMany(p => p.RequestBuyProductTrucking)
                    .HasForeignKey(d => d.FkRequestBuyProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestBuyProductTrucking_RequestBuyProduct");
            });

            modelBuilder.Entity<RequestFindProduct>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.BeginRequestDate).HasColumnType("datetime");

                entity.Property(e => e.CustomsProcessDate).HasColumnType("datetime");

                entity.Property(e => e.Dc20cost)
                    .HasColumnName("DC20Cost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20retailCost)
                    .HasColumnName("DC20RetailCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20retailPercent).HasColumnName("DC20RetailPercent");

                entity.Property(e => e.Dc20retailPrice)
                    .HasColumnName("DC20RetailPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20transferCost)
                    .HasColumnName("DC20TransferCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20wholesaleCost)
                    .HasColumnName("DC20WholesaleCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20wholesalePercent).HasColumnName("DC20WholesalePercent");

                entity.Property(e => e.Dc20wholesalePrice)
                    .HasColumnName("DC20WholesalePrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40cost)
                    .HasColumnName("DC40Cost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hcost)
                    .HasColumnName("DC40HCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hretailCost)
                    .HasColumnName("DC40HRetailCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hretailPercent).HasColumnName("DC40HRetailPercent");

                entity.Property(e => e.Dc40hretailPrice)
                    .HasColumnName("DC40HRetailPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40htransferCost)
                    .HasColumnName("DC40HTransferCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hwholesaleCost)
                    .HasColumnName("DC40HWholesaleCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hwholesalePercent).HasColumnName("DC40HWholesalePercent");

                entity.Property(e => e.Dc40hwholesalePrice)
                    .HasColumnName("DC40HWholesalePrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40retailCost)
                    .HasColumnName("DC40RetailCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40retailPercent).HasColumnName("DC40RetailPercent");

                entity.Property(e => e.Dc40retailPrice)
                    .HasColumnName("DC40RetailPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40transferCost)
                    .HasColumnName("DC40TransferCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40wholesaleCost)
                    .HasColumnName("DC40WholesaleCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40wholesalePercent).HasColumnName("DC40WholesalePercent");

                entity.Property(e => e.Dc40wholesalePrice)
                    .HasColumnName("DC40WholesalePrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DeliveryAddress)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.DemoCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoRetailCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoRetailPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoShippingPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoTransferCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoWholesaleCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoWholesalePrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DesignTradeMarkFile).HasMaxLength(500);

                entity.Property(e => e.EndRequestDate).HasColumnType("datetime");

                entity.Property(e => e.FinishEstimatorDate).HasColumnType("datetime");

                entity.Property(e => e.FkFinishEstimator)
                    .HasColumnName("Fk_FinishEstimator")
                    .HasMaxLength(50);

                entity.Property(e => e.FkInventoryCategory)
                    .IsRequired()
                    .HasColumnName("FK_InventoryCategory")
                    .HasMaxLength(50);

                entity.Property(e => e.FkInventoryItem)
                    .HasColumnName("Fk_InventoryItem")
                    .HasMaxLength(50);

                entity.Property(e => e.FkOpapprover)
                    .HasColumnName("Fk_OPApprover")
                    .HasMaxLength(50);

                entity.Property(e => e.FkOpestimator)
                    .HasColumnName("Fk_OPEstimator")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvine)
                    .IsRequired()
                    .HasColumnName("Fk_Provine")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestPrioty)
                    .HasColumnName("FK_RequestPrioty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FkStatus).HasColumnName("Fk_Status");

                entity.Property(e => e.FkTypeOfRequest).HasColumnName("FK_TypeOfRequest");

                entity.Property(e => e.FkUnit)
                    .HasColumnName("Fk_Unit")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUnitPacking)
                    .HasColumnName("FK_UnitPacking")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCustomsProcess)
                    .HasColumnName("Fk_UserCustomsProcess")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserLcofprocess)
                    .HasColumnName("Fk_UserLCOFProcess")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserRequestApprover)
                    .HasColumnName("Fk_UserRequestApprover")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserSaleRequest)
                    .IsRequired()
                    .HasColumnName("Fk_UserSaleRequest")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserSourceApprover)
                    .HasColumnName("Fk_UserSourceApprover")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserSourceEstimator)
                    .HasColumnName("Fk_UserSourceEstimator")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserSourceProcess)
                    .HasColumnName("Fk_UserSourceProcess")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserTruckingProcess)
                    .HasColumnName("Fk_UserTruckingProcess")
                    .HasMaxLength(50);

                entity.Property(e => e.FkWeightUnit)
                    .IsRequired()
                    .HasColumnName("Fk_WeightUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.IsApproverLcof).HasColumnName("IsApproverLCOF");

                entity.Property(e => e.IsEstimatorLcof).HasColumnName("IsEstimatorLCOF");

                entity.Property(e => e.IsLcofdone).HasColumnName("IsLCOFDone");

                entity.Property(e => e.IsReceptionLcof).HasColumnName("IsReceptionLCOF");

                entity.Property(e => e.Lcofdate)
                    .HasColumnName("LCOFDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MoqCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqRetailCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqRetailPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqShippingPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqTransferCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqWholesaleCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqWholesalePrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.OpapproverDate)
                    .HasColumnName("OPApproverDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpapproverNote).HasColumnName("OPApproverNote");

                entity.Property(e => e.OpestimatorDate)
                    .HasColumnName("OPEstimatorDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpestimatorNote).HasColumnName("OPEstimatorNote");

                entity.Property(e => e.Packing)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ProductNameUnsign).HasMaxLength(500);

                entity.Property(e => e.QuantityOfPacking).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReferRequestFindProduct).HasMaxLength(50);

                entity.Property(e => e.RequestCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RequestImage)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RequestNote).HasMaxLength(1000);

                entity.Property(e => e.SourceApproverDate).HasColumnType("datetime");

                entity.Property(e => e.SourceEstimator).HasColumnType("datetime");

                entity.Property(e => e.SourceProcessDate).HasColumnType("datetime");

                entity.Property(e => e.TradeMark).HasMaxLength(500);

                entity.Property(e => e.TruckingProcessDate).HasColumnType("datetime");

                entity.Property(e => e.UserRequestApproverDate).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WeightFrom).HasMaxLength(50);

                entity.Property(e => e.WeightTo).HasMaxLength(50);

                entity.Property(e => e.WishPrice).HasColumnType("decimal(20, 6)");

                entity.HasOne(d => d.FkStatusNavigation)
                    .WithMany(p => p.RequestFindProduct)
                    .HasForeignKey(d => d.FkStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFindProduct_RequestFindProductStatus");
            });

            modelBuilder.Entity<RequestFindProductCustoms>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AnotherCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Dc20cost)
                    .HasColumnName("DC20Cost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20importTax)
                    .HasColumnName("DC20ImportTax")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20vatTax)
                    .HasColumnName("DC20VatTax")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40cost)
                    .HasColumnName("DC40Cost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hcost)
                    .HasColumnName("DC40HCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40himportTax)
                    .HasColumnName("DC40HImportTax")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hvatTax)
                    .HasColumnName("DC40HVatTax")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40importTax)
                    .HasColumnName("DC40ImportTax")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40vatTax)
                    .HasColumnName("DC40VatTax")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoImportTax).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoVatTax).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.FkCcy)
                    .IsRequired()
                    .HasColumnName("FK_CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvider)
                    .IsRequired()
                    .HasColumnName("FK_Provider")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestFindProduct)
                    .IsRequired()
                    .HasColumnName("Fk_RequestFindProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCreate)
                    .IsRequired()
                    .HasColumnName("Fk_UserCreate")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserUpdate)
                    .HasColumnName("Fk_UserUpdate")
                    .HasMaxLength(50);

                entity.Property(e => e.InspectionCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqImportTax).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqVatTax).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.PublicationCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkRequestFindProductNavigation)
                    .WithMany(p => p.RequestFindProductCustoms)
                    .HasForeignKey(d => d.FkRequestFindProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFindProductCustoms_RequestFindProduct");
            });

            modelBuilder.Entity<RequestFindProductLc>(entity =>
            {
                entity.ToTable("RequestFindProductLC");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLoadGood)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Dc20cost)
                    .HasColumnName("DC20Cost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40cost)
                    .HasColumnName("DC40Cost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hcost)
                    .HasColumnName("DC40HCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.FkCcy)
                    .IsRequired()
                    .HasColumnName("FK_CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvider)
                    .IsRequired()
                    .HasColumnName("FK_Provider")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestFindProduct)
                    .IsRequired()
                    .HasColumnName("Fk_RequestFindProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkSourcePort)
                    .IsRequired()
                    .HasColumnName("FK_SourcePort")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCreate)
                    .IsRequired()
                    .HasColumnName("Fk_UserCreate")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserUpdate)
                    .HasColumnName("Fk_UserUpdate")
                    .HasMaxLength(50);

                entity.Property(e => e.MoqCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkRequestFindProductNavigation)
                    .WithMany(p => p.RequestFindProductLc)
                    .HasForeignKey(d => d.FkRequestFindProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFindProductLC_RequestFindProduct");
            });

            modelBuilder.Entity<RequestFindProductOf>(entity =>
            {
                entity.ToTable("RequestFindProductOF");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Dc20exwprice)
                    .HasColumnName("DC20EXWPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20lcprice)
                    .HasColumnName("DC20LCPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20price)
                    .HasColumnName("DC20Price")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40exwprice)
                    .HasColumnName("DC40EXWPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hexwprice)
                    .HasColumnName("DC40HEXWPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hlcprice)
                    .HasColumnName("DC40HLCPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hprice)
                    .HasColumnName("DC40HPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40lcprice)
                    .HasColumnName("DC40LCPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40price)
                    .HasColumnName("DC40Price")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoExwprice)
                    .HasColumnName("DemoEXWPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoLcprice)
                    .HasColumnName("DemoLCPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoShippingPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.FkCcy)
                    .IsRequired()
                    .HasColumnName("FK_CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.FkDestinationPort)
                    .IsRequired()
                    .HasColumnName("FK_DestinationPort")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvider)
                    .IsRequired()
                    .HasColumnName("FK_Provider")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProviderLc)
                    .IsRequired()
                    .HasColumnName("FK_ProviderLC")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestFindProduct)
                    .IsRequired()
                    .HasColumnName("Fk_RequestFindProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkSourcePort)
                    .IsRequired()
                    .HasColumnName("FK_SourcePort")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCreate)
                    .IsRequired()
                    .HasColumnName("Fk_UserCreate")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserUpdate)
                    .HasColumnName("Fk_UserUpdate")
                    .HasMaxLength(50);

                entity.Property(e => e.MoqExwprice)
                    .HasColumnName("MoqEXWPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqLcprice)
                    .HasColumnName("MoqLCPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqShippingPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkRequestFindProductNavigation)
                    .WithMany(p => p.RequestFindProductOf)
                    .HasForeignKey(d => d.FkRequestFindProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFindProductOF_RequestFindProduct");
            });

            modelBuilder.Entity<RequestFindProductProvider>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Accessories).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Dc20approverSelected).HasColumnName("DC20ApproverSelected");

                entity.Property(e => e.Dc20cifPrice)
                    .HasColumnName("DC20CifPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20exwPrice)
                    .HasColumnName("DC20ExwPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20fobPrice)
                    .HasColumnName("DC20FobPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc20quantity).HasColumnName("DC20Quantity");

                entity.Property(e => e.Dc20selected).HasColumnName("DC20Selected");

                entity.Property(e => e.Dc40approverSelected).HasColumnName("DC40ApproverSelected");

                entity.Property(e => e.Dc40cifPrice)
                    .HasColumnName("DC40CifPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40exwPrice)
                    .HasColumnName("DC40ExwPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40fobPrice)
                    .HasColumnName("DC40FobPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40happroverSelected).HasColumnName("DC40HApproverSelected");

                entity.Property(e => e.Dc40hcifPrice)
                    .HasColumnName("DC40HCifPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hexwPrice)
                    .HasColumnName("DC40HExwPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hfobPrice)
                    .HasColumnName("DC40HFobPrice")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hquantity).HasColumnName("DC40HQuantity");

                entity.Property(e => e.Dc40hselected).HasColumnName("DC40HSelected");

                entity.Property(e => e.Dc40quantity).HasColumnName("DC40Quantity");

                entity.Property(e => e.Dc40selected).HasColumnName("DC40Selected");

                entity.Property(e => e.DemoCifPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoExwPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoFobPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.FkCcy)
                    .IsRequired()
                    .HasColumnName("FK_CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.FkPort)
                    .IsRequired()
                    .HasColumnName("FK_Port")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvider)
                    .IsRequired()
                    .HasColumnName("FK_Provider")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestFindProduct)
                    .IsRequired()
                    .HasColumnName("Fk_RequestFindProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUnit)
                    .IsRequired()
                    .HasColumnName("FK_Unit")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUnitPacking)
                    .HasColumnName("FK_UnitPacking")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCreate)
                    .IsRequired()
                    .HasColumnName("Fk_UserCreate")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserUpdate)
                    .HasColumnName("Fk_UserUpdate")
                    .HasMaxLength(50);

                entity.Property(e => e.FkWeightUnit)
                    .IsRequired()
                    .HasColumnName("Fk_WeightUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.MoqCifPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqExwPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.MoqFobPrice).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Packing).HasMaxLength(500);

                entity.Property(e => e.ProductImage)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.QuantityOfPacking).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TermOfPayment).IsRequired();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.FkRequestFindProductNavigation)
                    .WithMany(p => p.RequestFindProductProvider)
                    .HasForeignKey(d => d.FkRequestFindProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFindProductProvider_RequestFindProduct");
            });

            modelBuilder.Entity<RequestFindProductProviderType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NameProvider)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RequestFindProductStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RequestFindProductTrucking>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLoadGood)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.AnotherCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Dc20cost)
                    .HasColumnName("DC20Cost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40cost)
                    .HasColumnName("DC40Cost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Dc40hcost)
                    .HasColumnName("DC40HCost")
                    .HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DemoCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.FkCcy)
                    .IsRequired()
                    .HasColumnName("FK_CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.FkDestinationPort)
                    .IsRequired()
                    .HasColumnName("FK_DestinationPort")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvider)
                    .IsRequired()
                    .HasColumnName("FK_Provider")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestFindProduct)
                    .IsRequired()
                    .HasColumnName("Fk_RequestFindProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserCreate)
                    .IsRequired()
                    .HasColumnName("Fk_UserCreate")
                    .HasMaxLength(50);

                entity.Property(e => e.FkUserUpdate)
                    .HasColumnName("Fk_UserUpdate")
                    .HasMaxLength(50);

                entity.Property(e => e.MoqCost).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkRequestFindProductNavigation)
                    .WithMany(p => p.RequestFindProductTrucking)
                    .HasForeignKey(d => d.FkRequestFindProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestFindProductTrucking_RequestFindProduct");
            });

            modelBuilder.Entity<RequestFindProductType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RequestProductPrioty>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PriotyName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.HasKey(e => e.ColAutoKey);

                entity.Property(e => e.ColBigInt).HasColumnName("Col_BigInt");

                entity.Property(e => e.ColBit).HasColumnName("Col_Bit");

                entity.Property(e => e.ColDate)
                    .HasColumnName("Col_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ColDatetime)
                    .HasColumnName("Col_Datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ColDecimal180)
                    .HasColumnName("Col_Decimal_18_0")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ColEnum).HasColumnName("Col_Enum");

                entity.Property(e => e.ColFloat).HasColumnName("Col_Float");

                entity.Property(e => e.ColInt).HasColumnName("Col_Int");

                entity.Property(e => e.ColNumeric180)
                    .HasColumnName("Col_Numeric_18_0")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ColNvarchar)
                    .IsRequired()
                    .HasColumnName("Col_NVarchar")
                    .HasMaxLength(50);

                entity.Property(e => e.ColReal).HasColumnName("Col_Real");

                entity.Property(e => e.ColText)
                    .IsRequired()
                    .HasColumnName("Col_Text")
                    .HasColumnType("text");

                entity.Property(e => e.NullColBigInt).HasColumnName("Null_Col_BigInt");

                entity.Property(e => e.NullColBit).HasColumnName("Null_Col_Bit");

                entity.Property(e => e.NullColDate)
                    .HasColumnName("Null_Col_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NullColDatetime)
                    .HasColumnName("Null_Col_Datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.NullColDecimal180)
                    .HasColumnName("Null_Col_Decimal_18_0")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NullColEnum).HasColumnName("Null_Col_Enum");

                entity.Property(e => e.NullColFloat).HasColumnName("Null_Col_Float");

                entity.Property(e => e.NullColInt).HasColumnName("Null_Col_Int");

                entity.Property(e => e.NullColNumeric180)
                    .HasColumnName("Null_Col_Numeric_18_0")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.NullColNvarchar)
                    .HasColumnName("Null_Col_NVarchar")
                    .HasMaxLength(50);

                entity.Property(e => e.NullColReal).HasColumnName("Null_Col_Real");

                entity.Property(e => e.NullColText)
                    .HasColumnName("Null_Col_Text")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(200)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.Property(e => e.StockId)
                    .HasColumnName("StockID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BranchId)
                    .HasColumnName("BranchID")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.InventoryAccount).HasMaxLength(20);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StockCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StockName)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<StockImportOrExport>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreditAccount).HasMaxLength(50);

                entity.Property(e => e.DebitAccount).HasMaxLength(50);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FkCcy)
                    .IsRequired()
                    .HasColumnName("FK_CCY")
                    .HasMaxLength(50);

                entity.Property(e => e.FkChiefUser)
                    .IsRequired()
                    .HasColumnName("FK_ChiefUser")
                    .HasMaxLength(50);

                entity.Property(e => e.FkCreateUser)
                    .IsRequired()
                    .HasColumnName("FK_CreateUser")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProviderOrCustomer)
                    .IsRequired()
                    .HasColumnName("FK_ProviderOrCustomer")
                    .HasMaxLength(50);

                entity.Property(e => e.FkRequestBuyProduct)
                    .IsRequired()
                    .HasColumnName("FK_RequestBuyProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkStockId)
                    .IsRequired()
                    .HasColumnName("FK_StockId")
                    .HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.TotalAmountWithOutTax).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.TotalAmountWithTax).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.TotalTaxAmount).HasColumnType("decimal(20, 6)");

                entity.HasOne(d => d.FkStock)
                    .WithMany(p => p.StockImportOrExport)
                    .HasForeignKey(d => d.FkStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockImportOrExport_Stock");
            });

            modelBuilder.Entity<StockImportOrExportDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualQuantity).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.FkInventoryItem)
                    .IsRequired()
                    .HasColumnName("FK_InventoryItem")
                    .HasMaxLength(50);

                entity.Property(e => e.FkInventoryItemDetailId)
                    .IsRequired()
                    .HasColumnName("FK_InventoryItemDetailId")
                    .HasMaxLength(50);

                entity.Property(e => e.FkStockImporOrExporttId)
                    .IsRequired()
                    .HasColumnName("FK_StockImporOrExporttId")
                    .HasMaxLength(50);

                entity.Property(e => e.FkStockInventoryItemDetail)
                    .HasColumnName("FK_StockInventoryItemDetail")
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Lot)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlanQuantity).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.RealityAmountInStock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TotalAmountWithOutTax).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.TotalDiscount).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitPrice)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FkInventoryItemDetail)
                    .WithMany(p => p.StockImportOrExportDetail)
                    .HasForeignKey(d => d.FkInventoryItemDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockImportOrExportDetail_InventoryItemDetail");

                entity.HasOne(d => d.FkStockImporOrExportt)
                    .WithMany(p => p.StockImportOrExportDetail)
                    .HasForeignKey(d => d.FkStockImporOrExporttId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockImportOrExportDetail_StockImportOrExport");
            });

            modelBuilder.Entity<StockInventoryItemDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ExperiedDate).HasColumnType("datetime");

                entity.Property(e => e.ExportAmount).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.FkInventoryItem)
                    .IsRequired()
                    .HasColumnName("FK_InventoryItem")
                    .HasMaxLength(50);

                entity.Property(e => e.FkInventoryItemDetail)
                    .IsRequired()
                    .HasColumnName("FK_InventoryItemDetail")
                    .HasMaxLength(50);

                entity.Property(e => e.FkStockId)
                    .IsRequired()
                    .HasColumnName("FK_StockID")
                    .HasMaxLength(50);

                entity.Property(e => e.ImportAmount).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.InitAmount).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Lot)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RealityAmount).HasColumnType("decimal(18, 1)");

                entity.HasOne(d => d.FkInventoryItemDetailNavigation)
                    .WithMany(p => p.StockInventoryItemDetail)
                    .HasForeignKey(d => d.FkInventoryItemDetail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockInventoryItemDetail_InventoryItemDetail");

                entity.HasOne(d => d.FkStock)
                    .WithMany(p => p.StockInventoryItemDetail)
                    .HasForeignKey(d => d.FkStockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockInventoryItemDetail_Stock");
            });

            modelBuilder.Entity<SysrefType>(entity =>
            {
                entity.HasKey(e => e.RefType);

                entity.ToTable("SYSRefType");

                entity.Property(e => e.RefType).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DetailTableName).HasMaxLength(50);

                entity.Property(e => e.IsReference)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MasterTableName).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostType).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefTypeName).HasMaxLength(100);

                entity.Property(e => e.SubSystem)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.RefTypeCategoryNavigation)
                    .WithMany(p => p.SysrefType)
                    .HasForeignKey(d => d.RefTypeCategory)
                    .HasConstraintName("FK_SYSRefType_SYSRefTypeCategory");
            });

            modelBuilder.Entity<SysrefTypeCategory>(entity =>
            {
                entity.HasKey(e => e.RefTypeCategory)
                    .HasName("PK_RefTypeCategory");

                entity.ToTable("SYSRefTypeCategory");

                entity.Property(e => e.RefTypeCategory).ValueGeneratedNever();

                entity.Property(e => e.DefaultCreditAccountId)
                    .HasColumnName("DefaultCreditAccountID")
                    .HasMaxLength(20);

                entity.Property(e => e.DefaultDebitAccountId)
                    .HasColumnName("DefaultDebitAccountID")
                    .HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.RefTypeCategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<TableVersion>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModify).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion();
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VoucherReference>(entity =>
            {
                entity.HasKey(e => e.ReferenceId)
                    .HasName("PK_VoucherReference_1");

                entity.Property(e => e.ReferenceId)
                    .HasColumnName("ReferenceID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.RefId1)
                    .HasColumnName("RefID1")
                    .HasMaxLength(50);

                entity.Property(e => e.RefId2)
                    .HasColumnName("RefID2")
                    .HasMaxLength(50);

                entity.Property(e => e.RefNoFinance1).HasMaxLength(100);

                entity.Property(e => e.RefNoFinance2).HasMaxLength(100);

                entity.Property(e => e.RefNoManagement1).HasMaxLength(100);

                entity.Property(e => e.RefNoManagement2).HasMaxLength(100);

                entity.Property(e => e.SortOrder).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VoucherType>(entity =>
            {
                entity.Property(e => e.VoucherTypeId)
                    .HasColumnName("VoucherTypeID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CorrespondingSummary).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreditAccount)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DebitAccount)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherTypeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VoucherTypeName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<VoucherTypeCategory>(entity =>
            {
                entity.HasKey(e => e.VoucherTypeCategory1);

                entity.Property(e => e.VoucherTypeCategory1)
                    .HasColumnName("VoucherTypeCategory")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.VoucherTypeCategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<VoucherTypeCategoryRefType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<WBlog>(entity =>
            {
                entity.ToTable("W_Blog");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.BlogAuthor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BlogDescription).IsRequired();

                entity.Property(e => e.BlogImage)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.BlogName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FkBlogCaterogy)
                    .IsRequired()
                    .HasColumnName("FK_BlogCaterogy")
                    .HasMaxLength(50);

                entity.Property(e => e.MetaDes)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WBlogCaterogy>(entity =>
            {
                entity.ToTable("W_BlogCaterogy");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.BlogCategoryName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MetaDes)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WCategory>(entity =>
            {
                entity.ToTable("W_Category");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryDes).HasMaxLength(500);

                entity.Property(e => e.CategoryIco)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CategoryLinks)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CategoryParent)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MetaDes).HasMaxLength(500);

                entity.Property(e => e.MetaKeyword).HasMaxLength(500);

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WColorOfProduct>(entity =>
            {
                entity.ToTable("W_ColorOfProduct");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ColorImage)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ColorName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WCommerceWebsite>(entity =>
            {
                entity.ToTable("W_CommerceWebsite");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Apikey)
                    .HasColumnName("APIKey")
                    .HasMaxLength(500);

                entity.Property(e => e.LinkUrl).HasMaxLength(500);

                entity.Property(e => e.PartnerId)
                    .HasColumnName("PartnerID")
                    .HasMaxLength(500);

                entity.Property(e => e.Password).HasMaxLength(500);

                entity.Property(e => e.Refix).HasMaxLength(50);

                entity.Property(e => e.SaveSource).HasMaxLength(50);

                entity.Property(e => e.SaveStore).HasMaxLength(50);

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasMaxLength(500);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(500);

                entity.Property(e => e.WebhookUrl).HasMaxLength(500);

                entity.Property(e => e.WebsiteName).HasMaxLength(100);
            });

            modelBuilder.Entity<WContact>(entity =>
            {
                entity.ToTable("W_Contact");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enquiry)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Tag).HasMaxLength(100);

                entity.Property(e => e.YourName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WCustomer>(entity =>
            {
                entity.ToTable("W_Customer");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1).HasMaxLength(500);

                entity.Property(e => e.Address2).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WEmail>(entity =>
            {
                entity.ToTable("W_Email");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WFaq>(entity =>
            {
                entity.ToTable("W_Faq");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Faqquestion)
                    .IsRequired()
                    .HasColumnName("FAQQuestion")
                    .HasMaxLength(1000);

                entity.Property(e => e.Faqreply)
                    .IsRequired()
                    .HasColumnName("FAQReply")
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<WOrder>(entity =>
            {
                entity.ToTable("W_Order");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerPhone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderNote).HasMaxLength(500);

                entity.Property(e => e.Totalmoney).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.WCustomer)
                    .IsRequired()
                    .HasColumnName("W_Customer")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WPostService>(entity =>
            {
                entity.ToTable("W_PostService");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountObjectId)
                    .IsRequired()
                    .HasColumnName("AccountObjectID")
                    .HasMaxLength(50);

                entity.Property(e => e.AddressOfSender).HasMaxLength(500);

                entity.Property(e => e.Apikey)
                    .HasColumnName("APIKey")
                    .HasMaxLength(500);

                entity.Property(e => e.Apipassword)
                    .HasColumnName("APIPassword")
                    .HasMaxLength(100);

                entity.Property(e => e.Apiusername)
                    .HasColumnName("APIUsername")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EmailOfSender).HasMaxLength(500);

                entity.Property(e => e.FkDictrist)
                    .HasColumnName("Fk_Dictrist")
                    .HasMaxLength(50);

                entity.Property(e => e.FkPostApimethod)
                    .IsRequired()
                    .HasColumnName("Fk_PostAPIMethod")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProvine)
                    .HasColumnName("Fk_Provine")
                    .HasMaxLength(50);

                entity.Property(e => e.NameOfSender).HasMaxLength(500);

                entity.Property(e => e.PaymentType).HasMaxLength(50);

                entity.Property(e => e.PhoneOfSender).HasMaxLength(500);

                entity.Property(e => e.PostProviderName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PostType).HasMaxLength(50);

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ServiceCode).HasMaxLength(50);

                entity.Property(e => e.Skapi)
                    .HasColumnName("SKAPI")
                    .HasMaxLength(100);

                entity.Property(e => e.Sl)
                    .HasColumnName("SL")
                    .HasMaxLength(100);

                entity.Property(e => e.Urlapi)
                    .HasColumnName("URLAPI")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<WProduct>(entity =>
            {
                entity.ToTable("W_Product");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FkWcategory)
                    .IsRequired()
                    .HasColumnName("FK_WCategory")
                    .HasMaxLength(50);

                entity.Property(e => e.MetaDes).HasMaxLength(500);

                entity.Property(e => e.MetaKeyword).HasMaxLength(500);

                entity.Property(e => e.MetaTitle).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductDes).IsRequired();

                entity.Property(e => e.ProductDesShor)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ProductImage).HasMaxLength(250);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ProductPriceSale).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Tag).HasMaxLength(500);

                entity.Property(e => e.YoutubeLink).HasMaxLength(100);
            });

            modelBuilder.Entity<WProductAndTag>(entity =>
            {
                entity.HasKey(e => new { e.FkWproduct, e.FkTag })
                    .HasName("PK_W_ProductTag");

                entity.ToTable("W_ProductAndTag");

                entity.Property(e => e.FkWproduct)
                    .HasColumnName("FK_WProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.FkTag)
                    .HasColumnName("FK_Tag")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WProductHotSale>(entity =>
            {
                entity.ToTable("W_ProductHotSale");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateSales).HasColumnType("datetime");

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ProductPriceSale).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.WProductId)
                    .IsRequired()
                    .HasColumnName("W_ProductID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WProductImage>(entity =>
            {
                entity.ToTable("W_ProductImage");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.FkWproduct)
                    .IsRequired()
                    .HasColumnName("FK_WProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<WProductOption>(entity =>
            {
                entity.ToTable("W_ProductOption");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.OptionName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<WProductOptionAndProduct>(entity =>
            {
                entity.HasKey(e => new { e.FkProductOptionId, e.FkProductId });

                entity.ToTable("W_ProductOptionAndProduct");

                entity.Property(e => e.FkProductOptionId)
                    .HasColumnName("FK_ProductOptionID")
                    .HasMaxLength(50);

                entity.Property(e => e.FkProductId)
                    .HasColumnName("FK_ProductID")
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<WReviewOfProduct>(entity =>
            {
                entity.ToTable("W_ReviewOfProduct");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.DateReview).HasColumnType("datetime");

                entity.Property(e => e.FkWproduct)
                    .IsRequired()
                    .HasColumnName("FK_WProduct")
                    .HasMaxLength(50);

                entity.Property(e => e.ReviewContent)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReviewName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<WSetting>(entity =>
            {
                entity.HasKey(e => e.SettingKey);

                entity.ToTable("W_Setting");

                entity.Property(e => e.SettingKey)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<WSlideShow>(entity =>
            {
                entity.ToTable("W_SlideShow");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.NameSlideShow)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SlideShowGroup)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WSlideShowGroup>(entity =>
            {
                entity.ToTable("W_SlideShowGroup");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.SlideShowGroupName).HasMaxLength(500);
            });

            modelBuilder.Entity<WSubMenu>(entity =>
            {
                entity.ToTable("W_SubMenu");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MetaDes)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubMenuDes).IsRequired();

                entity.Property(e => e.WSubMenuGroup)
                    .IsRequired()
                    .HasColumnName("W_SubMenuGroup")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WSubMenuGroup>(entity =>
            {
                entity.ToTable("W_SubMenuGroup");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.SubMenuGroupName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WUser>(entity =>
            {
                entity.ToTable("W_User");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Address2).HasMaxLength(500);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FkGroupUser)
                    .IsRequired()
                    .HasColumnName("FK_GroupUser")
                    .HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WUserGroup>(entity =>
            {
                entity.ToTable("W_UserGroup");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupUserDes).HasMaxLength(500);

                entity.Property(e => e.GroupUserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WeightUnit>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.KgRate).HasColumnType("decimal(18, 12)");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(20);
            });
        }
    }
}
