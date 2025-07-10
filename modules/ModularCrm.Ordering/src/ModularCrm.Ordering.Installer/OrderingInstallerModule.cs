using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace ModularCrm.Ordering;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class OrderingInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<OrderingInstallerModule>();
        });
    }
}
