using NorthCashFlow.Comunication.Requests;
using NorthCashFlow.Comunication.Responses;

namespace NorthCashFlow.Aplication.UseCases.Expenses.Register;
public class RegisterExpenseUseCase
{
    public ResponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        //TODO Validations

        return new ResponseRegisteredExpenseJson();
    }
}
