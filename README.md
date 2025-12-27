# Bank Credit System

A desktop application for managing credit applications and client data, built with C# and Windows Forms, integrated with PostgreSQL database.

## Table of Contents

- [Overview](#overview)
- [Functionality](#functionality)
- [Technology Stack](#technology-stack)
- [Project Structure](#project-structure)
- [Database Design & Relationships](#database-design--relationships)
- [Database Integration in C#](#database-integration-in-c)
- [SQL Scripts and Data Management](#sql-scripts-and-data-management)
- [Database Objects: Functions, Views, Triggers](#database-objects-functions-views-triggers)

---

## Overview

The Bank Credit System is a comprehensive desktop application designed to manage credit operations for banks. The system provides distinct interfaces for **Clients**, **Managers**, and **Inspectors**, each with specific roles and permissions.

The core of the project lies in its robust **PostgreSQL database design**, featuring multiple interconnected tables with defined relationships, foreign keys, and constraints. The database schema supports the full lifecycle of credit applications, from initial client submission to final approval or rejection.

The application implements role-based access control, where users are authenticated and directed to appropriate forms based on their roles. The system allows for creating new client profiles, submitting credit applications, tracking payments, managing contracts, and assigning inspectors for verification.

Key database components include:
- Client information management
- Credit application tracking
- Contract and payment history
- Employee roles and permissions
- User credentials and security

---

## Functionality

### Client Features:
- **User Authentication:** Secure login with role-based access.
- **Profile Management:** View and update personal information (FIO, phone, passport).
- **Credit Applications:** Submit new credit applications with amount and term.
- **Payment Processing:** Make payments towards existing contracts.
- **Account Overview:** View current balance and total debt.

### Manager Features:
- **Client Application Review:** Accept and process applications submitted by clients.
- **New Client Creation:** Add new clients and create initial credit applications.
- **Inspector Assignment:** Assign inspectors to applications for verification.
- **Record Management:** View all applications assigned to the manager, with color-coded status indicators (red for unassigned, green for assigned to inspector).
- **Application Tracking:** Monitor the status of all applications processed by the manager.

### Inspector Features (Conceptual):
- **Application Verification:** Review assigned applications and approve/reject them.
- **Status Updates:** Update application status based on verification results.

### General Features:
- **Data Integrity:** Enforced through foreign key constraints and database triggers.
- **Dynamic Calculations:** Real-time debt calculation based on payments and approved amounts.
- **Secure Authentication:** Password-protected access with role-based navigation.

---

## Technology Stack

Below are the main technologies, frameworks, and versions used in this project:

- **Programming Language:** C#
- **Framework:** .NET Framework
- **UI Framework:** Windows Forms
- **Database:** PostgreSQL 13+
- **Database Driver:** Npgsql
- **IDE:** Visual Studio
- **Version Control:** Git (for project management)

---

## Project Structure

```
BankCreditSystem/
├── Forms/
│   ├── AuthorizationForm.cs
│   ├── AccountInfoForm.cs
│   ├── ManageForm.cs
│   ├── InspectorForm.cs
│   ├── NewApplicationForm.cs
│   ├── PaymentForm.cs
│   ├── ProfileSettingsForm.cs
│   ├── AcceptClientApplicationForm.cs
│   ├── CreateApplicationForNewClientForm.cs
│   └── MyRecordsForm.cs
├── Globals.cs
├── Program.cs
└── Database/
    └── SQL Scripts
```

---

## Database Design & Relationships

### ER Diagram 


> 💡 **Пояснение связей:**
> - `records.client_id` → `clients_data.client_id` (**RESTRICT** — нельзя удалить клиента, если есть заявки)
> - `records.contract_id` → `contracts_data.contract_id` (**CASCADE** — при удалении контракта удаляются связанные заявки)
> - `records.credit_type_id` → `credit_type.credit_type_id` (**RESTRICT**)
> - `records.manager_id` / `inspector_id` → `employees_data.employee_id` (**SET NULL** — можно удалить сотрудника, но его ID в заявках станет NULL)
> - `payments_data.contract_id` → `contracts_data.contract_id` (**RESTRICT** — нельзя удалить контракт, если есть платежи)
> - `clients_data.login` → `user_credentials.login` (**RESTRICT** — нельзя удалить учётные данные, если есть клиент)

---

## Database Integration in C#

The application connects to PostgreSQL using the **Npgsql** library. Database connection is managed globally through the `Globals.cs` class:

```csharp
namespace tr
{
    public class Globals
    {
        public static string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=qwert013579;Database=BD1";
        public static NpgsqlConnection connection = null;
    }
}


