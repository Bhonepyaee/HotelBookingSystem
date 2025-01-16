namespace MVC.Models;

public class BlogListResponseModel
{
    public PageSettingModel PageSetting { get; set; }
    public List<BlogModel> Blogs { get; set; }
}
