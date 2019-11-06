using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AbpDemo.Data;
using Volo.Abp.DependencyInjection;

namespace AbpDemo.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreAbpDemoDbSchemaMigrator 
        : IAbpDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly AbpDemoMigrationsDbContext _dbContext;

        public EntityFrameworkCoreAbpDemoDbSchemaMigrator(AbpDemoMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}