using System.Collections.Generic;
using System.Data.SqlClient;

namespace SysDatCMS.Classes
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Role(){ }
        public Role(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<Role> GetRoles()
        {
            var roles = new List<Role>();

            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Roles", con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            roles.Add(new Role(
                                (int)dr["Id"],
                                dr["Name"].ToString()));
                        }
                    }
                }
            }
            return roles;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
