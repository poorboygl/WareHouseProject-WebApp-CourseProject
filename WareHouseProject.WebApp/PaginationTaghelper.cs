using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseProject.WebApp
{
    public class PaginationTaghelper : TagHelper
    {
        public int Size { get; set; }
        public int Total { get; set; }
        public string Url { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            int n = (Total - 1) / Size + 1;
            output.TagName = "ul";
            output.Attributes.Add("class", "pagination");
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                string uri = string.Format(Url, i);
                sb.AppendFormat("<li class=\"page-item\"><a class=\"page-link\"href=\"{0}\">{1}</a></li>",uri, i);
            }
            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
