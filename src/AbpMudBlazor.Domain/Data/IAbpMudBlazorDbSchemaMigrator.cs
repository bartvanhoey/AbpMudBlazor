using System.Threading.Tasks;

namespace AbpMudBlazor.Data;

public interface IAbpMudBlazorDbSchemaMigrator
{
    Task MigrateAsync();
}
