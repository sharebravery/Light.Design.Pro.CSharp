using Furion;
using Microsoft.Extensions.DependencyInjection;

namespace Light.Design.Pro.CSharp.EntityFramework.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(options =>
            {
                options.AddDbPool<DefaultDbContext>();
            }, "Light.Design.Pro.CSharp.Database.Migrations");
        }
    }
}