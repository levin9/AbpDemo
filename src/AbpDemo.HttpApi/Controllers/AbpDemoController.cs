using AbpDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpDemoController : AbpController
    {
        protected AbpDemoController()
        {
            LocalizationResource = typeof(AbpDemoResource);
        }
    }
}