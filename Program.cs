// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using Pharmaceuticals.Models;
using Pharmaceuticals.Repository;

const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Database=Medicament;Trusted_Connection=True;MultipleActiveResultSets=True;";

var connection = new SqlConnection(CONNECTION_STRING);
connection.Open();

ReadLaboratories(connection);
ReadRoles(connection);
ReadTags(connection);

connection.Close();


static void ReadLaboratories(SqlConnection connection)
{
    var repository = new Repository<Laboratory>(connection);
    var laboratories = repository.Get();

    // repository.Delete(1);

    foreach (var laboratory in laboratories)
        Console.WriteLine(laboratory.Name);
}

static void ReadRoles(SqlConnection connection)
{
    var repository = new Repository<Role>(connection);
    var items = repository.Get();

    foreach (var item in items)
        Console.WriteLine(item.Name);
}

static void ReadTags(SqlConnection connection)
{
    var repository = new Repository<Tag>(connection);
    var items = repository.Get();

    foreach (var item in items)
        Console.WriteLine(item.Name);
}

//03:13