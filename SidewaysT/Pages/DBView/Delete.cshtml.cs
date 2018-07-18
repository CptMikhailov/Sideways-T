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
    public class DeleteModel : PageModel
    {
        private readonly SidewaysT.Models.FCSContext _context;

        public DeleteModel(SidewaysT.Models.FCSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Weapon Weapon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Weapon = await _context.Weapon.FirstOrDefaultAsync(m => m.WeaponID == id);

            if (Weapon == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Weapon = await _context.Weapon.FindAsync(id);

            if (Weapon != null)
            {
                _context.Weapon.Remove(Weapon);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
