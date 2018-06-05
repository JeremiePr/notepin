# notepin project

Sample App using ASP.NET Core Web API

## What is it?

this project is a sample application built with ASP.NET Core.
It can be used as a reference for creating a simple one-project ASP.NET Core Web API application.

## Project Info

The project uses a SQL Server database.

It requires the use of the package [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/).

To connect to SQL Server, the easiest way is adding this code at the root of the ```appsettings.json```:

```
"ConnectionStrings": {
    "DefaultConnection": "Server=MyServer;Database=MyDatabase;User Id=MyUsername;Password=MyPassword;"
}
```


## Thanks

Thanks to you for finding this repo
