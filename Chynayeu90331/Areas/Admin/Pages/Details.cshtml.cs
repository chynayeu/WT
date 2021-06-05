using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Chynayeu90331.DAL.Data;
using Chynayeu90331.DAL.Entities;

namespace Chynayeu90331.Areas.Admin.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Chynayeu90331.DAL.Data.ApplicationDbContext _context;

        public DetailsModel(Chynayeu90331.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Dish Dish { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dish = await _context.Dishes
                .Include(d => d.Group).FirstOrDefaultAsync(m => m.DishId == id);

            if (Dish == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
