// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using Pharmaceuticals.Models;
using Pharmaceuticals.Repository;

const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Database=Medicament;Trusted_Connection=True;MultipleActiveResultSets=True;";

var connection = new SqlConnection(CONNECTION_STRING);
connection.Open();

// ReadLaboratories();
// ReadLaboratory();
// CreateLaboratory();
// UpdateLaboratory();
// DeleteLaboratory();
connection.Close();



static void ReadLaboratories(SqlConnection connection)
{
    var repository = new LaboratoryRepository(connection);
    var laboratories = repository.Get();

    foreach (var laboratory in laboratories)
        Console.WriteLine(laboratory.Name);

}


static void ReadLaboratory()
{
    using (var connection = new SqlConnection())
    {
        var laboratory = connection.Get<Laboratory>(1);
        Console.WriteLine(laboratory.Name);
    }
}

static void CreateLaboratory()
{
    var laboratory = new Laboratory()
    {
        Email = "capuletos@live.com",
        Address = "Professor Teodorico",
        Image = "https://....",
        Name = "Cept laboratory",
        PasswordHash = "HASH",
        Slug = "equipe-medic",
        CNPJ = "07.426.627/0001"
    };
    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        connection.Insert<Laboratory>(laboratory);
        Console.WriteLine("Cadastro realizado com sucesso!");
    }
}

//Update
static void UpdateLaboratory()
{
    var laboratory = new Laboratory()
    {
        Id = 2,
        Email = "william@live.com",
        Address = "Professor Teodorico",
        Image = "https://....",
        Name = "Cept laboratory",
        PasswordHash = "HASH",
        Slug = "equipe-medic",
        CNPJ = "07.426.627/0001"
    };
    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        connection.Insert<Laboratory>(laboratory);
        Console.WriteLine("Atualização realizada com sucesso!");
    }
}

//Delete

static void DeleteLaboratory()
{
    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        var laboratory = connection.Get<Laboratory>(2);
        connection.Delete<Laboratory>(laboratory);
        Console.WriteLine("Deletado com sucesso!");
    }
}