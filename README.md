# SpendSmart

An ASP.NET Core MVC expense tracker. You can create, edit and delete your expenses and see them listed with the total amount.

## Tech stack

- **ASP.NET Core MVC** (.NET 10)
- **Entity Framework Core** with an in-memory database (`Microsoft.EntityFrameworkCore.InMemory`)
- Razor views with Bootstrap

## Features

- Create and edit expenses (amount + description)
- Delete expenses
- List all expenses with total sum
- Model validation with client-side and server-side handling

## Getting started

```bash
git clone https://github.com/Linaslala/SpendSmart.git
cd SpendSmart
dotnet run --project SpendSmart
```

Open `https://localhost:<port>` in your browser. The database is in memory, so data resets when the app restarts.

## Possible future improvements

- Replace the in-memory database with a real one (SQLite / SQL Server)
- Add categories and filtering
- Add a monthly summary chart
- Add authentication so multiple users can keep separate expenses