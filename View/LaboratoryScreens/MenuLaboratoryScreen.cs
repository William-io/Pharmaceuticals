using System;

namespace Pharmaceuticals.LaboratoryScreens
{
    public static class MenuLaboratoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Laboratorios");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Laboratorios");
            Console.WriteLine("2 - Cadastrar Laboratorios");
            Console.WriteLine("3 - Atualizar Laboratorios");
            Console.WriteLine("4 - Excluir Laboratorios");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListLaboratoryScreen.Load();
                    break;
                case 2:
                    CreateLaboratoryScreen.Load();
                    break;
                case 3:
                    UpdateLaboratoryScreen.Load();
                    break;
                case 4:
                    DeleteLaboratoryScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}