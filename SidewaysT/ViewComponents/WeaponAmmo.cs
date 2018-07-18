using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SidewaysT.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SidewaysT.ViewComponents
{
    public class WeaponAmmo : ViewComponent
    {
        public FCSContext _context;

        public WeaponAmmo(FCSContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(string item)
        {
            int selectedWeaponID = await _context.Weapon.Where(w => w.Item == item).Select(i => i.WeaponID).FirstOrDefaultAsync();
            List<AmmoTypeEnum> AmmoList = await _context.Ammo.Where(a => a.WeaponID == selectedWeaponID).Select(l => l.AmmoType).ToListAsync();
            return View(AmmoList);
        }
    }
}
