﻿using System.Web.Mvc ;
using System.Web.Routing;
using System.Web.SessionState;
using ControllerExtensibility.Controllers;
using System;

namespace ControllerExtensibility.Infrastructure
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName){
            Type targetType = null;
            switch (controllerName) {
                case "Product":
                    targetType = typeof(ProductController);
                    break;
                case "Custom":
                    targetType = typeof(CustomController);
                    break;
                default:
                    requestContext.RouteData.Values["controller"] = "Product"; //set in the map routing name of controller for resolving then
                    targetType = typeof(ProductController);
                    break;
            }
            return targetType == null ? null : (IController)DependencyResolver.Current.GetService(targetType);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName){
            switch (controllerName) {
                case "Product": return SessionStateBehavior.ReadOnly;
                case "SelectorAction": return SessionStateBehavior.Required;
                default: return SessionStateBehavior.Default;
            }
        }

        public void ReleaseController(IController controller){
            IDisposable disposable = controller as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }
    }
}