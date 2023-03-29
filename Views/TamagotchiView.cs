using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Tamagotchi.Services;



namespace Tamagotchi.Views
{
    public  class TamagotchiView
    {
        Iterations iterations = new Iterations();

        public void WelcomeMenu()
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


        public void MainMenu(string userName)
        {
            Console.Clear();
            Console.WriteLine($"- - - - - - - - - - BEM VINDO, {userName} - - - - - - - - - -");
            Console.WriteLine($"{userName}, voce deseja:");
            Console.WriteLine($"1 - Adotar um novo mascote.");
            Console.WriteLine($"2 - Ver meus mascotes:");
            Console.WriteLine($"X - Sair");
        }





        public void AdoptNewCreatureMenu(string userName, List<Creature> creatureList)
        {

            Console.Clear();
            Console.WriteLine($"{userName}, escolha um mascote ou pesquise outro pelo nome (ex: 'pikachu')");
           foreach (Creature creature in creatureList)
            {
                Console.WriteLine($"{creatureList.IndexOf(creature)+1} - {creature.name}");
            }
            Console.WriteLine($"\nP - Pesquisar");
            Console.WriteLine($"X - Voltar");
        }

        public void SelectedCreatureMenu(string userName, Creature selectedCreature)
        {
            Console.Clear();
            Console.WriteLine($"O mascote escolhido foi {selectedCreature.name}");
            Console.WriteLine($"{userName} o que deseja fazer:");
            Console.WriteLine($"1 - Ver caracteristicas");
            Console.WriteLine($"2 - Adotar {selectedCreature.name}");
            Console.WriteLine($"X - Voltar");
        }
        

        public async void ViewCreatureDetailsSubMenu(Creature creature)
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

        

        public void AdoptSubMenu(List<Creature> myCreatures, Creature creature)
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

            myCreatures.Add(creature);
            Console.ReadKey();
        }



        public void MyCreaturesMenu(List<Creature> myCreatures)
        {
            Console.Clear();

            int indexMyCreatureSelected = 1;

            Console.WriteLine($"Meus mascotes:\n");
            foreach (Creature myCreature in myCreatures)
            {
                Console.WriteLine($"{indexMyCreatureSelected} - {myCreature.name} - " +
                    $"Happiness:{myCreature.Happiness} | Hunger:{myCreature.Hunger} | Rest:{myCreature.Rest}");
                indexMyCreatureSelected++;
            }
            Console.WriteLine("X - Voltar");
            
            indexMyCreatureSelected = int.Parse(Console.ReadLine());
            Creature myCreatureSelected = myCreatures[indexMyCreatureSelected-1];

            Console.Clear();
            Console.WriteLine($"O QUE DESEJA FAZER COM O MASCOTE: {myCreatureSelected.name.ToUpper()}");
            Console.WriteLine($"1 - ALIMENTAR");
            Console.WriteLine($"2 - BRINCAR");
            Console.WriteLine($"3 - DESCANSAR");
            Console.WriteLine($"X - Voltar");

            var option = char.Parse(Console.ReadLine());

            switch (option)
            {
                case '1':
                    {
                        Console.Clear();
                        Console.WriteLine($"Alimentando {myCreatureSelected.name}".ToUpper());
                        Iterations.FeedCreature(myCreatureSelected);
                        Console.ReadKey();
                        break;
                    }

                case '2':
                    {
                        Console.Clear();
                        Console.WriteLine($"Brincando com {myCreatureSelected.name}".ToUpper());
                        Iterations.PlayWithCreature(myCreatureSelected);
                        Console.ReadKey();
                        break;
                    }

                case '3':
                    {
                        Console.Clear();
                        Console.WriteLine($"{myCreatureSelected.name} foi nanar".ToUpper());
                        Iterations.RestCreature(myCreatureSelected);
                        Console.ReadKey();
                        break;
                    }

                case 'X':
                    { break;}

            }
        }





    }
}
