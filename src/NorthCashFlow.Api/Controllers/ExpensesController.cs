using Microsoft.AspNetCore.Mvc;
using NorthCashFlow.Aplication.UseCases.Expenses.Register;
using NorthCashFlow.Comunication.Requests;
using NorthCashFlow.Comunication.Responses;

namespace NorthCashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        try
        {
            var useCase = new RegisterExpenseUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
        catch (ArgumentException ex)
        {
            var response = new ResponseErrorJson
            {
                Message = ex.Message
            };

            return BadRequest(response);
        }
        catch
        {
            var response = new ResponseErrorJson
            {
                Message = "Uknown error. Please, try again later."
            };

            return StatusCode(StatusCodes.Status500InternalServerError, response);
        }
    }
}