using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpMudBlazor.Data;
using Volo.Abp.DependencyInjection;

namespace AbpMudBlazor.EntityFrameworkCore;

public class EntityFrameworkCoreAbpMudBlazorDbSchemaMigrator
    : IAbpMudBlazorDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpMudBlazorDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpMudBlazorDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpMudBlazorDbContext>()
            .Database
            .MigrateAsync();
    }
}
