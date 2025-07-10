using Volo.Abp.Modularity;

namespace ModularCrm.Ordering;

[DependsOn(
    typeof(OrderingApplicationModule),
    typeof(OrderingDomainTestModule)
    )]
public class OrderingApplicationTestModule : AbpModule
{

}
