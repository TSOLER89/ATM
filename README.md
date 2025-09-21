Project Description
This project is a simple ATM console application written in C#. It allows a user to log in with a PIN, deposit and withdraw money, and check their account balance. The application demonstrates basic banking operations and user interaction through a text-based menu.

Example Usage
Welcome Tsoler Hayitian to your ATM Bank Account! 
Please log in with your PIN to continue. 
Enter 4-digit PIN: 1234

Choose an option:
1.	Deposit money
2.	Withdraw money
3.	Show balance
4.	Exit Choice: 1 Enter amount to deposit: 100 Deposited $100.00. New balance: $100.00



OOP/Encapsulation in the Project
The project uses object-oriented programming (OOP) principles:
•	Classes: The main entities are modeled as classes (Customer_klass and BankAccount).
•	Encapsulation: Each class encapsulates its data using properties with get accessors, and fields are kept private or protected. For example, the BankAccount class manages the account balance internally and exposes methods for deposit and withdrawal, preventing direct modification from outside the class. The Customer_klass class holds customer information and their associated bank account, exposing only necessary data through properties.
•	Separation of Concerns: Each class is responsible for its own data and behavior, making the code modular and easier to maintain.
