# Preferred technology stack

I prefer to use the following technologies:

* C#, .NET Technologies using the net9.0 TFM
* ASP.NET Core
* ASP.NET Identity
* Modular Monolith with Vertical Slice architecture.

## For development:

* .NET Aspire 9.2.0
* Local containers hosted in .NET Aspire
    * SQL Server
    * MongoDB
    * Azurite
    * RabbitMQ

## For production:

* Azure Container Apps
* Azure Developer CLI with Bicep and Azure Verified Modules for IaC.
* Azure platform services:
    * Azure SQL
    * CosmosDB with MongoDB facet.
    * Azure Blob Storage
    * Azure Service Bus

# Project Layout

* /project is used for project related documentation such as product proposals, technical specifications and implementation plans.
* /docs is used for project documentation
* /src is used for source code for the deployable code.
* /test is used for unit, UI, and integration test code.

# Maintaining, building and testing the project.

* Use `dotnet` commands to alter the solution and add packages to the projects.
    * Always attempt to install the latest version of the package before reverting to a specific version.
* Use `npm run build` to build the application.
* Use `npm run test` to run all tests.
* Use `gh act` to run the CI locally.
