using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_.DB;
using MVC_.Models;

namespace MVC_.Controllers;

public class BlogEFCoreController : Controller
{
    public AppDbContext _context;

    public BlogEFCoreController(AppDbContext context)
    {
        _context = context;
    }

    [ActionName("BlogListPage")]
    public async Task<IActionResult> Index()
    {
        try
        {
            var blogLst = await _context.Tbl_Blogs.AsNoTracking().ToListAsync();
            var lst = blogLst
                .Select(x => new BlogModel()
                {
                    BlogId = x.BlogId,
                    BlogTitle = x.BlogTitle,
                    BlogAuthor = x.BlogAuthor,
                    BlogContent = x.BlogContent,
                })
                .ToList();

            return View(lst);
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
            var entity = new Tbl_Blog()
            {
                BlogTitle = requestModel.BlogTitle,
                BlogAuthor = requestModel.BlogAuthor,
                BlogContent = requestModel.BlogContent,
            };

            await _context.Tbl_Blogs.AddAsync(entity);
            var result = await _context.SaveChangesAsync();

            if (result == 1)
            {
                TempData["success"] = "Saving Successful.";
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
            var item =
                await _context.Tbl_Blogs.FindAsync(id) ?? throw new Exception("No data found.");
            var blog = new BlogModel()
            {
                BlogId = item.BlogId,
                BlogTitle = item.BlogTitle,
                BlogAuthor = item.BlogAuthor,
                BlogContent = item.BlogContent,
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
    public async Task<IActionResult> UpdateAsync(BlogRequestModel requestModel, int id)
    {
        try
        {
            var item =
                await _context.Tbl_Blogs.FindAsync(id) ?? throw new Exception("NO DATA FOund.");

            item.BlogTitle = requestModel.BlogTitle;
            item.BlogAuthor = requestModel.BlogAuthor;
            item.BlogContent = requestModel.BlogContent;

            int result = await _context.SaveChangesAsync();

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
            var item =
                await _context.Tbl_Blogs.FindAsync(id) ?? throw new Exception("No Data Found.");
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
