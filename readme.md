## Delta Clinic Center
> this project we be used to minitor clinic's patients history 

### Repository Design Pattern 


### I used dotnet comment 
> so follow this steps to get the project running 

1. ensure that your install dontent-ef tool 

```
dotnet tool install --global dotnet-ef
```
2. Open a command prompt in the Web folder and execute the following commands:

```
dotnet restore
dotnet tool restore
dotnet ef database update -c AppDbContext -p ..\DeltaCenter.Infrastructure\DeltaCenter.Infrastructure.csproj -s Web.csproj
dotnet ef database update -c appidentitydbcontext -p ../Infrastructure/Infrastructure.csproj -s Web.csproj
```