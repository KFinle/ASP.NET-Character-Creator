/**
 * Name:       Khris Finley
 * Date:       December 12th, 2022
 * Class:      Netd3202
 * Assignment: Lab 5 + Communication
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    public class Character
    {
        #region Character Constants

        [NotMapped]
        public int MAX_LEVEL = 100;

        [NotMapped]
        private int MAX_EXP = 247500;

        [NotMapped]
        public int levelUpCurve = 25;

        [NotMapped]
        private int BASE_HP = 150;

        [NotMapped]
        private int HP_GAIN = 10;

        [NotMapped]
        private int AP_GAIN = 10;

        [NotMapped]
        private int BASE_AP = 100;
        #endregion


        #region Data fields

        public int characterID { get; set; }

        [Required]
        public string name { get; set; }
        public Roles role { get; set; }
        public string jobName { get; set; }     // Extracted from Job Selection
        public int maxHP { get; set; }          // Hit Points
        public int currentHP { get; set; }      // Hit Points
        public int maxAP { get; set; }          // Action Points
        public int currentAP { get; set; }      // Action Points

        [Required]
        public int currentLevel { get; set; }   // Level
        public int currentExp { get; set; }     // Experience Points
        public int expToNextLevel { get; set; } // Experience Points needed for next level up

        // Character skills based on job 
        private List<Skill> skills = new List<Skill>();

        // Enum for easy access to roles
        public enum Roles { Tank = 0, Healer, MeleeDPS, MagicDPS }

        #endregion

        // Default Constructor
        public Character()
        {
            currentHP = maxHP;
            currentAP = maxAP;
            expToNextLevel = GetExpToNextLevel();
            currentExp = 0;
        }

        #region Member Functions

        // Calculate Exp needed for next level up
        public int GetExpToNextLevel()
        {
            int nextLevel = currentLevel + 1;

            if (nextLevel > MAX_LEVEL)
            {
                return 0;
            }

            int expNeeded = (levelUpCurve * nextLevel * nextLevel - levelUpCurve * nextLevel) - currentExp;
            return expNeeded;
        }

        // Get the lowest exp value possible for the given level
        public int MinimumExpReqForLevel(int targetLevel)
        {
            return levelUpCurve * targetLevel * targetLevel - levelUpCurve * targetLevel;
        }

        // Calculate the current level of a character given its current exp
        public int GetLevelFromCurrentXP(int exp)
        {
            if (exp >= MAX_EXP)
            {
                return MAX_LEVEL;
            }

            // Quadratic equation
            double levelRaw = levelUpCurve + (Math.Sqrt((levelUpCurve * levelUpCurve) - (levelUpCurve * 4 * (-exp))));
            int level = Convert.ToInt32(Math.Floor(levelRaw / (2 * levelUpCurve)));

            // if the result is greater than the MAX_LEVEL, character level is MAX_LEVEL
            if (level >= MAX_LEVEL)
            {
                return MAX_LEVEL;
            }
            return level;
        }

        // Checks if the character's current level is higher than the MAX_LEVEL
        public bool IsAboveMaxLevel()
        {
            return currentLevel > MAX_LEVEL;
        }

        // Checks if the character's current exp is higher than the MAX_EXP
        public bool IsAboveMaxExp()
        {
            return currentExp > MAX_EXP;
        }

        // If the character's exp is greater than the max, set it to the max
        public void PreventExpOverflow()
        {
            if (IsAboveMaxExp())
            {
                currentExp = MAX_EXP;
            }
        }


        #region AP Methods

        // Return the correct AP multiplier to use for level scaling based on role
        public double GetApMultiplierByJob()
        {
            switch (role)
            {
                case Roles.Tank:
                    return 0.8f;
                case Roles.Healer:
                    return 1.1f;
                case Roles.MagicDPS:
                    return 1.4f;
                default:
                    return 1.0f;
            }
        }

        // Return the level-scaled AP value to add to the current AP
        public double GetApBonusByLevel()
        {
            if (currentLevel == 1)
            {
                return BASE_AP * Math.Ceiling((double)currentLevel / 2);
            }
            return BASE_AP + AP_GAIN * Math.Ceiling((double)currentLevel / 2);
        }

        // Assign a new AP value when leveling up
        public int SetNewAp()
        {
            return Convert.ToInt32(GetApBonusByLevel() * GetApMultiplierByJob());
        }
        #endregion


        #region HP Methods

        // Return the correct HP multiplier to use for level scaling based on role
        public double GetHpMultiplierByJob()
        {
            switch (role)
            {
                case Roles.Tank:
                    return 2.0f;
                case Roles.Healer:
                    return 1.3f;
                case Roles.MagicDPS:
                    return 0.9f;
                default:
                    return 1.0f;
            }
        }

        // Return the level-scaled HP value to add to the current AP
        public double GetHpBonusByLevel()
        {
            if (currentLevel == 1)
            {
                return BASE_HP * Math.Ceiling((double)currentLevel / 2);
            }
            return BASE_HP + HP_GAIN * Math.Ceiling((double)currentLevel / 2);
        }

        // Assign a new HP value when leveling up
        public int SetNewHp()
        {
            return Convert.ToInt32(GetHpBonusByLevel() * GetHpMultiplierByJob());
        }

        #endregion

        #endregion


    }
}
