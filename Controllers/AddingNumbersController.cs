//Harrison Busby
//10/27/2022
//Adding Numbers Endpoint
//Peer reviewed by: Peer Review: Brandon Le - Web API project works as intended. 
//I'm able to get the sum of two numbers when I input it into the URL after /addingnumbers/adding numbers/ 
//**Make sure to have a space between adding and numbers for the second part of the URL to make it work, I missed that small detail in the beginning and was having trouble getting it to work. 
//I would suggest choosing a different route name just to avoid the same type of issue in the future, but other than that it does what it needed to do! Good Job Harrison :)



using Microsoft.AspNetCore.Mvc;

namespace BusbyHAddingNumbersEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class AddingNumbersController : ControllerBase
{
    [HttpGet]
    [Route("Adding Numbers/{num1}/{num2}")]

    public int numberTime(int num1, int num2){
            return num1 + num2;
    }
}
