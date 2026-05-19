# 1. Project Title
**DVLD — Driving & Vehicle License Department Management System**  
_A production-grade WinForms desktop application for managing drivers, licenses, applications, and test workflows in a centralized registry._

# 2. Overview
DVLD is a desktop information system built for a Driving & Vehicle License Department. It centralizes the management of people records, driver licensing workflows, applications, testing, and detainment/release operations. The solution was built to model real-world governmental processes with a clean, maintainable architecture that separates presentation, business rules, and data access concerns.

The system provides structured workflows for issuing local and international licenses, scheduling and recording tests, handling renewals and replacements, and tracking detentions and releases. It uses ADO.NET for direct SQL Server access and follows a layered, MVC-inspired design that keeps responsibilities clearly separated across the solution.

**Key technologies:** C#, WinForms, ADO.NET, SQL Server, .NET Framework 4.8, GitHub

| UI Scope | Count |
|---|---:|
| Screens | 21+ |
| Pop-ups | 12 |
| Custom Components (controls + user controls) | 15 |

# 3. Features
## Authentication & User Management
- Secure login flow with password hashing (SHA-256)
- Remember-me support via Windows Registry
- User activation status enforcement
- Create, update, and manage system users

## People & Drivers Registry
- Full CRUD for people records
- National number-based lookup
- Photo management and storage
- Country and nationality lookup

## Applications Management
- Submit local driving license applications
- Submit international driving license applications
- Application list view with filtering and status tracking
- Application type management and fee display

## Licenses & Operations
- Renew expired licenses
- Replace damaged or lost licenses
- Release detained licenses with fee calculation
- License history and details views

## Test Management
- Test scheduling and appointment tracking
- Test type management
- Test results and history views

## Detain & Release
- Detain license processing
- Release workflows with fine and fee handling
- Detainment history lookup

## UI & Usability
- Modular WinForms UI with reusable user controls
- Custom UI components (rounded controls, custom tab headers)
- Centralized input validation for key forms

# 4. Screenshots
Here are some screenshots showcasing the main features and workflows of the DVLD application:

### Dashboard Overview
<p align="center">
  <img src="docs/screenshots/Dashboard%20Overview/Dashbaord.png" alt="Dashboard Overview" width="900" />
</p>

### Individuals Management
<p align="center">
  <img src="docs/screenshots/Individuals%20Management/individuals_management.png" alt="Individuals Management" width="900" />
</p>
<p align="center">
  <img src="docs/screenshots/Individuals%20Management/add_new_person.png" alt="Add New Person" width="900" />
</p>

### Applications Workflow
<p align="center">
  <img src="docs/screenshots/Applications%20Workflow/applications.png" alt="Applications Workflow" width="900" />
</p>

### License Operations
<p align="center">
  <img src="docs/screenshots/License%20Operations/detain_license.png" alt="License Operations" width="900" />
</p>

### Test Management
<p align="center">
  <img src="docs/screenshots/Test%20Management/test_management.png" alt="Test Management" width="900" />
</p>

# 5. Architecture
DVLD follows a clean layered architecture inspired by MVC. Each layer has a focused responsibility, enabling maintainability, testability, and clear boundaries between UI, business rules, and data access.

**Architecture overview:**
- **Presentation (WinForms)**: Forms, dialogs, pop-ups, and reusable user controls orchestrate UI workflows.
- **Business Logic (Controllers)**: Controllers coordinate validation and business rules, bridging UI and repositories.
- **Core (Domain Model)**: Plain models, enums, DTOs, and repository interfaces define the contract.
- **Data Access (Repositories)**: ADO.NET repositories execute SQL via shared DB helpers.

**Data flow:**
`Form/UI → Controller → Repository → DBHelper → SQL Server`

This design avoids tight coupling between UI and database logic, improves readability, and enables safer future refactoring or migration.

