using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.Where<DiaryEntry>(entry => entry.Created < DateTime.Now).ToList();

            return View(objDiaryEntryList);
        }

        public IActionResult Search(string? tags)
        {
            if (tags == null)
            {
                List<DiaryEntry> diaryEntries = _db.DiaryEntries.ToList();
                return View(diaryEntries);
            }
            tags = tags.Replace(",", "");
            List<string> tagsFiltered = tags.Split(' ').ToList();

            List<DiaryEntry> searchDiaryEntryList = _db.DiaryEntries.Where<DiaryEntry>(entry => entry.Tags.Any(sring => tagsFiltered.Contains(sring))).ToList();

            return View(searchDiaryEntryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry objDiaryEntry)
        {
            _db.Add(objDiaryEntry);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        
        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0) 
            {
                return NotFound();
            }

            DiaryEntry? objDiaryEntry = _db.DiaryEntries.Find(id);

            if (objDiaryEntry == null)
            {
                return NotFound();
            }

            return View(objDiaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry objDiaryEntry)
        {
            _db.DiaryEntries.Update(objDiaryEntry);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0)
            {
                return BadRequest();
            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            _db.DiaryEntries.Remove(diaryEntry);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
