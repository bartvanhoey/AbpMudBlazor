using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpMudBlazor.Data;

/* This is used if database provider does't define
 * IAbpMudBlazorDbSchemaMigrator implementation.
 */
public class NullAbpMudBlazorDbSchemaMigrator : IAbpMudBlazorDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
