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
    public class IndexModel : PageModel
    {
        private readonly Chynayeu90331.DAL.Data.ApplicationDbContext _context;

        public IndexModel(Chynayeu90331.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; }

        public async Task OnGetAsync()
        {
            Dish = await _context.Dishes
                .Include(d => d.Group).ToListAsync();
        }
    }
}
