using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using AbpDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpDemo.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits AbpDemo.Web.Pages.AbpDemoPage
     */
    public abstract class AbpDemoPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<AbpDemoResource> L { get; set; }
    }
}
