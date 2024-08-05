# Stock Tracking System
<p>  This web-based project is based on the MVC software architecture pattern of the .Net Framework. In order for the database system in this project to have a secure data processing feature, atomicity, consistency, isolation and durability features were taken into consideration.</p>

<h3>Development Tools</h3>
<ul>
 <li><i>SQL Server Express 2019 & SQL Server Management Studio (SSMS) </i></li>
 <li><i>Visual Studio Community 2022</i></li>
</ul>
<h3>System Design</h3>
<img src="https://github.com/user-attachments/assets/f18e04a9-2f8c-4d66-a022-40481565a0ff" alt="System design Diagram" width="400" height="300" >

<h3>Project Overview</h3>
<p> This project focuses on user and warehouse management within a web application. </p>
<h4>Admin</h4>
<p> Admin users can easily perform various management tasks, including adding, updating, deleting, and listing users; managing warehouses (add, update, delete, list); and managing sub-warehouses (add, update, delete, list). Additionally, users and warehouse data can be exported to Excel, and search functions allow for quick retrieval of information. The system ensures that each operation is completed smoothly and without errors, providing a successful confirmation or detailed error explanations as needed.</p>
<img src="https://github.com/user-attachments/assets/0964c322-3fc9-4460-ab54-ac2de30e07c7" alt="Admin Use Case Diagram" width="500" height="600"> 

<h4>Warehouse Manager</h4>
<p>The Warehouse Manager is responsible for managing stock movements within the system. This includes adding new stock movements, updating existing ones, and deleting or listing stock movements as needed. The Warehouse Manager can also add, update, or delete users in the system. Key tasks include accessing the respective functions for stock movements or user management, completing and submitting forms with relevant details, and receiving confirmation of successful operations or explanations for any issues encountered. All actions performed by the Warehouse Manager must adhere to system requirements, ensuring data integrity and accuracy across related tables and processes. The Warehouse Manager must be logged into the system to perform these tasks.</p>
<img src="https://github.com/user-attachments/assets/f6b18f8b-d651-4429-a1bf-fdffda6284f6" alt="Warehouse Use Case Diagram" width="500" height="600"> 

<h4>Report User</h4>
<p>The Report User is responsible for performing various tasks related to users and stock movements within the system. These tasks include adding, updating, deleting, and listing users, as well as viewing and exporting stock movement and status reports to Excel files. The Report User activates the relevant functions, fills out the required forms, and submits them to the system. The system either confirms the successful completion of the tasks or provides an explanation if any issues arise. All operations related to user and stock management must be carried out in accordance with system requirements, ensuring that data is accurately updated and reported. The user must be logged into the system before performing any operations, and efforts must be made to avoid errors throughout the process.</p>
<img src="https://github.com/user-attachments/assets/e8778dca-bfa7-4f50-a532-41dd5caf5397" alt="Report User	Use Case Diagram" width="500" height="600"> 
