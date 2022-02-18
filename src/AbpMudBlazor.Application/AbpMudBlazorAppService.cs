using System;
using System.Collections.Generic;
using System.Text;
using AbpMudBlazor.Localization;
using Volo.Abp.Application.Services;

namespace AbpMudBlazor;

/* Inherit your application services from this class.
 */
public abstract class AbpMudBlazorAppService : ApplicationService
{
    protected AbpMudBlazorAppService()
    {
        LocalizationResource = typeof(AbpMudBlazorResource);
    }
}
