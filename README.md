# Management Portal

Blazor Server web portal with Azure AD sign-in and a user-profile data layer.

## What it holds
- `ManagementPortal/Data/` - EF Core `DbContext` and `UserProfile` model
- `ManagementPortal/Pages/` and `Shared/` - Blazor pages, layout and navigation
- Azure AD authentication configured through `appsettings.json` (values are placeholders)

## Stack
C#, Blazor Server (.NET 7), Entity Framework Core, Azure AD

## Run it
```bash
cd ManagementPortal
dotnet user-secrets set "AzureAd:ClientSecret" "<your secret>"
dotnet run
```

## Status
Early-stage / template-based project.
