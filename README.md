# Remote Desktop App

Ứng dụng Remote Desktop được xây dựng bằng .NET WinForms, gồm ba thành phần chính:

* **RemoteAuthApp**: Xác thực người dùng bằng Firebase Authentication.
* **RemoteHostApp**: Chia sẻ màn hình và nhận điều khiển từ xa.
* **RemoteViewerApp**: Kết nối tới Host và hiển thị màn hình từ xa.

---

# Cấu trúc project

```text
RemoteDesktopApp
│
├── BuildOutput/
│   └── Chứa các file build (.exe) để chạy ứng dụng.
│
├── RemoteAuthApp/
│   ├── Forms/
│   │   └── Các giao diện đăng nhập, đăng ký và chọn vai trò.
│   │
│   ├── Services/
│   │   └── Xử lý xác thực với Firebase.
│   │
│   ├── Models/
│   │   └── Các model dữ liệu xác thực.
│   │
│   ├── Helpers/
│   │   └── Session và các hàm hỗ trợ kiểm tra dữ liệu.
│   │
│   └── appsettings.json
│       └── Cấu hình Firebase API Key.
│
├── RemoteHostApp/
│   ├── Forms/
│   │   └── Giao diện chia sẻ màn hình.
│   │
│   ├── Services/
│   │   └── Xử lý capture màn hình và giao tiếp SignalR.
│   │
│   ├── DTOs/
│   │   └── Các đối tượng truyền dữ liệu giữa Host và Viewer.
│   │
│   └── Helpers/
│       └── Các hàm hỗ trợ xử lý hệ thống.
│
└── RemoteViewerApp/
    ├── Forms/
    │   └── Giao diện kết nối và xem màn hình từ xa.
    │
    ├── Controls/
    │   └── Các control hiển thị màn hình remote.
    │
    ├── Services/
    │   └── Xử lý kết nối SignalR và nhận dữ liệu màn hình.
    │
    ├── DTOs/
    │   └── Các đối tượng truyền dữ liệu giữa Viewer và Host.
    │
    └── Helpers/
        └── Các hàm hỗ trợ xử lý giao diện và kết nối.
```

---

# Thành phần chính

## RemoteAuthApp

Chịu trách nhiệm:

* Đăng ký tài khoản.
* Đăng nhập tài khoản.
* Xác thực bằng Firebase Authentication.
* Lưu thông tin phiên đăng nhập.

## RemoteHostApp

Chịu trách nhiệm:

* Chia sẻ màn hình máy Host.
* Nhận lệnh điều khiển từ Viewer.
* Truyền dữ liệu màn hình qua SignalR.

## RemoteViewerApp

Chịu trách nhiệm:

* Kết nối tới Host.
* Hiển thị màn hình từ xa.
* Gửi thao tác chuột và bàn phím tới Host.
* Điều khiển máy Host từ xa.

## BuildOutput

Chứa các file thực thi sau khi build hoặc publish ứng dụng, phục vụ cho việc triển khai và chạy thực tế.
