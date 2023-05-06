using Tamagotchi.Views;
using Tamagotchi.Services;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public static class TamagotchiController
    {
        private static char option {get; set;}
       

        public static void Play(List<string> defaultCreatures)
        {

            TamagotchiView.WelcomeMenu();
            MyAccount.Username = Console.ReadLine();

            while (option != 'X')
            {
                TamagotchiView.MainMenu(MyAccount.Username);
                option = char.Parse(Console.ReadLine().ToUpper());

                switch (option)
                {
                    case '1':
                        {
                            AdoptCreatureController.AdoptCreature();
                            break;
                        }

                    case '2':
                        {
                            ViewMyCreaturesController.ViewMyCreatures();
                            break;
                        }

                    case 'X':
                        {
                            TamagotchiView.Exit(MyAccount.Username);
                            break;
                        }


                }
            }
























            /*
            List<Creature> myCreatures = new List<Creature>();
            char opt = 'a';
            char subopt = 'a';

            TamagotchiView.WelcomeMenu();
            string userName = Console.ReadLine();


            while (opt != 'x')
            {
                TamagotchiView.MainMenu(userName);
                opt = char.Parse(Console.ReadLine());



                switch (opt)
                {
                    case '1':
                        {
                            TamagotchiView.AdoptCreatureMenu(userName);

                            subopt = char.Parse(Console.ReadLine().ToUpper());

                            if (char.IsDigit(subopt))
                            {
                                int digit = subopt - '0';
                                Creature creature = await TamagotchiService.GetCreatureJsonObjAsync(defaultCreatures[digit - 1]);



                                char subopt2 = '1';
                                while (subopt2 == '1')
                                {
                                    TamagotchiView.SelectedCreatureMenu(userName, creature);
                                    subopt2 = char.Parse(Console.ReadLine().ToUpper());

                                    switch (subopt2)
                                    {
                                        case '1':
                                            {
                                                TamagotchiView.ViewCreatureDetailsSubMenu(creature);
                                                break;
                                            }

                                        case '2':
                                            {
                                                TamagotchiView.AdoptSubMenu(myCreatures, creature);
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

                                            Task<Creature> search = TamagotchiService.GetCreatureJsonObjAsync(Console.ReadLine());
                                            Creature creature = search.Result;

                                            char subopt2 = '1';
                                            while (subopt2 == '1')
                                            {
                                                TamagotchiView.SelectedCreatureMenu(userName, creature);
                                                subopt2 = char.Parse(Console.ReadLine().ToUpper());

                                                switch (subopt2)
                                                {
                                                    case '1':
                                                        {
                                                            TamagotchiView.ViewCreatureDetailsSubMenu(creature);
                                                            break;
                                                        }

                                                    case '2':
                                                        {
                                                            TamagotchiView.AdoptSubMenu(myCreatures, creature);
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
                            TamagotchiView.MyCreaturesMenu(myCreatures);
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
        }
    }
}