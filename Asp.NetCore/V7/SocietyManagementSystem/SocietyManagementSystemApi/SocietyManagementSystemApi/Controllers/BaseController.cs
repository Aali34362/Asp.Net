using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SocietyManagementSystemApi.Controllers;

[Route("[controller]")]
[ApiController]
//[Route("v{version:apiVersion}/[controller]")]
//[ApiVersion("1")]
//[ProducesResponseType(StatusCodes.Status200OK)]
//[ProducesResponseType(StatusCodes.Status204NoContent)]
//[ProducesResponseType(StatusCodes.Status400BadRequest)]
//[ProducesResponseType(StatusCodes.Status401Unauthorized)]
//[ProducesResponseType(StatusCodes.Status415UnsupportedMediaType)]
//[ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
//[ProducesResponseType(StatusCodes.Status500InternalServerError)]
public class BaseController : Controller
{
    public override void OnActionExecuted(ActionExecutedContext context)
    {
        base.OnActionExecuted(context);
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        base.OnActionExecuting(context);
    }
}
