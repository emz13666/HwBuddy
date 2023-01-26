using HwBuddy.Actions;
using HwBuddy.Bots.Base;
using HwBuddy.Common;
using HwBuddy.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace HwBuddy.Bots
{
    public class TowerBot : BaseBot
    {
        int ToggleButtonc = 0;
        int CanAttackc = 0;
        int NextFloorc = 0;
        int Shrinec = 0;
        int Chestc = 0;
        int CanRaidc = 0;
        int Victoryc = 0;
        int Powerupsc = 0;
        int OpenChestc = 0;
        int MoveOnc = 0;
        int Attackc = 0;
        int CanAttackManuallyc = 0;
        int OkButtonc = 0;
        int FinalChest = 0;
        public TowerBot() : base(null)
        {
        }

        public override void Step()
        {
            Random rnd = new Random();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (ImageService.CursorToImage(Images.TOWER_MOMENT,0.75f))
            {
                ImageService.DoMouseClick();
                System.Threading.Thread.Sleep(1500);
                return;
            }

            if (ImageService.CursorToImage(Images.TOWER_CHOOSE15,0,135))
            {
                ImageService.DoMouseClick();
                return;
            }
            if (ImageService.CursorToImage(Images.TOGGLE_BUTTON))
            {
                ImageService.DoMouseClick();
                ToggleButtonc++;
                return;
            }
            if (ImageService.CursorToImage(Images.TOWER_DOOR))
            {
                ImageService.DoMouseClick();
                CanAttackc++;
                return;
            }
            if (ImageService.CursorToImage(Images.TOWER_ATTACK))
            {
                ImageService.DoMouseClick();
                Attackc++;
                return;
            }
            if (ImageService.CheckImagePresent(Images.VICTORY,0.75f))
            {
               Victoryc++;
               ImageService.PressEsc();
               return;
            }
            if (ImageService.CursorToImage(Images.TOWER_NEXT, 0.75f))
            {
                ImageService.DoMouseClick();
                NextFloorc++;
                return;
            }
            if (ImageService.CursorToImage(Images.TOWER_CHEST) || ImageService.CursorToImage(Images.TOWER_CHEST_BIG))
            {
                ImageService.DoMouseClick();
                Chestc++;
                return;
            }

            if ((FinalChest < 0) && ImageService.CursorToImage(Images.TOWER_HALL))
            {
                ImageService.DoMouseClick();
                System.Threading.Thread.Sleep(300);
                if (ImageService.CursorToImage(Images.POST_COLLECT_ALL))
                {
                    ImageService.DoMouseClick();
                }
                System.Threading.Thread.Sleep(700);
                ImageService.PressEsc();
                System.Threading.Thread.Sleep(700);
                ImageService.PressEsc();
                ImageService.PressF1();
                return;
            }

            if ((FinalChest > 0) && ImageService.CursorToImage(Images.TOWER_SKULLS_COLLECT))
            {
                ImageService.DoMouseClick();
                System.Threading.Thread.Sleep(300);
                if (ImageService.CursorToImage(Images.TOWER_CHANGE_SKILLS,0,0))
                {
                    ImageService.DoMouseClick();
                    FinalChest = -1;
                }
                return;  
            }
            
            if ((FinalChest == 0) && ImageService.CursorToImage(Images.TOWER_CHEST_FINAL))
            {
                ImageService.DoMouseClick();
                FinalChest++;
                return;
            }
            
            if (ImageService.CursorToImage(Images.TOWER_CHEST_MOVEON))
            {
                ImageService.DoMouseClick();
                MoveOnc++;
                return;
            }
            if (ImageService.CursorToImage(Images.TOWER_CHEST_OPEN, 0.9f, -300+300*rnd.Next(3), 100))
            {
                ImageService.DoMouseClick();
                OpenChestc++;
                return;
            }
            if (Shrine())
            {
                ImageService.DoMouseClick();
                Shrinec++;
                return;
            }
            if (ImageService.CheckImagePresent(Images.TOWER_POWERUP_SCREEN))
            {
                ImageService.PressEsc();
                Powerupsc++;
                return;
            }
            if (ImageService.CursorToImage(Images.TOWER_RAID,0.85f,50,0))
            {
                ImageService.DoMouseClick();
                CanRaidc++;
                return;
            }
            if (ImageService.CursorToImage(Images.DUNGEON_ATTACK_BUTTON))
            {
                ImageService.DoMouseClick();
                CanAttackc++;
                return;
            }
            if ((FinalChest > 0) && ImageService.CheckImagePresent(Images.TOWER_LAST_CHEST))
            {
                ImageService.PressEsc();
                return;
            }
            sw.Stop();
        }
        

        

        bool Shrine()
        {
            return  !ImageService.CheckImagePresent(Images.TOWER_NEXT) && (ImageService.CursorToImage(Images.TOWER_SHRINE) || ImageService.CursorToImage(Images.TOWER_SHRINE_2));
        }
    }
}
