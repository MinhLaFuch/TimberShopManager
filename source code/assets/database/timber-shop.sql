/*==============================================================*/
/* Database name:  TimberShop                                   */
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/4/2025 2:44:52 PM                          */
/*==============================================================*/

/*==============================================================*/
/* Database: TimberShop                                         */
/*==============================================================*/
create database TimberShop
go

use TimberShop
go

/*==============================================================*/
/* Table: Account                                               */
/*==============================================================*/
create table Account (
   Email                varchar(100)         not null,
   Id                   varchar(20)          not null,
   Password             nvarchar(255)        null,
   IsActivate           bit                  null default 1,
   constraint PK_ACCOUNT primary key (Email)
)
go

/*==============================================================*/
/* Index: HasFk                                                 */
/*==============================================================*/




create nonclustered index HasFk on Account (Id ASC)
go

/*==============================================================*/
/* Table: Accountant                                            */
/*==============================================================*/
create table Accountant (
   Id                   varchar(20)          not null,
   constraint PK_ACCOUNTANT primary key (Id)
)
go

/*==============================================================*/
/* Table: Administrator                                         */
/*==============================================================*/
create table Administrator (
   Id                   varchar(20)          not null,
   constraint PK_ADMINISTRATOR primary key (Id)
)
go

/*==============================================================*/
/* Table: Applied                                               */
/*==============================================================*/
create table Applied (
   VouId                varchar(20)          not null,
   Id                   varchar(20)          not null,
   constraint PK_APPLIED primary key (VouId, Id)
)
go

/*==============================================================*/
/* Index: AppliedFk                                             */
/*==============================================================*/




create nonclustered index AppliedFk on Applied (VouId ASC)
go

/*==============================================================*/
/* Index: AppliedFk2                                            */
/*==============================================================*/




create nonclustered index AppliedFk2 on Applied (Id ASC)
go

/*==============================================================*/
/* Table: Attendance                                            */
/*==============================================================*/
create table Attendance (
   Id                   varchar(20)          not null,
   Date                 datetime             not null,
   Review               nvarchar(255)        null,
   constraint PK_ATTENDANCE primary key (Id, Date)
)
go

/*==============================================================*/
/* Index: AttendFk                                              */
/*==============================================================*/




create nonclustered index AttendFk on Attendance (Id ASC)
go

/*==============================================================*/
/* Table: Category                                              */
/*==============================================================*/
create table Category (
   Id                   varchar(20)          not null,
   Name                 nvarchar(255)        null,
   Description          nvarchar(255)        null,
   IsShow               bit                  null default 1,
   constraint PK_CATEGORY primary key (Id)
)
go

/*==============================================================*/
/* Table: Customer                                              */
/*==============================================================*/
create table Customer (
   PhoneNumber          varchar(20)          not null,
   Name                 nvarchar(255)        null,
   Address              nvarchar(255)        null,
   IsDeleted            bit                  null default 0,
   constraint PK_CUSTOMER primary key (PhoneNumber)
)
go

/*==============================================================*/
/* Table: Employee                                              */
/*==============================================================*/
create table Employee (
   Id                   varchar(20)          not null,
   Name                 nvarchar(255)        null,
   IdentificationNumber nvarchar(255)        null,
   Address              nvarchar(255)        null,
   Birthday             datetime             null 
      constraint CKC_BIRTHDAY_EMPLOYEE check (Birthday is null or (Birthday <= GETDATE())),
   Salary               bigint               null default 0
      constraint CKC_SALARY_EMPLOYEE check (Salary is null or (Salary >= 0)),
   PhoneNumber          nvarchar(255)        null,
   Role                 nvarchar(255)        null default 'Unknown',
   IsDeleted            bit                  null default 0,
   constraint PK_EMPLOYEE primary key (Id)
)
go

/*==============================================================*/
/* Table: ImportDetail                                          */
/*==============================================================*/
create table ImportDetail (
   Id                   varchar(20)          not null,
   ProId                varchar(20)          not null,
   Quantity             int                  null default 0
      constraint CKC_QUANTITY_IMPORTDE check (Quantity is null or (Quantity >= 0)),
   Price                bigint               null default 0
      constraint CKC_PRICE_IMPORTDE check (Price is null or (Price >= 0)),
   Tax                  decimal(5,2)         null default 0
      constraint CKC_TAX_IMPORTDE check (Tax is null or (Tax between 0 and 1)),
   Total                bigint               null default 0
      constraint CKC_TOTAL_IMPORTDE check (Total is null or (Total >= 0)),
   WarrantyDateEnd      datetime             null default GETDATE()
      constraint CKC_WARRANTYDATEEND_IMPORTDE check (WarrantyDateEnd is null or (WarrantyDateEnd >= GETDATE())),
   constraint PK_IMPORTDETAIL primary key (Id, ProId)
)
go

