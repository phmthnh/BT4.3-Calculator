# 🧮 Bài Tập 4.3 – Form Máy Tính (Calculator)

Bài tập thiết kế giao diện máy tính, áp dụng kỹ thuật **dùng chung một Event Handler** cho nhiều nút bấm thông qua tham số `object sender`.

---

## 📋 Mô tả

Máy tính cơ bản hỗ trợ 4 phép tính, điểm nổi bật là 10 nút số (0–9) đều gán **cùng một hàm xử lý sự kiện** `NumberButton_Click`. Bên trong hàm, dùng kỹ thuật ép kiểu `(Button)sender` để lấy giá trị của nút vừa bấm.

```csharp
// 10 nút số dùng chung 1 event handler
private void NumberButton_Click(object sender, EventArgs e)
{
    Button btn = (Button)sender;  // ép kiểu để lấy Text của nút
    txtDisplay.Text += btn.Text;
}
```

---

## 🖼️ Giao diện

![Giao diện máy tính](Screenshot%202026-09-23%20164601.png)

---

## ⚙️ Các thành phần chính

| Tên Control | Chức năng |
|-------------|-----------|
| `txtDisplay` | Màn hình hiển thị số và kết quả |
| `btn0` → `btn9` | 10 nút số — dùng **chung** `NumberButton_Click` |
| `btnAdd` `btnSub` `btnMul` `btnDiv` | Các phép toán `+` `−` `×` `÷` |
| `btnEquals` | Tính và hiển thị kết quả `=` |
| `btnClear` | Xóa toàn bộ, về `0` |
| `btnBackspace` | Xóa ký tự cuối cùng `⌫` |
| `btnDot` | Nhập dấu thập phân `.` |

---

## 🚀 Cách chạy

**Bằng Visual Studio:**
1. Mở file `BT4_3_Calculator.sln`
2. Nhấn `F5` để chạy

**Bằng terminal:**
```bash
dotnet run
```

---

## 🛠️ Yêu cầu
- .NET 10.0 SDK
- Windows OS
- Visual Studio 2022 trở lên
