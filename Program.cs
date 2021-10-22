// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using Pharmaceuticals.Models;
using Pharmaceuticals.Repository;
using Pharmaceuticals.View;
using Pharmaceuticals;
using Pharmaceuticals.LaboratoryScreens;

const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Database=Medicament;Trusted_Connection=True;MultipleActiveResultSets=True;";

Database.Connection = new SqlConnection(CONNECTION_STRING);
Database.Connection.Open();

Load();

// ReadLaboratories(connection);
// ReadRoles(connection);
// ReadTags(connection);
Console.ReadKey();

Database.Connection.Close();

static void Load()
{
    Console.Clear();
    Console.WriteLine("Meu Blog");
    Console.WriteLine("-----------------");
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine();
    Console.WriteLine("1 - Gestão de Laboratorios");
    Console.WriteLine("2 - Gestão de perfil");
    Console.WriteLine("3 - Gestão de categoria");
    Console.WriteLine("4 - Gestão de tag");
    Console.WriteLine("5 - Vincular perfil/usuário");
    Console.WriteLine("6 - Vincular post/tag");
    Console.WriteLine("7 - Relatórios");
    Console.WriteLine();
    Console.WriteLine();
    var option = short.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 1:
            MenuLaboratoryScreen.Load();
            break;
        case 4:
            Menu.Load();
            break;
        default: Load(); break;
    }
}

// static void CreateLaboratory(SqlConnection connection)
// {
//     var laboratory = new Laboratory()
//     {
//         Email = "capuletos@live.com",
//         Address = "Professor Teodorico",
//         Image = "https://....",
//         Name = "Cept laboratory",
//         PasswordHash = "HASH",
//         Slug = "equipe-medic",
//         CNPJ = "07.426.627/0001"
//     };
//     var repository = new Repository<Laboratory>(connection);
//     repository.Create(laboratory);

// }

// static void ReadLaboratories(SqlConnection connection)
// {
//     var repository = new Repository<Laboratory>(connection);
//     var laboratories = repository.Get();

//     // repository.Delete(1);

//     foreach (var laboratory in laboratories)
//         Console.WriteLine(laboratory.Name);
// }

// static void ReadRoles(SqlConnection connection)
// {
//     var repository = new Repository<Role>(connection);
//     var items = repository.Get();

//     foreach (var item in items)
//         Console.WriteLine(item.Name);
// }

// static void ReadTags(SqlConnection connection)
// {
//     var repository = new Repository<Tag>(connection);
//     var items = repository.Get();

//     foreach (var item in items)
//         Console.WriteLine(item.Name);
// }

//03:13