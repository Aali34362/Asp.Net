using Microsoft.AspNetCore.Mvc;
using SocietyManagementSystemApi.Model;
//using SocietyManagementSystemApi.Controllers;

namespace SocietyManagementSystemApi.Admin;

public class AdminController : Controller
{
    #region Users
    [HttpGet("User")]
    public IActionResult GetUser([FromQuery]Users users)
    {
        return View();
    }
    [HttpPost("User")]
    public IActionResult PostUser([FromBody]Users users)
    {
        return View();
    }
    [HttpPut("User")]
    public IActionResult UpdateUser([FromBody] Users users)
    {
        return View();
    }
    [HttpDelete("User")]
    public IActionResult DeleteUser([FromQuery] string user_created_id)
    {
        return View();
    }
    #endregion

    #region UsersDetails
    [HttpGet("UsersDetails")]
    public IActionResult GetUsersDetails([FromQuery] UsersDetails usersdetails)
    {
        return View();
    }
    [HttpPost("UsersDetails")]
    public IActionResult PostUsersDetails([FromBody] UsersDetails usersdetails)
    {
        return View();
    }
    [HttpPut("UsersDetails")]
    public IActionResult UpdateUsersDetails([FromBody] UsersDetails usersdetails)
    {
        return View();
    }
    [HttpDelete("UsersDetails")]
    public IActionResult DeleteUsersDetails([FromQuery] string user_created_id)
    {
        return View();
    }
    #endregion

    #region UsersLoginDetails
    [HttpGet("UsersLoginDetails")]
    public IActionResult GetUsersLoginDetails([FromQuery] UsersLoginDetails userslogindetails)
    {
        return View();
    }
    [HttpPost("UsersLoginDetails")]
    public IActionResult PostUsersLoginDetails([FromBody] UsersLoginDetails userslogindetails)
    {
        return View();
    }
    [HttpDelete("UsersLoginDetails")]
    public IActionResult DeleteBulkUsersLoginDetails([FromBody] List<UsersLoginDetails> userslogindetails)
    {
        return View();
    }
    #endregion

    #region UsersTypes
    [HttpGet("UsersTypes")]
    public IActionResult GetUsersTypes([FromQuery] UsersTypes userstypes)
    {
        return View();
    }
    [HttpPost("UsersTypes")]
    public IActionResult PostUsersTypes([FromBody] UsersTypes userstypes)
    {
        return View();
    }
    [HttpPut("UsersTypes")]
    public IActionResult UpdateUsersTypes([FromBody] UsersTypes userstypes)
    {
        return View();
    }
    [HttpDelete("UsersTypes")]
    public IActionResult DeleteUsersTypes([FromQuery] string user_created_id)
    {
        return View();
    }
    #endregion

}
