/**
 * Name:       Khris Finley
 * Date:       December 12th, 2022
 * Class:      Netd3202
 * Assignment: Lab 5 + Communication
 */

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab5.Models;
using Lab5.Data;
using Microsoft.AspNetCore.Authorization;

namespace Lab5.Controllers
{
    public class CharactersController : Controller
    {
        #region Initialization
        // DB context storing Jobs, Skills, Characters
        private readonly ApplicationDbContext _context;

        public CharactersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Characters
        public async Task<IActionResult> Index()
        {

            return View(await _context.Characters.ToListAsync());
        }

        #endregion

        #region Details

        // GET: Characters/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters
                .FirstOrDefaultAsync(m => m.characterID == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }
        #endregion

        #region Create

        // GET: Characters/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["JobList"] = _context.Jobs.ToList();
            return View();

        }

        // POST: Characters/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("characterID,name,jobName,maxHP,currentHP,maxAP," +
                                                       "currentAP,currentLevel,currentExp,expToNextLevel")] 
                                                        Character character)
        {
            if (ModelState.IsValid)
            {
                // If data entered is valid, call a DB entry function
                CreateNewCharacterEntry(character);

                // Save DB changes
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(character);
        }

        #endregion

        #region Edit

        // GET: Characters/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }

            ViewData["JobList"] = _context.Jobs.ToList();
            return View(character);
        }

        // POST: Characters/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("characterID,name,jobName,maxHP,currentHP,maxAP," +
                                                            "currentAP,currentLevel,currentExp,expToNextLevel")] 
                                                            Character character)
        {
            if (id != character.characterID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // If new data is valid, call custom update script
                    EditCharacterEntry(character);

                    // Save changes
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterExists(character.characterID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(character);
        }

        #endregion

        #region Delete

        // GET: Characters/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var character = await _context.Characters
                .FirstOrDefaultAsync(m => m.characterID == id);
            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }

        // POST: Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var character = await _context.Characters.FindAsync(id);
            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region "Helper Functions"

        // Verify character entry exists
        private bool CharacterExists(int id)
        {
            return _context.Characters.Any(e => e.characterID == id);
        }

        /// <summary>
        /// Uses the passed JobName to find the matching Role
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="character"></param>
        /// <returns>Role</returns>
        private Character.Roles GetRoleFromJobName(string jobName, Character character)
        {
            // Get the DbSet of Job objects from the _context object
            DbSet<Job> jobs = _context.Jobs;

            // Retrieve a specific Job object from the DbSet
            Job job = jobs.Where(j => j.JobName == character.jobName).FirstOrDefault();

            // Return the Role property of the Job object
            return job.Role;
        }


        /// <summary>
        /// Runs a series of validations and corrections on a new character object
        /// before committing it to the database
        /// </summary>
        /// <param name="character"></param>
        private void CreateNewCharacterEntry(Character character)
        {
            if (character.IsAboveMaxLevel())
            {
                character.currentLevel = character.MAX_LEVEL;
            }
            character.role = GetRoleFromJobName(character.jobName, character);
            character.maxHP = character.SetNewHp();
            character.maxAP = character.SetNewAp();
            character.currentHP = character.maxHP;
            character.currentAP = character.maxAP;
            character.currentExp = character.MinimumExpReqForLevel(character.currentLevel);
            character.expToNextLevel = character.GetExpToNextLevel();
            _context.Add(character);
        }

        /// <summary>
        /// Runs a series of validations and corrections on an
        /// edited character object prior to saving to the database
        /// </summary>
        /// <param name="character"></param>
        private void EditCharacterEntry(Character character)
        {
            character.role = GetRoleFromJobName(character.jobName, character);
            character.PreventExpOverflow();
            character.currentLevel = character.GetLevelFromCurrentXP(character.currentExp);
            character.maxHP = character.SetNewHp();
            character.maxAP = character.SetNewAp();
            character.currentHP = character.maxHP;
            character.currentAP = character.maxAP;
            character.expToNextLevel = character.GetExpToNextLevel();
            _context.Update(character);

        }
        #endregion
    }

}
