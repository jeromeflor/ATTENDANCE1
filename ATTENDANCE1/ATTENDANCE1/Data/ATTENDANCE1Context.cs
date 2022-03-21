#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ATTENDANCE1.sheet;

namespace ATTENDANCE1.Data
{
    public class ATTENDANCE1Context : DbContext
    {
        public ATTENDANCE1Context (DbContextOptions<ATTENDANCE1Context> options)
            : base(options)
        {
        }

        public DbSet<ATTENDANCE1.sheet.sheets> sheets { get; set; }
    }
}
