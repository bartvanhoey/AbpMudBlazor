using AbpMudBlazor.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpMudBlazor.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpMudBlazorEntityFrameworkCoreModule),
    typeof(AbpMudBlazorApplicationContractsModule)
    )]
public class AbpMudBlazorDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
