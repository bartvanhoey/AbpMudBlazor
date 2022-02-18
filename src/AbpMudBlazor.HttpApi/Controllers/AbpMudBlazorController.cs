using AbpMudBlazor.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpMudBlazor.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpMudBlazorController : AbpControllerBase
{
    protected AbpMudBlazorController()
    {
        LocalizationResource = typeof(AbpMudBlazorResource);
    }
}
