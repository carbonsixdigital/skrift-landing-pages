using HtmlAgilityPack;
using System.Web;

namespace SkriftLandingPage.Core.Extensions
{
    public static class HtmlStringExtensions
    {
        public static IHtmlString ApplyClass(this IHtmlString html, string selector, string classes)
        {
            var htmlString = html?.ToString();
            if (string.IsNullOrWhiteSpace(htmlString))
            {
                return new HtmlString(htmlString);
            }

            var doc = new HtmlDocument();
            doc.LoadHtml(htmlString);
            var tags = doc.DocumentNode.SelectNodes(selector);
            foreach (var tag in tags)
            {
                tag.AddClass(classes, false);
            }

            return new HtmlString(doc.DocumentNode.OuterHtml);
        }
    }
}
