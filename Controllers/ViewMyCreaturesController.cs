using Tamagotchi.Views;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class ViewMyCreaturesController
    {


        public static void ViewMyCreatures()
        {

            TamagotchiView.MyCreaturesMenu(MyAccount.Creatures);

            char option = char.Parse(Console.ReadLine());

            if (char.IsDigit(option))
            {
                TamagotchiView.MyCreatureSelectedMenu(MyAccount.Creatures[option - '0' - 1]);
                Creature selectedCreature = MyAccount.Creatures[option - '0' - 1];

                option = char.Parse(Console.ReadLine().ToUpper());

                switch (option)
                {
                    case '1':
                        {
                            TamagotchiView.FeedCreatureMenu(selectedCreature);
                            Iterations.FeedCreature(selectedCreature);
                            break;
                        }

                    case '2':
                        {
                            TamagotchiView.PlayWithCreatureMenu(selectedCreature);
                            Iterations.PlayWithCreature(selectedCreature);
                            break;
                        }

                    case '3':
                        {
                            TamagotchiView.RestMenu(selectedCreature);
                            Iterations.RestCreature(selectedCreature);
                            break;
                        }

                    case 'X':
                        {
                            break;
                        }


                }
            }
            else
                return;

        }

    }
}
