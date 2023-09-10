using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Light.Design.Pro.CSharp.EntityFramework.Core
{
    [AppDbContext("LightConnectionString", DbProvider.MySql)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}