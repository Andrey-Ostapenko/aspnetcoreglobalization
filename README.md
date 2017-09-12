# aspnetcoreglobalization
This repo contains the sample project which demonstrate globalization localization using ASP.NET Core 2.0

## Usage Case
I have written series of blog post on aspnet core globalization and localization. You can refer at https://sbrakl.wordpress.com/2017/09/08/globalization-and-localization-in-asp-net-core-part-1/. You will get most of the gist regarding using Resource Manager using aspnet core. This repo acts as sample reference to this article.

There is an article on the Microsoft site, which shows how to do Globalization and localization in ASP.NET Core   
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization   
   
But, this didn't explain the plain use on the Resource Manager, which we did when using .NET Framework 1.1-4.7

This repo has two web api project, which contains resource rs1.resx. 
It contains the string Hello in english (default), spanish and french. 

Lib1.ResRdr is the Classlibrary project, which contains the code to read from resources from the calling assembly.

api1.dll --(calls)--> Lib1.ResRdr.GetHello()   
Lib1.ResRdr.GetHello() creates ResourceManager which reads resource from the api1.dll  
   
api2.dll --(calls)--> Lib1.ResRdr.GetHello()   
Lib1.ResRdr.GetHello() creates ResourceManager which reads resource from the api2.dll

### Note:
This will work only in dotnet core 2.0+, not in dotnet core 1.0 or 1.1, as API's used in Resource Manager weren't there in dotnet core 1.0/1.1

