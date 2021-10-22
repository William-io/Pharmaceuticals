using Pharmaceuticals.Models;
using Pharmaceuticals.Repository;

namespace Pharmaceuticals.LaboratoryScreens
{
    public static class UpdateLaboratoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um Laboratorios");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Laboratory
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuLaboratoryScreen.Load();
        }

        public static void Update(Laboratory laboratory)
        {
            try
            {
                var repository = new Repository<Laboratory>(Database.Connection);
                repository.Update(laboratory);
                Console.WriteLine("Laboratorios atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a Laboratorios");
                Console.WriteLine(ex.Message);
            }
        }
    }
}