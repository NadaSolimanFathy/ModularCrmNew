using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ModularCrm.Products;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductsHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ProductsConsoleApiClientModule : AbpModule
{

}
