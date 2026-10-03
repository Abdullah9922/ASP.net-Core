using Microsoft.AspNetCore.Html;

namespace Custoom_Helper_Html
{
    public static class MyHelper
    {
        // custoom helper that genarate button
        public static HtmlString Button(string type, string value)
        {
            return new HtmlString(String.Format("<input type='{0}' value='{1}'/>", type, value));
        }

        public static HtmlString Image(string src, string alt="", string width="", string hight="")
        {
            return new HtmlString(String.Format("<img src='{0}' alt='{1}' width='{2}' hight='{3}'/>", src, alt, width, hight));
        }
    }
}
