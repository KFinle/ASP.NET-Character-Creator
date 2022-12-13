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
    public class SkillsController : Controller
    {
        #region Initialization
        // DB context with access to Jobs, Characters, Skills
        private readonly ApplicationDbContext _context;

        public SkillsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Skills
        public async Task<IActionResult> Index()
        {
            // Access Jobs table and store in ViewData
            ViewData["JobList"] = _context.Jobs.ToList();
            return View(await _context.Skills.ToListAsync());
        }

        #endregion

        #region Details

        // GET: Skills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            // Access Jobs table and store in ViewData
            ViewData["JobList"] = _context.Jobs.ToList();

            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills
                .FirstOrDefaultAsync(m => m.SkillId == id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

        #endregion

        #region Create

        // GET: Skills/Create
        [Authorize]
        public IActionResult Create()
        {
            // Access Jobs table and store in ViewData
            ViewData["JobList"] = _context.Jobs.ToList();
            return View();
        }

        // POST: Skills/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("skillID,skillName,skillDesc, skillType,apCost," +
                                                      "abilityDmg,dmgType,critMultiplier,levelLearned, jobId")] Skill skill)
        {
            if (ModelState.IsValid)
            {
                // Validate and fix skill before committing to DB
                skill.FixLevelLearned();
                skill.NegativeValueFix();

                // Add skill to DB context
                _context.Add(skill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(skill);
        }

        #endregion

        #region Edit

        // GET: Skills/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills.FindAsync(id);
            if (skill == null)
            {
                return NotFound();
            }
            // Access Jobs table and store in ViewData
            ViewData["JobList"] = _context.Jobs.ToList();

            return View(skill);
        }

        // POST: Skills/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("skillID,skillName,jobId, skillDesc,skillType," +
                                                            "apCost,abilityDmg,dmgType,critMultiplier,levelLearned")] Skill skill)
        {
            if (id != skill.SkillId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Validate and fix skill before committing to DB
                    skill.FixLevelLearned();
                    skill.NegativeValueFix();

                    // Add skill to DB context
                    _context.Update(skill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkillExists(skill.SkillId))
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
            return View(skill);
        }

        #endregion

        #region Delete

        // GET: Skills/Delete
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skill = await _context.Skills
                .FirstOrDefaultAsync(m => m.SkillId == id);
            if (skill == null)
            {
                return NotFound();
            }

            return View(skill);
        }

        // POST: Skills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // find skill to delete
            var skill = await _context.Skills.FindAsync(id);

            // commit changes
            _context.Skills.Remove(skill);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        #endregion

        #region Helper Methods

        // Check for skill
        private bool SkillExists(int id)
        {
            return _context.Skills.Any(e => e.SkillId == id);
        }

        #endregion
    }
}
