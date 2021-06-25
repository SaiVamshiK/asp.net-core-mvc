using Microsoft.AspNetCore.Mvc;
using MvcCourse.Data;
using MvcCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCourse.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> obj = _db.Category;
            return View(obj);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