**Solution structure (simplified):**
```
DVLD.sln
README.md
DVLD/
  Forms/
  Dialogs/
  Pop-Ups/
  UserControls/
  CustomControls/
  CustomForms/
  InputValidation.cs
  Program.cs
  App.config
DVLD_BusinessLogic/
  *Controller.cs
DVLD_DataAccess/
  Database/
    DBConnection.cs
    DBHelper.cs
  Repositories/
Core/
  Models/
  Interfaces/
  DTOs/
  Enums/
database/
docs/
  requirements/
  screenshots/
```

# 6. Technologies Used
| Technology | Purpose |
|---|---|
| C# | Core application language |
| .NET Framework 4.8 | Runtime and framework target |
| WinForms | Desktop UI layer |
| ADO.NET (`System.Data.SqlClient`) | Database access |
| SQL Server | Persistent data storage |
| Git & GitHub | Version control and hosting |

# 7. Database
The application uses SQL Server with ADO.NET repositories for all data operations. Each repository translates domain-level actions into SQL commands executed via `DBHelper`, ensuring consistent handling of connections, parameters, and transactions.

- **Connection string**: Stored in `DVLD/App.config`
- **Database backup**: Expected under `database/backup/`

## Restore Instructions (SQL Server)
1. Open SQL Server Management Studio (SSMS).
2. Right-click **Databases** → **Restore Database**.
3. Select the `.bak` file from `database/`.
4. Restore using default options.

# 8. Installation & Setup
## Prerequisites
- Visual Studio 2019/2022
- .NET Framework 4.8 Developer Pack
- SQL Server (Local or Express)
- SQL Server Management Studio (SSMS)

## Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/OussamaSpring/Driving-And-Vehicle-License-Department.git
   ```
2. Restore the database from `database/backup/` using SSMS.
3. Open `DVLD.sln` in Visual Studio.
4. Configure the connection string in `DVLD/App.config`.
5. Build the solution.
6. Run the application (startup project: `DVLD`).

# 9. Connection String Configuration
The connection string is stored in `DVLD/App.config` under `connectionStrings`.

**Example:**
```xml
<connectionStrings>
  <add name="DVLDConnection"
       connectionString="Data Source=.;Initial Catalog=DVLD;User ID=sa;Password=123456;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

**Security recommendations:**
- Use Windows Authentication in production environments.
- Avoid storing credentials in source control.
- Consider environment-specific config transforms for deployment.

# 10. Project Structure
```
DVLD/
  Forms/                # Main screens (Dashboard, Individuals, Licenses, etc.)
  Dialogs/              # Login and modal dialogs
  Pop-Ups/              # View and edit pop-ups (person, application, license)
  UserControls/         # Reusable UI components
  CustomControls/       # Custom UI styling elements
  CustomForms/          # Base forms and shared UI behaviors
DVLD_BusinessLogic/     # Controllers and business rules
DVLD_DataAccess/        # Repositories, DB helpers, and SQL access
Core/                   # Models, enums, DTOs, and repository interfaces
```

# 11. Client Requirements
The original client requirements document is included here:
`docs/requirements/Client_Requirements.pdf`

The implementation aligns with the specified workflows (applications, licensing, testing, and user administration) while providing a structured and maintainable architecture suitable for extension.

# 12. Technical Highlights
- Layered architecture separating UI, business logic, and data access
- Repository pattern with shared ADO.NET helpers for consistent SQL execution
- Domain-driven core models, enums, and DTOs for clean data contracts
- Password hashing (SHA-256) in user workflows
- Registry-based credential persistence for optional remember-me
- Modular WinForms UI with reusable user controls and custom styling
- Input validation centralized for key workflows

# 13. Future Improvements
- Migrate to modern .NET (e.g., .NET 8) and modern UI frameworks
- Add role-based permissions and audit logs
- Integrate reporting/export (PDF, Excel)
- Introduce API layer for external integrations
- Add dark mode and configurable themes
- Improve connection security via secrets management

# 14. Author
**Author:** Oussama Azzouz
**Role:** Software Engineer  
**GitHub:** _https://github.com/OussamaSpring_

# 15. License
This project is licensed under the MIT License.
