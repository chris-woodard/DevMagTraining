using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using RazorGenerator.Mvc;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(SitefinityWebApp.RazorGeneratorMvcStart), "Start")]

namespace SitefinityWebApp {
    public static class RazorGeneratorMvcStart {
        public static void Start() {
            var engine = new PrecompiledMvcEngineCustom()
            {
                UsePhysicalViewsIfNewer = HttpContext.Current.Request.IsLocal
            };

            ViewEngines.Engines.Insert(0, engine);

            // StartPage lookups are done by WebPages. 
            VirtualPathFactoryManager.RegisterVirtualPathFactory(engine);
        }
    }

    public class PrecompiledMvcEngineCustom : PrecompiledMvcEngine
    {
        public PrecompiledMvcEngineCustom()
            : base(typeof(RazorGeneratorMvcStart).Assembly)
        {
        }
    }
}
