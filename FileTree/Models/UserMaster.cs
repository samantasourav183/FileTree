using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FileTree.Models
{
    public class UserMaster
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }
        public string UserType { get; set; }

        public string Email_Address { get; set; }

        public string UserPassword { get; set; }
        public string ConfirmPassword { get; set; }

        private string Cs = ConfigurationManager.ConnectionStrings["abcd"].ConnectionString;

        public bool InsertUser(string UserName,string UserRole,string Email_Address,string UserPassword)
        {
            SqlConnection con = new SqlConnection(Cs);
            SqlCommand cmd = new SqlCommand("Usp_UserMaster",con);
            cmd.CommandType = CommandType.StoredProcedure;  
            con.Open();
            cmd.Parameters.AddWithValue("@UserName",UserName);
            cmd.Parameters.AddWithValue("UserRole",UserRole);
            cmd.Parameters.AddWithValue("@Email_Address",Email_Address);
            cmd.Parameters.AddWithValue("@UserPassword",UserPassword);
            cmd.Parameters.AddWithValue("Task","Insert");
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i>0)
            {
                return true;
            }
            else
            {
                return false; 
            }

           
        }

        public DataTable UserLogin( string Email_Address, string UserPassword)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(Cs);
            SqlCommand cmd = new SqlCommand("Usp_UserMaster", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@UserName","");
            cmd.Parameters.AddWithValue("UserRole", "");
            cmd.Parameters.AddWithValue("@Email_Address", Email_Address);
            cmd.Parameters.AddWithValue("@UserPassword", UserPassword);
            cmd.Parameters.AddWithValue("Task", "Login");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            con.Close();
            return dt;
        }

    }
}