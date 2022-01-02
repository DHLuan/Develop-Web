using demo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo1.ViewComponents
{
    public class CatergoryListViewComponent : ViewComponent
    {
        private readonly webContext _context;

        public CatergoryListViewComponent(webContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> catList = await _context.Categories.ToListAsync();
            return View(catList);
        }
    }
}