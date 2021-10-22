using Pharmaceuticals.Models;
using Pharmaceuticals.Repository;

namespace Pharmaceuticals.LaboratoryScreens
{
    public static class DeleteLaboratoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma Laboratorios");
            Console.WriteLine("-------------");
            Console.Write("Qual o id da Laboratorios que deseja exluir? ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuLaboratoryScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Laboratory>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Laboratorios exluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir a Laboratorios");
                Console.WriteLine(ex.Message);
            }
        }
    }
}