using Pharmaceuticals.Models;
using Pharmaceuticals.Repository;

namespace Pharmaceuticals.LaboratoryScreens
{
    public static class ListLaboratoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Laboratorios");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuLaboratoryScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Laboratory>(Database.Connection);
            var tags = repository.Get();
            foreach (var item in tags)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }
    }
}