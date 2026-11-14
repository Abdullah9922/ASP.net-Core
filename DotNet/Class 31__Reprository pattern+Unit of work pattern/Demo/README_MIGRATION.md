# Demo project - Category, Supplier, Customer migration

This archive is based on the uploaded Demo project.

## Review findings

- `ApplicationDbContext` already exposes DbSets for Product, Category, Supplier and Customer.
- The three new entity classes implement `IAggregateRoot<Guid>`.
- `IApplicationUnitOfWork`, the repository interfaces, concrete repositories and DI registrations are present.
- Fixed `CustomerRepository` constructor to accept `ApplicationDbContext`, consistently with the other repositories. This matters because `AddDbContext<ApplicationDbContext>()` registers that concrete context; it does not automatically register the base `DbContext` service for constructor injection.
- Renamed `ISupplierRepository .cs` to `ISupplierRepository.cs` (removed accidental trailing space).
- Added `ApplicationDbContextFactory` to Demo.Web so EF Core tooling can create the context at design time without trying to build the app host.

## Migration included

`20261114230000_AddCategorySupplierCustomer`

It creates:
- Categories
- Customers
- Suppliers

It does not recreate Products; the existing `AddProduct` migration already creates that table.

## Commands

Run from the folder containing `Demo.slnx`:

```bash
dotnet ef migrations list --project Demo.Infrastructure --startup-project Demo.Web --context Demo.Infrastructure.Data.ApplicationDbContext
```

Then apply migrations:

```bash
dotnet ef database update --project Demo.Infrastructure --startup-project Demo.Web --context Demo.Infrastructure.Data.ApplicationDbContext
```

If you want to generate the migration yourself instead of using the included migration files, remove the three included files for `20261114230000_AddCategorySupplierCustomer` and run:

```bash
dotnet ef migrations add AddCategorySupplierCustomer --project Demo.Infrastructure --startup-project Demo.Web --context Demo.Infrastructure.Data.ApplicationDbContext
```

## Important verification note

The migration source and model snapshot were prepared from the uploaded model. The execution environment used to prepare this archive does not have the .NET SDK / `dotnet ef`, so the migration could not be compiled or executed here. Run `dotnet build` and the commands above in Visual Studio on your machine. Back up the database before applying migrations to an existing database.
