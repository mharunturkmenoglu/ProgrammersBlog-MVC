# ProgrammersBlog 

This project created
using ASP.NET Core and EntityFramework Core.

## Prerequirements

* Visual Studio 2022
* .NET Core 5.0.7 SDK
* MSSQL Server

---

## How To Run

### Migrating
* Open Windows PowerShell in administrative mode.
* ```cd``` to the directory ```~/ProgrammersBlog-MVC/ProgrammersBlog.Data```
* Copy the following code, run it on the shell.
```bash
 dotnet ef --startup-project ../ProgrammersBlog.Mvc database update
```
---

### Running
* Open solution in Visual Studio 2022
* Set ProgrammersBlog.Mvc.csproj project as Startup Project and build the project.
* Run the application using IIS Express.

---

<p align="center">
  <img src="https://user-images.githubusercontent.com/75381086/180672155-2e9a8b74-d6b9-4950-9f21-65425d056098.png">
</p>
<p align="center">
  <img src="https://user-images.githubusercontent.com/75381086/180672199-e4091bd7-11c4-40c6-a778-a48783561829.png">
</p>
<p align="center">
  <img src="https://user-images.githubusercontent.com/75381086/180672229-c8b6e427-66dd-456e-8665-4be1304e0369.png">
</p>
