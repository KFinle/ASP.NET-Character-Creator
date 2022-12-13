/**
 * Name:       Khris Finley
 * Date:       December 12th, 2022
 * Class:      Netd3202
 * Assignment: Lab 5 + Communication
 */
using System.Collections.Generic;

namespace Lab5.Models
{
    // Used to gather all RPG models into one ViewModel
    public class ViewModel
    {
        public List<Character> Characters { get; set; }
        public List<Job> Jobs { get; set; }
        public List<Skill> Skills { get; set; }

    }
}
