using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SidewaysT.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SidewaysT.ViewComponents
{
    public class WeaponItems : ViewComponent
    {
        private FCSContext _context;

        public WeaponItems(FCSContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(string category)
        {
            List<Weapon> itemList = await _context.Weapon.ToListAsync();
            return View(itemList.Where(w => w.Category == category).Select(i => i.Item).ToList());
        }
    }
}
