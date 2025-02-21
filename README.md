# Game Store Website

## Project Description

This project was developed as a prerequisite for our capstone class. The objective was to create a fully functional website that imitates an online game store, similar to platforms like Steam. The website includes essential features such as:

- Browsing and searching for games
- Viewing detailed game information
- Managing user accounts
- Processing purchases
- Admin panel for managing games, reviews, and events

The project was built using **ASP.NET** for the backend and integrated with a **SQL Server database**. It was developed in **Visual Studio** to provide a structured and scalable solution.

To ensure broad accessibility and ease of collaboration, we have licensed this project under the **MIT License**. This allows others to freely use, modify, and distribute the code while only requiring attribution to the original creators. The MIT License was chosen due to its simplicity and permissiveness, making it ideal for educational and open-source projects. You can find the full license details in the [`LICENSE`](LICENSE) file.

---

## How to Run the Project

To set up and run this project on your local machine, follow these steps:

### **Prerequisites**

- Install **Visual Studio** (latest version recommended)
- Install **.NET SDK** (if not included in Visual Studio)
- Install **SQL Server** and **SQL Server Management Studio (SSMS)**

### **Steps to Run the Project**

1. **Clone the Repository**

   ```sh
   git clone https://github.com/VictoriaTomasz/INFO2300-Assignment3.git
   cd INFO2300-Assignment3

2. **Open the Project in Visual Studio**

    - Launch Visual Studio.
    - Click **File → Open → Project/Solution**.
    - Select the `.sln` file of the project.

3. **Set Up the Database**

    - Open the **Package Manager Console** in Visual Studio (**Tools → NuGet Package Manager → Package Manager Console**).
    - Run the following command to apply database migrations:

      ```sh
      Update-Database
      ```

    - This will set up the required database schema on your local SQL Server.

4. **Run the Project**

    - Click the **Run** button in Visual Studio or press `F5`.
    - The website should launch in your default browser.

