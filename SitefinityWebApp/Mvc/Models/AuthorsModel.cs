using System;
using System.Collections.Generic;
using System.Linq;

namespace SitefinityWebApp.Mvc.Models
{
    public class AuthorsModel
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Title { get; set; }
        public List<AuthorViewModel> Authors { get; set; }
    }
}