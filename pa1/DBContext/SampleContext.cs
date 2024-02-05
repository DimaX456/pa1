using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace pa1.DBContext
{
    public class SampleContext : IDesignTimeDbContextFactory<pa1Context>
    {
        public pa1Context CreateDbContext(string[] args) => new pa1Context(DBOptions.Options());
    }
}
