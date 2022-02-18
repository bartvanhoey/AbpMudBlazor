using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpMudBlazor;

[Dependency(ReplaceServices = true)]
public class AbpMudBlazorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpMudBlazor";
}
