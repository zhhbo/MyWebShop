﻿using Orchard.Mvc.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyWebShop
{
    public class Routes : IRouteProvider
    {
        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[] {
             new RouteDescriptor {
                         Priority = 97,
                        Route = new Route(
                            "Product/{category}/{title}",
                            new RouteValueDictionary {
                                                        {"area", "MyWebShop"},
                                                        {"controller", "ProductInfo"},
                                                        {"action", "Index"}
                                                    },
                            new RouteValueDictionary (),
                            new RouteValueDictionary {
                                                        {"area", "MyWebShop"}
                                                    },
                            new MvcRouteHandler())
                    },
                         new RouteDescriptor {
                         Priority = 98,
                        Route = new Route(
                            "Category/{title}",
                            new RouteValueDictionary {
                                                        {"area", "MyWebShop"},
                                                        {"controller", "CategoryInfo"},
                                                        {"action", "Index"}
                                                    },
                            new RouteValueDictionary (),
                            new RouteValueDictionary {
                                                        {"area", "MyWebShop"}
                                                    },
                            new MvcRouteHandler())
                    },
                new RouteDescriptor {
                    Priority = 99,
                    Route = new Route( 
                  "",
                        new RouteValueDictionary {
                            {"area", "MyWebShop"},
                            {"controller", "Home"},
                            {"action", "Index"}
                        },
                        new RouteValueDictionary(),
                        new RouteValueDictionary {
                            {"area", "MyWebShop"}
                        },
                        new MvcRouteHandler())
                }
 
 
            };
        }

    }
}