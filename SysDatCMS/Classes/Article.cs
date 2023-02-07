using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SysDatCMS.Classes
{
    public class Article
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Testo { get; set; }
        public User Autore { get; set; }
        public Status Status { get; set; }
        public List<ArticleImage> Images { get; set; }

        public Article(int id, string titolo, string testo, User autore, Status status, List<ArticleImage> image)
        {
            Id = id;
            Titolo = titolo;
            Testo = testo;
            Autore = autore;
            Status = status;
            Images = image;
        }


        /// <summary>
        /// Se il parametro è "true" verranno restituiti tutti gli articoli. Se "false" solo quelli sospesi ed eliminati.
        /// </summary>
        /// <param name="deletedOrSuspended">true o false</param>
        /// <returns>Lista di articoli</returns>
        public static List<Article> GetAllArticlesOrNotPublished(bool deletedOrSuspended)
        {
            var articles = new List<Article>();

            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("GetAllArticlesOrNotPublishedSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DeletedOrSuspended", Convert.ToInt32(!deletedOrSuspended));
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            articles.Add(new Article(
                                (int)dr["id"],
                                (string)dr["Titolo"],
                                (string)dr["Testo"],
                                new User((int)dr["UserId"], dr["UserName"].ToString(), dr["UserSurname"].ToString()),
                                new Status((int)dr["StatusId"], dr["StatusName"].ToString()),
                                Article.GetArticleImages((int)dr["id"])));
                        }
                    }
                }
            }

            return articles;
        }
        public static List<Article> GetOnlyPublishedArticles()
        {
            var articles = new List<Article>();

            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("GetOnlyPublishedArticlesSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            articles.Add(new Article(
                                (int)dr["id"],
                                (string)dr["Titolo"],
                                (string)dr["Testo"],
                                new User((int)dr["UserId"], dr["UserName"].ToString(), dr["UserSurname"].ToString()),
                                new Status((int)dr["StatusId"], dr["StatusName"].ToString()),
                                Article.GetArticleImages((int)dr["id"])));
                        }
                    }
                }
            }
            return articles;
        }
        public static List<Article> GetCurrentUserArticles()
        {
            var userArticles = new List<Article>();

            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("GetUserArticlesSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", CMSState.CurrentUserId);
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            userArticles.Add(new Article(
                                (int)dr["id"],
                                (string)dr["Titolo"],
                                (string)dr["Testo"],
                                new User((int)dr["UserId"], dr["UserName"].ToString(), dr["UserSurname"].ToString()),
                                new Status((int)dr["StatusId"], dr["StatusName"].ToString()),
                                Article.GetArticleImages((int)dr["id"])));
                        }
                    }
                }
            }
            return userArticles;
        }
        public static List<ArticleImage> GetArticleImages(int articleId)
        {
            var articleImages = new List<ArticleImage>();
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("GetArticleImagesSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ArticleId", articleId);
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            articleImages.Add(new ArticleImage(
                                (int)dr["ImageId"],
                                dr["ImagePath"].ToString(),
                                dr["ImageName"].ToString()));
                        }
                    }
                }
            }
            return articleImages;
        }
        public static int GetNumberOfArticlesOfTheCurrentUser()
        {
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("GetNumberOfArticlesOfTheUserSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", CMSState.CurrentUserId);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        public static bool AddImagesToArticle(int articleId, int imageId)
        {
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("AddImagesToArticleSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@articleId", articleId);
                    cmd.Parameters.AddWithValue("@imageId", imageId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static int CreateOrModifyArticle(int articleId, string title, string text, int statusId, int userId)
        {
            //Creazione/Modifica di un articolo senza immagini
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("CreateOrModifyArticleSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ArticleId", articleId);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Text", text);
                    cmd.Parameters.AddWithValue("@StatusId", statusId);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public static bool CreateOrModifyArticleWithImages(int articleId, string title, string text, int statusId, int userId, string[] images)
        {
            //Creazione/Modifica di un articolo con immagini in una transazione
            int targetArticleId = 0;
            string imagesDirectory = "c:\\Users\\mbenini.LOGICONE\\source\\repos\\SysDatCMS\\images";
            Directory.CreateDirectory(imagesDirectory);
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        using (var cmd = new SqlCommand("CreateOrModifyArticleSP", con, transaction))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ArticleId", articleId);
                            cmd.Parameters.AddWithValue("@Title", title);
                            cmd.Parameters.AddWithValue("@Text", text);
                            cmd.Parameters.AddWithValue("@StatusId", statusId);
                            cmd.Parameters.AddWithValue("@UserId", userId);
                            targetArticleId = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                        foreach (var image in images)
                        {
                            string imageName = DbHelper.getRandomFileName(image);
                            File.Copy(image, imagesDirectory + "\\" + imageName);
                            using (var cmd = new SqlCommand("CreateImageAndPushInPivotTableSP", con, transaction))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@ImageName", imageName);
                                cmd.Parameters.AddWithValue("@articleId", targetArticleId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                        return true;

                    }
                    catch (SqlException sqlError)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
        public static Article GetArticleById(int articleId)
        {
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("GetArticleByIdSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ArticleId", articleId);
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Article(
                                (int)dr["id"],
                                (string)dr["Titolo"],
                                (string)dr["Testo"],
                                new User((int)dr["UserId"], dr["UserName"].ToString(), dr["UserSurname"].ToString()),
                                new Status((int)dr["StatusId"], dr["StatusName"].ToString()),
                                Article.GetArticleImages((int)dr["id"]));
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public static bool DeleteArticleById(int articleId)
        {
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("DeleteArticleSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ArticleId", articleId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
