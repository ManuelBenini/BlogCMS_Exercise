using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace SysDatCMS.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Ruolo { get; set; }


        public User(int id, string nome, string cognome)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
        }
        public User(int id, string nome, string cognome, string email, string password, Role ruolo)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
            Email = email;
            Password = password;
            Ruolo = ruolo;
        }


        public static List<User> GetUsers()
        {
            var users = new List<User>();

            using(var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("GetUsers" , con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            users.Add(new User(
                                (int)dr["Id"],
                                (string)dr["Nome"],
                                (string)dr["Cognome"],
                                (string)dr["Email"],
                                (string)dr["Password"],
                                new Role((int)dr["RoleId"], dr["RoleName"].ToString())));
                        }
                    }
                }
            }
            return users;
        }
        public static int GetCurrentUserRole()
        {
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("GetUserRoleSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", CMSState.CurrentUserId);
                    using (var dr = cmd.ExecuteReader())
                    {
                        return dr.Read() ? (int)dr["RoleId"] : 0;
                    }
                }
            }
        }
        public static bool AddOrUpdateUser(int Id, string Name, string Surname, string Email, string Password, int RoleId)
        {
            string storedName = Id <= 0 ? "CreateUserSP" : "UpdateUserSP";

            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand(storedName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (Id > 0)
                    {
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.Parameters.AddWithValue("@RoleId", RoleId);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Password", Password);
                    }
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Surname", Surname);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static User GetUserById(int userId)
        {
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("GetUserByIdSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", userId);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new User(
                                (int)dr["Id"],
                                dr["Name"].ToString(),
                                dr["Surname"].ToString(),
                                dr["Email"].ToString(),
                                dr["Password"].ToString(),
                                new Role((int)dr["RoleId"], dr["RoleName"].ToString()));
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public static bool DeleteUser(int userId)
        {
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("DeleteUserSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", userId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static int Login(string Email, string Password)
        {
            using (var con = new SqlConnection(DbHelper.ConnStr))
            {
                con.Open();
                using (var cmd = new SqlCommand("FindUserSP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    //La stored restituisce solo l'ID dell'utente, se trovato.
                    return cmd.ExecuteScalar() != null ? (int)cmd.ExecuteScalar() : 0;
                }
            }
        }

        public override string ToString()
        {
            return $"{Nome} {Cognome}";
        }
    }
}
