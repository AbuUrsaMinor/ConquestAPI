using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Db;

namespace Persistence
{
    public static class MigrateDb
    {
        public static void MigrateSqlServerStorage(this IServiceProvider sp)
        {
            using var scope = sp.CreateScope();
            using var db = scope.ServiceProvider.GetRequiredService<ConquestDbContext>();
            db.Database.Migrate();
        }
    }
}
