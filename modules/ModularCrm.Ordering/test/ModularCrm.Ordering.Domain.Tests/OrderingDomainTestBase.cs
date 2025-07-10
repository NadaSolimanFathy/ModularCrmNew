using Volo.Abp.Modularity;

namespace ModularCrm.Ordering;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class OrderingDomainTestBase<TStartupModule> : OrderingTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
