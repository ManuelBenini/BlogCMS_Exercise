using SysDatCMS.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace SysDatCMS.Classes
{
    public class Article
    {

        // TODO Creare costruttore con ID e rendere i metodi non statici
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Testo { get; set; }
        public User Autore { get; set; }
        public Status Status { get; set; }
        public List<ArticleImage> Images { get; set; } = new List<ArticleImage>();


        public Article() { }
        public Article(int id, string titolo, string testo, User autore, Status status)
        {
            Id = id;
            Titolo = titolo;
            Testo = testo;
            Autore = autore;
            Status = status;
        }

        /// <summary>
        /// restituisce lista di articoli
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static List<Article> GetArticles(StatusEnum status)
        {
            var articles = new List<Article>();

            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("GetArticles", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@status", (int)status);
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var currentArticle = MapArticle(dr);

                            //Se l'articolo non è presente nella lista articoli, lo aggiungo. Altrimenti aggiungo solo delle immagini allo stesso articolo.
                            if (!articles.Any(article => article.Id == currentArticle.Id))
                            {
                                articles.Add(currentArticle);
                            }
                            else
                            {
                                var index = articles.FindIndex(article => article.Id == currentArticle.Id);
                                articles[index].Images.Add(currentArticle.Images[0]);
                            }
                        }
                    }
                }
            }
            return articles;
        }
        public static bool ModifyArticleWithoutImages(int articleId, string title, string text, int statusId, int userId)
        {
            //Modifica di un articolo lasciando invariate le immagini (modifica su gridControl)
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

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
        public static bool CreateOrModifyArticleWithImages(int articleId, string title, string text, int statusId, int userId, string[] images)
        {
            //Creazione/Modifica di un articolo con immagini in una transazione
            int targetArticleId = 0;
            var imagesNames = new List<string>();

            //Imposto la directory corrente a SysDatCMS\bin\debug e creo una cartella "Images" Se non esiste
            string imagesPath = ConfigurationManager.AppSettings["imagesPath"];
            Directory.SetCurrentDirectory(AppContext.BaseDirectory);
            var imagesDirectory = Directory.CreateDirectory(imagesPath);

            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        //Creo/modifico l'articolo
                        using (var cmd = new SqlCommand("CreateOrModifyArticleSP", con, transaction))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ArticleId", articleId);
                            cmd.Parameters.AddWithValue("@Title", title);
                            cmd.Parameters.AddWithValue("@Text", text);
                            cmd.Parameters.AddWithValue("@StatusId", statusId);
                            cmd.Parameters.AddWithValue("@UserId", userId);
                            targetArticleId = Convert.ToInt32(cmd.ExecuteScalar());

                            //Creo le immagini, le pusho nella tabella images, nella tabella pivot Article_Image e le sposto nella cartella locale Images
                            cmd.CommandText = "CreateImageAndPushInPivotTableSP";
                            for (int i = 0; i < images.Length; i++)
                            {
                                cmd.Parameters.Clear();
                                imagesNames.Add(Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + Path.GetExtension(images[i]));

                                cmd.Parameters.AddWithValue("@ImageName", imagesNames[i]);
                                cmd.Parameters.AddWithValue("@articleId", targetArticleId);
                                cmd.Parameters.AddWithValue("@ImagePath", ConfigurationManager.AppSettings["imagesPath"] + "\\");
                                cmd.ExecuteNonQuery();

                                //SysDatCMS\\bin\\debug\\Images
                                File.Copy(images[i], imagesDirectory + "\\" + imagesNames[i]);
                            }
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        //Elimino le immagini nella cartella locale
                        DeleteImages(imagesDirectory.FullName, imagesNames);
                        
                        //foreach (var imageName in imagesNames)
                        //{
                        //    File.Delete(imagesDirectory + "\\" + imageName);
                        //}
                        return false;
                    }
                }
            }
        }
        public static Article GetArticleById(int articleId)
        {
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                try
                {
                    con.Open();
                    Article currentArticle = new Article();

                    using (var cmd = new SqlCommand("GetArticleByIdSP", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ArticleId", articleId);
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                //Se currentArticle.Id è 0 assegno l'articolo, altrimenti aggiungo solo le immagini all'articolo già ottenuto
                                if (currentArticle.Id == 0)
                                {
                                    currentArticle = MapArticle(dr);
                                }
                                else
                                {
                                    currentArticle.Images.Add(new ArticleImage(
                                    (int)dr["ImageId"],
                                    dr["ImagePath"].ToString(),
                                    dr["ImageName"].ToString()));
                                }
                            }
                        }
                    }
                    return currentArticle;
                }
                //catch(SqlException ex)
                //{
                //    throw;
                //}
                //catch(InvalidCastException ex)
                //{
                //   // inserisco l'errore nel mio sistema di log
                //}
                catch (Exception)
                {
                    // Log di quello che è successo e continui l'esecuzione
                    //throw;
                    return null;
                }

            }
        }
        public static bool DeleteArticleById(int articleId) 
        {
            //Ottengo la cartella delle immagini da cui cancellare le immagini dell'articolo
            var imagesDirectory = Directory.GetCurrentDirectory() + @"\" + ConfigurationManager.AppSettings["imagesPath"];

            // conterrà tutti gli id delle immagini da eliminare
            var imagesToRemove = new List<ArticleImage>();

            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        using (var cmd = new SqlCommand("GetArticleByIdSP", con, transaction))
                        {
                            //Ottengo le immagini dell'articolo e le salvo nella lista images
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ArticleId", articleId);
                            using (var dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    imagesToRemove.Add(new ArticleImage((int)dr["ImageId"], dr["ImagePath"].ToString(), dr["ImageName"].ToString()));
                                }
                            }

                            //Elimino l'articolo
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "DELETE FROM Articles WHERE Id = @ArticleId";
                            cmd.ExecuteNonQuery();

                            //Elimino le immagini dell'articolo dalla tabella images

                            string inClause = string.Join(",", imagesToRemove.Select(s => s.Id));

                            cmd.Parameters.Clear();
                            cmd.CommandText = $"DELETE FROM Images WHERE Id IN ({inClause})";
                            cmd.ExecuteNonQuery();

                            //Elimino le immagini dalla cartella Images locale
                            DeleteImages(imagesDirectory, imagesToRemove.Select(s => s.Name).ToList());
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        private static void DeleteImages(string imagesDirectory, List<string> imagesToRemove)
        {
            foreach (var image in imagesToRemove)
            {
                if (File.Exists(imagesDirectory + "\\" + image))
                {
                    File.Delete(imagesDirectory + "\\" + image);
                }
            }
        }
        private static Article MapArticle(SqlDataReader dr)
        {
            Article currentArticle = new Article(
                                (int)dr["id"],
                                (string)dr["Titolo"],
                                (string)dr["Testo"],
                                new User((int)dr["UserId"], dr["UserName"].ToString(), dr["UserSurname"].ToString()),
                                new Status((int)dr["StatusId"], dr["StatusName"].ToString()));

            currentArticle.Images.Add(new ArticleImage(
                (int)dr["ImageId"],
                dr["ImagePath"].ToString(),
                dr["ImageName"].ToString()));

            return currentArticle;
        }


        public static bool DeleteArticleByIdOLD(int articleId)
        {
            //Ottengo la cartella delle immagini da cui cancellare le immagini dell'articolo
            var imagesDirectory = Directory.GetCurrentDirectory() + @"\" + ConfigurationManager.AppSettings["imagesPath"];
            var images = new List<ArticleImage>();
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        using (var cmd = new SqlCommand("GetArticleImagesSP", con, transaction))
                        {
                            //Ottengo le immagini dell'articolo e le salvo nella lista images
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ArticleId", articleId);
                            using (var dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    images.Add(new ArticleImage((int)dr["ImageId"], dr["ImagePath"].ToString(), dr["ImageName"].ToString()));
                                }
                            }

                            //Elimino l'articolo
                            cmd.CommandText = "DeleteArticleSP";
                            cmd.ExecuteNonQuery();

                            //Elimino le immagini dell'articolo dalla tabella images
                            cmd.Parameters.Clear();
                            cmd.CommandText = "DELETE FROM Images WHERE id IN (";
                            cmd.CommandType = CommandType.Text;
                            for (int i = 0; i < images.Count; i++)
                            {
                                cmd.CommandText += i == (images.Count - 1) ? images[i].Id + ");" : images[i].Id + ",";
                            }
                            cmd.ExecuteNonQuery();

                            //Elimino le immagini dalla cartella Images locale
                            foreach (var image in images)
                            {
                                if (File.Exists(imagesDirectory + "\\" + image.Name))
                                {
                                    File.Delete(imagesDirectory + "\\" + image.Name);
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}
