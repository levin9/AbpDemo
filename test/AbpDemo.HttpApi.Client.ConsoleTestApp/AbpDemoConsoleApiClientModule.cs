using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpDemo.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpDemoHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpDemoConsoleApiClientModule : AbpModule
    {
        
    }
}
