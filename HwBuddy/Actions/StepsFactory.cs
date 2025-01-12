﻿using HwBuddy.Actions.Campaign;
using HwBuddy.Actions.Dungeon;
using HwBuddy.Actions.Events;
using HwBuddy.Actions.Shared;
using HwBuddy.Actions.TournamentOfElements;
using HwBuddy.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwBuddy.Actions
{
    public static class StepsFactory
    {
        static List<AbstractStep> dungeonSteps = null;
        static List<AbstractStep> toeSteps = null;
        static List<AbstractStep> campaignSteps = null;
        static List<AbstractStep> eventsSteps = null;
        static List<AbstractStep> expeditionsSteps = null;
        static List<AbstractStep> outlandSteps = null;
        static List<AbstractStep> questsSteps = null;
        static List<AbstractStep> postSteps = null;


        public static List<AbstractStep> GetDungeonSteps()
        {
            if (dungeonSteps == null)
            {
                dungeonSteps = new List<AbstractStep>();
                dungeonSteps.Add(new Step(Images.DUNGEON_NEW_CARDS));
                dungeonSteps.Add(new Step(Images.DUNGEON_CARDS_COLLECT));
                dungeonSteps.Add(new Step(Images.DUNGEON_CARDS_CLOSE,0.95f));
                dungeonSteps.Add(new Step(Images.DUNGEON_TO_BATTLE));
                dungeonSteps.Add(new DungeonUseCardStep());
                dungeonSteps.Add(new Step(Images.DUNGEON_ATTACK_MIXFIGHT, 0.95f, 0, 30));
                dungeonSteps.Add(new Step(Images.DUNGEON_ATTACK_WATER, 0.95f, 0, 30));
                dungeonSteps.Add(new Step(Images.DUNGEON_ATTACK_EARTH, 0.95f, 0, 30));
                dungeonSteps.Add(new Step(Images.DUNGEON_ATTACK_FIRE, 0.95f, 0, 30));
                dungeonSteps.Add(new InBattleStep());
                dungeonSteps.Add(new DungeonAttackStep());
                dungeonSteps.Add(new DungeonVictoryStep());
                dungeonSteps.Add(new Step(Images.DUNGEON_ACTIVATION));
                dungeonSteps.Add(new Step(Images.EVENTS_TAKE_DAILY_BUTTON));
            }
            return dungeonSteps;
        }

        public static List<AbstractStep> GetToeSteps()
        {
            if (toeSteps == null)
            {
                toeSteps = new List<AbstractStep>();
                toeSteps.Add(new Step(Images.TOE_RAID));
                toeSteps.Add(new Step(Images.TOE_COLLECT));
                toeSteps.Add(new Step(Images.TOE_CLOSE, 0.9f,152));
                toeSteps.Add(new Step(Images.TOE_CHEST, 0.9f, -20, 30));
                toeSteps.Add(new Step(Images.TOE_COLLECT_ALL));
                toeSteps.Add(new Step(Images.TOE_COLLECT_2));
            }
            return toeSteps;
        }

        public static List<AbstractStep> GetCampaignSteps()
        {
            if (campaignSteps == null)
            {
                campaignSteps = new List<AbstractStep>();
                campaignSteps.Add(new CampaignValkiryStep());
                campaignSteps.Add(new CampaignAttackStep());
                campaignSteps.Add(new DungeonAttackStep());
                campaignSteps.Add(new CampaignVictoryStep());
                campaignSteps.Add(new InBattleStep());
                campaignSteps.Add(new CampaignMissionStep());

            }
            return campaignSteps;
        }

        public static List<AbstractStep> GetEventsSteps()
        {
            if (eventsSteps == null)
            {
                eventsSteps = new List<AbstractStep>();
                eventsSteps.Add(new EventButtonStep());
                eventsSteps.Add(new EventCompleteButtonStep());
                eventsSteps.Add(new EventActiveTabStep());
                eventsSteps.Add(new EventDailyRewardStep());
                eventsSteps.Add(new EventTakeDailyStep());
                eventsSteps.Add(new EventRedDotStep());
            }
            return eventsSteps;
        }

        // New and simpler bot creation, TODO: consider refactoring previous step sets with new approach
        public static List<AbstractStep> GetExpeditionsSteps()
        {
            if(expeditionsSteps == null)
            {
                expeditionsSteps = new List<AbstractStep>();
                expeditionsSteps.Add(new Step(Images.EXPEDITIONS_RED_DOT));
                expeditionsSteps.Add(new Step(Images.EXPEDITIONS_AUTO));
                expeditionsSteps.Add(new Step(Images.EXPEDITIONS_COLLECT));
                expeditionsSteps.Add(new Step(Images.EXPEDITIONS_START));
                expeditionsSteps.Add(new Step(Images.EXPEDITIONS_START_2));
                expeditionsSteps.Add(new Step(Images.EXPEDITIONS_CLOSE));
            }
            return expeditionsSteps;
        }

        public static List<AbstractStep> GetOutlandSteps()
        {
            if (outlandSteps == null)
            {
                outlandSteps = new List<AbstractStep>();
                outlandSteps.Add(new Step(Images.OUTLAND_REWARD));
                outlandSteps.Add(new Step(Images.OUTLAND_OPEN_CHEST, 0.93f));
                outlandSteps.Add(new Step(Images.OUTLAND_OPEN_CHEST_2, 0.93f));
                outlandSteps.Add(new Step(Images.OUTLAND_CLOSE));
                outlandSteps.Add(new Step(Images.OUTLAND_BOSS_DOT, 0.95f, -20, 30));
            }
            return outlandSteps;
        }

        public static List<AbstractStep> GetQuestsSteps()
        {
            if (questsSteps == null)
            {
                questsSteps = new List<AbstractStep>();
                questsSteps.Add(new Step(Images.QUESTS_COMPLETE));
                questsSteps.Add(new Step(Images.QUESTS_RED_DOT));
            }
            return questsSteps;
        }

        public static List<AbstractStep> GetPostSteps()
        {
            if (postSteps == null)
            {
                postSteps = new List<AbstractStep>();
                postSteps.Add(new Step(Images.POST_COLLECT_ALL));
                postSteps.Add(new Step(Images.POST_SHOW_ALL));
                postSteps.Add(new Step(Images.POST_TAKE_ALL));
                postSteps.Add(new Step(Images.POST_READ));
                postSteps.Add(new Step(Images.POST_TAKE));
            }
            return postSteps;
        }
    }
}
