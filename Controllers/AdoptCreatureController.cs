using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamagotchi.Services;
using Tamagotchi.Views;

namespace Tamagotchi.Controllers
{
    public class AdoptCreatureController
    {
        public static Creature? SelectedCreature { get; set; }

        public static void AdoptCreature()
        {
            TamagotchiView.AdoptCreatureMenu(TamagotchiController.Username);
            char option = char.Parse(Console.ReadLine().ToUpper());

            if (char.IsDigit(option))
            {
                string creatureName = DefaultCreatures.defaultCreatures[option - '0' - 1];
                SelectedCreature = TamagotchiService.GetCreatureJsonObjAsync(creatureName);
            }

            else
            {
                switch (option)
                {
                    case 'P':
                        {
                            TamagotchiView.AdoptCreatureSearchMenu(TamagotchiController.Username);
                            string creatureName = Console.ReadLine();

                            SelectedCreature = TamagotchiService.GetCreatureJsonObjAsync(creatureName);

                            break;
                        }

                    case 'X':
                        {
                            return;
                        }
                }
            }

            char subopt = '0';
            while (subopt != 'X' && subopt != '1')
            {
                TamagotchiView.AdoptCreatureSelectedMenu(SelectedCreature);
                subopt = char.Parse(Console.ReadLine().ToUpper());

                switch (subopt)
                {
                    case '1':
                        {
                            TamagotchiView.AdoptedCreatureMenu();
                            break;
                        }

                    case '2':
                        {
                            TamagotchiView.CreatureStatusMenu(SelectedCreature);
                            break;
                        }

                    case 'X':
                        {
                            break;
                        }
                }
            }









        }



    }
}
