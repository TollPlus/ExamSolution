using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamSolution.Data;
using ExamSolution.Models;

namespace ExamSolution.Controllers
{
    public class StudentModelClassesController : Controller
    {
        private readonly SchoolManagamentContext _context;

        public StudentModelClassesController(SchoolManagamentContext context)
        {
            _context = context;
        }

        // GET: StudentModelClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

        // GET: StudentModelClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModelClass = await _context.Students
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (studentModelClass == null)
            {
                return NotFound();
            }

            return View(studentModelClass);
        }

        // GET: StudentModelClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentModelClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,StudentName,StudentImage,Address,Gender,Grade,ClassId,Section")] StudentModelClass studentModelClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentModelClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentModelClass);
        }

        // GET: StudentModelClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModelClass = await _context.Students.FindAsync(id);
            if (studentModelClass == null)
            {
                return NotFound();
            }
            return View(studentModelClass);
        }

        // POST: StudentModelClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,StudentName,StudentImage,Address,Gender,Grade,ClassId,Section")] StudentModelClass studentModelClass)
        {
            if (id != studentModelClass.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentModelClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentModelClassExists(studentModelClass.StudentId))
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
            return View(studentModelClass);
        }

        // GET: StudentModelClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModelClass = await _context.Students
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (studentModelClass == null)
            {
                return NotFound();
            }

            return View(studentModelClass);
        }

        // POST: StudentModelClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentModelClass = await _context.Students.FindAsync(id);
            _context.Students.Remove(studentModelClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentModelClassExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }
    }
}
