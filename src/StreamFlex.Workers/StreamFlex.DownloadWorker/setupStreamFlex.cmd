@echo off

SET namespace=StreamFlex.DownloadWorker.
SET solutionPath=D:\termit\StreamFlex\src\StreamFlex.sln

REM Create projects
dotnet new classlib -n %namespace%Core -o %namespace%Core
dotnet new classlib -n %namespace%Services -o %namespace%Services
dotnet new classlib -n %namespace%Infrastructure -o %namespace%Infrastructure
dotnet new webapi -n %namespace%Api -o %namespace%Api
dotnet new classlib -n %namespace%Application -o %namespace%Application
dotnet new xunit -n %namespace%Tests -o %namespace%Tests

REM Add projects to the existing solution
dotnet sln %solutionPath% add %namespace%Core/%namespace%Core.csproj
dotnet sln %solutionPath% add %namespace%Services/%namespace%Services.csproj
dotnet sln %solutionPath% add %namespace%Infrastructure/%namespace%Infrastructure.csproj
dotnet sln %solutionPath% add %namespace%Api/%namespace%Api.csproj
dotnet sln %solutionPath% add %namespace%Application/%namespace%Application.csproj
dotnet sln %solutionPath% add %namespace%Tests/%namespace%Tests.csproj

REM Add project references
dotnet add %namespace%Services/%namespace%Services.csproj reference %namespace%Core/%namespace%Core.csproj
dotnet add %namespace%Infrastructure/%namespace%Infrastructure.csproj reference %namespace%Core/%namespace%Core.csproj
dotnet add %namespace%Api/%namespace%Api.csproj reference %namespace%Services/%namespace%Services.csproj
dotnet add %namespace%Application/%namespace%Application.csproj reference %namespace%Services/%namespace%Services.csproj
dotnet add %namespace%Tests/%namespace%Tests.csproj reference %namespace%Core/%namespace%Core.csproj
dotnet add %namespace%Tests/%namespace%Tests.csproj reference %namespace%Services/%namespace%Services.csproj
dotnet add %namespace%Tests/%namespace%Tests.csproj reference %namespace%Infrastructure/%namespace%Infrastructure.csproj

echo Project setup completed.