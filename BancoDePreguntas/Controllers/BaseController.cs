﻿using BancoDePreguntas.Services.LogService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancoDePreguntas.Controllers
{
    public abstract class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            //ILog log = new ProductionLog();

            //if (filterContext.ExceptionHandled)
            //{
            //    return;
            //}

            //log.WriteLog(filterContext.Exception.Message);
            //filterContext.Result = new ViewResult
            //{
            //    ViewName = "~/Views/Shared/Error.csthml"
            //};
            //filterContext.ExceptionHandled = true;
        }
    }
}