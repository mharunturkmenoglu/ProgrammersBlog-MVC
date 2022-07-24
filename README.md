# ProgrammersBlog 

This project created
using ASP.NET Core and EntityFramework Core.

## Prerequirements

* Visual Studio 2022
* .NET Core 5.0.7 SDK
* MMSQL Server

## How To Run

* Open Windows PowerShell in administrative mode.
* Change directory ~/ProgrammersBlog-MVC/ProgrammersBlog.Data
```bash
 dotnet ef --startup-project ../ProgrammersBlog.Mvc database update
```
* Open solution in Visual Studio 2022
* Set ProgrammersBlog.Mvc.csproj project as Startup Project and build the project.
* Run the application using IIS Express.
