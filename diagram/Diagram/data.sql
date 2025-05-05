USE TimberShop
GO

-- EMPLOYEE + ACCOUNT + VAI TRÒ TƯƠNG ỨNG

-- 1. Manager
insert into Employee values ('E001', N'Nguyễn Văn An', '123456789', N'123 Đường Láng, Hà Nội', '1980-05-10', 25000000, '0901234567', N'Manager', 0);
insert into Manager values ('E001');
insert into Account values ('an.nguyen@timbershop.vn', 'E001', 'hashedpassword1', 1);

-- 2. Administrator
insert into Employee values ('E002', N'Lê Thị Mai', '987654321', N'45 Trần Phú, Đà Nẵng', '1985-07-22', 22000000, '0912345678', N'Administrator', 0);
insert into Administrator values ('E002');
insert into Account values ('mai.le@timbershop.vn', 'E002', 'hashedpassword2', 1);

-- 3. Accountant
insert into Employee values ('E003', N'Phạm Minh Đức', '112233445', N'89 Nguyễn Huệ, Huế', '1987-03-15', 20000000, '0938765432', N'Accountant', 0);
insert into Accountant values ('E003');
insert into Account values ('duc.pham@timbershop.vn', 'E003', 'hashedpassword3', 1);

-- 4–14. Sale Agents
insert into Employee values ('E004', N'Trần Quốc Toàn', '223344556', N'10 Lý Thường Kiệt, Hà Nội', '1992-01-10', 12000000, '0912123456', N'Sale Agent', 0);
insert into SaleAgent values ('E004');
insert into Account values ('toan.tran@timbershop.vn', 'E004', 'hashedpassword4', 1);

insert into Employee values ('E005', N'Hoàng Thị Lan', '334455667', N'92 Cách Mạng Tháng 8, Sài Gòn', '1995-08-19', 11500000, '0943234567', N'Sale Agent', 0);
insert into SaleAgent values ('E005');
insert into Account values ('lan.hoang@timbershop.vn', 'E005', 'hashedpassword5', 1);

insert into Employee values ('E006', N'Ngô Văn Bình', '445566778', N'21 Nguyễn Trãi, Hải Phòng', '1991-09-20', 11000000, '0904345678', N'Sale Agent', 0);
insert into SaleAgent values ('E006');
insert into Account values ('binh.ngo@timbershop.vn', 'E006', 'hashedpassword6', 1);

insert into Employee values ('E007', N'Đinh Thị Hương', '556677889', N'54 Quang Trung, Hà Nội', '1996-11-11', 11500000, '0965456789', N'Sale Agent', 0);
insert into SaleAgent values ('E007');
insert into Account values ('huong.dinh@timbershop.vn', 'E007', 'hashedpassword7', 1);

insert into Employee values ('E008', N'Vũ Mạnh Cường', '667788990', N'78 Lê Lợi, Vinh', '1993-04-25', 11800000, '0934567890', N'Sale Agent', 0);
insert into SaleAgent values ('E008');
insert into Account values ('cuong.vu@timbershop.vn', 'E008', 'hashedpassword8', 1);

insert into Employee values ('E009', N'Bùi Thanh Hà', '778899001', N'33 Trường Chinh, Cần Thơ', '1990-12-05', 11700000, '0925678901', N'Sale Agent', 0);
insert into SaleAgent values ('E009');
insert into Account values ('ha.bui@timbershop.vn', 'E009', 'hashedpassword9', 1);

insert into Employee values ('E010', N'Nguyễn Thị Lệ', '889900112', N'26 Phan Đình Phùng, Quảng Ngãi', '1994-06-30', 11300000, '0976789012', N'Sale Agent', 0);
insert into SaleAgent values ('E010');
insert into Account values ('le.nguyen@timbershop.vn', 'E010', 'hashedpassword10', 1);

insert into Employee values ('E011', N'Đoàn Văn Huy', '990011223', N'15 Pasteur, Đà Lạt', '1992-02-14', 11200000, '0987890123', N'Sale Agent', 0);
insert into SaleAgent values ('E011');
insert into Account values ('huy.doan@timbershop.vn', 'E011', 'hashedpassword11', 1);

insert into Employee values ('E012', N'Tống Thị Ngọc', '101112131', N'68 An Dương Vương, Hà Nội', '1996-10-18', 11400000, '0958901234', N'Sale Agent', 0);
insert into SaleAgent values ('E012');
insert into Account values ('ngoc.tong@timbershop.vn', 'E012', 'hashedpassword12', 1);

