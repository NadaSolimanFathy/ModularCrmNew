using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using ModularCrm.Products;
using ModularCrm.Ordering;

namespace ModularCrm;

[DependsOn(
    typeof(ModularCrmDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(ModularCrmApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
[DependsOn(typeof(ProductsApplicationModule))]
    [DependsOn(typeof(OrderingApplicationModule))]
    public class ModularCrmApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<ModularCrmApplicationModule>();
        });
    }
}
