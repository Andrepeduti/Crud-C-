using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WhatInfoApi.Filters
{
    public class ApiExcepetionFilter : IExceptionFilter
    {
        private readonly ILogger<ApiExcepetionFilter> _logger;
        public ApiExcepetionFilter(ILogger<ApiExcepetionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)// tratamento global de erro
        {
            _logger.LogError(context.Exception, "Ocorreu um erro");
            context.Result = new ObjectResult("Ocorreu um erro ao tratar sua solicitação")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}