insert into Employee values ('E013', N'Trịnh Mạnh Hùng', '121314151', N'90 Hùng Vương, TP.HCM', '1993-03-03', 11600000, '0999012345', N'Sale Agent', 0);
insert into SaleAgent values ('E013');
insert into Account values ('hung.trinh@timbershop.vn', 'E013', 'hashedpassword13', 1);

insert into Employee values ('E014', N'Võ Thị Kim Oanh', '131415161', N'32 Nguyễn Khuyến, Huế', '1995-05-05', 11900000, '0940123456', N'Sale Agent', 0);
insert into SaleAgent values ('E014');
insert into Account values ('oanh.vo@timbershop.vn', 'E014', 'hashedpassword14', 1);
GO

-- 1. Nhà cung cấp gỗ nguyên liệu
insert into Supplier values (
   'S001',
   N'Công Ty TNHH Gỗ Minh Long',
   N'Khu công nghiệp Phố Nối A, Hưng Yên',
   '02213876543',
   'contact@minhlongwood.vn',
   'https://minhlongwood.vn',
   0
);

-- 2. Nhà cung cấp ván ép cao cấp
insert into Supplier values (
   'S002',
   N'Công Ty Cổ Phần Ván Ép Việt Á',
   N'Số 12, Đường Số 3, KCN Tân Bình, TP.HCM',
   '02837923456',
   'sales@vietaplywood.com.vn',
   'https://vietaplywood.com.vn',
   0
);

-- 3. Nhà cung cấp gỗ nhập khẩu
insert into Supplier values (
   'S003',
   N'Công Ty TNHH Gỗ Nhập Khẩu Đông Dương',
   N'Lô B3, Đường số 9, KCN Hiệp Phước, Nhà Bè, TP.HCM',
   '02838475678',
   'info@dongduongwood.vn',
   'https://dongduongwood.vn',
   0
);

-- 4. Nhà cung cấp phụ kiện ngành gỗ
insert into Supplier values (
   'S004',
   N'Công Ty TNHH Phụ Kiện Gỗ Hà Thành',
   N'234 Trường Chinh, Đống Đa, Hà Nội',
   '02435781234',
   'support@hathanhwood.vn',
   'https://hathanhwood.vn',
   0
);
GO

insert into Category values (
   'CAT01',
   N'Nguyên vật liệu gỗ',
   N'Bao gồm các loại gỗ tự nhiên, gỗ công nghiệp, ván ép, ván dăm,... dùng trong sản xuất nội thất và xây dựng',
   1
);

insert into Category values (
   'CAT02',
   N'Phụ kiện ngành gỗ',
   N'Phụ kiện hỗ trợ như bản lề, ray trượt, tay nắm, chân bàn,... dùng để hoàn thiện sản phẩm gỗ',
   1
);
GO

