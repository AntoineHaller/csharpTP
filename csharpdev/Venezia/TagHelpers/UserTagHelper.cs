using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Venezia.TagHelpers
{
    public class UserTagHelper : TagHelper
    {
        [ViewContext]
        public ViewContext Context { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //Si un utilisateur est connecté
            if (Context.HttpContext.User.Identity.Name != null)
            {
                var data = Context.HttpContext.User.Identity.Name.ToString();
                output.Content.SetContent(data);
            }
        }
    }
}