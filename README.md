# AspNetCoreSqlLocalization
An example of DB-based Localization in ASP.NET Core, using custom providers through the [AspNet5Localization](https://github.com/damienbod/AspNet5Localization) package.

## Instructions
The project targets .NET Core RC2, and was built on Visual Studio 2015 Update 2.
If you examine `project.json` you'll find that we've installed the `Localization.SqlLocalizer` package:

```
{
  "dependencies": {
    "Localization.SqlLocalizer": "1.0.1",
    }
}
```
We've also installed **EF Core** and **EF Tools** packages for Entity Framework and CLI Commands.

Under the **Migrations** folder you'll find a migration named **add_sql_localizer** which creates the **LocalizationRecords** table. Fire up your console at the root of the project (where `project.json` lives) and do:

`dotnet ef migrations add Localization --context localizationModelContext`  
`dotnet ef database update Localization --context localizationModelContext`

If all goes well, you're all set. Configuring localization services is documented at [AspNet5Localization repo](https://github.com/damienbod/AspNet5Localization). You can find a more detailed explanation on [Damien's blog](https://damienbod.com/2016/05/26/released-sql-localization-nuget-package-for-asp-net-core-dotnet/).