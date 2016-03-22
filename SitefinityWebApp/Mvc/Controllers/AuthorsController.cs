using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.DynamicModules;
using System.Collections.Generic;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Utilities.TypeConverters;
using Telerik.Sitefinity.Configuration;
using SitefinityWebApp.Configs;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Authors", Title = "Authors", SectionName = "MvcWidgets")]
    public class AuthorsController : Controller
    {
        public string ItemType
        {
            get
            {
                return this.itemType;
            }

            set
            {
                this.itemType = value;
            }
        }

        string itemType = "Telerik.Sitefinity.DynamicTypes.Model.Authors.Author";

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Title { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {

            var model = new AuthorsModel();
            if (string.IsNullOrEmpty(this.Title))
            {
                model.Title = "Author";
            }
            else
            {
                model.Title = this.Title;
            }
            var authors = GetAuthors().Select(i=> AuthorViewModel.GetAuthorViewModel(i));
            
            model.Authors = authors.ToList();

            return View("Default", model);
        }

        public IQueryable<DynamicContent> GetAuthors() {

            var providerName = String.Empty;
            DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager(providerName);
            Type authorType = TypeResolutionService.ResolveType(ItemType);

            // This is how we get the collection of Author items
            var myCollection = dynamicModuleManager.GetDataItems(authorType).Where(i=> i.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live);
            // At this point myCollection contains the items from type authorType
            return myCollection;
        }
    }
}