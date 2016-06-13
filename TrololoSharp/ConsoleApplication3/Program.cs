using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ensage;
using Ensage.Common;
using Ensage.Menu;
using System.Security.Permissions;
using SharpDX;
using Ensage.Common.Extensions;
using SharpDX.Direct3D9;
using System.Windows.Input;
using Ensage.Common.Menu;

namespace TrololoSharp
{
    using System.ComponentModel.Design;
    using System.Security.Cryptography;

    class Program
    {
        private static readonly Menu Menu = new Menu("TROLOLO#", "trololo", true);
        static void Main(string[] args)
        {
            Console.WriteLine("Trololo# by Lenovers Loaded! :D");
            var optionsmenu = new Menu("Options", "options");
            optionsmenu.AddItem(new MenuItem("Active", "OFF/ON").SetValue(true));
            optionsmenu.AddItem(new MenuItem("Russian", "ENG/RU").SetValue(true));
            Menu.AddSubMenu(optionsmenu);
            Menu.AddToMainMenu();
            var IsActive = Menu.Item("Active").GetValue<bool>();
            var me = ObjectManager.LocalHero;
            var activ = IsActive.Equals(false);
            




            if (!Game.IsInGame || Game.IsPaused || activ)
            {
                return;
            }
            else
            {
                if (me.IsReincarnating)
                {
                    var ReinRand0 = "say AHAHAHAHA! DADDY IS COME BACK, BITCHES!";
                    var ReinRand1 = "say COME ON BITCH, IM UNDED!";
                    var ReinRand2 = "say I'LL TAKE U WITH ME!";
                    var Randomer = new Random();
                    switch (Randomer.Next(2))
                    {
                        case 0:
                            Game.ExecuteCommand(ReinRand0);
                            break;
                        case 1:
                            Game.ExecuteCommand(ReinRand1);
                            break;
                        case 2:
                            Game.ExecuteCommand(ReinRand2);
                            break;
                    }
                }
                if (me.IsMagicImmune() & me.IsVisibleToEnemies)
                {
                    var bkbrand0 = "say LOL, NOW U CAN'T CATCH ME!";
                    var bkbrand1 = "say COME ON BITCH, IM GOLDEN!";
                    var bkbrand2 = "say I'M UNSTOPPABLE!";
                    var randomer = new Random();
                    switch (randomer.Next(2))
                    {
                        case 0:
                            Game.ExecuteCommand(bkbrand0);
                            break;
                        case 1:
                            Game.ExecuteCommand(bkbrand1);
                            break;
                        case 2:
                            Game.ExecuteCommand(bkbrand2);
                            break;
                    }
                }
            }
        }
    }
}
