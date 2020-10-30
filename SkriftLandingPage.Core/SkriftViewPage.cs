using System.Linq;
using Umbraco.Core.Cache;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;

namespace SkriftLandingPage.Core
{
    public class SkriftViewPage<TModel> : UmbracoViewPage<TModel>
    {
        public GlobalSettings Settings { get; private set; }


        public SkriftViewPage()
        {
            Settings = AppCaches.RequestCache.GetCacheItem("globalSettings", () =>
            {
                // should move this to a function somewhere...
                var content = Umbraco.ContentAtRoot().FirstOrDefault(x => x.ContentType.Alias == GlobalSettings.ModelTypeAlias);
                if (content is GlobalSettings settings)
                {
                    return settings;
                }

                return null;
            });
        }


        public override void Execute()
        {           
        }
    }
}
