using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NorthCashFlow.Comunication.Responses;
using NorthCashFlow.Exception.ExceptionsBase;

namespace NorthCashFlow.Api.Filters;

/// <summary>
///     A custom exception filter for handling exceptions globally across the application.
/// </summary>
public class ExceptionFilter : IExceptionFilter
{
    /// <summary>
    ///     Called when an exception occurs during action execution.
    /// </summary>
    /// <param name="context">The context in which the exception occurred.</param>
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is NorthCashFlowException)
            if (context.Exception is NorthCashFlowException)
                HandleProjectException(context);
            else
                HandleUnknownException(context);
    }

    /// <summary>
    ///     Handles exceptions specific to the NorthCashFlow project, such as validation errors.
    /// </summary>
    /// <param name="context">The context in which the exception occurred.</param>
    private void HandleProjectException(ExceptionContext context)
    {
        if (context.Exception is ErrorOnValidationException)
        {
            var ex = (ErrorOnValidationException)context.Exception;

            var errorResponse = new ResponseErrorJson(ex.Errors);

            context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
            context.Result = new BadRequestObjectResult(errorResponse);
        }
        else
        {
            var errorResponse = new ResponseErrorJson("Internal error. Please, try again later.");

            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(errorResponse);
        }
    }

    /// <summary>
    ///     Handles exceptions that are not specifically accounted for in the project, treating them as unknown errors.
    /// </summary>
    /// <param name="context">The context in which the exception occurred.</param>
    private void HandleUnknownException(ExceptionContext context)
    {
        var errorResponse = new ResponseErrorJson("Uknown error. Please, try again later.");

        context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(errorResponse);
    }
}