insert into Product values 
('P001', 'CAT01', N'Gỗ sồi trắng Mỹ', N'm3', 14500000, 50, 12, N'Gỗ nhập khẩu, bền, màu sáng', 0),
('P002', 'CAT01', N'Gỗ lim Lào', N'm3', 22000000, 35, 10, N'Gỗ cứng, chịu lực tốt', 0),
('P003', 'CAT01', N'Gỗ xoan đào', N'm3', 9800000, 60, 8, N'Gỗ nội địa, giá hợp lý', 0),
('P004', 'CAT01', N'Ván ép phủ phim', N'tấm', 460000, 100, 6, N'Dùng cho cốp pha xây dựng', 0),
('P005', 'CAT01', N'Gỗ thông ghép thanh', N'tấm', 670000, 80, 6, N'Thích hợp làm nội thất', 0),
('P006', 'CAT01', N'Gỗ MDF chống ẩm', N'tấm', 850000, 75, 6, N'Phù hợp môi trường ẩm ướt', 0),
('P007', 'CAT01', N'Ván dăm MFC', N'tấm', 570000, 90, 6, N'Ván công nghiệp phủ Melamine', 0),
('P008', 'CAT01', N'Gỗ tràm bông vàng', N'm3', 8200000, 40, 8, N'Dùng đóng pallet và nội thất', 0),
('P009', 'CAT01', N'Gỗ cao su ghép', N'tấm', 600000, 120, 6, N'Rẻ, bền, ứng dụng cao', 0),
('P010', 'CAT01', N'Gỗ hương Nam Phi', N'm3', 28000000, 25, 10, N'Cao cấp, mùi thơm đặc trưng', 0),
('P011', 'CAT02', N'Bản lề giảm chấn', N'cái', 23000, 200, 3, N'Dùng cho tủ bếp, cửa gỗ', 0),
('P012', 'CAT02', N'Tay nắm cửa tủ hợp kim', N'cái', 17000, 300, 3, N'Thiết kế hiện đại, dễ lắp', 0),
('P013', 'CAT02', N'Ray trượt bi 3 tầng', N'bộ', 45000, 180, 3, N'Dùng cho ngăn kéo trượt nhẹ', 0),
('P014', 'CAT02', N'Chân bàn gỗ tròn', N'cái', 75000, 150, 3, N'Dùng làm bàn ăn, bàn làm việc', 0),
('P015', 'CAT01', N'Tấm gỗ plywood chống nước', N'tấm', 980000, 60, 6, N'Độ bền cao, không cong vênh', 0),
('P016', 'CAT01', N'Ván dăm lõi xanh', N'tấm', 890000, 50, 6, N'Chống ẩm tốt, nội thất bếp', 0),
('P017', 'CAT02', N'Decking gỗ nhựa ngoài trời', N'mét', 120000, 100, 5, N'Dùng cho sân vườn, ban công', 0),
('P018', 'CAT01', N'Gỗ óc chó Mỹ', N'm3', 32000000, 20, 10, N'Cao cấp, màu đẹp, dễ gia công', 0),
('P019', 'CAT01', N'Gỗ teak Myanmar', N'm3', 34000000, 18, 12, N'Chịu nước, không mối mọt', 0),
('P020', 'CAT01', N'Ván ép phủ keo Phenol', N'tấm', 780000, 70, 6, N'Tăng độ bền ngoài trời', 0),
('P021', 'CAT01', N'Gỗ sồi đỏ Mỹ', N'm3', 15000000, 40, 10, N'Mềm hơn sồi trắng, dễ tạo hình', 0),
('P022', 'CAT02', N'Tay nâng tủ bếp', N'bộ', 135000, 50, 3, N'Tiện dụng cho tủ treo', 0),
('P023', 'CAT01', N'Gỗ gõ đỏ', N'm3', 36000000, 15, 12, N'Gỗ quý, vân đẹp, độ bền cao', 0);
GO

insert into ImportInvoice values ('IMP001', 'S001', 'E001', '2025-03-01', 58400000, N'Tiền mặt');
insert into ImportInvoice values ('IMP002', 'S002', 'E001', '2025-03-03', 43800000, N'Chuyển khoản');
insert into ImportInvoice values ('IMP003', 'S003', 'E001', '2025-03-07', 65000000, N'Tiền mặt');
insert into ImportInvoice values ('IMP004', 'S004', 'E001', '2025-03-10', 22500000, N'Chuyển khoản');
insert into ImportInvoice values ('IMP005', 'S001', 'E001', '2025-03-14', 47000000, N'Chuyển khoản');
insert into ImportInvoice values ('IMP006', 'S002', 'E001', '2025-03-18', 51000000, N'Tiền mặt');
insert into ImportInvoice values ('IMP007', 'S003', 'E001', '2025-03-21', 38800000, N'Chuyển khoản');
GO

-- IMP001: 3 sản phẩm
insert into ImportDetail values ('IMP001', 'P001', 5, 14500000, 0.1, 72500000, '2026-03-01');
insert into ImportDetail values ('IMP001', 'P004', 20, 460000, 0.05, 9660000, '2026-03-01');
insert into ImportDetail values ('IMP001', 'P008', 3, 8200000, 0.08, 26592000, '2026-03-01');

-- IMP002: 4 sản phẩm
insert into ImportDetail values ('IMP002', 'P006', 10, 850000, 0.05, 8925000, '2026-03-03');
insert into ImportDetail values ('IMP002', 'P009', 15, 600000, 0.05, 9450000, '2026-03-03');
insert into ImportDetail values ('IMP002', 'P014', 30, 75000, 0.03, 2325000, '2026-03-03');
insert into ImportDetail values ('IMP002', 'P017', 20, 120000, 0.04, 2496000, '2026-03-03');

