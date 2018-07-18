using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SidewaysT.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SidewaysT.ViewComponents
{
    public class AddMech : ViewComponent
    {
        public AddMech()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync(string mechs)
        {
            List<string> mechList = await mechs.Split(" ").ToAsyncEnumerable().ToList();
            return View(mechList);
        }
    }
}
