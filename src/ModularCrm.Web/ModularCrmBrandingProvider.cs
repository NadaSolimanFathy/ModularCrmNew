using Microsoft.Extensions.Localization;
using ModularCrm.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ModularCrm.Web;

[Dependency(ReplaceServices = true)]
public class ModularCrmBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ModularCrmResource> _localizer;

    public ModularCrmBrandingProvider(IStringLocalizer<ModularCrmResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
