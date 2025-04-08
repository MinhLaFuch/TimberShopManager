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
/* Created on:     4/7/2025 1:25:23 PM                          */
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
   where r.fkeyid = object_id('Applied') and o.name = 'FK_APPLIED_APPLIED_DISCOUNT')
alter table Applied
   drop constraint FK_APPLIED_APPLIED_DISCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Applied') and o.name = 'FK_APPLIED_APPLIED_SALEINVO')
alter table Applied
   drop constraint FK_APPLIED_APPLIED_SALEINVO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Attendance') and o.name = 'FK_ATTENDAN_RELATIONS_EMPLOYEE')
alter table Attendance
   drop constraint FK_ATTENDAN_RELATIONS_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Employee') and o.name = 'FK_EMPLOYEE_HAS_ACCOUNT')
alter table Employee
   drop constraint FK_EMPLOYEE_HAS_ACCOUNT
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
   where r.fkeyid = object_id('Manager') and o.name = 'FK_MANAGER_SPECIALIZ_EMPLOYEE')
alter table Manager
   drop constraint FK_MANAGER_SPECIALIZ_EMPLOYEE
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
            and   name  = 'RELATIONSHIP6_FK'
            and   indid > 0
            and   indid < 255)
   drop index Attendance.RELATIONSHIP6_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Attendance')
            and   type = 'U')
   drop table Attendance
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Customer')
            and   type = 'U')
   drop table Customer
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Discount')
            and   type = 'U')
   drop table Discount
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Employee')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index Employee.HAS_FK
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
            from  sysobjects
           where  id = object_id('Manager')
            and   type = 'U')
   drop table Manager
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
   constraint PK_ACCOUNTANT primary key (EmployeeId)
)
go