-- IMP003: 5 sản phẩm
insert into ImportDetail values ('IMP003', 'P002', 2, 22000000, 0.1, 48400000, '2026-03-07');
insert into ImportDetail values ('IMP003', 'P018', 1, 32000000, 0.1, 35200000, '2026-03-07');
insert into ImportDetail values ('IMP003', 'P013', 50, 45000, 0.02, 2295000, '2026-03-07');
insert into ImportDetail values ('IMP003', 'P011', 100, 23000, 0.03, 2369000, '2026-03-07');
insert into ImportDetail values ('IMP003', 'P005', 10, 670000, 0.05, 7035000, '2026-03-07');

-- IMP004: 2 sản phẩm
insert into ImportDetail values ('IMP004', 'P012', 80, 17000, 0.03, 1402400, '2026-03-10');
insert into ImportDetail values ('IMP004', 'P022', 20, 135000, 0.04, 2808000, '2026-03-10');

-- IMP005: 3 sản phẩm
insert into ImportDetail values ('IMP005', 'P003', 6, 9800000, 0.07, 62832000, '2026-03-14');
insert into ImportDetail values ('IMP005', 'P015', 10, 980000, 0.05, 10290000, '2026-03-14');
insert into ImportDetail values ('IMP005', 'P020', 5, 780000, 0.05, 4095000, '2026-03-14');

-- IMP006: 3 sản phẩm
insert into ImportDetail values ('IMP006', 'P007', 8, 570000, 0.03, 4692000, '2026-03-18');
insert into ImportDetail values ('IMP006', 'P010', 2, 28000000, 0.1, 61600000, '2026-03-18');
insert into ImportDetail values ('IMP006', 'P016', 6, 890000, 0.04, 5558400, '2026-03-18');

-- IMP007: 3 sản phẩm
insert into ImportDetail values ('IMP007', 'P021', 3, 15000000, 0.08, 48600000, '2026-03-21');
insert into ImportDetail values ('IMP007', 'P023', 1, 36000000, 0.1, 39600000, '2026-03-21');
insert into ImportDetail values ('IMP007', 'P019', 2, 34000000, 0.1, 74800000, '2026-03-21');
GO

insert into Customer values (
   '0905123456',
   N'Nguyễn Thị Hằng',
   N'142 Nguyễn Văn Cừ, Long Biên, Hà Nội',
   0
);

insert into Customer values (
   '0938765432',
   N'Trần Minh Quân',
   N'25 Lê Duẩn, Quận 1, TP.HCM',
   0
);

insert into Customer values (
   '0912456789',
   N'Lê Thị Thanh Tuyền',
   N'89 Pasteur, Quận 3, TP.HCM',
   0
);

insert into Customer values (
   '0967981324',
   N'Phạm Văn Hậu',
   N'70 Điện Biên Phủ, Thanh Khê, Đà Nẵng',
   0
);
GO

insert into SaleInvoice values (
   'SI001',
   '0905123456',
   'E004',
   '2025-04-10',
   12500000,
   N'Tiền mặt'
);

insert into SaleInvoice values (
   'SI002',
   '0912456789',
   'E005',
   '2025-04-12',
   21400000,
   N'Chuyển khoản'
);
GO

-- SI001 gồm 2 sản phẩm: P009 (Gỗ cao su ghép), P011 (Bản lề giảm chấn)
insert into SaleDetail values ('P009', 'SI001', 10, 600000, 0.05, 6300000, '2026-04-10');
insert into SaleDetail values ('P011', 'SI001', 100, 23000, 0.03, 2369000, '2026-04-10');

-- SI002 gồm 3 sản phẩm: P001 (Gỗ sồi trắng Mỹ), P012 (Tay nắm cửa), P017 (Decking gỗ nhựa)
insert into SaleDetail values ('P001', 'SI002', 1, 14500000, 0.1, 15950000, '2026-04-12');
insert into SaleDetail values ('P012', 'SI002', 30, 17000, 0.03, 526500, '2026-04-12');
insert into SaleDetail values ('P017', 'SI002', 20, 120000, 0.04, 2496000, '2026-04-12');
GO

-- 15–21. Sale Agents (Không có account)
insert into Employee values ('E015', N'Nguyễn Văn Tài', '141516171', N'12 Hoàng Diệu, Hà Nội', '1991-05-20', 11500000, '0912345000', N'Sale Agent', 0);
insert into SaleAgent values ('E015');

