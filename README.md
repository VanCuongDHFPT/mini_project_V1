# mini_project_V1

*Kiến thức đầu tiên tôi đã học và ôn lại chỉnh là Middleware cái này nó là một phần kiến thức của ASP.NET Core cũng rất là quan trọng 
+ Khái niệm mà tôi đã hiểu về Middleware
 - Middleware là module code để nhận request và trả về các reponse
 - Thì bản chất của nhận request từ client và nó sẽ check middlware trước khi vào Controller
   *Ví dụ : Middleware authentication  -> Middleware Authorization : Trước khi vào controller thì nó sẽ check xem client đã login chưa và nếu chưa thì bắt login
   nếu login rồi thì sẽ lấy token đó vào bên trong controller thì nó có một lớp là Filter sẽ check tiếp
- Chuyển request nếu Middleware trước hợp lệ trong trường hợp có lỗi thì repsone về cho client
* Kiến thức thứ hai tui cũng đã ôn qua Dependency Injection (DI): Cũng khá quan trọng giảm đi sự phụ thuộc giữa các Class vs nhau
  -Tránh hai class chính phụ thuộc lẵn nhau.Nếu áp dụng cho thực tế có nguy cỡ là hư project
  -Có thể dụng kỹ thuât IOC(Inversion of Control) làm
  - Phải đki thông qua DI Container : bên trong đăng vòng đời DI và đăng kí đối tường chuẩn bị inject

* Kiến thức thức 3 khá đơn giản và ai cũng có thể biết : tách business logic ra service thay vì nhét trong controller.
  - Hỗ trợ chúng ta chia các layer rõ ràng và dễ hiểu hơn khi áp dụng vào project

  Thực hành mini project: <img width="320" height="466" alt="image" src="https://github.com/user-attachments/assets/e45baf29-5497-4672-b528-27ab6fa645c1" />