/*==============================================================*/
/* Table: Administrator                                         */
/*==============================================================*/
create table Administrator (
   EmployeeId           char(10)             not null,
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
   Review               char(256)            null,
   constraint PK_ATTENDANCE primary key (EmployeeId, Date)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP6_FK                                      */
/*==============================================================*/




create nonclustered index RELATIONSHIP6_FK on Attendance (EmployeeId ASC)
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
/* Table: Discount                                              */
/*==============================================================*/
create table Discount (
   DiscountId           char(10)             not null,
   DiscountName         nvarchar(50)         null,
   Type                 nvarchar(50)         null,
   StartTime            datetime             null,
   EndTime              datetime             null,
   StartDate            datetime             null,
   EndDate              datetime             null,
   constraint PK_DISCOUNT primary key (DiscountId)
)
go

/*==============================================================*/
/* Table: Employee                                              */
/*==============================================================*/
create table Employee (
   EmployeeId           char(10)             not null,
   Username             varchar(20)          null,
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
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on Employee (Username ASC)
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
/* Table: Manager                                               */
/*==============================================================*/
create table Manager (
   EmployeeId           char(10)             not null,
   constraint PK_MANAGER primary key (EmployeeId)
)
go

/*==============================================================*/
/* Table: Product                                               */
/*==============================================================*/
create table Product (
   ProductId            char(10)             not null,
   Name                 nvarchar(50)         null,
   CalculationUnit      nvarchar(50)         null,
   PriceQuotation       float                null,
   CustomerWarranty     int                  null,
   Description          nvarchar(256)        null,
   constraint PK_PRODUCT primary key (ProductId)
)
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
   add constraint FK_APPLIED_APPLIED_DISCOUNT foreign key (DiscountId)
      references Discount (DiscountId)
go

alter table Applied
   add constraint FK_APPLIED_APPLIED_SALEINVO foreign key (SaleInvoiceId)
      references SaleInvoice (SaleInvoiceId)
go

alter table Attendance
   add constraint FK_ATTENDAN_RELATIONS_EMPLOYEE foreign key (EmployeeId)
      references Employee (EmployeeId)
go

alter table Employee
   add constraint FK_EMPLOYEE_HAS_ACCOUNT foreign key (Username)
      references Account (Username)
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

alter table Manager
   add constraint FK_MANAGER_SPECIALIZ_EMPLOYEE foreign key (EmployeeId)
      references Employee (EmployeeId)
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

INSERT INTO Product (ProductId, Name, CalculationUnit, PriceQuotation, CustomerWarranty, Description)
VALUES
('P0001', 'Product A', 'Piece', 500, 12, 'High-quality electronic device, ideal for home use.'),
('P0002', 'Product B', 'Piece', 250, 6, 'Durable and affordable item, widely used in households.'),
('P0003', 'Product C', 'Piece', 400, 18, 'Advanced tech gadget with multiple features for professionals.'),
('P0004', 'Product D', 'Box', 300, 24, 'Pack of 10 items, perfect for small businesses.'),
('P0005', 'Product E', 'Piece', 500, 12, 'Stylish and portable, designed for personal use.'),
('P0006', 'Product F', 'Piece', 550, 24, 'Premium product with high performance and durability.'),
('P0007', 'Product G', 'Piece', 600, 12, 'New generation product with the latest technology.'),
('P0008', 'Product H', 'Piece', 400, 18, 'Compact and easy-to-use, suitable for both beginners and experts.'),
('P0009', 'Product I', 'Piece', 700, 6, 'Top-quality item, known for its efficiency and power.'),
('P0010', 'Product J', 'Box', 600, 12, 'Comes in packs of 5, ideal for industrial use.'),
('P0011', 'Product K', 'Piece', 300, 24, 'Affordable and functional for everyday use in various fields.'),
('P0012', 'Product L', 'Piece', 450, 18, 'Multifunctional product designed for professionals in tech.'),
('P0013', 'Product M', 'Piece', 350, 12, 'Perfect for household use, low-cost and high-efficiency.'),
('P0014', 'Product N', 'Piece', 500, 12, 'A reliable product with excellent value for money.'),
('P0015', 'Product O', 'Piece', 550, 24, 'Designed for demanding users who require both quality and performance.'),
('P0016', 'Product P', 'Box', 500, 18, 'A pack of 6, suitable for high-demand operations.'),
('P0017', 'Product Q', 'Piece', 600, 6, 'Compact and powerful, great for everyday tasks.'),
('P0018', 'Product R', 'Piece', 400, 12, 'Efficient and reliable, a top choice for businesses.'),
('P0019', 'Product S', 'Piece', 550, 24, 'High-quality material, designed for professionals and experts.'),
('P0020', 'Product T', 'Piece', 200, 6, 'Economical and efficient for daily use.'),
('P0021', 'Product U', 'Box', 600, 18, 'Ideal for bulk orders, delivers high performance at a low cost.'),
('P0022', 'Product V', 'Piece', 550, 12, 'Stylish and durable, perfect for modern use.'),
('P0023', 'Product W', 'Piece', 400, 18, 'Affordable and functional, suitable for general tasks.'),
('P0024', 'Product X', 'Piece', 450, 6, 'Durable and reliable, designed for tech enthusiasts.'),
('P0025', 'Product Y', 'Piece', 600, 24, 'Compact design with advanced features for professional users.'),
('P0026', 'Product Z', 'Box', 450, 12, 'Affordable and efficient, suitable for general operations.'),
('P0027', 'Product AA', 'Piece', 550, 18, 'Reliable and functional, widely used in different industries.'),
('P0028', 'Product AB', 'Piece', 500, 24, 'Premium quality, high efficiency and long-lasting performance.'),
('P0029', 'Product AC', 'Piece', 550, 12, 'Compact and lightweight, designed for personal use.'),
('P0030', 'Product AD', 'Piece', 600, 18, 'A powerful device, designed for both work and personal use.'),
('P0031', 'Product AE', 'Piece', 300, 6, 'A budget-friendly solution for everyday tasks.'),
('P0032', 'Product AF', 'Piece', 550, 12, 'Stylish, compact, and highly functional product.'),
('P0033', 'Product AG', 'Piece', 600, 24, 'Top-class product, high quality, and long durability.'),
('P0034', 'Product AH', 'Box', 500, 12, 'Pack of 5, designed for industrial and heavy-duty use.'),
('P0035', 'Product AI', 'Piece', 450, 18, 'Affordable and efficient product for general usage.'),
('P0036', 'Product AJ', 'Piece', 500, 24, 'A reliable product, perfect for businesses that need consistency.'),
('P0037', 'Product AK', 'Piece', 350, 12, 'Functional and economical, great for home use.'),
('P0038', 'Product AL', 'Piece', 600, 12, 'Compact, powerful, and versatile product for a variety of tasks.'),
('P0039', 'Product AM', 'Piece', 450, 18, 'Highly functional, easy-to-use, perfect for businesses.'),
('P0040', 'Product AN', 'Box', 550, 24, 'Durable and reliable, pack of 10 for professional use.'),
('P0041', 'Product AO', 'Piece', 300, 6, 'Affordable and high-performing product for day-to-day tasks.'),
('P0042', 'Product AP', 'Piece', 500, 12, 'Designed for demanding users, perfect for technical work.');
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
GO 

use TimberShop;
go
alter table Product
add Quantity int;
GO

update Product
set Quantity = 10

select * from Product