insert into Employee values ('E016', N'Lê Thị Hạnh', '151617181', N'88 Trần Hưng Đạo, TP.HCM', '1993-03-10', 11700000, '0923456001', N'Sale Agent', 0);
insert into SaleAgent values ('E016');

insert into Employee values ('E017', N'Trương Quốc Bảo', '161718192', N'56 Nguyễn Văn Linh, Đà Nẵng', '1992-09-18', 11300000, '0934567002', N'Sale Agent', 0);
insert into SaleAgent values ('E017');

insert into Employee values ('E018', N'Phạm Thị Ngân', '171819203', N'34 Nguyễn Huệ, Huế', '1994-08-25', 11400000, '0945678003', N'Sale Agent', 0);
insert into SaleAgent values ('E018');

insert into Employee values ('E019', N'Hoàng Văn Đức', '181920214', N'76 Phan Chu Trinh, Hải Phòng', '1990-07-14', 11600000, '0956789004', N'Sale Agent', 0);
insert into SaleAgent values ('E019');

insert into Employee values ('E020', N'Đặng Thị Tuyết', '192021225', N'123 Lê Lợi, Vinh', '1996-12-05', 11200000, '0967890005', N'Sale Agent', 0);
insert into SaleAgent values ('E020');

insert into Employee values ('E021', N'Bùi Quang Minh', '202122236', N'101 Trường Chinh, Cần Thơ', '1995-11-11', 11000000, '0978901006', N'Sale Agent', 0);
insert into SaleAgent values ('E021');
GO

DECLARE @StartDate DATE = '2025-03-01';
DECLARE @EndDate DATE = '2025-03-31';

DECLARE @EmpId VARCHAR(20);
DECLARE @CurrentDate DATE;

DECLARE @RandInMin INT;
DECLARE @RandOutMin INT;

DECLARE @CheckIn DATETIME;
DECLARE @CheckOut DATETIME;
DECLARE @ReviewIn NVARCHAR(255);
DECLARE @ReviewOut NVARCHAR(255);

DECLARE emp_cursor CURSOR FOR
SELECT Id FROM Employee WHERE IsDeleted = 0;

OPEN emp_cursor;
FETCH NEXT FROM emp_cursor INTO @EmpId;

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @CurrentDate = @StartDate;

    WHILE @CurrentDate <= @EndDate
    BEGIN
        -- Khoảng 15% nghỉ không chấm công
        IF NOT(RAND() < 0.15)
        BEGIN
            -- Sinh thời gian check-in (-15 đến +60 phút từ 8h)
            SET @RandInMin = CAST(RAND() * 75 - 15 AS INT);
            SET @CheckIn = DATEADD(MINUTE, @RandInMin, CAST(@CurrentDate AS DATETIME) + '08:00');

            -- Sinh thời gian check-out (-30 đến +15 phút từ 17h)
            SET @RandOutMin = CAST(RAND() * 45 - 30 AS INT);
            SET @CheckOut = DATEADD(MINUTE, @RandOutMin, CAST(@CurrentDate AS DATETIME) + '17:00');

            -- Review check-in
            IF @RandInMin < -5
                SET @ReviewIn = N'Check-in: Đến sớm';
            ELSE IF @RandInMin <= 5
                SET @ReviewIn = N'Check-in: Đúng giờ';
            ELSE
                SET @ReviewIn = N'Check-in: Đi muộn';

            -- Review check-out
            IF @RandOutMin < -5
                SET @ReviewOut = N'Check-out: Về sớm';
            ELSE
                SET @ReviewOut = N'Check-out: Về đúng giờ';

            -- Insert bản ghi check-in
            INSERT INTO Attendance (Id, Date, Review)
            VALUES (@EmpId, @CheckIn, @ReviewIn);

            -- Insert bản ghi check-out
            INSERT INTO Attendance (Id, Date, Review)
            VALUES (@EmpId, @CheckOut, @ReviewOut);
        END

        SET @CurrentDate = DATEADD(DAY, 1, @CurrentDate);
    END

    FETCH NEXT FROM emp_cursor INTO @EmpId;
END

CLOSE emp_cursor;
DEALLOCATE emp_cursor;
GO

INSERT INTO Voucher (Id, Name, StartDate, EndDate, Discription, Percentant, Price)
VALUES 
('VOUCHER01', N'Giảm 10% cho đơn hàng đầu tiên', GETDATE(), DATEADD(DAY, 30, GETDATE()), N'Áp dụng cho khách hàng mới', 0.10, 0);

