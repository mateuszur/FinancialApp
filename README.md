# FinancialApp

## Description
The application is currently under development. It serves as my experimental ground. Ultimately, I would like the application to have the following features:

  - Expense Tracking: Keep an eye on your spending and understand where your money goes.
  - Budget Creation: Set up and manage your budgets to achieve your financial goals.
  - Financial Analysis: Generate insightful charts and reports to analyze your financial health.

During the development process, I emphasize maintaining the principles of clean architecture, as well as adhering to SOLID, KISS, and DRY principles.

## Installation

At this point the application is in the development stage. The only option to run it is to copy the repository and run it e.g. in Visual Studio

1. Clone the repository:
   ```sh
   git clone https://github.com/mateuszur/FinancialApp.git
   ```
2. It is necessary to provide the database address, username and password. We provide this data in the appsettings.json file located in the FinancialApp.MVC folder
3. After providing the DB user data, it is necessary to execute a command from EF that will initialize the tables in the database. We execute the command in the nuget package manager console: update-database
4. Run project.

## Contributing
At this point, I am developing the project as my experimental ground and for learning purposes. However, I am open to feedback on how to improve it.
