using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Queries;

namespace MVC.Controllers;

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
            using IDbConnection db = new SqlConnection(
                _configuration.GetConnectionString("DbConnection")
            );
            var lst = await db.QueryAsync<BlogModel>(query);

            return View(lst.ToList());
        }
        catch (Exception ex)
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

            using IDbConnection db = new SqlConnection(
                _configuration.GetConnectionString("DbConnection")
            );

            int result = await db.ExecuteAsync(query, parameters);
            if (result > 0)
            {
                TempData["success"] = "Saving Successful.";
            }
            else
            {
                TempData["fail"] = "Saving Fail.";
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
            string query = BlogQuery.GetBlogByIdQuery;
            var parameters = new { BlogId = id };
            using IDbConnection db = new SqlConnection(
                _configuration.GetConnectionString("DbConnection")
            );
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
            string query = BlogQuery.UpdateBlogQuery;
            var parameters = new
            {
                requestModel.BlogTitle,
                requestModel.BlogAuthor,
                requestModel.BlogContent,
                BlogId = id,
            };

            using IDbConnection db = new SqlConnection(
                _configuration.GetConnectionString("DbConnection")
            );
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

    [ActionName("DeleteBlogAsync")]
    public async Task<IActionResult> DeleteBlogAsync(int id)
    {
        string query = BlogQuery.DeleteBlogQuery;
        var parameters = new { BlogId = id };

        using IDbConnection db = new SqlConnection(
            _configuration.GetConnectionString("DbConnection")
        );

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
}
