using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trululu.web.Migrations
{
    public class TrululuDbContext : IdentityDbContext
    {
        public TrululuDbContext(DbContextOptions<TrululuDbContext> options)
            : base(options)
        {
        }
    }

}
