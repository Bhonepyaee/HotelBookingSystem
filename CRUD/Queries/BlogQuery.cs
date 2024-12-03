namespace CRUD.Queries
{
    public class BlogQuery
    {
        public static string GetBlogListQuery { get; } =
            @"SELECT BlogId,BlogTitle,BlogAuthor,BlogContent 
              FROM Tbl_Blog ORDER BY BlogId DESC";

        public static string UpdateBlogQuery { get; } =
            @"UPDATE Tbl_Blog SET BlogTitle = @BlogTitle, 
         BlogAuthor= @BlogAuthor, BlogContent = @BlogContent WHERE BlogId = @BlogId";
    }
}
