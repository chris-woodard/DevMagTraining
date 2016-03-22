using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Services;

namespace SitefinityWebApp
{
    public class MyCustomModule : ModuleBase
    {

        protected override Telerik.Sitefinity.Configuration.ConfigSection GetModuleConfig()
        {
            throw new NotImplementedException();
        }

        public override void Install(Telerik.Sitefinity.Abstractions.SiteInitializer initializer)
        {
            
        }

        public override void Uninstall(Telerik.Sitefinity.Abstractions.SiteInitializer initializer)
        {
            base.Uninstall(initializer);
        }

        public override void Upgrade(Telerik.Sitefinity.Abstractions.SiteInitializer initializer, Version upgradeFrom)
        {
            base.Upgrade(initializer, upgradeFrom);
        }

        public override Guid LandingPageId
        {
            get { throw new NotImplementedException(); }
        }

        public override Type[] Managers
        {
            get { throw new NotImplementedException(); }
        }
    }
}