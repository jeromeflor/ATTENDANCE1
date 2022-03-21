#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ATTENDANCE1.Data;
using ATTENDANCE1.sheet;

namespace ATTENDANCE1.Pages.sheet1
{
#pragma warning disable CS8618
#pragma warning disable CS8602
    public class IndexModel : PageModel
    {
        private readonly ATTENDANCE1.Data.ATTENDANCE1Context _context;

        public IndexModel(ATTENDANCE1.Data.ATTENDANCE1Context context)
        {
            _context = context;
        }

        public IList<sheets> sheets { get;set; }

        public async Task OnGetAsync()
        {
            sheets = await _context.sheets.ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8602
}
