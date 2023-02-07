using System.Collections.Generic;
using System.Data.SqlClient;

namespace SysDatCMS.Classes
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Status(){}
        public Status(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<Status> GetStatuses()
        {
            var statuses = new List<Status>();

            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Article_Statuses", con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            statuses.Add(new Status(
                                (int)dr["Id"],
                                dr["Name"].ToString()));
                        }
                    }
                }
            }
            return statuses;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
