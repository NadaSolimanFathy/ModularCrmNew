using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace ModularCrm.Ordering;

[DependsOn(
    typeof(OrderingDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class OrderingApplicationContractsModule : AbpModule
{

}
