﻿namespace MVC.Queries;

public class BlogQuery
{
    public static string GetBlogByIdQuery { get; } =
        @"SELECT BlogId,BlogTitle,BlogAuthor,BlogContent
              FROM Tbl_Blog WHERE BlogId = @BlogId";

    public static string BlogListQuery { get; } =
        @"SELECT BlogId,BlogTitle,BlogAuthor,BlogContent 
             FROM Tbl_Blog ORDER BY BlogId DESC";

    public static string CreateBlogQuery { get; } =
        @"INSERT INTO Tbl_Blog (BlogTitle, BlogAuthor, BlogContent)
             VALUES(@BlogTitle, @BlogAuthor, @BlogContent)";

    public static string UpdateBlogQuery { get; } =
        @"UPDATE Tbl_Blog SET BlogTitle = @BlogTitle, BlogAuthor = @BlogAuthor, 
            BlogContent = @BlogContent WHERE BlogId =@BlogId";

    public static string DeleteBlogQuery { get; } = @"DELETE FROM Tbl_Blog WHERE BlogId = @BlogId";
}
