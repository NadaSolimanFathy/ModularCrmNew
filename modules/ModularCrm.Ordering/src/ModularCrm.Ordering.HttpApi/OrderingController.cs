using ModularCrm.Ordering.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ModularCrm.Ordering;

public abstract class OrderingController : AbpControllerBase
{
    protected OrderingController()
    {
        LocalizationResource = typeof(OrderingResource);
    }
}
