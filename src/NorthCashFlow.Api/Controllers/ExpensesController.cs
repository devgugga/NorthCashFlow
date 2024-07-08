using Microsoft.AspNetCore.Mvc;
using NorthCashFlow.Aplication.UseCases.Expenses.Register;
using NorthCashFlow.Comunication.Requests;

namespace NorthCashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        var useCase = new RegisterExpenseUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }
}