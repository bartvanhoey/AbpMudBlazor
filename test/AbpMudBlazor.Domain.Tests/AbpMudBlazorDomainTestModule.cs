using AbpMudBlazor.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpMudBlazor;

[DependsOn(
    typeof(AbpMudBlazorEntityFrameworkCoreTestModule)
    )]
public class AbpMudBlazorDomainTestModule : AbpModule
{

}
