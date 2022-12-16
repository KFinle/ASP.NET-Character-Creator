/**
 * Name:       Khris Finley
 * Date:       December 12th, 2022
 * Class:      Netd3202
 * Assignment: Lab 5 + Communication
 */
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    public class Skill
    {
        #region Data Fields

        [Key]
        public int SkillId { get; set; }

        [Required]
        public string skillName { get; set; }

        [Required]
        public string skillDesc { get; set; }
        public SkillTypes skillType { get; set; }

        [Required]
        public int apCost { get; set; }

        [Required]
        public float abilityDmg { get; set; }

        [Required]
        public DmgTypes dmgType { get; set; }

        [Required]
        public float critMultiplier { get; set; }

        [Required]
        public int levelLearned { get; set; }


        [ForeignKey("Job")]
        public int jobId { get; set; } 
        public virtual Job Job { get; set; } // Virtual Job to ensure proper FK implimentation when creating new skills

        // Enums for easy access to setting/getting properties
        public enum SkillTypes { Offensive, Defensive, Status, Restorative, Misc }
        public enum DmgTypes { Physical, Fire, Ice, Electric, Holy, Dark }

        #endregion

        #region Member Functions

        // Level fixes in case user inputs values out of intended range
        public void FixLevelLearned()
        {
            if (levelLearned <= 0) { levelLearned = 0; }    
            if (levelLearned > 100) { levelLearned = 100; }
        }

        // AP and DMG fixes in case user inputs bad values
        public void NegativeValueFix()
        {
            if (apCost < 0) { apCost = 0; }
            if (abilityDmg < 0) { abilityDmg = 0; }
        }

        #endregion

    }
}
