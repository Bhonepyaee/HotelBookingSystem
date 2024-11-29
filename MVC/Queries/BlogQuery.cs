namespace MVC.Queries
{
    public class BlogQuery
    {
        public static string BlogListQuery { get; } =
            @"SELECT BlogId,BlogTitle,BlogAuthor,BlogContent 
             FROM Tbl_Blog ORDER BY BlogId DESC";

        public static string CreateBlogQuery { get; } =
            @"INSERT INTO Tbl_Blog (BlogTitle, BlogAuthor, BlogContent)
             VALUES(@BlogTitle, @BlogAuthor, @BlogContent)";
    }
}
