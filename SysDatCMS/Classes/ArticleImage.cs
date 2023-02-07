using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysDatCMS.Classes
{
    public class ArticleImage
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public Image GraphicImage { get; set; }

        public ArticleImage(int id, string path, string name)
        {
            Id = id;
            Path = path;
            Name = name;

            GraphicImage = Image.FromFile(path + name);
        }

        public static bool CreateImageAndPushInPivotTable(string imageName, int articleId)
        {
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("CreateImageAndPushInPivotTableSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ImageName", imageName);
                    cmd.Parameters.AddWithValue("@articleId", articleId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
