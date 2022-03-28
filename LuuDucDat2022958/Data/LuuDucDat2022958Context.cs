#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LuuDucDat2022958.Models;

namespace LuuDucDat2022958.Data
{
    public class LuuDucDat2022958Context : DbContext
    {
        public LuuDucDat2022958Context (DbContextOptions<LuuDucDat2022958Context> options)
            : base(options)
        {
        }

        public DbSet<LuuDucDat2022958.Models.PersonLDD2022958> PersonLDD2022958 { get; set; }
    }
}
