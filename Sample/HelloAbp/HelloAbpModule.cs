using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HelloAbp
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class HelloAbpModule:AbpModule
    {
        public override Task ConfigureServicesAsync(ServiceConfigurationContext context)
        {
            return base.ConfigureServicesAsync(context);
        }
    }
}
