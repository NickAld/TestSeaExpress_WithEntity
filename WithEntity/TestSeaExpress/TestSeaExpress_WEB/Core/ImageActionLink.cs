using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace TestSeaExpress_WEB.Core
{

    public static class HelperExtensions
    {
        public static IHtmlString ImageActionLink(this AjaxHelper helper, string imageUrl, string titleText, string actionName, object routeValues, AjaxOptions ajaxOptions)
        {
            var builder = new TagBuilder("img");
            builder.MergeAttribute("src", imageUrl);
            builder.MergeAttribute("title", titleText);
            var link = helper.ActionLink("[replaceme]", actionName, routeValues, ajaxOptions).ToHtmlString();
            return new MvcHtmlString(link.Replace("[replaceme]", builder.ToString(TagRenderMode.SelfClosing)));
        }
        public static IHtmlString ImageActionLink(this AjaxHelper helper, string imageUrl, string titleText, string actionName, string controllerName, object routeValues, AjaxOptions ajaxOptions)
        {
            var builder = new TagBuilder("img");
            builder.MergeAttribute("src", imageUrl);
            builder.MergeAttribute("title", titleText);
            var link = helper.ActionLink("[replaceme]", actionName, controllerName, routeValues, ajaxOptions).ToHtmlString();
            return new MvcHtmlString(link.Replace("[replaceme]", builder.ToString(TagRenderMode.SelfClosing)));
        }
    }

}