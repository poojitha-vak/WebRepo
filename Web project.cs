using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Login
{
    public partial class Login : System.Web.UI.Page
    {









        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["LoginSuccess"] != null)
            {
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = Session["LoginSuccess"].ToString();
                Session.Remove("LoginSuccess");
            }
            else if (!IsPostBack || Request.HttpMethod == "GET")
            {
                lblMessage.Text = "";
            }
        }



        //protected void btnLogin_Click(object sender, EventArgs e)
        //{
        //    string username = txtUsername.Text.Trim();
        //    string password = txtPassword.Text.Trim();

        //    if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
        //    {
        //        string connectionString = ConfigurationManager.ConnectionStrings["WebDbConnectionString"].ConnectionString;

        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            string query = "SELECT COUNT(*) FROM Web WHERE Username = @Username AND Password = @Password";

        //            SqlCommand cmd = new SqlCommand(query, conn);
        //            cmd.Parameters.AddWithValue("@Username", username);
        //            cmd.Parameters.AddWithValue("@Password", password);
        //            try
        //            {
        //                conn.Open();
        //                int userCount = (int)cmd.ExecuteScalar();

        //                if (userCount > 0)
        //                {
        //                    Session["User"] = username;
        //                    Session["LoginSuccess"] = "Successfully logged in!";
        //                    Response.Redirect("Login.aspx");
        //                }
        //                else
        //                {
        //                    lblMessage.ForeColor = System.Drawing.Color.Red;
        //                    lblMessage.Text = "Invalid username or password.";
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                lblMessage.ForeColor = System.Drawing.Color.Red;
        //                lblMessage.Text = "Error: " + ex.Message;
        //            }
        //        }
        //    }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                Session["User"] = username;
                Session["LoginSuccess"] = "Successfully logged in!";
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Invalid username or password.";
            }
        }
    }
}








//        protected void btnLogin_Click(object sender, EventArgs e)
//        {
//            string username = txtUsername.Text.Trim();
//            string password = txtPassword.Text.Trim();

//            // Accept any non-empty username and password
//            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
//            {
//                Session["User"] = username;
//                lblMessage.ForeColor = System.Drawing.Color.Green;
//                lblMessage.Text = "Successfully logged in!";
//            }
//            else
//            {
//                lblMessage.ForeColor = System.Drawing.Color.Red;
//                lblMessage.Text = "Invalid username or password.";
//            }
//        }
//    }
//}