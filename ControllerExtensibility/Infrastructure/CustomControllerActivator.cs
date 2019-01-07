using System;
using System.Web.Routing;
using System.Web;
using System.Web.Mvc;
using ControllerExtensibility.Controllers;

namespace ControllerExtensibility.Infrastructure{

    public class CustomControllerActivator : IControllerActivator{

        public IController Create(RequestContext requestContext, Type controllerType){
        
            if (controllerType == typeof(ProductController))
                controllerType = typeof(CustomController);

            return (IController)DependencyResolver.Current.GetService(controllerType);
        }
    }
}