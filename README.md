# WarehouseWMS (sample)# WarehouseWMS (sample)





















- Razor Pages under `Pages/` include Dashboard and Products index with search.- `Services/InventoryService.cs` contains `AdjustStockAsync` with validation and transactions.- Models are under `Models/` and `Data/WarehouseContext.cs`.Notes:- SQL Server / LocalDB (connection string in `appsettings.json`)- .NET 7 SDKRequirements:```dotnet rundotnet ef database updatedotnet ef migrations add InitialCreatedotnet restore```bashQuick start:Minimal ASP.NET Core Razor Pages skeleton for Warehouse Management System.
Minimal ASP.NET Core Razor Pages sample for a Warehouse Management System.

Quick start:

```bash
dotnet restore
dotnet tool install --global dotnet-ef # if not installed
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```

Default connection string is in `appsettings.json` (LocalDB). Adjust for production.
