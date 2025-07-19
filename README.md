# 🛒 Eco-POS - small Retail shops POS System

**Offline Point of Sale (POS) system designed specifically for small Retail shops to manage sales transactions efficiently and locally**

## 💡 Features

* 🛒 Product selection with quantity and price
* ➕ Add-to-cart functionality
* 🧾 Real-time cart view
* 💰 Total calculation
* 💽 SQL Server database integration
* 🔐 Desktop-based (no internet required)
* 🛠️ Functions:
  * Add Product
  * Generate Invoice
  * Sales History tracking
  * Clear Cart

## ⚙️ Technology Stack

* **Language**: C# .NET Framework
* **UI Framework**: Windows Forms (WinForms)
* **Database**: SQL Server (Express or LocalDB)
* **Data Access**: ADO.NET using `Microsoft.Data.SqlClient`

## 📦 Prerequisites

* **Visual Studio 2022** or later
* **.NET Framework 4.7.2** or newer
* **SQL Server Express** or **LocalDB**

## 🛠️ Installation & Setup

1. Clone the repository:
git clone https://github.com/yourusername/EcoGroceryMart.git
cd EcoGroceryMart

2. Open the solution in **Visual Studio**.

3. Update the connection string inside `Sales.cs`:
csharp
private readonly string connectionString = "Data Source=YOUR_SERVER;Initial Catalog=EcoMart_POS;Integrated Security=True";

Replace `YOUR_SERVER` with your actual SQL Server name
(e.g., `DESKTOP-XYZ\\SQLEXPRESS`).

## ▶️ Running the App

* Press **F5** or click **Start** in Visual Studio.
* The form will load, allowing you to:

  * Select products
  * Enter quantities
  * Add items to cart
  * View totals
  * Generate invoices

## 📌 Future Improvements

* 🧾 Save and print invoices (PDF/Bill)
* 📊 Sales history reporting
* 🔐 Admin login & authentication
* 📦 Product stock tracking

## 📸 Screenshots
## Login
<img width="782" height="690" alt="1" src="https://github.com/user-attachments/assets/3856cfda-6ed8-4d47-88d4-8aaf73444218" />

## Dashboard
<img width="782" height="690" alt="2" src="https://github.com/user-attachments/assets/0d5db16b-f4b7-4e84-aeda-16f978ec74c7" />

## ProductManage
<img width="782" height="690" alt="3" src="https://github.com/user-attachments/assets/7707f1fa-d01e-4617-924b-ea42f0f3d0b9" />

## Sales
<img width="782" height="690" alt="4" src="https://github.com/user-attachments/assets/4389bc2b-229b-4372-855c-4ce0feeb2361" />

## Invoice
<img width="500" height="634" alt="5" src="https://github.com/user-attachments/assets/00a72020-9ab2-4d80-9332-a50ac9053335" />

## SalesHistory
<img width="782" height="690" alt="6" src="https://github.com/user-attachments/assets/e47dcba7-2ab1-4a91-a67a-b08de6c4dc99" />

## 👨‍💻 Author
Developed by **DulanjanaS**
* GitHub: [https://github.com/Dulanjana-S](https://github.com/Dulanjana-S)

## 📄 License
This project is licensed under the [MIT License](LICENSE).
Feel free to use or modify it for learning or internal use.

https://gitdocs1.s3.amazonaws.com/digests/dulanjana-s-eco-pos/b03d2460-a430-4a40-ae52-cd43857c3383.txt
