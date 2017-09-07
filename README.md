# aspnetcoreglobalization
This repo contains the sample project which demonstrate globalization localization using ASP.NET Core 2.0

## Usage Case
This is article on the Microsoft site, which shows how to do Globalization and localization in ASP.NET Core   
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization   
   
But, this didn't explain the plain use on the Resource Manager, which we did when using .NET Framework 2.0-4.7

This repo has two web api project, which contains resource rs1.resx. 
It contains the string Hello in english (default), spanish and french. 

Lib1.ResRdr is the Classlibrary project, which contains the code to read from resources from the calling assembly.
   

api1.dll --(calls)--> Lib1.ResRdr.GetHello()   
Lib1.ResRdr.GetHello() creates ResourceManager which reads resource from the api1.dll  
   
api2.dll --(calls)--> Lib1.ResRdr.GetHello()   
Lib1.ResRdr.GetHello() creates ResourceManager which reads resource from the api2.dll

### Note:
This will work only in dotnet core 2.0+, not in dotnet core 1.0 or 1.1, as API's used in Resource Manager weren't there in dotnet core 1.0/1.1

I am planning to write wiki page to explain more about the working of ResourceManager. Pray, I get time.

