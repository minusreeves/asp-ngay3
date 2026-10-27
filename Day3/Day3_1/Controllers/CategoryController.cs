using Day3_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ExceptionServices;

namespace Day3_1.Controllers
{
    public class CategoryController : Controller
    {


        public static List<Category> categories = new List<Category>
        {
            new Category {id = 1,
                name = "Máy tính siêu to khổng lồ",
            },
            new Category{id=2,name="Điện thoại Siêu cấp Pro max"},
        };
        [HttpGet]
        public ActionResult Index()
        {
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var category = categories.FirstOrDefault(c => c.id == id);
            return View(category);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category) 
        {
            category.id = categories.Count + 1;
            categories.Add(category);
            return RedirectToAction(nameof(Index));
            
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var editCategory = categories.FirstOrDefault(c => c.id == id);
            if(editCategory == null)
            {
                return NotFound();
            }
            return View(editCategory);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            var exitsCategory = categories.FirstOrDefault(c => c.id == category.id);
            if (exitsCategory == null)
            {
                return NotFound();
            }
            exitsCategory.name = category.name;
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var deleteCategory = categories.FirstOrDefault(c => c.id == id);
            if (deleteCategory == null) return NotFound();
            
            return View(deleteCategory);


        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Category category)
        {
            var exitsCategory = categories.FirstOrDefault(c => c.id == category.id);
            categories.Remove(exitsCategory);
            return RedirectToAction(nameof(Index));

            }
        }
    }

    