using AbpMudBlazor.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpMudBlazor.Blazor;

public abstract class AbpMudBlazorComponentBase : AbpComponentBase
{
    protected AbpMudBlazorComponentBase()
    {
        LocalizationResource = typeof(AbpMudBlazorResource);
    }
}
