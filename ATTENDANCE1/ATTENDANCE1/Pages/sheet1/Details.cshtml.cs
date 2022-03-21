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
    public class DetailsModel : PageModel
    {
        private readonly ATTENDANCE1.Data.ATTENDANCE1Context _context;

        public DetailsModel(ATTENDANCE1.Data.ATTENDANCE1Context context)
        {
            _context = context;
        }

        public sheets sheets { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            sheets = await _context.sheets.FirstOrDefaultAsync(m => m.ID == id);

            if (sheets == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