INSERT INTO Voucher (Id, Name, StartDate, EndDate, Discription, Percentant, Price)
VALUES 
('VOUCHER02', N'Giảm 50000 VNĐ cho đơn từ 500k', GETDATE(), DATEADD(DAY, 60, GETDATE()), N'Áp dụng đơn hàng từ 500,000 VNĐ', 0.00, 50000);

INSERT INTO Voucher (Id, Name, StartDate, EndDate, Discription, Percentant, Price)
VALUES 
('VOUCHER03', N'Ưu đãi hè 20%', GETDATE(), DATEADD(DAY, 45, GETDATE()), N'Giảm giá mùa hè cho tất cả sản phẩm', 0.20, 0);

INSERT INTO Voucher (Id, Name, StartDate, EndDate, Discription, Percentant, Price)
VALUES 
('VOUCHER04', N'Giảm 100000 VNĐ cho VIP', GETDATE(), DATEADD(DAY, 90, GETDATE()), N'Ưu đãi đặc biệt dành cho khách VIP', 0.00, 100000);
GO

DECLARE @CustomerPhone VARCHAR(20);
DECLARE @SaleAgentId VARCHAR(20);
DECLARE @InvoiceId VARCHAR(20);
DECLARE @InvoiceCount INT;
DECLARE @CurrentDate DATETIME = GETDATE();
DECLARE @ProductId VARCHAR(20);
DECLARE @Quantity INT;
DECLARE @Price BIGINT;
DECLARE @Tax DECIMAL(5,2);
DECLARE @Total BIGINT;
DECLARE @WarrantyEnd DATETIME;
DECLARE @InvoiceIndex INT = 100; -- Starting from 100 to avoid conflicts

-- Cursor to iterate over active customers
DECLARE customer_cursor CURSOR FOR
SELECT PhoneNumber FROM Customer WHERE IsDeleted = 0;

OPEN customer_cursor;
FETCH NEXT FROM customer_cursor INTO @CustomerPhone;

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Generate random invoice count (2–5)
    SET @InvoiceCount = FLOOR(RAND() * 4) + 2;

    DECLARE @i INT = 1;

    WHILE @i <= @InvoiceCount
    BEGIN
        SET @InvoiceId = CONCAT('SI', FORMAT(@InvoiceIndex, '000'));
        SET @InvoiceIndex += 1;

        -- Pick a random SaleAgent
        SELECT TOP 1 @SaleAgentId = Id FROM SaleAgent ORDER BY NEWID();

        INSERT INTO SaleInvoice (Id, PhoneNumber, SalId, PaymentDate, TotalCost, PaymentMethod)
        VALUES (@InvoiceId, @CustomerPhone, @SaleAgentId, @CurrentDate, 0, N'Tiền mặt');

        DECLARE @ItemCount INT = FLOOR(RAND() * 3) + 1; -- 1 to 3 items
        DECLARE @j INT = 1;

        WHILE @j <= @ItemCount
        BEGIN
            -- Pick a random product
            SELECT TOP 1 @ProductId = Id FROM Product WHERE IsDeleted = 0 ORDER BY NEWID();

            SET @Quantity = FLOOR(RAND() * 5) + 1;  -- Quantity: 1–5
            SET @Price = FLOOR(RAND() * 5000000) + 100000; -- Price: 100K – 5M
            SET @Tax = 0.05;
            SET @Total = (@Quantity * @Price) + CAST((@Quantity * @Price) * @Tax AS INT);
            SET @WarrantyEnd = DATEADD(YEAR, 1, @CurrentDate);

            INSERT INTO SaleDetail (ProId, Id, Quantity, Price, Tax, Total, WarrantyEnd)
            VALUES (@ProductId, @InvoiceId, @Quantity, @Price, @Tax, @Total, @WarrantyEnd);

            SET @j += 1;
        END

        SET @i += 1;
    END

    FETCH NEXT FROM customer_cursor INTO @CustomerPhone;
END

CLOSE customer_cursor;
DEALLOCATE customer_cursor;
GO

UPDATE Account
SET Password = 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3'

update Employee
set Role = N'Bán hàng'
where Role = 'Sale Agent'

update Employee
set Role = N'Quản trị viên'
where Role = 'Administrator'

update Employee
set Role = N'Kế toán'
where Role = 'Accountant'

update Employee
set Role = N'Quản lý'
where Role = 'Manager'