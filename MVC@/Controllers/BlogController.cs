using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MVC_.Models;
using MVC_.Queries;

namespace MVC_.Controllers
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
                using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DbConnection"));
                var lst = await db.QueryAsync<BlogModel>(query);

                return View(lst);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [ActionName("CreateBlogPage")]
        public IActionResult CreateBlog()
        {
            return View();
        }

        [ActionName("SaveAsync")]
        [HttpPost]
        public async Task<IActionResult> SaveAsync(BlogRequestModel requestModel)
        {
            try
            {
                string query = BlogQuery.CreateBlogQuery;
                var parameters = new
                {
                    requestModel.BlogTitle,
                    requestModel.BlogAuthor,
                    requestModel.BlogContent,
                };

                using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DbConnection"));
                int result = await db.ExecuteAsync(query, parameters);

                if(result == 1)
                {
                    TempData["success"] = "Saving Successful";
                }
                else
                {
                    TempData["fail"] = "Saving Fail";
                }

                return RedirectToAction("BlogListPage");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [ActionName("EditBlogPage")]
        [HttpGet]
        public async Task<IActionResult> EditBlogAsync(int id)
        {
            try
            {
                string query = BlogQuery.GetBlogListQuery;
                var parameters = new { BlogId = id };

                using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DbConnection"));
                var lst = await db.QueryAsync<BlogModel>(query, parameters);

                return View(lst);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [ActionName("UpdateBlogAsync")]
        [HttpPost]
        public async Task<IActionResult> UpdateBlogAsync(BlogRequestModel requestModel, int id)
        {
            try
            {
                string query = BlogQuery.UpdateBlogListQuery;
                var parameters = new
                {
                    requestModel.BlogTitle,
                    requestModel.BlogAuthor,
                    requestModel.BlogContent,
                    BlogId = id
                };

                using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DbConnection"));
                int result = await db.ExecuteAsync(query, parameters);

                if (result > 0)
                {
                    TempData["success"] = "Updating Successful.";
                }
                else
                {
                    TempData["fail"] = "Updating Fail.";
                }

                return RedirectToAction("BlogListPage");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [ActionName("DeleteAsync")]
        [HttpGet]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                string query = @"DELETE Tbl_Blog WHERE BlogId = @BlogId";
                var parameters = new { BlogId = id };

                using IDbConnection db = new SqlConnection(_configuration.GetConnectionString("DbConnection"));
                int result = await db.ExecuteAsync(query, parameters);

                if (result > 0)
                {
                    TempData["success"] = "Deleting Successful.";
                }
                else
                {
                    TempData["fail"] = "Deleting Fail.";
                }

                return RedirectToAction("BlogListPage");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
