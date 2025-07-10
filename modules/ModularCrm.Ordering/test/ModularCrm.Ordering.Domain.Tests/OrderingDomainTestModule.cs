using Volo.Abp.Modularity;

namespace ModularCrm.Ordering;

[DependsOn(
    typeof(OrderingDomainModule),
    typeof(OrderingTestBaseModule)
)]
public class OrderingDomainTestModule : AbpModule
{

}
