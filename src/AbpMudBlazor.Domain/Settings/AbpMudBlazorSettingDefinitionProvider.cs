using Volo.Abp.Settings;

namespace AbpMudBlazor.Settings;

public class AbpMudBlazorSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpMudBlazorSettings.MySetting1));
    }
}
