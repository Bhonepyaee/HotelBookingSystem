using System.Data;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Queries;

namespace MVC.Controllers
{
    public class BlogController : Controller
    {
        internal readonly IConfiguration _configuration;
        public BlogController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [ActionName("BlogListPage")]
        public async Task<IActionResult> Index()
        {
            try
            {
                string query = BlogQuery.BlogListQuery;
                using IDbConnection db = new SqlConnectionn(_configuration.GetConnectionString("DbConnection"));
                var lst = await db.QueryAsync<BlogModel>(query);

                return View();
            }
            catch(Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }
    }
}
