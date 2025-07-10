using ModularCrm.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ModularCrm.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ModularCrmPageModel : AbpPageModel
{
    protected ModularCrmPageModel()
    {
        LocalizationResourceType = typeof(ModularCrmResource);
    }
}
