using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SidewaysT.Models;

namespace SidewaysT.Pages.DBView
{
    public class CreateModel : PageModel
    {
        private readonly SidewaysT.Models.FCSContext _context;

        public CreateModel(SidewaysT.Models.FCSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Weapon Weapon { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Weapon.Add(Weapon);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}