/*==============================================================*/
/* Index: ImportdetailFk                                        */
/*==============================================================*/




create nonclustered index ImportdetailFk on ImportDetail (Id ASC)
go

/*==============================================================*/
/* Index: ImportdetailFk2                                       */
/*==============================================================*/




create nonclustered index ImportdetailFk2 on ImportDetail (ProId ASC)
go

/*==============================================================*/
/* Table: ImportInvoice                                         */
/*==============================================================*/
create table ImportInvoice (
   Id                   varchar(20)          not null,
   SupId                varchar(20)          not null,
   ManId                varchar(20)          not null,
   PaymentDate          datetime             null default GETDATE(),
   TotalPrice           bigint               null default 0
      constraint CKC_TOTALPRICE_IMPORTIN check (TotalPrice is null or (TotalPrice >= 0)),
   PaymentMethod        nvarchar(255)        null,
   constraint PK_IMPORTINVOICE primary key (Id)
)
go

/*==============================================================*/
/* Index: SupplyFk                                              */
/*==============================================================*/




create nonclustered index SupplyFk on ImportInvoice (SupId ASC)
go

/*==============================================================*/
/* Index: ImportFk                                              */
/*==============================================================*/




create nonclustered index ImportFk on ImportInvoice (ManId ASC)
go

/*==============================================================*/
/* Table: Manager                                               */
/*==============================================================*/
create table Manager (
   Id                   varchar(20)          not null,
   constraint PK_MANAGER primary key (Id)
)
go

/*==============================================================*/
/* Table: Product                                               */
/*==============================================================*/
create table Product (
   Id                   varchar(20)          not null,
   CatId                varchar(20)          null,
   Name                 nvarchar(255)        null,
   CalculationUnit      nvarchar(255)        null,
   PriceQuotation       bigint               null default 0
      constraint CKC_PRICEQUOTATION_PRODUCT check (PriceQuotation is null or (PriceQuotation >= 0)),
   Quantity             int                  null default 0
      constraint CKC_QUANTITY_PRODUCT check (Quantity is null or (Quantity >= 0)),
   CustomerWarranty     int                  null default 0
      constraint CKC_CUSTOMERWARRANTY_PRODUCT check (CustomerWarranty is null or (CustomerWarranty >= 0)),
   Description          nvarchar(255)        null,
   IsDeleted            bit                  null default 0,
   constraint PK_PRODUCT primary key (Id)
)
go

/*==============================================================*/
/* Index: IsFk                                                  */
/*==============================================================*/




create nonclustered index IsFk on Product (CatId ASC)
go

/*==============================================================*/
/* Table: SaleAgent                                             */
/*==============================================================*/
create table SaleAgent (
   Id                   varchar(20)          not null,
   constraint PK_SALEAGENT primary key (Id)
)
go

/*==============================================================*/
/* Table: SaleDetail                                            */
/*==============================================================*/
create table SaleDetail (
   ProId                varchar(20)          not null,
   Id                   varchar(20)          not null,
   Quantity             int                  null,
   Price                bigint               null default 0
      constraint CKC_PRICE_SALEDETA check (Price is null or (Price >= 0)),
   Tax                  decimal(5,2)         null default 0
      constraint CKC_TAX_SALEDETA check (Tax is null or (Tax between 0 and 1)),
   Total                bigint               null default 0
      constraint CKC_TOTAL_SALEDETA check (Total is null or (Total >= 0)),
   WarrantyEnd          datetime             null 
      constraint CKC_WARRANTYEND_SALEDETA check (WarrantyEnd is null or (WarrantyEnd >= GETDATE())),
   constraint PK_SALEDETAIL primary key (ProId, Id)
)
go

/*==============================================================*/
/* Index: SaledetailFk                                          */
/*==============================================================*/




create nonclustered index SaledetailFk on SaleDetail (ProId ASC)
go

/*==============================================================*/
/* Index: SaledetailFk2                                         */
/*==============================================================*/




create nonclustered index SaledetailFk2 on SaleDetail (Id ASC)
go

/*==============================================================*/
/* Table: SaleInvoice                                           */
/*==============================================================*/
create table SaleInvoice (
   Id                   varchar(20)          not null,
   PhoneNumber          varchar(20)          not null,
   SalId                varchar(20)          not null,
   PaymentDate          datetime             null default GETDATE(),
   TotalCost            bigint               null default 0
      constraint CKC_TOTALCOST_SALEINVO check (TotalCost is null or (TotalCost >= 0)),
   PaymentMethod        nvarchar(255)        null,
   constraint PK_SALEINVOICE primary key (Id)
)
go

