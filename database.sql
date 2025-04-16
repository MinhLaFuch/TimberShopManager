USE master;
GO
DROP DATABASE TimberShop;
GO

CREATE DATABASE TimberShop;
GO
USE TimberShop;
GO

/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     16/04/2025 8:31:38 pm                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Account') and o.name = 'FK_ACCOUNT_HAS_EMPLOYEE')
alter table Account
   drop constraint FK_ACCOUNT_HAS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Accountant') and o.name = 'FK_ACCOUNTA_SPECIALIZ_EMPLOYEE')
alter table Accountant
   drop constraint FK_ACCOUNTA_SPECIALIZ_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Administrator') and o.name = 'FK_ADMINIST_SPECIALIZ_EMPLOYEE')
alter table Administrator
   drop constraint FK_ADMINIST_SPECIALIZ_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Applied') and o.name = 'FK_APPLIED_APPLIED_SALEINVO')
alter table Applied
   drop constraint FK_APPLIED_APPLIED_SALEINVO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Applied') and o.name = 'FK_APPLIED_APPLIED_VOUCHER')
alter table Applied
   drop constraint FK_APPLIED_APPLIED_VOUCHER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Attendance') and o.name = 'FK_ATTENDAN_ATTEND_EMPLOYEE')
alter table Attendance
   drop constraint FK_ATTENDAN_ATTEND_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ImportDetail') and o.name = 'FK_IMPORTDE_IMPORTDET_IMPORTIN')
alter table ImportDetail
   drop constraint FK_IMPORTDE_IMPORTDET_IMPORTIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ImportDetail') and o.name = 'FK_IMPORTDE_IMPORTDET_PRODUCT')
alter table ImportDetail
   drop constraint FK_IMPORTDE_IMPORTDET_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ImportInvoice') and o.name = 'FK_IMPORTIN_IMPORT_MANAGER')
alter table ImportInvoice
   drop constraint FK_IMPORTIN_IMPORT_MANAGER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ImportInvoice') and o.name = 'FK_IMPORTIN_SUPPLY_SUPPLIER')
alter table ImportInvoice
   drop constraint FK_IMPORTIN_SUPPLY_SUPPLIER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LockedAcocunt') and o.name = 'FK_LOCKEDAC_HAS_DELETEDE')
alter table LockedAcocunt
   drop constraint FK_LOCKEDAC_HAS_DELETEDE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Manager') and o.name = 'FK_MANAGER_SPECIALIZ_EMPLOYEE')
alter table Manager
   drop constraint FK_MANAGER_SPECIALIZ_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Product') and o.name = 'FK_PRODUCT_IS_CATEGORY')
alter table Product
   drop constraint FK_PRODUCT_IS_CATEGORY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ProfitAccounting') and o.name = 'FK_PROFITAC_PROFITREP_ACCOUNTA')
alter table ProfitAccounting
   drop constraint FK_PROFITAC_PROFITREP_ACCOUNTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SalaryAccounting') and o.name = 'FK_SALARYAC_SALARYREP_ACCOUNTA')
alter table SalaryAccounting
   drop constraint FK_SALARYAC_SALARYREP_ACCOUNTA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SaleAgent') and o.name = 'FK_SALEAGEN_SPECIALIZ_EMPLOYEE')
alter table SaleAgent
   drop constraint FK_SALEAGEN_SPECIALIZ_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SaleDetail') and o.name = 'FK_SALEDETA_SALEDETAI_PRODUCT')
alter table SaleDetail
   drop constraint FK_SALEDETA_SALEDETAI_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SaleDetail') and o.name = 'FK_SALEDETA_SALEDETAI_SALEINVO')
alter table SaleDetail
   drop constraint FK_SALEDETA_SALEDETAI_SALEINVO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SaleInvoice') and o.name = 'FK_SALEINVO_BUY_CUSTOMER')
alter table SaleInvoice
   drop constraint FK_SALEINVO_BUY_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SaleInvoice') and o.name = 'FK_SALEINVO_SELL_SALEAGEN')
alter table SaleInvoice
   drop constraint FK_SALEINVO_SELL_SALEAGEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Account')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Account.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Account')
            and   type = 'U')
   drop table Account
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Accountant')
            and   type = 'U')
   drop table Accountant
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Administrator')
            and   type = 'U')
   drop table Administrator
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Applied')
            and   name  = 'APPLIED_FK2'
            and   indid > 0
            and   indid < 255)
   drop index Applied.APPLIED_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Applied')
            and   name  = 'APPLIED_FK'
            and   indid > 0
            and   indid < 255)
   drop index Applied.APPLIED_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Applied')
            and   type = 'U')
   drop table Applied
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Attendance')
            and   name  = 'ATTEND_FK'
            and   indid > 0
            and   indid < 255)
   drop index Attendance.ATTEND_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Attendance')
            and   type = 'U')
   drop table Attendance
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Category')
            and   type = 'U')
   drop table Category
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Customer')
            and   type = 'U')
   drop table Customer
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DeletedCategory')
            and   type = 'U')
   drop table DeletedCategory
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DeletedEmployee')
            and   type = 'U')
   drop table DeletedEmployee
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DeletedProduct')
            and   type = 'U')
   drop table DeletedProduct
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DeletedSupplier')
            and   type = 'U')
   drop table DeletedSupplier
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DeletedVoucher')
            and   type = 'U')
   drop table DeletedVoucher
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Employee')
            and   type = 'U')
   drop table Employee
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ImportDetail')
            and   name  = 'IMPORTDETAIL_FK2'
            and   indid > 0
            and   indid < 255)
   drop index ImportDetail.IMPORTDETAIL_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ImportDetail')
            and   name  = 'IMPORTDETAIL_FK'
            and   indid > 0
            and   indid < 255)
   drop index ImportDetail.IMPORTDETAIL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ImportDetail')
            and   type = 'U')
   drop table ImportDetail
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ImportInvoice')
            and   name  = 'IMPORT_FK'
            and   indid > 0
            and   indid < 255)
   drop index ImportInvoice.IMPORT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ImportInvoice')
            and   name  = 'SUPPLY_FK'
            and   indid > 0
            and   indid < 255)
   drop index ImportInvoice.SUPPLY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ImportInvoice')
            and   type = 'U')
   drop table ImportInvoice
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LockedAcocunt')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LockedAcocunt.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LockedAcocunt')
            and   type = 'U')
   drop table LockedAcocunt
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Manager')
            and   type = 'U')
   drop table Manager
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Product')
            and   name  = 'IS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Product.IS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Product')
            and   type = 'U')
   drop table Product
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ProfitAccounting')
            and   name  = 'PROFITREPORT_FK'
            and   indid > 0
            and   indid < 255)
   drop index ProfitAccounting.PROFITREPORT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ProfitAccounting')
            and   type = 'U')
   drop table ProfitAccounting
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SalaryAccounting')
            and   name  = 'SALARYREPORT_FK'
            and   indid > 0
            and   indid < 255)
   drop index SalaryAccounting.SALARYREPORT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SalaryAccounting')
            and   type = 'U')
   drop table SalaryAccounting
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SaleAgent')
            and   type = 'U')
   drop table SaleAgent
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SaleDetail')
            and   name  = 'SALEDETAIL_FK2'
            and   indid > 0
            and   indid < 255)
   drop index SaleDetail.SALEDETAIL_FK2
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SaleDetail')
            and   name  = 'SALEDETAIL_FK'
            and   indid > 0
            and   indid < 255)
   drop index SaleDetail.SALEDETAIL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SaleDetail')
            and   type = 'U')
   drop table SaleDetail
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SaleInvoice')
            and   name  = 'BUY_FK'
            and   indid > 0
            and   indid < 255)
   drop index SaleInvoice.BUY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SaleInvoice')
            and   name  = 'SELL_FK'
            and   indid > 0
            and   indid < 255)
   drop index SaleInvoice.SELL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SaleInvoice')
            and   type = 'U')
   drop table SaleInvoice
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Supplier')
            and   type = 'U')
   drop table Supplier
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Voucher')
            and   type = 'U')
   drop table Voucher
