﻿using System;
using System.Collections.Generic;
using ControllerExtensibility.Infrastructure;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllerExtensibility
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());

            //ControllerBuilder.Current.DefaultNamespaces.Add("MyControllerNamespace");
            //ControllerBuilder.Current.DefaultNamespaces.Add("MyProject.*");

            ControllerBuilder.Current.SetControllerFactory(new DefaultControllerFactory(new CustomControllerActivator()));
        }
    }
}
