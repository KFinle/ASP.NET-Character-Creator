/**
 * Name:       Khris Finley
 * Date:       December 12th, 2022
 * Class:      Netd3202
 * Assignment: Lab 5 + Communication
 */
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }             
        public string JobName { get; set; }
        public Character.Roles Role { get; set; } // (Tank/Healer/MeleeDPS/MagicDPS)
    }
}
