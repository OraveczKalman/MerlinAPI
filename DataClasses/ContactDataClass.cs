using Dapper;
using MerlinAPI.CoreClasses;
using MerlinAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection;

namespace MerlinAPI.DataClasses
{
    public class ContactDataClass
    {
        public ContactForm Get(int portalId)
        {
            ContactForm retVal = new();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.connectionString))
                {
                    var parameters = new { PortalId = portalId };
                    retVal = connection.QuerySingle<ContactForm>($"SELECT * FROM contact_form WHERE PortalId = @PortalId");
                }
            }
            catch (Exception ex)
            { 
                Debug.WriteLine(ex.InnerException);
                Debug.WriteLine(ex.Message + " "  +  ex.StackTrace);
            }
            return retVal;
        }

        public int Insert(ContactForm contactForm) 
        {
            int retVal = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.connectionString)) 
                {
                    string queryString = "INSERT INTO contact_form SET " +
                        " Name= @Name, " +
                        " Address = @Address, " +
                        " Phone = @Phone, " +
                        " Fax = @Fax, " +
                        " Mobile = @Mobile, " +
                        " TargetMail = @TargetMail, " +
                        " SmtpPassword = @SmtpPassword, " +
                        " SmtpServer = @SmtpServer, " +
                        " Port = @Port, " +
                        " UserName = @UserName, " +
                        " Created = @Created, " +
                        " CreatedBy = @CreatedBy, " +
                        " Active = @Active";
                    retVal = connection.Execute(queryString, contactForm);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException);
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
            }
            return retVal;
        }

        public int Update(ContactForm contactForm) 
        {
            int retVal = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.connectionString))
                {
                    string queryString = "UPDATE contact_form SET " +
                        " Name= @Name, " +
                        " Address = @Address, " +
                        " Phone = @Phone, " +
                        " Fax = @Fax, " +
                        " Mobile = @Mobile, " +
                        " TargetMail = @TargetMail, " +
                        " SmtpPassword = @SmtpPassword, " +
                        " SmtpServer = @SmtpServer, " +
                        " Port = @Port, " +
                        " UserName = @UserName, " +
                        " Modified = @Modified, " +
                        " ModifiedBy = @ModifiedBy, " +
                        " Active = @Active " +
                        " ContactId = @ContactId";
                    retVal = connection.Execute(queryString, contactForm);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException);
                Debug.WriteLine(ex.Message + " " + ex.StackTrace);
            }
            return retVal;
        }

        public int Delete(ContactForm contactForm) 
        {
            int retVal = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Globals.connectionString))
                {
                    string queryString = "UPDATE contact_form SET " +
                        " Modified = @Modified, " +
                        " ModifiedBy = @ModifiedBy, " +
                        " Active = @Active " +
                        " ContactId = @ContactId";
                    retVal = connection.Execute(queryString, contactForm);
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
}
