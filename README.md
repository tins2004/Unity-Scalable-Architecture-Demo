# Unity Scalable Architecture Demo

## Giới thiệu

**Unity Scalable Architecture Demo** là một repository **tổng hợp các giải pháp về kiến trúc (Architecture) và các mẫu thiết kế (Design Patterns)** phổ biến trong phát triển Game với Unity.

Mục tiêu của dự án này là cung cấp các ví dụ mã nguồn sạch (Clean Code), dễ mở rộng (Scalable) và giảm thiểu sự phụ thuộc giữa các thành phần (Decoupling), giúp tối ưu hóa quy trình phát triển và bảo trì dự án.

## Danh mục Mẫu thiết kế Design Patterns

Mỗi thư mục dưới đây chứa một ví dụ hoàn chỉnh bao gồm mã nguồn (Scripts), Scene mẫu và file README chi tiết cho từng Pattern.

1. Structural Patterns (Nhóm cấu trúc)
   - **[Object Pool Design Pattern:](./Assets/Object%20Pooling%20Design%20Pattern)** Tối ưu hóa hiệu suất bằng cách tái sử dụng các đối tượng (Đạn, Effect, Enemy).

2. Structural Patterns (Nhóm cấu trúc)
   - Coming soon
3. Behavioral Patterns (Nhóm hành vi)
   - **[Command Design Pattern:](./Assets/Command%20Design%20Pattern)** Đóng gói yêu cầu thành đối tượng, hỗ trợ hệ thống Undo/Redo và Lưu trữ hành động.
   - **[Observer Design Pattern:](./Assets/Observer%20Design%20Pattern)** Xây dựng hệ thống Global Event (Tổng đài sự kiện), giúp các thành phần giao tiếp mà không cần tham chiếu trực tiếp.

## Danh mục Kiến trúc & Hệ thống (Architecture)

Ngoài các Design Patterns nhỏ lẻ, dự án còn mô phỏng các cách tiếp cận kiến trúc lớn hơn:

- Coming soon

## Lưu ý

1. **Unity Version 6000.3.11.f1**
2. Khi áp dụng vào dự án thực tế, hãy cân nhắc quy mô của dự án để lựa chọn Pattern phù hợp, **tránh việc làm quá phức tạp hóa vấn đề**.
