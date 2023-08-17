/*
dotnet add package Microsoft.EntityFrameworkCore

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet ef dbcontext scaffold "Server=localhost\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;Encrypt=no;" Microsoft.EntityFrameworkCore.SqlServer -o Models
*/

using EntityFrameworkTesti.Models;

NorthwindContext konteksti = new();

// LINQ-kysely
var suomalaiset = from c in konteksti.Customers
                  where c.Country == "Finland"
                  select c;

foreach (var suomalainen in suomalaiset)
{
    Console.WriteLine(suomalainen.CompanyName);
}
