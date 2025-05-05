# Hướng Dẫn Cài Đặt Phần Mềm Timber Shop Manager

## Yêu Cầu Hệ Thống
- **Hệ điều hành**: Windows 10 hoặc mới hơn.
- **Phần mềm hỗ trợ**: .NET Framework 8.0, SQL Server.
- **Dung lượng ổ cứng**: Tối thiểu 500MB trống.
- **RAM**: Tối thiểu 4GB.

## Các Bước Cài Đặt

1. **Tải Phần Mềm**
    - Truy cập [Trang GitHub của dự án](https://github.com/username/TimberShopManager).
    - Tải xuống phiên bản mới nhất từ mục **Releases**.

2. **Cài Đặt Phần Mềm**
    - Giải nén file tải về.
    - Chạy file `timber-shop-manager.exe` với quyền **Administrator**.
    - Làm theo hướng dẫn trên màn hình để hoàn tất cài đặt.

3. **Tạo Cơ Sở Dữ Liệu**
    - Sử dụng file timber-shop.sql trong thư mục source code/assets/database để tạo hệ cơ sở dữ liệu.
    - Sử dụng file data.sql trong thư mục source code/assets/database để tạo ra dữ liệu ảo phục vụ cho việc kiểm thử phần mềm.

4. **Cấu Hình Cơ Sở Dữ Liệu**
    - Mở ứng dụng và nhập thông tin kết nối cơ sở dữ liệu:
      - **Server**: địa chỉ máy chủ SQL.
      - **Database**: `TimberShop`.
    - Nhấn **Kết Nối** để kiểm tra kết nối.

5. **Khởi Chạy Ứng Dụng**
    - Sau khi cài đặt, mở ứng dụng từ menu Start hoặc biểu tượng trên Desktop.
    - Đăng nhập bằng tài khoản mặc định:
      - **Username**: `admin@timbershop.vn`
      - **Password**: `123`

6. **Hoàn Tất**
    - Thực hiện các bước cấu hình bổ sung nếu cần.
    - Bắt đầu sử dụng phần mềm để quản lý cửa hàng gỗ.

## Hỗ Trợ
Nếu gặp vấn đề trong quá trình cài đặt, vui lòng liên hệ qua email: 52300145@student.tdtu.edu.vn hoặc 52300153@student.tdtu.edu.vn