﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Ensage;
    using Ensage.Common;
    using Ensage.Menu;
    using System.Security.Permissions;
    using SharpDX;
    using Ensage.Common.Extensions;
    using SharpDX.Direct3D9;
    using System.Windows.Input;
    using Ensage.Common.Menu;
    using Ensage.Common.Objects;

    internal class Trolling
    {
        private static Hero me;

        private bool IsActive = Menu.Item("Active").GetValue<bool>();
        private bool activ;
        private static readonly Menu Menu = new Menu("TROLOLO#", "trololo", true);

        public static void Init()
        {
            Console.WriteLine("Trololo# by Lenovers Loaded! :D");
            var optionsmenu = new Menu("Options", "options");
            optionsmenu.AddItem(new MenuItem("Active", "OFF/ON").SetValue(true));
            optionsmenu.AddItem(new MenuItem("Russian", "ENG/RU").SetValue(true));
            Menu.AddSubMenu(optionsmenu);
            Menu.AddToMainMenu();
            Events.OnLoad += Events_OnLoad;
            Events.OnClose += Events_OnClose;
        }
        private static void Events_OnLoad(object sender, EventArgs e)
        {
            me = ObjectManager.LocalHero;
            Game.PrintMessage(
                "<font face='Tahoma'><font color='#000000'>[--</font> <font color='#33ff66'>TrololoSharp</font> by <font color='#999999'>LEON</font><font color='#ff9900'>OVERS</font> loaded! <font color='#000000'>--]</font></font>",
                MessageType.LogMessage);
            Events.OnUpdate += Game_OnUpdate;
        }
        private static void Events_OnClose(object sender, EventArgs e)
        {
            Events.OnUpdate -= Game_OnUpdate;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            var IsActive = Menu.Item("Active").GetValue<bool>();
            var activ = IsActive.Equals(false);
            if (!Game.IsInGame || Game.IsPaused || activ)
            {
                return;
            }
            else
            {
                if (me.IsReincarnating && Utils.SleepCheck("Reinlol"))
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
                    Utils.Sleep(7000 + Game.Ping, "Reinlol");
                }
                if (me.IsMagicImmune() && me.IsVisibleToEnemies && Utils.SleepCheck("Bkblol"))
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
                    Utils.Sleep(15000 + Game.Ping, "Bkblol");
                }
                if (me.Player.KillStreak.Equals(3) && Utils.SleepCheck("triple"))
                {
                    var metrand0 = "say OH BABY A TRIPLE! OH YEAH!";
                    var metrand1 = "say NOOBS CONFIRMED";
                    var metrand2 = "say EZ TRIPLE";
                    var randomer = new Random();
                    switch (randomer.Next(2))
                    {
                        case 0:
                            Game.ExecuteCommand(metrand0);
                            break;
                        case 1:
                            Game.ExecuteCommand(metrand1);
                            break;
                        case 2:
                            Game.ExecuteCommand(metrand2);
                            break;
                    }
                    Utils.Sleep(20000 + Game.Ping, "triple");
                }
                if (me.Player.KillStreak.Equals(5) && Utils.SleepCheck("rampage"))
                {
                    var metrand0 = "say OH MY GOD! VOLVO FIX IT PLEASE!";
                    var metrand1 = "say EZ GAME DEAL WITH IT!";
                    var metrand2 = "say EZ TRIPLE";
                    var randomer = new Random();
                    switch (randomer.Next(2))
                    {
                        case 0:
                            Game.ExecuteCommand(metrand0);
                            break;
                        case 1:
                            Game.ExecuteCommand(metrand1);
                            break;
                        case 2:
                            Game.ExecuteCommand(metrand2);
                            break;
                    }
                    Utils.Sleep(12000 + Game.Ping, "rampage");
                }
                if (me == null || me.ClassID != ClassID.CDOTA_Unit_Hero_Invoker)
                {
                    return;
                }
                else
                {

                }
            }
        }
    }
}
