# BT4.3 – Form Calculator dùng chung sự kiện với `sender`

> **Môn:** Lập trình Windows Forms với C# | **Framework:** .NET 10.0

## Mục tiêu
Thiết kế Form máy tính, gán **chung 1 Event Handler** cho 10 nút bấm số (0–9) bằng tham số `object sender`.

## Tính năng

| Control | Chức năng |
|---------|-----------|
| `txtDisplay` | Màn hình hiển thị kết quả |
| `btn0` → `btn9` | 10 nút số — dùng **chung** `NumberButton_Click(object sender, ...)` |
| `btnAdd` / `btnSub` / `btnMul` / `btnDiv` | Phép toán `+` `-` `*` `/` |
| `btnEquals` | Tính kết quả `=` |
| `btnClear` | Xóa toàn bộ `C` |
| `btnBackspace` | Xóa ký tự cuối `⌫` |
| `btnDot` | Dấu thập phân `.` |

## Kỹ thuật chính

```csharp
// Gán chung 1 handler cho 10 nút số
private void NumberButton_Click(object sender, EventArgs e)
{
    Button btn = (Button)sender;   // ép kiểu để lấy Text
    txtDisplay.Text += btn.Text;
}
```

## Demo

![Calculator - Giao diện](Screenshot%202026-09-23%20164601.png)

## Cách chạy

```bash
dotnet run
```

hoặc mở file `BT4_3_Calculator.sln` bằng **Visual Studio 2022+** và nhấn `F5`.

## Yêu cầu hệ thống
- .NET 10.0 SDK
- Windows OS (Windows Forms)
- Visual Studio 2022 (khuyến nghị)
