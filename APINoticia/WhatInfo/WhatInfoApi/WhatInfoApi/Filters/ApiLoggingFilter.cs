using Microsoft.AspNetCore.Mvc.Filters;

namespace WhatInfoApi.Filters
{
    public class ApiLoggingFilter : IActionFilter
    {
        private readonly ILogger _logger;
        public ApiLoggingFilter(ILogger<ApiLoggingFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("###########################");
            _logger.LogInformation(DateTime.Now.ToString());
            _logger.LogInformation($"ModelState {context.ModelState.IsValid}");
            _logger.LogInformation("###########################");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation($"###############################");
            _logger.LogInformation($"{typeof(ApiLoggingFilter)}");
            _logger.LogInformation($"StatusCode {context.HttpContext.Response.StatusCode}");
            _logger.LogInformation($"###############################");
        }
    }
}