go

/*==============================================================*/
/* Table: Account                                               */
/*==============================================================*/
create table Account (
   Username             varchar(20)          not null,
   EmployeeId           char(10)             not null,
   Password             char(64)             null,
   constraint PK_ACCOUNT primary key (Username)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on Account (EmployeeId ASC)
go

/*==============================================================*/
/* Table: Accountant                                            */
/*==============================================================*/
create table Accountant (
   EmployeeId           char(10)             not null,
   Name                 nvarchar(50)         null,
   IdentificationNumber char(12)             null,
   Address              nvarchar(256)        null,
   DateOfBirth          datetime             null,
   Salary               float                null,
   Role                 nvarchar(20)         null,
   PhoneNumber          char(10)             null,
   constraint PK_ACCOUNTANT primary key (EmployeeId)
)
go

/*==============================================================*/
/* Table: Administrator                                         */
/*==============================================================*/
create table Administrator (
   EmployeeId           char(10)             not null,
   Name                 nvarchar(50)         null,
   IdentificationNumber char(12)             null,
   Address              nvarchar(256)        null,
   DateOfBirth          datetime             null,
   Salary               float                null,
   Role                 nvarchar(20)         null,
   PhoneNumber          char(10)             null,
   constraint PK_ADMINISTRATOR primary key (EmployeeId)
)
go

/*==============================================================*/
/* Table: Applied                                               */
/*==============================================================*/
create table Applied (
   DiscountId           char(10)             not null,
   SaleInvoiceId        char(10)             not null,
   constraint PK_APPLIED primary key (DiscountId, SaleInvoiceId)
)
go

/*==============================================================*/
/* Index: APPLIED_FK                                            */
/*==============================================================*/




create nonclustered index APPLIED_FK on Applied (DiscountId ASC)
go

/*==============================================================*/
/* Index: APPLIED_FK2                                           */
/*==============================================================*/




create nonclustered index APPLIED_FK2 on Applied (SaleInvoiceId ASC)
go

/*==============================================================*/
/* Table: Attendance                                            */
/*==============================================================*/
create table Attendance (
   EmployeeId           char(10)             not null,
   Date                 datetime             not null,
   Time                 datetime             null,
   Review               char(256)            null,
   constraint PK_ATTENDANCE primary key (EmployeeId, Date)
)
go

/*==============================================================*/
/* Index: ATTEND_FK                                             */
/*==============================================================*/




create nonclustered index ATTEND_FK on Attendance (EmployeeId ASC)
go

/*==============================================================*/
/* Table: Category                                              */
/*==============================================================*/
create table Category (
   CategoryId           char(256)            not null,
   Name                 char(256)            null,
   Description          char(256)            null,
   constraint PK_CATEGORY primary key (CategoryId)
)
go

/*==============================================================*/
/* Table: Customer                                              */
/*==============================================================*/
create table Customer (
   PhoneNumber          char(10)             not null,
   Name                 nvarchar(50)         null,
   Address              nvarchar(256)        null,
   constraint PK_CUSTOMER primary key (PhoneNumber)
)
go

/*==============================================================*/
/* Table: DeletedCategory                                       */
/*==============================================================*/
create table DeletedCategory (
   CategoryId           char(256)            not null,
   Name                 char(256)            null,
   Description          char(256)            null,
   constraint PK_DELETEDCATEGORY primary key (CategoryId)
)
go

/*==============================================================*/
/* Table: DeletedEmployee                                       */
/*==============================================================*/
create table DeletedEmployee (
   EmployeeId           char(10)             not null,
   Name                 char(256)            null,
   IdentificationNumber char(12)             null,
   Address              nvarchar(256)        null,
   DateOfBirth          datetime             null,
   Salary               float                null,
   Role                 nvarchar(20)         null,
   PhoneNumber          char(10)             null,
   constraint PK_DELETEDEMPLOYEE primary key (EmployeeId)
)
go

/*==============================================================*/
/* Table: DeletedProduct                                        */
/*==============================================================*/
create table DeletedProduct (
   ProductId            char(10)             not null,
   Name                 char(256)            null,
   CalculationUnit      nvarchar(50)         null,
   PriceQuotation       float                null,
   CustomerWarranty     int                  null,
   Description          char(256)            null,
   Quantity             int                  null,
   constraint PK_DELETEDPRODUCT primary key (ProductId)
)
go

/*==============================================================*/
/* Table: DeletedSupplier                                       */
/*==============================================================*/
create table DeletedSupplier (
   SupplierId           char(10)             not null,
   Name                 char(256)            null,
   Address              nvarchar(256)        null,
   ContactNumber        char(10)             null,
   Email                varchar(50)          null,
   Website              varchar(50)          null,
   constraint PK_DELETEDSUPPLIER primary key (SupplierId)
)
go

/*==============================================================*/
/* Table: DeletedVoucher                                        */
/*==============================================================*/
create table DeletedVoucher (
   DiscountId           char(10)             not null,
   DiscountName         nvarchar(50)         null,
   Type                 nvarchar(50)         null,
   StartTime            datetime             null,
   EndTime              datetime             null,
   StartDate            datetime             null,
   EndDate              datetime             null,
   constraint PK_DELETEDVOUCHER primary key (DiscountId)
)
go

/*==============================================================*/
/* Table: Employee                                              */
/*==============================================================*/
create table Employee (
   EmployeeId           char(10)             not null,
   Name                 nvarchar(50)         null,
   IdentificationNumber char(12)             null,
   Address              nvarchar(256)        null,
   DateOfBirth          datetime             null,
   Salary               float                null,
   Role                 nvarchar(20)         null,
   PhoneNumber          char(10)             null,
   constraint PK_EMPLOYEE primary key (EmployeeId)
)
go

/*==============================================================*/
/* Table: ImportDetail                                          */
/*==============================================================*/
create table ImportDetail (
   ProductId            char(10)             not null,
   ImportInvoiceId      varchar(50)          not null,
   Quanitty             int                  null,
   Price                float                null,
   Tax                  real                 null,
   Total                float                null,
   WarrantyDateEnd      datetime             null,
   constraint PK_IMPORTDETAIL primary key (ProductId, ImportInvoiceId)
)
go

/*==============================================================*/
/* Index: IMPORTDETAIL_FK                                       */
/*==============================================================*/




create nonclustered index IMPORTDETAIL_FK on ImportDetail (ProductId ASC)
go

/*==============================================================*/
/* Index: IMPORTDETAIL_FK2                                      */
/*==============================================================*/




create nonclustered index IMPORTDETAIL_FK2 on ImportDetail (ImportInvoiceId ASC)
go

/*==============================================================*/
/* Table: ImportInvoice                                         */
/*==============================================================*/
create table ImportInvoice (
   ImportInvoiceId      varchar(50)          not null,
   SupplierId           char(10)             not null,
   EmployeeId           char(10)             not null,
   DateOfPayment        datetime             null,
   TotalPrice           float                null,
   PaymentMethod        nvarchar(50)         null,
   constraint PK_IMPORTINVOICE primary key (ImportInvoiceId)
)
go

/*==============================================================*/
/* Index: SUPPLY_FK                                             */
/*==============================================================*/




create nonclustered index SUPPLY_FK on ImportInvoice (SupplierId ASC)
go

/*==============================================================*/
/* Index: IMPORT_FK                                             */
/*==============================================================*/




create nonclustered index IMPORT_FK on ImportInvoice (EmployeeId ASC)
go

/*==============================================================*/
/* Table: LockedAcocunt                                         */
/*==============================================================*/
create table LockedAcocunt (
   Username             varchar(20)          not null,
   EmployeeId           char(10)             not null,
   Password             char(64)             null,
   constraint PK_LOCKEDACOCUNT primary key (Username)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on LockedAcocunt (EmployeeId ASC)
go

/*==============================================================*/
/* Table: Manager                                               */
/*==============================================================*/
create table Manager (
   EmployeeId           char(10)             not null,
   Name                 nvarchar(50)         null,
   IdentificationNumber char(12)             null,
   Address              nvarchar(256)        null,
   DateOfBirth          datetime             null,
   Salary               float                null,
   Role                 nvarchar(20)         null,
   PhoneNumber          char(10)             null,
   constraint PK_MANAGER primary key (EmployeeId)
)
go

/*==============================================================*/
/* Table: Product                                               */
/*==============================================================*/
create table Product (
   ProductId            char(10)             not null,
   CategoryId           char(256)            null,
   Name                 nvarchar(50)         null,
   CalculationUnit      nvarchar(50)         null,
   PriceQuotation       float                null,
   CustomerWarranty     int                  null,
   Description          nvarchar(256)        null,
   Quantity             int                  null,
   constraint PK_PRODUCT primary key (ProductId)
)
go

/*==============================================================*/
/* Index: IS_FK                                                 */
/*==============================================================*/




create nonclustered index IS_FK on Product (CategoryId ASC)
go

/*==============================================================*/
/* Table: ProfitAccounting                                      */
/*==============================================================*/
create table ProfitAccounting (
   EmployeeId           char(10)             not null,
   Date                 datetime             null,
   Total                float                null
)
go

/*==============================================================*/
/* Index: PROFITREPORT_FK                                       */
/*==============================================================*/




create nonclustered index PROFITREPORT_FK on ProfitAccounting (EmployeeId ASC)
go

/*==============================================================*/
/* Table: SalaryAccounting                                      */
/*==============================================================*/
create table SalaryAccounting (
   EmployeeId           char(10)             not null,
   Date                 datetime             null,
   Total                float                null
)
go

/*==============================================================*/
/* Index: SALARYREPORT_FK                                       */
/*==============================================================*/




create nonclustered index SALARYREPORT_FK on SalaryAccounting (EmployeeId ASC)
go

/*==============================================================*/
/* Table: SaleAgent                                             */
/*==============================================================*/
create table SaleAgent (
   EmployeeId           char(10)             not null,
   Name                 nvarchar(50)         null,
   IdentificationNumber char(12)             null,
   Address              nvarchar(256)        null,
   DateOfBirth          datetime             null,
   Salary               float                null,
   Role                 nvarchar(20)         null,
   PhoneNumber          char(10)             null,
   constraint PK_SALEAGENT primary key (EmployeeId)
)
go

/*==============================================================*/
/* Table: SaleDetail                                            */
/*==============================================================*/
create table SaleDetail (
   SaleInvoiceId        char(10)             not null,
   ProductId            char(10)             not null,
   Quantity             int                  null,
   Price                float                null,
   Tax                  int                  null,
   Total                float                null,
   WarrantyDateEnd      datetime             null,
   constraint PK_SALEDETAIL primary key (SaleInvoiceId, ProductId)
)
go

/*==============================================================*/
/* Index: SALEDETAIL_FK                                         */
/*==============================================================*/




create nonclustered index SALEDETAIL_FK on SaleDetail (SaleInvoiceId ASC)
go

/*==============================================================*/
/* Index: SALEDETAIL_FK2                                        */
/*==============================================================*/




create nonclustered index SALEDETAIL_FK2 on SaleDetail (ProductId ASC)
go

/*==============================================================*/
/* Table: SaleInvoice                                           */
/*==============================================================*/
create table SaleInvoice (
   SaleInvoiceId        char(10)             not null,
   PhoneNumber          char(10)             not null,
   EmployeeId           char(10)             not null,
   DateOfPayment        datetime             null,
   TotalCost            float                null,
   PaymentMethod        nvarchar(50)         null,
   constraint PK_SALEINVOICE primary key (SaleInvoiceId)
)
go

/*==============================================================*/
/* Index: SELL_FK                                               */
/*==============================================================*/




create nonclustered index SELL_FK on SaleInvoice (EmployeeId ASC)
go

/*==============================================================*/
/* Index: BUY_FK                                                */
/*==============================================================*/




create nonclustered index BUY_FK on SaleInvoice (PhoneNumber ASC)
go

/*==============================================================*/
/* Table: Supplier                                              */
/*==============================================================*/
create table Supplier (
   SupplierId           char(10)             not null,
   Name                 nvarchar(50)         null,
   Address              nvarchar(256)        null,
   ContactNumber        char(10)             null,
   Email                varchar(50)          null,
   Website              varchar(50)          null,
   constraint PK_SUPPLIER primary key (SupplierId)
)
go

/*==============================================================*/
/* Table: Voucher                                               */
/*==============================================================*/
create table Voucher (
   DiscountId           char(10)             not null,
   DiscountName         nvarchar(50)         null,
   Type                 nvarchar(50)         null,
   StartTime            datetime             null,
   EndTime              datetime             null,
   StartDate            datetime             null,
   EndDate              datetime             null,
   constraint PK_VOUCHER primary key (DiscountId)
)
go

alter table Account
   add constraint FK_ACCOUNT_HAS_EMPLOYEE foreign key (EmployeeId)
      references Employee (EmployeeId)
go

alter table Accountant
   add constraint FK_ACCOUNTA_SPECIALIZ_EMPLOYEE foreign key (EmployeeId)
      references Employee (EmployeeId)
go

alter table Administrator
   add constraint FK_ADMINIST_SPECIALIZ_EMPLOYEE foreign key (EmployeeId)
      references Employee (EmployeeId)
go

alter table Applied
   add constraint FK_APPLIED_APPLIED_SALEINVO foreign key (SaleInvoiceId)
      references SaleInvoice (SaleInvoiceId)
go

alter table Applied
   add constraint FK_APPLIED_APPLIED_VOUCHER foreign key (DiscountId)
      references Voucher (DiscountId)
go

alter table Attendance
   add constraint FK_ATTENDAN_ATTEND_EMPLOYEE foreign key (EmployeeId)
      references Employee (EmployeeId)
go

alter table ImportDetail
   add constraint FK_IMPORTDE_IMPORTDET_IMPORTIN foreign key (ImportInvoiceId)
      references ImportInvoice (ImportInvoiceId)
go

alter table ImportDetail
   add constraint FK_IMPORTDE_IMPORTDET_PRODUCT foreign key (ProductId)
      references Product (ProductId)
go

alter table ImportInvoice
   add constraint FK_IMPORTIN_IMPORT_MANAGER foreign key (EmployeeId)
      references Manager (EmployeeId)
go

alter table ImportInvoice
   add constraint FK_IMPORTIN_SUPPLY_SUPPLIER foreign key (SupplierId)
      references Supplier (SupplierId)
go

alter table LockedAcocunt
   add constraint FK_LOCKEDAC_HAS_DELETEDE foreign key (EmployeeId)
      references DeletedEmployee (EmployeeId)
go

alter table Manager
   add constraint FK_MANAGER_SPECIALIZ_EMPLOYEE foreign key (EmployeeId)
      references Employee (EmployeeId)
go

alter table Product
   add constraint FK_PRODUCT_IS_CATEGORY foreign key (CategoryId)
      references Category (CategoryId)
go

alter table ProfitAccounting
   add constraint FK_PROFITAC_PROFITREP_ACCOUNTA foreign key (EmployeeId)
      references Accountant (EmployeeId)
go

alter table SalaryAccounting
   add constraint FK_SALARYAC_SALARYREP_ACCOUNTA foreign key (EmployeeId)
      references Accountant (EmployeeId)
go

alter table SaleAgent
   add constraint FK_SALEAGEN_SPECIALIZ_EMPLOYEE foreign key (EmployeeId)
      references Employee (EmployeeId)
go

alter table SaleDetail
   add constraint FK_SALEDETA_SALEDETAI_PRODUCT foreign key (ProductId)
      references Product (ProductId)
go

alter table SaleDetail
   add constraint FK_SALEDETA_SALEDETAI_SALEINVO foreign key (SaleInvoiceId)
      references SaleInvoice (SaleInvoiceId)
go

alter table SaleInvoice
   add constraint FK_SALEINVO_BUY_CUSTOMER foreign key (PhoneNumber)
      references Customer (PhoneNumber)
go

alter table SaleInvoice
   add constraint FK_SALEINVO_SELL_SALEAGEN foreign key (EmployeeId)
      references SaleAgent (EmployeeId)
go




go

INSERT INTO Employee (EmployeeId, Name, IdentificationNumber, Address, DateOfBirth, Salary, Role, PhoneNumber) 
VALUES 
('E0001', 'John Doe', '123456789012', '123 Main St', '1985-06-15', 50000, 'Manager', '1234567890'),
('E0002', 'Jane Smith', '234567890123', '456 Oak St', '1990-02-25', 45000, 'Accountant', '2345678901'),
('E0003', 'Alice Johnson', '345678901234', '789 Pine St', '1992-11-10', 30000, 'Administrator', '3456789012'),
('E0004', 'Bob Brown', '456789012345', '101 Maple St', '1988-03-30', 25000, 'Sale Agent', '4567890123'),
('E0005', 'Charlie White', '567890123456', '202 Birch St', '1991-07-14', 27000, 'Sale Agent', '5678901234'),
('E0006', 'David Green', '678901234567', '303 Cedar St', '1993-09-01', 29000, 'Sale Agent', '6789012345'),
('E0007', 'Eve Black', '789012345678', '404 Elm St', '1987-12-19', 32000, 'Sale Agent', '7890123456'),
('E0008', 'Frank Blue', '890123456789', '505 Ash St', '1989-05-22', 31000, 'Sale Agent', '8901234567'),
('E0009', 'Grace Red', '901234567890', '606 Willow St', '1994-01-12', 28000, 'Sale Agent', '9012345678'),
('E0010', 'Hank Gray', '012345678901', '707 Fir St', '1995-04-09', 30000, 'Sale Agent', '0123456789'),
('E0011', 'Ivy Yellow', '123456789012', '808 Pine St', '1990-06-20', 34000, 'Sale Agent', '1234567890'),
('E0012', 'Jack Silver', '234567890123', '909 Maple St', '1992-02-14', 33000, 'Sale Agent', '2345678901'),
('E0013', 'Kathy Gold', '345678901234', '1010 Cedar St', '1988-10-29', 31000, 'Sale Agent', '3456789012'),
('E0014', 'Leo Copper', '456789012345', '1111 Ash St', '1991-12-05', 32000, 'Sale Agent', '4567890123'),
('E0015', 'Mona Platinum', '567890123456', '1212 Elm St', '1986-11-18', 35000, 'Sale Agent', '5678901234'),
('E0016', 'Nick Diamond', '678901234567', '1313 Oak St', '1989-03-17', 36000, 'Sale Agent', '6789012345'),
('E0017', 'Olivia Ruby', '789012345678', '1414 Willow St', '1990-08-30', 33000, 'Sale Agent', '7890123456'),
('E0018', 'Paul Emerald', '890123456789', '1515 Fir St', '1993-05-02', 31000, 'Sale Agent', '8901234567'),
('E0019', 'Quincy Sapphire', '901234567890', '1616 Birch St', '1992-07-13', 32000, 'Sale Agent', '9012345678'),
('E0020', 'Rita Amethyst', '012345678901', '1717 Maple St', '1994-01-25', 29000, 'Sale Agent', '0123456789');
GO

INSERT INTO Manager (EmployeeId)
VALUES ('E0001');
INSERT INTO Accountant (EmployeeId)
VALUES ('E0002');
INSERT INTO Administrator (EmployeeId)
VALUES ('E0003');
INSERT INTO SaleAgent (EmployeeId)
VALUES 
('E0004'),
('E0005'),
('E0006'),
('E0007'),
('E0008'),
('E0009'),
('E0010'),
('E0011'),
('E0012'),
('E0013'),
('E0014'),
('E0015'),
('E0016'),
('E0017'),
('E0018'),
('E0019'),
('E0020');
GO

INSERT INTO Account (Username, EmployeeId, Password) VALUES
('john.doe', 'E0001', 'pass123'),
('jane.smith', 'E0002', 'pass456'),
('alice.johnson', 'E0003', 'alicepw'),
('bob.brown', 'E0004', 'bobbypw'),
('charlie.white', 'E0005', 'charlie1'),
('david.green', 'E0006', 'green123'),
('eve.black', 'E0007', 'evepass'),
('frank.blue', 'E0008', 'bluepass'),
('grace.red', 'E0009', 'redpass'),
('hank.gray', 'E0010', 'graypass'),
('ivy.yellow', 'E0011', 'ivy123'),
('jack.silver', 'E0012', 'silverpw'),
('kathy.gold', 'E0013', 'goldpass'),
('leo.copper', 'E0014', 'copper1'),
('mona.platinum', 'E0015', 'platinum'),
('nick.diamond', 'E0016', 'diamond1'),
('olivia.ruby', 'E0017', 'ruby123'),
('paul.emerald', 'E0018', 'emerald1'),
('quincy.sapphire', 'E0019', 'sapphire'),
('rita.amethyst', 'E0020', 'amethyst');


INSERT INTO Supplier (SupplierId, Name, Address, ContactNumber, Email, Website)
VALUES
('S0001', 'ABC Supplies Co.', '123 Supply St', '1112233445', 'contact@abc.com', 'www.abc.com'),
('S0002', 'Global Tech Inc.', '456 Tech Ave', '1122334456', 'info@globaltech.com', 'www.globaltech.com'),
('S0003', 'Quality Goods Ltd.', '789 Goods Blvd', '1133445567', 'support@qualitygoods.com', 'www.qualitygoods.com'),
('S0004', 'NextGen Products', '1011 Innovation Dr', '1144556678', 'sales@nextgenproducts.com', 'www.nextgenproducts.com'),
('S0005', 'Green Earth Supplies', '2022 Eco St', '1155667789', 'greenearth@eco.com', 'www.greenearth.com'),
('S0006', 'Fresh Start Ltd.', '3033 Fresh St', '1166778890', 'hello@freshstart.com', 'www.freshstart.com'),
('S0007', 'Techno World', '4044 Tech Park', '1177889901', 'contact@technoworld.com', 'www.technoworld.com'),
('S0008', 'Future Innovations', '5055 Future Rd', '1188991012', 'info@futureinnovations.com', 'www.futureinnovations.com'),
('S0009', 'Prime Supply Inc.', '6066 Prime Blvd', '1199101123', 'support@primesupply.com', 'www.primesupply.com'),
('S0010', 'Global Traders', '7077 Global St', '1200112234', 'contact@globaltraders.com', 'www.globaltraders.com');
GO

-- Thêm dữ liệu cho các hóa đơn nhập hàng từ các nhà cung cấp
INSERT INTO ImportInvoice (ImportInvoiceId, SupplierId, EmployeeId, DateOfPayment, TotalPrice, PaymentMethod)
VALUES
('I0001', 'S0001', 'E0001', '2025-04-01', 50000, 'Bank Transfer'),
('I0002', 'S0001', 'E0001', '2025-04-02', 70000, 'Cash'),
('I0003', 'S0002', 'E0001', '2025-04-05', 45000, 'Credit Card'),
('I0004', 'S0002', 'E0001', '2025-04-07', 62000, 'Bank Transfer'),
('I0005', 'S0002', 'E0001', '2025-04-10', 75000, 'Cash'),
('I0006', 'S0003', 'E0001', '2025-04-12', 40000, 'Bank Transfer'),
('I0007', 'S0003', 'E0001', '2025-04-13', 56000, 'Credit Card'),
('I0008', 'S0003', 'E0001', '2025-04-15', 45000, 'Cash'),
('I0009', 'S0004', 'E0001', '2025-04-16', 69000, 'Bank Transfer'),
('I0010', 'S0004', 'E0001', '2025-04-18', 85000, 'Credit Card'),
('I0011', 'S0004', 'E0001', '2025-04-20', 78000, 'Cash'),
('I0012', 'S0005', 'E0001', '2025-04-22', 60000, 'Bank Transfer'),
('I0013', 'S0005', 'E0001', '2025-04-23', 52000, 'Credit Card'),
('I0014', 'S0006', 'E0001', '2025-04-25', 72000, 'Cash'),
('I0015', 'S0006', 'E0001', '2025-04-27', 65000, 'Bank Transfer'),
('I0016', 'S0007', 'E0001', '2025-04-29', 48000, 'Credit Card'),
('I0017', 'S0007', 'E0001', '2025-04-30', 56000, 'Cash'),
('I0018', 'S0008', 'E0001', '2025-05-02', 90000, 'Bank Transfer'),
('I0019', 'S0008', 'E0001', '2025-05-05', 75000, 'Credit Card'),
('I0020', 'S0009', 'E0001', '2025-05-07', 64000, 'Cash');
GO
INSERT INTO Category (CategoryId, Name, Description)
VALUES
('CAT001', 'Personal Electronics', 'Products designed for personal or home use.'),
('CAT002', 'Business Essentials', 'Items commonly used in small to medium businesses.'),
('CAT003', 'Professional Devices', 'Advanced products for technical and professional tasks.'),
('CAT004', 'Budget Friendly', 'Affordable and cost-effective items for general use.'),
('CAT005', 'Premium Line', 'High-end, durable, and high-performance products.'),
('CAT006', 'Portable & Compact', 'Compact products designed for easy transport and use.'),
('CAT007', 'Household Utilities', 'Products made for regular household tasks.'),
('CAT008', 'Bulk Packages', 'Boxed or multi-pack products for industrial or group use.'),
('CAT009', 'Stylish Design', 'Modern and aesthetically pleasing product designs.'),
('CAT010', 'Heavy Duty Tools', 'Durable items suitable for industrial and intense workloads.');

INSERT INTO Product (ProductId, CategoryId, Name, CalculationUnit, PriceQuotation, CustomerWarranty, Description, Quantity) VALUES
('P0001', 'CAT001', 'EchoWave Speaker', 'Piece', 500, 12, 'High-fidelity Bluetooth speaker designed for home entertainment.', 12),
('P0002', 'CAT007', 'AquaClean Mop', 'Piece', 250, 6, 'Durable spin mop with adjustable handle and water-saving bucket.', 6),
('P0003', 'CAT003', 'ProSketch Tablet', 'Piece', 400, 18, 'Advanced digital drawing tablet for designers and tech professionals.', 18),
('P0004', 'CAT008', 'OfficeSupply Kit', 'Box', 300, 24, 'Box of essential stationery items for small offices.', 24),
('P0005', 'CAT006', 'MiniSmart Projector', 'Piece', 500, 12, 'Compact projector with HD output, perfect for home or travel.', 12),
('P0006', 'CAT005', 'TitanEdge Laptop', 'Piece', 550, 24, 'Premium business laptop with high-performance specs and durability.', 24),
('P0007', 'CAT005', 'Nexus VR Headset', 'Piece', 600, 12, 'Immersive virtual reality headset with motion tracking.', 12),
('P0008', 'CAT006', 'QuickNote Scanner', 'Piece', 400, 18, 'Lightweight document scanner with mobile app support.', 18),
('P0009', 'CAT005', 'HyperCore Processor', 'Piece', 700, 6, 'Top-tier CPU with exceptional multitasking and processing speed.', 6),
('P0010', 'CAT008', 'WorkForce Tool Set', 'Box', 600, 12, 'Box of 5 toolkits designed for small-scale construction jobs.', 12),
('P0011', 'CAT004', 'FlexiLight LED Lamp', 'Piece', 300, 24, 'Adjustable desk lamp with brightness and color temperature control.', 24),
('P0012', 'CAT003', 'TechMaster Router', 'Piece', 450, 18, 'High-speed dual-band Wi-Fi router for professional environments.', 18),
('P0013', 'CAT007', 'HomeGuard Smoke Detector', 'Piece', 350, 12, 'Essential safety device for modern homes, easy installation.', 12),
('P0014', 'CAT004', 'EcoHeat Kettle', 'Piece', 500, 12, 'Energy-efficient electric kettle with auto shut-off feature.', 12),
('P0015', 'CAT005', 'AlphaX Gaming Console', 'Piece', 550, 24, 'Powerful console with 4K graphics and premium build quality.', 24),
('P0016', 'CAT008', 'BulkPrinter Cartridge Set', 'Box', 500, 18, 'Box of 6 toner cartridges for heavy-use office printers.', 18),
('P0017', 'CAT006', 'ZoomMate Webcam', 'Piece', 600, 6, 'Compact HD webcam with built-in mic for video conferencing.', 6),
('P0018', 'CAT002', 'BusinessLink Fax Machine', 'Piece', 400, 12, 'Reliable fax machine built for small business needs.', 12),
('P0019', 'CAT003', 'DevPro Monitor 4K', 'Piece', 550, 24, 'High-resolution monitor with color calibration for creators.', 24),
('P0020', 'CAT004', 'QuickSteam Iron', 'Piece', 200, 6, 'Fast-heating steam iron with safety auto shut-off.', 6),
('P0021', 'CAT008', 'StorageSafe Box Pack', 'Box', 600, 18, 'Bulk pack of durable plastic storage containers.', 18),
('P0022', 'CAT009', 'StyleCharge Powerbank', 'Piece', 550, 12, 'Fashionable fast-charging power bank with LED display.', 12),
('P0023', 'CAT004', 'MultiMate Extension Cord', 'Piece', 400, 18, 'Universal power strip with surge protection.', 18),
('P0024', 'CAT003', 'NanoGrip Mouse', 'Piece', 450, 6, 'Ergonomic, precision mouse designed for tech professionals.', 6),
('P0025', 'CAT003', 'CodePro Keyboard', 'Piece', 600, 24, 'Mechanical keyboard optimized for programmers.', 24),
('P0026', 'CAT008', 'CaféBox Coffee Pods', 'Box', 450, 12, 'Box of 50 assorted coffee pods for office or home.', 12),
('P0027', 'CAT002', 'WorkSmart Label Printer', 'Piece', 550, 18, 'Efficient labeling machine for warehouse and office use.', 18),
('P0028', 'CAT005', 'ForceOne SSD Drive', 'Piece', 500, 24, 'Ultra-fast external SSD with encryption support.', 24),
('P0029', 'CAT006', 'AirSnap Earbuds', 'Piece', 550, 12, 'Lightweight wireless earbuds with noise cancellation.', 12),
('P0030', 'CAT003', 'StreamStation Dock', 'Piece', 600, 18, 'Professional docking station for work-from-home setups.', 18),
('P0031', 'CAT004', 'BudgetCalc Calculator', 'Piece', 300, 6, 'Simple solar-powered calculator for everyday use.', 6),
('P0032', 'CAT009', 'SleekTime Smartwatch', 'Piece', 550, 12, 'Modern smartwatch with fitness and notification tracking.', 12),
('P0033', 'CAT005', 'UltraView Projector', 'Piece', 600, 24, 'High-definition projector designed for large presentations.', 24),
('P0034', 'CAT010', 'HeavyDuty Wrench Set', 'Box', 500, 12, 'Set of 5 industrial-grade wrenches in a tool box.', 12),
('P0035', 'CAT004', 'AllDay Fan', 'Piece', 450, 18, 'Affordable tabletop fan with 3 speed settings.', 18),
('P0036', 'CAT002', 'PrintEdge Pro', 'Piece', 500, 24, 'Fast, high-capacity printer for business environments.', 24),
('P0037', 'CAT007', 'KitchenMax Blender', 'Piece', 350, 12, 'High-efficiency blender for everyday meal prep.', 12),
('P0038', 'CAT006', 'CarryGo Laptop Stand', 'Piece', 600, 12, 'Portable and foldable aluminum stand for laptops.', 12),
('P0039', 'CAT002', 'BizTask Time Clock', 'Piece', 450, 18, 'Employee punch-in system with digital logging.', 18),
('P0040', 'CAT010', 'PowerGrip Drill Kit', 'Box', 550, 24, 'Heavy-duty drill set for construction and maintenance.', 24),
('P0041', 'CAT004', 'Compact Alarm Clock', 'Piece', 300, 6, 'Simple and reliable battery-operated alarm clock.', 6),
('P0042', 'CAT003', 'CodeX Workstation', 'Piece', 500, 12, 'Designed for developers: compact, powerful mini-PC.', 12);

GO

-- Thêm dữ liệu cho bảng ImportDetail
INSERT INTO ImportDetail (ProductId, ImportInvoiceId, Quanitty, Price, Tax, Total, WarrantyDateEnd)
VALUES
('P0001', 'I0001', 10, 500, 5, 5500, '2026-04-01'),
('P0002', 'I0001', 20, 250, 3, 5300, '2026-04-01'),
('P0003', 'I0001', 15, 400, 4, 6000, '2026-04-01'),

('P0004', 'I0002', 12, 300, 4, 4080, '2026-04-03'),
('P0005', 'I0002', 10, 500, 6, 5600, '2026-04-03'),
('P0006', 'I0002', 8, 550, 7, 4944, '2026-04-03'),

('P0007', 'I0003', 5, 600, 8, 3200, '2026-04-06'),
('P0008', 'I0003', 10, 400, 6, 4600, '2026-04-06'),
('P0009', 'I0003', 6, 700, 5, 4020, '2026-04-06'),

('P0010', 'I0004', 8, 600, 5, 4800, '2026-04-09'),
('P0011', 'I0004', 15, 300, 4, 4560, '2026-04-09'),
('P0012', 'I0004', 12, 450, 6, 5580, '2026-04-09'),

('P0013', 'I0005', 20, 250, 4, 5200, '2026-04-11'),
('P0014', 'I0005', 10, 500, 5, 5250, '2026-04-11'),
('P0015', 'I0005', 15, 350, 3, 5250, '2026-04-11'),

('P0016', 'I0006', 8, 500, 4, 4320, '2026-04-14'),
('P0017', 'I0006', 12, 600, 5, 7440, '2026-04-14'),
('P0018', 'I0006', 10, 400, 3, 4600, '2026-04-14'),

('P0019', 'I0007', 15, 350, 4, 5250, '2026-04-16'),
('P0020', 'I0007', 8, 600, 7, 5040, '2026-04-16'),
('P0021', 'I0007', 20, 200, 3, 4600, '2026-04-16'),

('P0022', 'I0008', 10, 550, 5, 5775, '2026-04-18'),
('P0023', 'I0008', 12, 400, 6, 5040, '2026-04-18'),
('P0024', 'I0008', 15, 450, 4, 5130, '2026-04-18'),

('P0025', 'I0009', 8, 500, 6, 4800, '2026-04-21'),
('P0026', 'I0009', 10, 450, 4, 4900, '2026-04-21'),
('P0027', 'I0009', 12, 550, 5, 5940, '2026-04-21'),

('P0028', 'I0010', 15, 300, 5, 4950, '2026-04-24'),
('P0029', 'I0010', 10, 550, 7, 5950, '2026-04-24'),
('P0030', 'I0010', 8, 600, 4, 5280, '2026-04-24'),

('P0031', 'I0011', 20, 200, 3, 4600, '2026-04-26'),
('P0032', 'I0011', 10, 550, 6, 5850, '2026-04-26'),
('P0033', 'I0011', 8, 600, 5, 5400, '2026-04-26'),

('P0034', 'I0012', 8, 500, 5, 4800, '2026-04-29'),
('P0035', 'I0012', 10, 400, 6, 4600, '2026-04-29'),
('P0036', 'I0012', 12, 450, 4, 5580, '2026-04-29'),

('P0037', 'I0013', 15, 350, 5, 5250, '2026-05-01'),
('P0038', 'I0013', 8, 600, 4, 4800, '2026-05-01'),
('P0039', 'I0013', 12, 550, 6, 6600, '2026-05-01'),

('P0040', 'I0014', 10, 450, 5, 4950, '2026-05-03'),
('P0041', 'I0014', 15, 300, 6, 4950, '2026-05-03'),
('P0042', 'I0014', 12, 500, 7, 6000, '2026-05-03');
GO

INSERT INTO Customer (PhoneNumber, Name, Address)
VALUES
('0912345678', 'Alice Nguyen', '123 Main St, Hanoi, Vietnam'),
('0923456789', 'Bob Tran', '456 Oak St, Hanoi, Vietnam'),
('0934567890', 'Charlie Le', '789 Pine St, Ho Chi Minh City, Vietnam'),
('0945678901', 'David Pham', '101 Maple St, Hai Phong, Vietnam'),
('0956789012', 'Eva Huynh', '202 Birch St, Da Nang, Vietnam'),
('0967890123', 'Frank Do', '303 Cedar St, Hanoi, Vietnam'),
('0978901234', 'Grace Lam', '404 Elm St, Ho Chi Minh City, Vietnam'),
('0989012345', 'Hank Nguyen', '505 Ash St, Da Nang, Vietnam'),
('0990123456', 'Ivy Bui', '606 Willow St, Hai Phong, Vietnam'),
('0911122334', 'Jack Vu', '707 Fir St, Hanoi, Vietnam'),
('0922233445', 'Kathy Mai', '808 Pine St, Ho Chi Minh City, Vietnam'),
('0933344556', 'Leo Cao', '909 Maple St, Da Nang, Vietnam'),
('0944455667', 'Mona Phan', '1010 Cedar St, Hai Phong, Vietnam'),
('0955566778', 'Nick Hoang', '1111 Ash St, Hanoi, Vietnam'),
('0966677889', 'Olivia Nguyen', '1212 Elm St, Ho Chi Minh City, Vietnam'),
('0977788990', 'Paul Dao', '1313 Oak St, Da Nang, Vietnam'),
('0988899001', 'Quincy Duong', '1414 Willow St, Hai Phong, Vietnam'),
('0999900112', 'Rita Nguyen', '1515 Fir St, Hanoi, Vietnam'),
('0912345555', 'Sammy Le', '1616 Birch St, Ho Chi Minh City, Vietnam');
GO

INSERT INTO SaleInvoice (SaleInvoiceId, PhoneNumber, EmployeeId, DateOfPayment, TotalCost, PaymentMethod)
VALUES
('SI0001', '0912345678', 'E0004', '2025-04-01', 100000, 'Bank Transfer'),
('SI0002', '0923456789', 'E0005', '2025-04-02', 120000, 'Cash'),
('SI0003', '0934567890', 'E0006', '2025-04-03', 150000, 'Credit Card'),
('SI0004', '0945678901', 'E0007', '2025-04-04', 110000, 'Bank Transfer'),
('SI0005', '0956789012', 'E0008', '2025-04-05', 130000, 'Cash'),
('SI0006', '0967890123', 'E0009', '2025-04-06', 140000, 'Credit Card'),
('SI0007', '0978901234', 'E0010', '2025-04-07', 110000, 'Bank Transfer'),
('SI0008', '0989012345', 'E0011', '2025-04-08', 125000, 'Cash'),
('SI0009', '0990123456', 'E0012', '2025-04-09', 135000, 'Credit Card'),
('SI0010', '0911122334', 'E0013', '2025-04-10', 140000, 'Bank Transfer'),
('SI0011', '0922233445', 'E0014', '2025-04-11', 145000, 'Cash'),
('SI0012', '0933344556', 'E0015', '2025-04-12', 150000, 'Credit Card'),
('SI0013', '0944455667', 'E0016', '2025-04-13', 115000, 'Bank Transfer'),
('SI0014', '0955566778', 'E0017', '2025-04-14', 120000, 'Cash'),
('SI0015', '0966677889', 'E0018', '2025-04-15', 125000, 'Credit Card'),
('SI0016', '0977788990', 'E0019', '2025-04-16', 130000, 'Bank Transfer'),
('SI0017', '0988899001', 'E0020', '2025-04-17', 140000, 'Cash'),
('SI0018', '0999900112', 'E0004', '2025-04-18', 105000, 'Credit Card'),
('SI0019', '0912345555', 'E0005', '2025-04-19', 115000, 'Bank Transfer'),
('SI0020', '0912345555', 'E0006', '2025-04-20', 125000, 'Cash');
GO

-- Thêm dữ liệu cho bảng SaleDetail
INSERT INTO SaleDetail (SaleInvoiceId, ProductId, Quantity, Price, Tax, Total)
VALUES
('SI0001', 'P0001', 2, 500, 5, 1050),
('SI0001', 'P0002', 1, 250, 3, 253),
('SI0001', 'P0003', 3, 400, 4, 1212),
('SI0001', 'P0004', 1, 300, 4, 308),

('SI0002', 'P0005', 2, 500, 5, 1050),
('SI0002', 'P0006', 1, 550, 6, 556),
('SI0002', 'P0007', 2, 600, 7, 1214),
('SI0002', 'P0008', 1, 400, 5, 405),

('SI0003', 'P0009', 3, 700, 5, 2115),
('SI0003', 'P0010', 1, 600, 6, 606),
('SI0003', 'P0011', 1, 300, 4, 308),
('SI0003', 'P0012', 2, 450, 5, 910),

('SI0004', 'P0013', 2, 350, 4, 708),
('SI0004', 'P0014', 1, 500, 5, 505),
('SI0004', 'P0015', 1, 550, 6, 556),
('SI0004', 'P0016', 2, 500, 6, 1012),

('SI0005', 'P0017', 2, 600, 6, 1212),
('SI0005', 'P0018', 1, 400, 4, 404),
('SI0005', 'P0019', 2, 550, 7, 1144),
('SI0005', 'P0020', 1, 200, 3, 203),

('SI0006', 'P0021', 1, 600, 5, 605),
('SI0006', 'P0022', 2, 550, 5, 1110),
('SI0006', 'P0023', 1, 400, 4, 404),
('SI0006', 'P0024', 2, 450, 6, 912),

('SI0007', 'P0025', 1, 500, 4, 504),
('SI0007', 'P0026', 2, 400, 5, 810),
('SI0007', 'P0027', 1, 550, 6, 556),
('SI0007', 'P0028', 2, 600, 6, 1212),

('SI0008', 'P0029', 1, 550, 5, 555),
('SI0008', 'P0030', 2, 600, 6, 1212),
('SI0008', 'P0031', 1, 300, 4, 308),
('SI0008', 'P0032', 1, 550, 6, 556),

('SI0009', 'P0033', 2, 450, 5, 910),
('SI0009', 'P0034', 1, 500, 6, 506),
('SI0009', 'P0035', 1, 450, 5, 457),
('SI0009', 'P0036', 1, 400, 4, 404),

('SI0010', 'P0037', 2, 350, 5, 710),
('SI0010', 'P0038', 1, 600, 5, 605),
('SI0010', 'P0039', 2, 550, 6, 1120),
('SI0010', 'P0040', 1, 500, 6, 506),

('SI0011', 'P0041', 1, 300, 4, 304),
('SI0011', 'P0042', 1, 500, 5, 505),
('SI0011', 'P0001', 2, 500, 5, 1050),
('SI0011', 'P0002', 1, 250, 3, 253),

('SI0012', 'P0013', 2, 350, 4, 708),
('SI0012', 'P0014', 1, 500, 5, 505),
('SI0012', 'P0015', 1, 550, 6, 556),
('SI0012', 'P0016', 2, 500, 6, 1012),

('SI0013', 'P0017', 2, 600, 6, 1212),
('SI0013', 'P0018', 1, 400, 4, 404),
('SI0013', 'P0019', 2, 550, 7, 1144),
('SI0013', 'P0020', 1, 200, 3, 203),

('SI0014', 'P0021', 1, 600, 5, 605),
('SI0014', 'P0022', 2, 550, 5, 1110),
('SI0014', 'P0023', 1, 400, 4, 404),
('SI0014', 'P0024', 2, 450, 6, 912),

('SI0015', 'P0025', 1, 500, 4, 504),
('SI0015', 'P0026', 2, 400, 5, 810),
('SI0015', 'P0027', 1, 550, 6, 556),
('SI0015', 'P0028', 2, 600, 6, 1212),

('SI0016', 'P0029', 1, 550, 5, 555),
('SI0016', 'P0030', 2, 600, 6, 1212),
('SI0016', 'P0031', 1, 300, 4, 308),
('SI0016', 'P0032', 1, 550, 6, 556),

('SI0017', 'P0033', 2, 450, 5, 910),
('SI0017', 'P0034', 1, 500, 6, 506),
('SI0017', 'P0035', 1, 450, 5, 457),
('SI0017', 'P0036', 1, 400, 4, 404),

('SI0018', 'P0037', 2, 350, 5, 710),
('SI0018', 'P0038', 1, 600, 5, 605),
('SI0018', 'P0039', 2, 550, 6, 1120),
('SI0018', 'P0040', 1, 500, 6, 506),

('SI0019', 'P0041', 1, 300, 4, 304),
('SI0019', 'P0042', 1, 500, 5, 505),
('SI0019', 'P0001', 2, 500, 5, 1050),
('SI0019', 'P0002', 1, 250, 3, 253),

('SI0020', 'P0003', 2, 400, 4, 808),
('SI0020', 'P0004', 1, 300, 4, 308),
('SI0020', 'P0005', 3, 500, 5, 1575),
('SI0020', 'P0006', 1, 550, 6, 556);

