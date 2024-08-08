using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");
        string email = txtEmail.Text;

        string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Email", email);

                con.Open();
                cmd.ExecuteNonQuery();
                lblMessage.Text = "Registration successful!";
            }
        }

    }
}