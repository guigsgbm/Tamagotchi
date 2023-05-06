using Tamagotchi;
using Tamagotchi.Controllers;
using Tamagotchi.Models;

List<Creature> myCreatures = new List<Creature>();

MyAccount.Creatures = new();
TamagotchiController.Play(DefaultCreatures.defaultCreatures);




















/*List<Creature> myCreatures = new List<Creature>();
TamagotchiView view = new TamagotchiView();
Creature creature = new Creature();

List<Creature> defaultCreatureList = new List<Creature>();
defaultCreatureList.Add(await TamagotchiService.GetCreatureJsonObjAsync($"pikachu"));
defaultCreatureList.Add(await TamagotchiService.GetCreatureJsonObjAsync($"charizard"));
defaultCreatureList.Add(await TamagotchiService.GetCreatureJsonObjAsync($"charmander"));
defaultCreatureList.Add(await TamagotchiService.GetCreatureJsonObjAsync($"eevee"));



string userName;
char opt = 'a';
char subopt = 'a';




view.WelcomeMenu();
userName = Console.ReadLine();


while (opt != 'x')
{
    view.MainMenu(userName);
    opt = char.Parse(Console.ReadLine());

    switch (opt)
    {
        case '1':
            {
                view.AdoptNewCreatureMenu(userName, defaultCreatureList);

                subopt = char.Parse(Console.ReadLine().ToUpper());

                if (char.IsDigit(subopt))
                {
                    int digit = subopt - '0';
                    creature = defaultCreatureList[digit-1];

                    
                    char subopt2 = '1';
                    while (subopt2 == '1')
                    {

                        view.SelectedCreatureMenu(userName, creature);
                        subopt2 = char.Parse(Console.ReadLine().ToUpper());

                        switch (subopt2)
                        {
                            case '1':
                                {
                                    view.ViewCreatureDetailsSubMenu(creature);
                                    break;
                                }

                            case '2':
                                {
                                    view.AdoptSubMenu(myCreatures, creature);
                                    break;
                                }

                            case 'X':
                                {
                                    break;
                                }
                        }
                    }
                }


                else
                {
                    switch (subopt)
                    {
                        case 'P':
                            {
                                Console.Clear();
                                Console.WriteLine($"Digite o nome do mascote (ex: ´pikachu')");
                                creature = await TamagotchiService.GetCreatureJsonObjAsync(Console.ReadLine());
                                
                                char subopt2 = '1';
                                while (subopt2 == '1')
                                {

                                    view.SelectedCreatureMenu(userName, creature);
                                    subopt2 = char.Parse(Console.ReadLine().ToUpper());

                                    switch (subopt2)
                                    {
                                        case '1':
                                            {
                                                view.ViewCreatureDetailsSubMenu(creature);
                                                break;
                                            }

                                        case '2':
                                            {
                                                view.AdoptSubMenu(myCreatures, creature);
                                                break;
                                            }

                                        case 'X':
                                            {
                                                break;
                                            }
                                    }
                                }
                                break;
                            }

                        case 'X':
                            {
                                Console.WriteLine("VOLTAR");
                                break;
                            }
                    }
                }

               


                break;
            }


        case '2':
            {
                Console.Clear();

                Console.WriteLine($"Meus mascotes:\n");
                foreach (Creature myCreature in myCreatures)
                {
                    Console.WriteLine($"{myCreature.name.ToUpper()}");
                }

                Console.ReadKey();

                break;
            }

        case 'x':
            {
                Console.Clear();
                Console.WriteLine($"Finalizando...");
                break;
            }



    }
}
*/


///////////////////////////////////////////////////////////////////////////////


/*
int opt1 = 1;
int creatureIndex = 1;
string chosenCreatureName;




List<string> creaturesNames = new List<string>();
creaturesNames.Add("Charizard");
creaturesNames.Add("Pikachu");
creaturesNames.Add("Eevee");


while (opt1 != 0)
{
    Console.Clear();
    Console.WriteLine($"- - - - - - - - - - BEM VINDO, {username} - - - - - - - - - -");
    Console.WriteLine($"{username}, voce deseja:");
    Console.WriteLine($"1 - Adotar um novo mascote.");
    Console.WriteLine($"2 - Ver meus mascotes:");
    Console.WriteLine($"0 - Sair");

    opt1 = int.Parse(Console.ReadLine());

    switch (opt1)
    {
        case 1:
            Console.Clear();
            Console.WriteLine($"{username}, escolha um mascote:");
            foreach (string creatureName in creaturesNames)
            {
                Console.WriteLine($"{creaturesNames.IndexOf(creatureName) +1} - {creatureName}");
            }
            Console.WriteLine($"0 - Voltar");

            creatureIndex = int.Parse(Console.ReadLine());
            chosenCreatureName = creaturesNames[creatureIndex - 1];

            creatureIndex = 1;
            Console.Clear();
            Console.WriteLine($"O mascote escolhido foi {chosenCreatureName}");
            Console.WriteLine($"{username} o que deseja fazer:");
            Console.WriteLine($"1 - Ver caracteristicas");
            Console.WriteLine($"2 - Adotar {chosenCreatureName}");
            Console.WriteLine($"0 - Voltar");
            int subopt1 = int.Parse(Console.ReadLine());

            switch (subopt1)
            {
                case 1:
                    {
                        Creature creature = await TamagotchiService.GetCreatureJsonObjAsync($"{chosenCreatureName}");

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


                        Console.WriteLine("\n \n \nTecle Enter.....");
                        Console.ReadKey();
                        break;
                    }




                case 2:
                    {
                        Creature creature = await TamagotchiService.GetCreatureJsonObjAsync(chosenCreatureName);
                        Console.Clear();
                        Console.WriteLine($"O mascote {creature.name} foi adotado com sucesso!!!");
                        Console.WriteLine($"O ovo esta chocando...");

                        Console.ReadKey();
                        break;
                    }


                case 0:
                    {
                        break;
                    }
            }
            break;



        case 2:
            Console.Clear();
            Console.WriteLine($"Vendo mascotes...");
            break;

        case 0:
            Console.Clear();
            Console.WriteLine($"Encerrando...");
            return;

    }
}
*/