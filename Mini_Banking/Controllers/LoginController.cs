using Microsoft.AspNetCore.Mvc;

namespace Mini_Banking.Controllers;

public class LoginController : Controller
{
    internal readonly IConfiguration _configuration;

    public LoginController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [ActionName("Login")]
    public async Task<IActionResult> Index()
    {

        #region Index
        try
        {

            return View();
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    
    }
    #endregion

    [ActionName("Register")]
    public async Task<IActionResult> Index1()
    {
        try
        {
            return View();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

}
