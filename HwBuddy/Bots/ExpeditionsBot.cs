using HwBuddy.Actions;
using HwBuddy.Bots.Base;
using HwBuddy.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Bots
{
    public class ExpeditionsBot : BaseBot
    {
        public ExpeditionsBot() : base(StepsFactory.GetExpeditionsSteps())
        {

        }
        public override void Step()
        {
            if (ImageService.CursorToImage(Images.EXPEDITIONS_RED_DOT))
            {
                ImageService.DoMouseClick();
                return;
            }

            if (ImageService.CursorToImage(Images.EXPEDITIONS_AUTO))
            {
                ImageService.DoMouseClick();
                return;
            }

            if (ImageService.CursorToImage(Images.EXPEDITIONS_COLLECT))
            {
                ImageService.DoMouseClick();
                return;
            }

            if (ImageService.CursorToImage(Images.EXPEDITIONS_START))
            {
                ImageService.DoMouseClick();
                return;
            }

            if (ImageService.CursorToImage(Images.EXPEDITIONS_START_2))
            {
                ImageService.DoMouseClick();
                return;
            }

            if (ImageService.CheckImagePresent(Images.EXPEDITIONS_DONE,0.75))
            {
                ImageService.PressEsc();
                return;
            }

            if (ImageService.CursorToImage(Images.EXPEDITIONS_CLOSE))
            {
                ImageService.DoMouseClick();
                return;
            }
        }
    }
    
}
