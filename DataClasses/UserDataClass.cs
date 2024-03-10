using Dapper;
using MerlinAPI.CoreClasses;
using MerlinAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

namespace MerlinAPI.DataClasses
{
    public class UserDataClass
    {
        public User Login(string username, string password)
        {
            User retVal = new User();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.connectionString))
                {
                    var parameters = new { UserName = username, Password = password };
                    retVal = connection.QuerySingle<User>($"SELECT * FROM user WHERE UserName = @UserName AND Password = @Password", parameters);
                }
            }
            catch (Exception ex) 
            {
                Debug.WriteLine(ex.InnerException);
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
            }
            return retVal;
        }

        public List<User> GetAll()
        {
            List<User> retVal = new List<User>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.connectionString))
                {
                    retVal = connection.Query<User>($"SELECT * FROM user").ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException);
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
            }
            return retVal;
        }

        public int Insert(User user)
        {
            int retVal = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.connectionString))
                {
                    string queryString = "INSERT INTO user " +
                        " SET Name = @Name, " +
                        " UserName = @UserName, " +
                        " Password = SHA2(@Password, 512), " +
                        " Email = @Email, " +
                        " RightId = @RightId, " +
                        " Created = @Created, " +
                        " CreatedBy = @CreatedBy, " +
                        " Active = @Active";
                    retVal = connection.Execute(queryString, user);
                }
            }
            catch (Exception ex)
            { 
                Debug.WriteLine(ex.InnerException);
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
            }
            return retVal;
        }

        public int Update(User user)
        {
            int retVal = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.connectionString))
                {
                    string queryString = "UPDATE user SET " +
                        " Name = @Name, " +
                        " UserName = @UserName, " +
                        " Password = SHA2(@Password, 512), " +
                        " Email = @Email, " +
                        " RightId = @RightId, " +
                        " Modified = @Modified, " +
                        " ModifiedBy = @ModifiedBy, " +
                        " Active = @Active " +
                        " WHERE UserId = @UserId";
                    retVal = connection.Execute(queryString, user);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException);
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
            }
            return retVal;
        }

        public int Delete(User user)
        {
            int retVal = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.connectionString))
                {
                    string queryString = "UPDATE user SET " +
                        " Modified = @Modified, " +
                        " ModifiedBy = @ModifiedBy, " +
                        " Active = @Active " +
                        " WHERE UserId = @UserId";
                    retVal = connection.Execute(queryString, user);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException);
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
            }
            return retVal;
        }
    }

    public class LoginData
    { 
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
