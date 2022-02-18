using Volo.Abp.Modularity;

namespace AbpMudBlazor;

[DependsOn(
    typeof(AbpMudBlazorApplicationModule),
    typeof(AbpMudBlazorDomainTestModule)
    )]
public class AbpMudBlazorApplicationTestModule : AbpModule
{

}
