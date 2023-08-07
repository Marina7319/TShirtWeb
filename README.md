Този проект е website за Тениски. <br />
<strong>Необходими инструменти:</strong> <br />
•	Visual Studio 2022: https://visualstudio.microsoft.com/ <br />
•	SQL Server 2022: https://www.microsoft.com/en-us/sql-server/sql-server-downloads <br />
•	SQL Server Management Studio (SSMS): https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16 <br />
•	Windows 10 <br />
<strong>Изисквания, за да се стартира проекта: </strong> <br />
•	Visual Studio 2022: https://visualstudio.microsoft.com/ <br />
•	SQL Server 2022: https://www.microsoft.com/en-us/sql-server/sql-server-downloads <br />
•	SQL Server Management Studio (SSMS): https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16 <br />
•	T-shirt Solution: https://github.com/Marina7319/TShirtWeb <br />
•	Windows 10. <br />
<strong>Файловете, който може да намерите в този проект: </strong><br />
•	MVC Controller HomeController.cs с методи Index(), Details(), Privacy()  и Error(). <br />
•	Razor Views Index.cshtml, Details.cshtml и Privacy.cshtml файлове. <br />
Екран с тениските видими за потребителите с името на тениската, цвета и цената. Бутони за Детайлите, Регистриране и Вписване на потребителите. <br />
<br />
![Home](https://github.com/Marina7319/TShirtWeb/assets/100438974/78007c4c-ffe7-4ce8-a69e-c938f6f85260) <br />

•	MVC Controller CategoryController.cs с методи Index(), Create(), Create(Category obj), Edit(int? id), Edit(Category obj), Delete(int? id), DeletePOST(int? id).
Екран с категорийте на тениските. Бутони за създаване на нова категория, редактиране на категория и изтриване на категория.
<br />
 ![CreateCategoryCategories](https://github.com/Marina7319/TShirtWeb/assets/100438974/2a12d7c1-7a7f-425a-bc71-610d468af8c9) <br />

Редактиране името на категорията и номера на категорията.
<br />
![EditT-shirtCategory](https://github.com/Marina7319/TShirtWeb/assets/100438974/f84f9bf6-41bf-4dfe-84a0-f97d3c4f0704)  <br />


Изтриване на категорията.
<br />
![DeleteCategory](https://github.com/Marina7319/TShirtWeb/assets/100438974/0b3a685b-94d3-4bf5-8ead-0b5ff05ce5df) <br />


•	MVC Controller ProductController.cs  с методи Index(), Update(int? id), Update(ProductVieModel productViewModel, IFromFile? file), DeletePOST(int? id), GetAll(int id), Delete(int? id). <br />
Екран с лист с тениски. Бутон за Създаване на тениска, редактиране на тениска, изтриване на тениска.
<br />
![CreateProductProductList](https://github.com/Marina7319/TShirtWeb/assets/100438974/c90195c6-d7f4-4763-9c95-9c6ce1d8de36) <br />

Екран за създаване на тениска.  С полета за име на тениската, обяснение за тениската, размера, цвета, цената, категорията и снимка. Бутони за създаване и връщане към листа с тениските. <br />
<br />
 ![CreateProduct](https://github.com/Marina7319/TShirtWeb/assets/100438974/986b9c6d-53e9-4db4-98fd-63490052dc47) <br />

Редактиране на тениска. С полета за име на тениската, обяснение за тениската, размера, цвета, цената, категорията и снимка. Бутони за създаване и връщане към листа с тениските.
<br />
![UpdateProduct](https://github.com/Marina7319/TShirtWeb/assets/100438974/ce4b9709-eaba-4764-9add-c804c1776020) <br />

Екран за изтриване на тениска.
<br />
![DeleteProduct](https://github.com/Marina7319/TShirtWeb/assets/100438974/b276acae-e44d-49a1-8d38-465f4c3f7984) <br />



