using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using SidewaysT.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using SidewaysT.ViewComponents;


namespace SidewaysT.Pages
{
    public class BattletechFCSModel : PageModel
    {
        private readonly SidewaysT.Models.FCSContext _context;
        public string CatSelect { get; set; }
        [BindProperty]
        public string Category { get; set; }
        [ModelBinder]
        public List<string> ItemList { get; set; }
        [BindProperty]
        public List<string> WepPartial { get; set; }

        public BattletechFCSModel(SidewaysT.Models.FCSContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Weapon> Weapon { get; set; }
        //public IList<Weapon> Categories { get; set; }

        [HttpGet]
        public async Task OnGetAsync()
        {

            if (Weapon == null)
            {
                Weapon = await _context.Weapon.ToListAsync();

            }

        }

        [HttpGet]
        public async Task<ViewComponentResult> OnGetWeaponItemsAsync(string category)
        {
            var result = new ViewComponentResult() { ViewComponentName = "WeaponItems", Arguments = category };
            return await Task.FromResult(result);
        }

        [HttpGet]
        public async Task<ViewComponentResult> OnGetWeaponAmmoAsync(string item)
        {
            var result = new ViewComponentResult() { ViewComponentName = "WeaponAmmo", Arguments = item };
            return await Task.FromResult(result);
        }

        [HttpGet]
        public async Task<ViewComponentResult> OnGetAddMechAsync(string mechs)
        {
            var result = new ViewComponentResult() { ViewComponentName = "AddMech", Arguments = mechs };
            return await Task.FromResult(result);
        }
    }
}
