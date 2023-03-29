using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Tamagotchi;
using Tamagotchi.Views;
using Tamagotchi.Services;

namespace Tamagotchi.Controllers
{
    public class TamagotchiController
    {

        public void Play(List<Creature> defaultCreatureList)
        {

            TamagotchiView view = new TamagotchiView();
            Creature creature = new Creature();
            List<Creature> myCreatures = new List<Creature>();
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
                                creature = defaultCreatureList[digit - 1];


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

                                            Task<Creature> search = TamagotchiService.GetCreatureJsonObjAsync(Console.ReadLine());
                                            creature = search.Result;

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
                            view.MyCreaturesMenu(myCreatures);
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

            
        }
    }
}