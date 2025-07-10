using Volo.Abp.Modularity;

namespace ModularCrm.Ordering;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class OrderingApplicationTestBase<TStartupModule> : OrderingTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
