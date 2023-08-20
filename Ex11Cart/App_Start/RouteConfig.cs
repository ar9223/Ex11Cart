using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace Ex11Cart
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Temporary;

            routes.MapPageRoute("DefaultRoute", "Home", "~/Default.aspx");
            routes.MapPageRoute("ProductsRoute", "Shop/Products", "~/Products.aspx");
            routes.MapPageRoute("OrderRoute", "Shop/Order", "~/Order.aspx");
            routes.MapPageRoute("CartRoute", "Shop/Cart", "~/Cart.aspx");
            routes.MapPageRoute("ContactUsRoute", "Contact", "~/ContactUs.aspx");

            routes.EnableFriendlyUrls(settings);
        }
    }
}
