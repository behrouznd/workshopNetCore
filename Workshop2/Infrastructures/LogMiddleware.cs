using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop2.Interfaces;
using Workshop2.Repositories;

namespace Workshop2.Infrastructures
{
    public class LogMiddleware
    {
        private RequestDelegate nextDelegate;

        public LogMiddleware(RequestDelegate next) => nextDelegate = next;

        public async Task Invoke(HttpContext httpContext, ILogRepository logRepository)
        {
       //     var controllerActionInfo = httpContext
       //.GetEndpoint()
       //.Metadata
       //.GetMetadata<ControllerActionDescriptor>();

            var controllerName ="";
            var actionName = "";

            string userId = httpContext.Request.Query["UserId"];
       

            logRepository.CreateLog(controllerName, actionName, userId);

            await nextDelegate.Invoke(httpContext);

        }

    }
}