/*==============================================================*/
/* Index: SellFk                                                */
/*==============================================================*/




create nonclustered index SellFk on SaleInvoice (SalId ASC)
go

/*==============================================================*/
/* Index: BuyFk                                                 */
/*==============================================================*/




create nonclustered index BuyFk on SaleInvoice (PhoneNumber ASC)
go

/*==============================================================*/
/* Table: Supplier                                              */
/*==============================================================*/
create table Supplier (
   Id                   varchar(20)          not null,
   Name                 nvarchar(255)        null,
   Address              nvarchar(255)        null,
   ContactNumber        nvarchar(255)        null,
   Email                nvarchar(255)        null,
   Website              nvarchar(255)        null,
   IsDeleted            bit                  null default 0,
   constraint PK_SUPPLIER primary key (Id)
)
go

/*==============================================================*/
/* Table: Voucher                                               */
/*==============================================================*/
create table Voucher (
   Id                   varchar(20)          not null,
   Name                 nvarchar(255)        null,
   StartDate            datetime             null default GETDATE()
      constraint CKC_STARTDATE_VOUCHER check (StartDate is null or (StartDate >= GETDATE())),
   EndDate              datetime             null default GETDATE()
      constraint CKC_ENDDATE_VOUCHER check (EndDate is null or (EndDate >= GETDATE())),
   Discription          nvarchar(255)        null,
   Percentant           decimal(5,2)         null default 0
      constraint CKC_PERCENTANT_VOUCHER check (Percentant is null or (Percentant between 0 and 1)),
   Price                int                  null default 0
      constraint CKC_PRICE_VOUCHER check (Price is null or (Price >= 0)),
   constraint PK_VOUCHER primary key (Id)
)
go

alter table Account
   add constraint FK_ACCOUNT_HAS_EMPLOYEE foreign key (Id)
      references Employee (Id)
go

alter table Accountant
   add constraint FK_ACCOUNTA_ROLE_EMPLOYEE foreign key (Id)
      references Employee (Id)
go

alter table Administrator
   add constraint FK_ADMINIST_ROLE_EMPLOYEE foreign key (Id)
      references Employee (Id)
go

alter table Applied
   add constraint FK_APPLIED_APPLIED_SALEINVO foreign key (Id)
      references SaleInvoice (Id)
go

alter table Applied
   add constraint FK_APPLIED_APPLIED_VOUCHER foreign key (VouId)
      references Voucher (Id)
go

alter table Attendance
   add constraint FK_ATTENDAN_ATTEND_EMPLOYEE foreign key (Id)
      references Employee (Id)
go

alter table ImportDetail
   add constraint FK_IMPORTDE_IMPORTDET_IMPORTIN foreign key (Id)
      references ImportInvoice (Id)
go

alter table ImportDetail
   add constraint FK_IMPORTDE_IMPORTDET_PRODUCT foreign key (ProId)
      references Product (Id)
go

alter table ImportInvoice
   add constraint FK_IMPORTIN_IMPORT_MANAGER foreign key (ManId)
      references Manager (Id)
go

alter table ImportInvoice
   add constraint FK_IMPORTIN_SUPPLY_SUPPLIER foreign key (SupId)
      references Supplier (Id)
go

alter table Manager
   add constraint FK_MANAGER_ROLE_EMPLOYEE foreign key (Id)
      references Employee (Id)
go

alter table Product
   add constraint FK_PRODUCT_IS_CATEGORY foreign key (CatId)
      references Category (Id)
go

alter table SaleAgent
   add constraint FK_SALEAGEN_ROLE_EMPLOYEE foreign key (Id)
      references Employee (Id)
go

alter table SaleDetail
   add constraint FK_SALEDETA_SALEDETAI_PRODUCT foreign key (ProId)
      references Product (Id)
go

alter table SaleDetail
   add constraint FK_SALEDETA_SALEDETAI_SALEINVO foreign key (Id)
      references SaleInvoice (Id)
go

alter table SaleInvoice
   add constraint FK_SALEINVO_BUY_CUSTOMER foreign key (PhoneNumber)
      references Customer (PhoneNumber)
go

alter table SaleInvoice
   add constraint FK_SALEINVO_SELL_SALEAGEN foreign key (SalId)
      references SaleAgent (Id)
go

insert into Employee(Id, Birthday, Role) values ('E000', GETDATE(), N'Quản trị viên');
go
insert into Administrator(Id) values ('E000');
go
insert into Account(Email, Id, Password) values ('admin@timbershop.vn','E000', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3');