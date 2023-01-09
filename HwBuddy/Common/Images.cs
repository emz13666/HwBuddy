﻿using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace HwBuddy.Common
{
    public static class Images
    {
        public static Image<Bgr, byte> TOWER = new Image<Bgr, byte>("Images/tower.png");
        public static Image<Bgr, byte> GUILD = new Image<Bgr, byte>("Images/guild.png");
        public static Image<Bgr, byte> VICTORY = new Image<Bgr, byte>("Images/victory.png");
        public static Image<Bgr, byte> HEROES_TEAM_SCREEN = new Image<Bgr, byte>("Images/heroes-team-screen.png");

        public static Image<Bgr, byte> PAUSE_BUTTON = new Image<Bgr, byte>("Images/pause-button.png");
        public static Image<Bgr, byte> OK_BUTTON = new Image<Bgr, byte>("Images/ok-button.png");
        public static Image<Bgr, byte> TOGGLE_BUTTON = new Image<Bgr, byte>("Images/toggle-button.png");
        public static Image<Bgr, byte> CLOSE_BUTTON = new Image<Bgr, byte>("Images/close-button.png");
        public static Image<Bgr, byte> RAID_BUTTON = new Image<Bgr, byte>("Images/raid.png");
        public static Image<Bgr, byte> RAID_NO_ENERGY = new Image<Bgr, byte>("Images/raid-no-energy.png");
        public static Image<Bgr, byte> TAKE_ALL_BUTTON = new Image<Bgr, byte>("Images/takeall.png");
        public static Image<Bgr, byte> CHECKOUT = new Image<Bgr, byte>("Images/checkout.png");
        public static Image<Bgr, byte> DONATE = new Image<Bgr, byte>("Images/donate.png");

        //public static Image<Bgr, byte> DUNGEON = new Image<Bgr, byte>("Images/dungeon.png");
        public static Image<Bgr, byte> DUNGEON_CARDS_ICON = new Image<Bgr, byte>("Images/dungeon-cards-icon.png");
        public static Image<Bgr, byte> DUNGEON_CARDS_COLLECT = new Image<Bgr, byte>("Images/dungeon-cards-collect.png");
        public static Image<Bgr, byte> DUNGEON_NEW_CARDS = new Image<Bgr, byte>("Images/dungeon-new-cards.png");
        public static Image<Bgr, byte> DUNGEON_BUTTONS = new Image<Bgr, byte>("Images/dungeon-buttons.png");
        public static Image<Bgr, byte> DUNGEON_TO_BATTLE = new Image<Bgr, byte>("Images/dungeon-to-battle.png");
        public static Image<Bgr, byte> DUNGEON_USE_CARD = new Image<Bgr, byte>("Images/dungeon-use-card.png");
        public static Image<Bgr, byte> DUNGEON_ATTACK_MIXFIGHT = new Image<Bgr, byte>("Images/dungeon-attack-mixfight.png");
        public static Image<Bgr, byte> DUNGEON_ATTACK_WATER = new Image<Bgr, byte>("Images/dungeon-attack-water.png");
        public static Image<Bgr, byte> DUNGEON_ATTACK_FIRE = new Image<Bgr, byte>("Images/dungeon-attack-fire.png");
        public static Image<Bgr, byte> DUNGEON_ATTACK_EARTH = new Image<Bgr, byte>("Images/dungeon-attack-earth.png");
        public static Image<Bgr, byte> DUNGEON_ATTACK_BUTTON = new Image<Bgr, byte>("Images/dungeon-attack-button.png");
        public static Image<Bgr, byte> DUNGEON_CARDS_CLOSE = new Image<Bgr, byte>("Images/dungeon-cards-close.png");
        public static Image<Bgr, byte> DUNGEON_ACTIVATION = new Image<Bgr, byte>("Images/dungeon-activation.png");

        public static Image<Bgr, byte> TOWER_DOOR = new Image<Bgr, byte>("Images/tower-door.png");
        public static Image<Bgr, byte> TOWER_HALL = new Image<Bgr, byte>("Images/tower-hall.png");
        public static Image<Bgr, byte> TOWER_ATTACK = new Image<Bgr, byte>("Images/tower-attack1.png");
        public static Image<Bgr, byte> TOWER_RAID = new Image<Bgr, byte>("Images/tower-raid.png");
        public static Image<Bgr, byte> TOWER_SHRINE = new Image<Bgr, byte>("Images/tower-shrine.png");
        public static Image<Bgr, byte> TOWER_SHRINE_2 = new Image<Bgr, byte>("Images/tower-shrine2.png");
        public static Image<Bgr, byte> TOWER_POWERUP_BUY_BUTTON = new Image<Bgr, byte>("Images/tower-powerup-button.png");
        public static Image<Bgr, byte> TOWER_POWERUP_CLOSE = new Image<Bgr, byte>("Images/tower-powerup-close.png");
        public static Image<Bgr, byte> TOWER_NEXT = new Image<Bgr, byte>("Images/tower-next-right.png");
        public static Image<Bgr, byte> TOWER_CHEST = new Image<Bgr, byte>("Images/tower-chest.png");
        public static Image<Bgr, byte> TOWER_CHEST_BIG = new Image<Bgr, byte>("Images/tower-chest-big.png");
        public static Image<Bgr, byte> TOWER_CHEST_FINAL = new Image<Bgr, byte>("Images/tower-chest-final.png");
        public static Image<Bgr, byte> TOWER_CHEST_OPEN = new Image<Bgr, byte>("Images/tower-chest-open.png");
        public static Image<Bgr, byte> TOWER_CHEST_MOVEON = new Image<Bgr, byte>("Images/tower-chest-moveon.png");
        public static Image<Bgr, byte> TOWER_POWERUP_SCREEN = new Image<Bgr, byte>("Images/tower-powerup-screen.png");
        public static Image<Bgr, byte> TOWER_LAST_CHEST = new Image<Bgr, byte>("Images/tower-last-chest.png");
        public static Image<Bgr, byte> TOWER_POWERUP_1 = new Image<Bgr, byte>("Images/tower-powerup-1.png");
        public static Image<Bgr, byte> TOWER_POWERUP_3 = new Image<Bgr, byte>("Images/tower-powerup-3.png");
        public static Image<Bgr, byte> TOWER_POWERUP_6 = new Image<Bgr, byte>("Images/tower-powerup-6.png");
        public static Image<Bgr, byte> TOWER_POWERUP_8 = new Image<Bgr, byte>("Images/tower-powerup-8.png");
        public static Image<Bgr, byte> TOWER_POWERUP_16 = new Image<Bgr, byte>("Images/tower-powerup-16.png");
        public static Image<Bgr, byte> TOWER_POWERUP_20 = new Image<Bgr, byte>("Images/tower-powerup-20.png");
        public static Image<Bgr, byte> TOWER_POWERUP_40 = new Image<Bgr, byte>("Images/tower-powerup-40.png");
        public static Image<Bgr, byte> TOWER_SKULLS_ENDED = new Image<Bgr, byte>("Images/tower-skulls-ended.png");
        public static Image<Bgr, byte> TOWER_SKULLS_COLLECT = new Image<Bgr, byte>("Images/tower-skulls-collect.png");
        public static Image<Bgr, byte> TOWER_CHANGE_SKILLS = new Image<Bgr, byte>("Images/tower-change-skills.png");
        public static Image<Bgr, byte> TOWER_BAD_POWERUP = new Image<Bgr, byte>("Images/tower-bad-powerup.png");
        public static Image<Bgr, byte> SKULLS_OK_BUTTON = new Image<Bgr, byte>("Images/skulls-ok-button.png");
        public static Image<Bgr, byte> TOWER_MOMENT = new Image<Bgr, byte>("Images/tower-moment.png");
        public static Image<Bgr, byte> TOWER_CHOOSE15 = new Image<Bgr, byte>("Images/tower-choose15.png");

        public static Image<Bgr, byte> TOE_RAID = new Image<Bgr, byte>("Images/toe-raid.png");
        public static Image<Bgr, byte> TOE_CLOSE = new Image<Bgr, byte>("Images/toe-close.png");
        public static Image<Bgr, byte> TOE_CHEST = new Image<Bgr, byte>("Images/toe-chest.png");
        public static Image<Bgr, byte> TOE_COLLECT = new Image<Bgr, byte>("Images/toe-collect.png");
        public static Image<Bgr, byte> TOE_COLLECT_2 = new Image<Bgr, byte>("Images/toe-collect-2.png");
        public static Image<Bgr, byte> TOE_COLLECT_ALL = new Image<Bgr, byte>("Images/toe-collect-all.png");

        public static Image<Bgr, byte> CAMPAIGN_MISSION = new Image<Bgr, byte>("Images/campaign-mission.png");
        public static Image<Bgr, byte> CAMPAIGN_ATTACK = new Image<Bgr, byte>("Images/campaign-attack.png");
        public static Image<Bgr, byte> CAMPAIGN_VICTORY = new Image<Bgr, byte>("Images/campaign-victory.png");
        public static Image<Bgr, byte> CAMPAIGN_VALKIRY = new Image<Bgr, byte>("Images/campaign-valkiry.png");

        public static Image<Bgr, byte> EVENTS_ACTIVE_TAB = new Image<Bgr, byte>("Images/events-active-tab.png");
        public static Image<Bgr, byte> EVENTS_BUTTON = new Image<Bgr, byte>("Images/events-button.png");
        public static Image<Bgr, byte> EVENTS_COMPLETE_BUTTON = new Image<Bgr, byte>("Images/events-complete-button.png");
        public static Image<Bgr, byte> EVENTS_DAILY_REWARD = new Image<Bgr, byte>("Images/events-daily-reward.png");
        public static Image<Bgr, byte> EVENTS_RED_DOT = new Image<Bgr, byte>("Images/events-red-dot.png");
        public static Image<Bgr, byte> EVENTS_TAKE_DAILY_BUTTON = new Image<Bgr, byte>("Images/events-take-daily-button.png");

        public static Image<Bgr, byte> EXPEDITIONS_AUTO = new Image<Bgr, byte>("Images/expeditions-auto.png");
        public static Image<Bgr, byte> EXPEDITIONS_COLLECT = new Image<Bgr, byte>("Images/expeditions-collect.png");
        public static Image<Bgr, byte> EXPEDITIONS_RED_DOT = new Image<Bgr, byte>("Images/expeditions-red-dot.png");
        public static Image<Bgr, byte> EXPEDITIONS_START = new Image<Bgr, byte>("Images/expeditions-start.png");
        public static Image<Bgr, byte> EXPEDITIONS_START_2 = new Image<Bgr, byte>("Images/expeditions-start-2.png");
        public static Image<Bgr, byte> EXPEDITIONS_CLOSE = new Image<Bgr, byte>("Images/expeditions-close.png");

        public static Image<Bgr, byte> OUTLAND_BOSS_DOT = new Image<Bgr, byte>("Images/zapred-boss-dot.png");
        public static Image<Bgr, byte> OUTLAND_CLOSE = new Image<Bgr, byte>("Images/zapred-close.png");
        public static Image<Bgr, byte> OUTLAND_OPEN_CHEST = new Image<Bgr, byte>("Images/zapred-open-chest.png");
        public static Image<Bgr, byte> OUTLAND_OPEN_CHEST_2 = new Image<Bgr, byte>("Images/zapred-open-chest-2.png");
        public static Image<Bgr, byte> OUTLAND_REWARD = new Image<Bgr, byte>("Images/zapred-reward.png");

        public static Image<Bgr, byte> QUESTS_RED_DOT = new Image<Bgr, byte>("Images/quests-red-dot.png");
        public static Image<Bgr, byte> QUESTS_COMPLETE = new Image<Bgr, byte>("Images/quests-complete.png");

        public static Image<Bgr, byte> POST_COLLECT_ALL = new Image<Bgr, byte>("Images/post-collect-all.png");
        public static Image<Bgr, byte> POST_READ = new Image<Bgr, byte>("Images/post-read.png");
        public static Image<Bgr, byte> POST_SHOW_ALL = new Image<Bgr, byte>("Images/post-show-all.png");
        public static Image<Bgr, byte> POST_TAKE = new Image<Bgr, byte>("Images/post-take.png");
        public static Image<Bgr, byte> POST_TAKE_ALL = new Image<Bgr, byte>("Images/post-take-all.png");
    }
}
