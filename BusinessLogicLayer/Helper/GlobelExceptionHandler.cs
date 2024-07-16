using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Helper
{
    public class GlobelExceptionHandler : IMiddleware
    {
        //2.method of exeption hadller
        /*
         * 1.we need to define a async method called InvokeAsync
         */
        //private readonly RequestDelegate _next;
        //private readonly ILogger logger;
        //public async Task InvokeAsync(HttpContext context) 
        //{
        //    try
        //    { await _next(context)}
        //    catch (Exception ex) 
        //    { logger.LogError(ex, ex.Message); }
        //}
        private readonly ILogger<GlobelExceptionHandler> _logger;

        public GlobelExceptionHandler(ILogger<GlobelExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync("An unexpected error occurred. Please try again later.");
            }
        }
    }
}
