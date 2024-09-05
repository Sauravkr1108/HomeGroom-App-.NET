using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HomeGroom.TagHelpers
{
    public class TelTagHelper : TagHelper
    {
        public string Phone { get; set; }
        public string Content { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "tel:" + Phone);
            output.Content.SetContent(Content);
            
        }
    }
}
