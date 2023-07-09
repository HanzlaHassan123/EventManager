using System.Security.Cryptography.X509Certificates;
using EventManager.Models.Domain;
using EventManager.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventManager.Controllers
{
   // [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        { 
            _categoryService = categoryService;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var result=_categoryService.Add(model);
            if (result)
            {
                TempData["msg"] = "Added Successfully";
                return RedirectToAction(nameof(Add));
            }
            else
            {
                TempData["msg"] = "Error on server side";
                return View(model);
            }
                
          
        }

        public IActionResult Edit(int id)
        {
            var data=_categoryService.GetById(id);   
            return View();
        }

        [HttpPost]
        public IActionResult Update(Category model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = _categoryService.Update(model);
            if (result)
            {
                TempData["msg"] = "Updated Successfully";
                return RedirectToAction(nameof(CategoryList));
            }
            else
            {
                TempData["msg"] = "Error on server side";
                return View(model);
            }


           

        }
        public IActionResult CategoryList()
        {
            var data = this._categoryService.List().ToList();
            return View(data);
           
        }

        public IActionResult Delete(int id)
        {
            var result = _categoryService.Delete(id);
            return RedirectToAction(nameof(CategoryList));
        }


    }
}
