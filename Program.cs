// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using Pharmaceuticals.Models;

Console.WriteLine("///");

const string CONNECTION_STRING = @"Data Source=(localdb)\\MSSQLLocalDB;Database=Laboratory;Trusted_Connection=True;MultipleActiveResultSets=True;";

static void ReadLaboratories()
{
    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        var laboratories = connection.GetAll<Laboratory>();

        foreach (var laboratory in laboratories)
        {
            Console.WriteLine(laboratory.Name);
        }
    }

}

