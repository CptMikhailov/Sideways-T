using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SidewaysT.Models;

namespace SidewaysT.Pages.DBView
{
    public class IndexModel : PageModel
    {
        private readonly SidewaysT.Models.FCSContext _context;

        public IndexModel(SidewaysT.Models.FCSContext context)
        {
            _context = context;
        }

        public IList<Weapon> Weapon { get;set; }

        public async Task OnGetAsync()
        {
            Weapon = await _context.Weapon.ToListAsync();
        }
    }
}
