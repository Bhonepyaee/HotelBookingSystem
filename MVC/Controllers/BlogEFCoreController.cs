using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.DB;
using MVC.Models;

namespace MVC.Controllers;

public class BlogEFCoreController : Controller
{
    internal readonly AppDbContext _context;

    public BlogEFCoreController(AppDbContext context)
    {
        _context = context;
    }

    [ActionName("BlogListPage")]
    public async Task<IActionResult> Index()
    {
        var blogLst = await _context.Tbl_Blogs.AsNoTracking().ToListAsync();
        var lst = blogLst.Select(x => new BlogModel()
        {
            BlogId = x.BlogId,
            BlogTitle = x.BlogTitle,
            BlogAuthor = x.BlogAuthor,
            BlogContent = x.BlogContent
        })
            .ToList();

        return View(lst);
    }

    [ActionName("CreateBlogPage")]
    public IActionResult CreateBlog()
    {
        return View();
    }

    [ActionName("SaveAsync")]
    public async Task<IActionResult> SaveAsync(BlogRequestModel requestModel)
    {
        try
        {
            var entity = new Tbl_Blog()
            {
                BlogTitle = requestModel.BlogTitle,
                BlogAuthor = requestModel.BlogAuthor,
                BlogContent = requestModel.BlogContent
            };

            await _context.Tbl_Blogs.AddAsync(entity);
            var result = await _context.SaveChangesAsync();

            if (result == 1)
            {
                TempData["success"] = "Saving Successful.";
            }
            else
            {

                TempData["success"] = "Saving Successful.";
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
            var item = await _context.Tbl_Blogs.FindAsync(id) ?? throw new Exception("No data found.");
            var blog = new BlogModel()
            {
                BlogId = item.BlogId,
                BlogTitle = item.BlogTitle,
                BlogAuthor = item.BlogAuthor,
                BlogContent = item.BlogContent
            };

            return View(blog);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    [ActionName("UpdateAsync")]
    [HttpPost]
    public async Task<IActionResult> UpdateAsync(int id, BlogRequestModel requestModel)
    {
        try
        {
            var item = await _context.Tbl_Blogs.FindAsync(id) ?? throw new Exception("No data found");

            item.BlogTitle = requestModel.BlogTitle;
            item.BlogAuthor = requestModel.BlogAuthor;
            item.BlogContent = requestModel.BlogContent;

            int result = await _context.SaveChangesAsync();

            if (result == 1)
            {
                TempData["success"] = "Updating successful.";
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
            var item = await _context.Tbl_Blogs.FindAsync(id) ?? throw new Exception("No data found");

            _context.Tbl_Blogs.Remove(item);

            int result = await _context.SaveChangesAsync();

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
