using Pharmaceuticals.Models;
using Pharmaceuticals.Repository;

namespace Pharmaceuticals.LaboratoryScreens
{
    public static class CreateLaboratoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("-------------");

            Console.Write("Nome do Laboratorio: ");
            var name = Console.ReadLine();

            Console.Write("CNPJ: ");
            var cnpj = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("pass: ");
            var passwordHash = Console.ReadLine();
            Console.Write("address: ");
            var address = Console.ReadLine();

            Console.Write("image: ");
            var image = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();



            Create(new Laboratory
            {
                Name = name,
                CNPJ = cnpj,
                Email = email,
                PasswordHash = passwordHash,
                Address = address,
                Image = image,
                Slug = slug,
            });
            Console.ReadKey();
            MenuLaboratoryScreen.Load();
        }

        public static void Create(Laboratory laboratory)
        {
            try
            {
                var repository = new Repository<Laboratory>(Database.Connection);
                repository.Create(laboratory);
                Console.WriteLine("Tag cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}