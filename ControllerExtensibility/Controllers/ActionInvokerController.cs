﻿using ControllerExtensibility.Infrastructure;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class ActionInvokerController : Controller{
        public ActionInvokerController() {
            this.ActionInvoker = new CustomActionInvoker(); //invoke from controller- not from Global.asax
        }
    }
}