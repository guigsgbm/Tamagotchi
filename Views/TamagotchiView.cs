namespace Tamagotchi.Views
{
    public  class TamagotchiView
    {

        public static void WelcomeMenu()
        {

            Console.WriteLine("   _______                                _       _     _   ");
            Console.WriteLine("  |__   __|                              | |     | |   (_)  ");
            Console.WriteLine("     | | __ _ _ __ ___   __ _  __ _  ___ | |_ ___| |__  _   ");
            Console.WriteLine("     | |/ _` | '_ ` _ \\ / _` |/ _` |/ _ \\| __/ __| '_ \\| |  ");
            Console.WriteLine("     | | (_| | | | | | | (_| | (_| | (_) | || (__| | | | |  ");
            Console.WriteLine("     |_|\\__,_|_| |_| |_|\\__,_|\\__, |\\___/ \\__\\___|_| |_|_| ");
            Console.WriteLine("                               __/ |                       ");
            Console.WriteLine("                              |___/                        ");



            Console.WriteLine($"Digite seu username:");
        }


        public static void MainMenu(string userName)
        {
            Console.Clear();
            Console.WriteLine($"- - - - - - - - - - BEM VINDO, {userName} - - - - - - - - - -");
            Console.WriteLine($"{userName}, voce deseja:");
            Console.WriteLine($"1 - Adotar um novo mascote.");
            Console.WriteLine($"2 - Ver meus mascotes:");
            Console.WriteLine($"X - Sair");
        }



        public static void AdoptCreatureMenu(string userName)
        {
            Console.Clear();
            Console.WriteLine($"{userName}, escolha um mascote ou pesquise pelo nome");

            DefaultCreatures.GetCreatures();

            Console.WriteLine($"P - Pesquisar");
            Console.WriteLine($"X - Voltar");
        }

        public static void AdoptCreatureSearchMenu(string username)
        {
            Console.Clear();

            Console.WriteLine($"Digite o nome do mascote (ex: pikachu)");
        }

        public static void AdoptCreatureSelectedMenu(Creature creature)
        {
            Console.Clear();
            Console.WriteLine($"O mascote escolhido foi: {creature.name.ToUpper()}");
            Console.WriteLine($"O que deseja fazer ?");

            Console.WriteLine($"1 - Adotar");
            Console.WriteLine($"2 - Ver status");
            Console.WriteLine($"X - Voltar");
        }
        

        public static void CreatureStatusMenu(Creature creature)
        {
            Console.Clear();
            Console.WriteLine($"Informacoes Basicas");
            Console.WriteLine($"Nome: {creature.name.ToUpper()}");
            Console.WriteLine($"Altura: {creature.height}");
            Console.WriteLine($"Peso: {creature.weight}");

            Console.WriteLine("\n" + $"Tipo");
            foreach (Tamagotchi.Type type in creature.types)
            {
                Console.WriteLine($"{type.slot}: {type.name}");
            }


            Console.WriteLine("\n" + $"Status");
            foreach (Stat stat in creature.stats)
            {
                Console.WriteLine($"{stat.name}: {stat.base_stat}");
            }

            Console.ReadKey();
        }

        

        public static void AdoptedCreatureMenu()
        {
            Console.Clear();
            Console.WriteLine($"Mascote adotado com sucesso!!!\n");
            Console.WriteLine($"O ovo está sendo incubado...\n\n\n");


            Console.WriteLine("                    ████████                                  ");
            Console.WriteLine("                  ██        ██                                ");
            Console.WriteLine("                ██▒▒▒▒        ██                              ");
            Console.WriteLine("              ██▒▒▒▒▒▒      ▒▒▒▒██                            ");
            Console.WriteLine("            ██  ▒▒▒▒        ▒▒▒▒▒▒██                          ");
            Console.WriteLine("            ██                ▒▒▒▒██                          ");
            Console.WriteLine("          ██▒▒      ▒▒▒▒▒▒          ██                        ");
            Console.WriteLine("          ██      ▒▒▒▒▒▒▒▒▒▒        ██                        ");
            Console.WriteLine("          ██      ▒▒▒▒▒▒▒▒▒▒    ▒▒▒▒██                        ");
            Console.WriteLine("          ██▒▒▒▒  ▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                        ");
            Console.WriteLine("            ██▒▒▒▒  ▒▒▒▒▒▒    ▒▒▒▒██                          ");
            Console.WriteLine("            ██▒▒▒▒            ▒▒▒▒██                          ");
            Console.WriteLine("              ██▒▒              ██                            ");
            Console.WriteLine("                ████        ████                              ");
            Console.WriteLine("                    ████████                                  ");

            Console.ReadKey();
        }



        public static void MyCreaturesMenu(List<Creature> myCreatures)
        {
            Console.Clear();

            Console.WriteLine($"Meus mascotes:\n");

            foreach (Creature creature in myCreatures)
            {
                Console.WriteLine($"{myCreatures.IndexOf(creature)} - {creature.name} - " +
                    $"Happiness:{creature.Happiness} | Hunger:{creature.Hunger} | Rest:{creature.Rest}");
            }

            Console.WriteLine("X - Voltar");
        }

        public static void MyCreatureSelectedMenu(Creature myCreature)
        {
            Console.Clear();

            Console.WriteLine($"O que deseja fazer com o mascote: {myCreature.name.ToUpper()} ?");
            Console.WriteLine($"1 - ALIMENTAR");
            Console.WriteLine($"2 - BRINCAR");
            Console.WriteLine($"3 - DESCANSAR");
            Console.WriteLine($"X - Voltar");
        }

        public static void FeedCreatureMenu(Creature myCreature, int myCreaturePreHunger)
        {
            Console.Clear();

            Console.WriteLine($"Alimentando {myCreature.name.ToUpper()}...");
            Console.WriteLine($"{myCreaturePreHunger} > {myCreature.Hunger}");
            Console.ReadKey();
        }

        public static void PlayWithCreatureMenu(Creature myCreature, int myCreaturePreHappiness)
        {
            Console.Clear();

            Console.WriteLine($"Brincando com {myCreature.name.ToUpper()}...");
            Console.WriteLine($"{myCreaturePreHappiness} > {myCreature.Happiness}");
            Console.ReadKey();
        }

        public static  void RestMenu(Creature myCreature, int myCreaturePreRest)
        {
            Console.Clear();

            Console.WriteLine($"{myCreature.name.ToUpper()} foi descansar...");
            Console.WriteLine($"{myCreaturePreRest} > {myCreature.Rest}");
            Console.ReadKey();
        }


        public static void Exit (string username)
        {
            Console.WriteLine($"Tchau {username}, encerrando...");
            Console.ReadKey();
        }


    }
}
